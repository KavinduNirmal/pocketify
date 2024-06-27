using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pocketify.Authentication;
using pocketify.Database;
using pocketify.GlobalHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static pocketify.Database.DbOperations;

namespace pocketify.Database
{
    internal class DbOperations : DbConnection
    {
        // get the password from the database.
        public string GetPassword(string username)
        {
            string storedHash = null;

            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string query = "SELECT PwdHash FROM Users WHERE UserName = @Username;";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            storedHash = reader.GetString(0);
                        }
                    }
                }


            }
            return storedHash;

        }
        // Get Password Hash
        public string GetPasswordHash(int userid)
        {
            string storedHash = null;
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string query = "SELECT PwdHash FROM Users WHERE UID = @Uid;";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Uid", userid);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            storedHash = reader.GetString(0);
                        }
                    }
                }


            }
            return storedHash;
        }
        // Check if the user exist in the database already
        public bool GetUser(string username)
        {
            bool userExists = false;

            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM Users WHERE UserName = @Username;";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            userExists = true;
                        }
                    }
                }
            }
            return userExists;
        }

        // Get userdetails
        public class UserDetails
        {
            public string Username { get; set; }
            public string Email { get; set; }
        }

        public UserDetails GetUserDetails(int userid)
        {
            UserDetails userDetails = new UserDetails();

            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string query = "SELECT UserName, Email FROM Users WHERE UID = @uid;";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@uid", userid);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userDetails.Username = reader.GetString(0);
                            userDetails.Email = reader.GetString(1);
                        }
                    }
                }


            }
            return userDetails;
        }

        // Get the user balance
        public class UserBalance
        {
            public float Balance { get; set; }
            public float BalanceGoal { get; set; }
            public string BalanceDeadline { get; set; }

            public float CreditBalance { get; set; }
        }

        public UserBalance GetUserBalance(int userid)
        {
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string retrieveData = "SELECT Balance, BalanceGoal, BalanceDeadLine FROM Balance WHERE UID = @uid;";
                string initializeFirst = "INSERT INTO Balance (UID, Balance, BalanceGoal, BalanceDeadLine) VALUES (@userId, @balance, @balanceGoal, @balanceDeadline);";

                using (SqlCommand cmd = new SqlCommand(retrieveData, con))
                {
                    cmd.Parameters.AddWithValue("@uid", userid);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new UserBalance
                            {
                                Balance = reader.GetFloat(0),
                                BalanceGoal = reader.GetFloat(1),
                                BalanceDeadline = reader.GetDateTime(2).ToString("yyyy-MM-dd")
                            };
                        }
                    }

                    // If no rows were found, we need to initialize the balance
                    using (SqlCommand cmd2 = new SqlCommand(initializeFirst, con))
                    {
                        float newBalance = 0;
                        cmd2.Parameters.AddWithValue("@userId", userid);
                        cmd2.Parameters.AddWithValue("@balance", newBalance);
                        cmd2.Parameters.AddWithValue("@balanceGoal", newBalance);
                        cmd2.Parameters.AddWithValue("@balanceDeadline", DateTime.Today);

                        cmd2.ExecuteNonQuery();

                        UserIDHelper.Instance.UserId = userid;
                        UserIDHelper.Instance.Balance = newBalance;
                        UserIDHelper.Instance.BalanceGoal = newBalance;

                        return new UserBalance
                        {
                            Balance = newBalance,
                            BalanceGoal = newBalance,
                            BalanceDeadline = DateTime.Today.ToString("yyyy-MM-dd")
                        };
                    }
                }
            }
        }

        // Get the user Credit balance
        public UserBalance GetUserCreditBalance(int userid)
        {
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string retrieveData = "SELECT Balance FROM CreditBalance WHERE UID = @uid;";
                string initializeFirst = "INSERT INTO CreditBalance (UID, Balance) VALUES (@userId, @balance);";

                using (SqlCommand cmd = new SqlCommand(retrieveData, con))
                {
                    cmd.Parameters.AddWithValue("@uid", userid);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            float balance = reader.GetFloat(0);
                            UserIDHelper.Instance.CreditBalance = balance;

                            return new UserBalance
                            {
                                CreditBalance = balance,
                            };
                        }
                    }

                    // If no rows were found, initialize the balance
                    using (SqlCommand cmd2 = new SqlCommand(initializeFirst, con))
                    {
                        float newBalance = 0;
                        cmd2.Parameters.AddWithValue("@userId", userid);
                        cmd2.Parameters.AddWithValue("@balance", newBalance);

                        cmd2.ExecuteNonQuery();

                        UserIDHelper.Instance.CreditBalance = newBalance;

                        return new UserBalance
                        {
                            CreditBalance = newBalance,
                        };
                    }
                }
            }
        }

        // Get recent transactions
        public List<Transaction> GetRecentTransactions(int userId)
        {
            List<Transaction> transactions = new List<Transaction>();

            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string query = "SELECT TOP 4 Title, Amount FROM Transactions WHERE UID = @uid ORDER BY Date DESC";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@uid", userId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Transaction transaction = new Transaction
                            {
                                Title = reader.GetString(0),
                                Amount = reader.GetFloat(1)
                            };
                            transactions.Add(transaction);
                        }
                    }
                }
            }

            return transactions;
        }

        public class Transaction
        {
            public string Title { get; set; }
            public float Amount { get; set; }
        }

        // Get mothly income
        public float GetUserMonthlyIncome(int userId)
        {
            float totalIncome = 0;
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string query = @"
                SELECT SUM(Value) 
                FROM Income 
                WHERE UID = @uid 
                  AND YEAR(Date) = YEAR(GETDATE()) 
                  AND MONTH(Date) = MONTH(GETDATE());";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@uid", userId);
                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalIncome = Convert.ToSingle(result);
                    }
                }
            }
            return totalIncome;
        }


        public void UpdateData(string username, string email, int userid)
        {

            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string query = "UPDATE Users SET UserName = @Username, Email = @Email WHERE UID = @uid;";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@uid", userid);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        
                        // Handle exception (e.g., log it)
                    }
                }
            }
        }

        public void UpdatePassword(int userid, string pwdHash)
        {

            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string query = "UPDATE Users SET PwdHash = @pwdHash WHERE UID = @uid;";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@pwdHash", pwdHash);;
                    cmd.Parameters.AddWithValue("@uid", userid);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {

                        // Handle exception (e.g., log it)
                    }
                }
            }
        }

        public int GetUid(string username)
        {
            int UID = 0; 

            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string query = "SELECT UID FROM Users WHERE UserName = @Username;";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            UID = reader.GetInt32(0); // Retrieve as int
                        }
                    }
                }
            }

            return UID;
        }

        // Save the user to the database. 
        public bool SaveUser(string email, string username, string passwordHash)
        {
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string query = "INSERT INTO Users (Email, UserName, PwdHash) VALUES (@Email, @Username, @PwdHash);";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@PwdHash", passwordHash);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqlException)
                    {
                        return false;
                    }
                }
            }
        }
    }
}
