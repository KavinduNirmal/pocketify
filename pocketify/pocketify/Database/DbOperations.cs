using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            public int Balance { get; set; }
            public int BalanceGoal { get; set; }
            public string BalanceDeadline { get; set; }

            public float CreditBalance { get; set; }
        }

        public UserBalance SetUserBalance(int userid)
        {
            using (SqlConnection con = GetConnection())
            {
                con.Open();

                string initializeFirst = "INSERT INTO Balance (UID, Balance, BalanceGoal, BalanceDeadLine) VALUES (@userId, @balance, @balanceGoal, @balanceDeadline);";

                using (SqlCommand cmd2 = new SqlCommand(initializeFirst, con))
                {
                    int newBalance = 0;
                    cmd2.Parameters.AddWithValue("@userId", userid);
                    cmd2.Parameters.AddWithValue("@balance", newBalance);
                    cmd2.Parameters.AddWithValue("@balanceGoal", newBalance);
                    cmd2.Parameters.AddWithValue("@balanceDeadline", DateTime.Today.ToString("G"));

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

        public UserBalance GetUserBalance(int userId)
        {
            UserBalance userBalance = null;

            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string retrieveData = "SELECT BalanceGoal, BalanceDeadline FROM Balance WHERE UID = @uid;";

                using (SqlCommand cmd = new SqlCommand(retrieveData, con))
                {
                    cmd.Parameters.AddWithValue("@uid", userId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int balanceGoal = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                            
                            userBalance = new UserBalance
                            {
                                BalanceGoal = balanceGoal,
                            };

                            UserIDHelper.Instance.UserId = userId;
                            UserIDHelper.Instance.BalanceGoal = userBalance.BalanceGoal;
                        }
                    }
                }
            }

            return userBalance;
        }


        public double GetTotalIncomeThisMonth(int userid)
        {
            double totalIncome = 0.0;
            DateTime startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            DateTime endDate = startDate.AddMonths(1);

            using (SqlConnection con = GetConnection())
            {
                string query = "SELECT SUM(Value) AS TotalIncome " +
                               "FROM Income " +
                               "WHERE UID = @UserId AND Date >= @StartDate AND Date < @EndDate;";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserId", userid);
                    cmd.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = startDate;
                    cmd.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = endDate;

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        totalIncome = Convert.ToDouble(result);
                    }
                    else
                    {
                        totalIncome = 0;
                    }

                    UserIDHelper.Instance.TotalIncome = totalIncome;
                }
            }

            return totalIncome;
        }

        public double GetTotalIncome(int userid)
        {
            double totalIncome = 0.0;
            DateTime startDate = new DateTime(DateTime.Today.Year, 1, 1);
            DateTime endDate = startDate.AddYears(1);

            using (SqlConnection con = GetConnection())
            {
                string query = "SELECT SUM(Value) AS TotalIncome " +
                               "FROM Income " +
                               "WHERE UID = @UserId AND Date >= @StartDate AND Date < @EndDate;";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserId", userid);
                    cmd.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = startDate;
                    cmd.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = endDate;

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        totalIncome = Convert.ToDouble(result);
                    }
                    else
                    {
                        totalIncome = 0;
                    }

                    UserIDHelper.Instance.TotalIncome = totalIncome;
                }
            }

            return totalIncome;
        }

        public double GetTotalExpense(int userid)
        {
            double totalIncome = 0.0;
            DateTime startDate = new DateTime(DateTime.Today.Year, 1, 1);
            DateTime endDate = startDate.AddYears(1);

            using (SqlConnection con = GetConnection())
            {
                string query = "SELECT SUM(Value) AS TotalIncome " +
                               "FROM Expenses " +
                               "WHERE UID = @UserId AND Date >= @StartDate AND Date < @EndDate;";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserId", userid);
                    cmd.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = startDate;
                    cmd.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = endDate;

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        totalIncome = Convert.ToDouble(result);
                    }
                    else
                    {
                        totalIncome = 0;
                    }

                    UserIDHelper.Instance.TotalIncome = totalIncome;
                }
            }

            return totalIncome;
        }

        public double GetTotalExpenseThisMonth(int userid)
        {
            double totalExpenses = 0.0;
            DateTime startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            DateTime endDate = startDate.AddMonths(1);

            using (SqlConnection con = GetConnection())
            {
                string query = "SELECT SUM(Value) AS TotalExpenses " +
                               "FROM Expenses " +
                               "WHERE UID = @UserId AND Date >= @StartDate AND Date < @EndDate;";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserId", userid);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalExpenses = Convert.ToDouble(result);
                        UserIDHelper.Instance.TotalExpenses = totalExpenses;
                    }
                    else
                    {
                        totalExpenses = 0;
                        UserIDHelper.Instance.TotalExpenses = totalExpenses;
                    }
                }
            }

            return totalExpenses;
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
        public List<TopTransaction> GetRecentTransactions(int userId)
        {
            List<TopTransaction> transactions = new List<TopTransaction>();

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
                            TopTransaction transaction = new TopTransaction
                            {
                                Title = reader.GetString(0),
                                Amount = reader.GetDouble(1)
                            };
                            transactions.Add(transaction);
                        }
                    }
                }
            }

            return transactions;
        }

        // get top 4 transactions
        public class TopTransaction
        {
            public string Title { get; set; }
            public double Amount { get; set; }
        }

        public class Transaction
        {
            public string Title { get; set; }
            public double Amount { get; set; }
            public DateTime Date { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }

        }

        // retrieve all the transactions.
        public List<Transaction> GetTransactions(int userId, DateTime? startDate, DateTime? endDate)
        {
            List<Transaction> transactions = new List<Transaction>();

            using (SqlConnection con = GetConnection())
            {
                string query = "SELECT t.Title, t.Date, t.Description, t.Amount, c.CategoryName " +
                               "FROM Transactions t " +
                               "LEFT JOIN Categories c ON t.CategoryID = c.CatID " + // Join with Categories table
                               "WHERE t.UID = @UserId ";

                // Add date range condition if startDate and endDate are not null
                if (startDate != null && endDate != null)
                {
                    query += "AND t.Date >= @StartDate AND t.Date <= @EndDate ";
                }

                query += "ORDER BY t.Date DESC;";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    // Add parameters only if they are not null
                    if (startDate != null)
                    {
                        cmd.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = startDate;
                    }
                    if (endDate != null)
                    {
                        cmd.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = endDate;
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Transaction transaction = new Transaction
                            {
                                Date = Convert.ToDateTime(reader["Date"]),
                                Title = reader["Title"].ToString(),
                                Description = reader["Description"].ToString(),
                                Amount = Convert.ToDouble(reader["Amount"]),
                                Category = reader["CategoryName"].ToString() // Assign category name
                            };
                            transactions.Add(transaction);
                        }
                    }
                }
            }

            return transactions;
        }


        // Save a Income

        public void SaveTransactionIncome(int userId, string title, string description, double amount, int categoryId)
        {
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Insert transaction
                        string insertTransactionQuery = "INSERT INTO Transactions (UID, Date, Title, Description, Amount, CategoryID) " +
                                                        "VALUES (@UID, @Date, @Title, @Description, @Amount, @CategoryID); " +
                                                        "SELECT SCOPE_IDENTITY();";

                        using (SqlCommand cmd = new SqlCommand(insertTransactionQuery, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@UID", userId);
                            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                            cmd.Parameters.AddWithValue("@Title", title);
                            cmd.Parameters.AddWithValue("@Description", description);
                            cmd.Parameters.AddWithValue("@Amount", amount);
                            cmd.Parameters.AddWithValue("@CategoryID", categoryId);

                            int transactionID = Convert.ToInt32(cmd.ExecuteScalar());

                            // Insert into Income table
                            string insertIncomeQuery = "INSERT INTO Income (UID, Date, TransactionID, Value) VALUES (@UID, @Date, @TransactionID, @Value)";

                            using (SqlCommand incomeCmd = new SqlCommand(insertIncomeQuery, con, transaction))
                            {
                                incomeCmd.Parameters.AddWithValue("@UID", userId);
                                incomeCmd.Parameters.AddWithValue("@Date", DateTime.Now);
                                incomeCmd.Parameters.AddWithValue("@TransactionID", transactionID);
                                incomeCmd.Parameters.AddWithValue("@Value", amount);

                                incomeCmd.ExecuteNonQuery();
                            }

                            // Update category amount
                            string updateCategoryQuery = "UPDATE Categories SET CatAmount = CatAmount + @Amount WHERE UID = @UID AND CatID = @CategoryID";

                            using (SqlCommand updateCmd = new SqlCommand(updateCategoryQuery, con, transaction))
                            {
                                updateCmd.Parameters.AddWithValue("@Amount", amount);
                                updateCmd.Parameters.AddWithValue("@UID", userId);
                                updateCmd.Parameters.AddWithValue("@CategoryID", categoryId);

                                updateCmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        // Handle the exception (e.g., log the error)
                        throw new Exception("Error saving transaction", ex);
                    }
                }
            }
        }


        // Save a Expense 
        public void SaveTransactionExpense(int userId, string title, string description, double amount, int categoryId)
        {
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Insert transaction
                        string insertTransactionQuery = "INSERT INTO Transactions (UID, Date, Title, Description, Amount, CategoryID) " +
                                                        "VALUES (@UID, @Date, @Title, @Description, @Amount, @CategoryID); " +
                                                        "SELECT SCOPE_IDENTITY();";

                        using (SqlCommand cmd = new SqlCommand(insertTransactionQuery, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@UID", userId);
                            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                            cmd.Parameters.AddWithValue("@Title", title);
                            cmd.Parameters.AddWithValue("@Description", description);
                            cmd.Parameters.AddWithValue("@Amount", amount);
                            cmd.Parameters.AddWithValue("@CategoryID", categoryId);

                            int transactionID = Convert.ToInt32(cmd.ExecuteScalar());

                            // Insert into Expenses table
                            string insertExpenseQuery = "INSERT INTO Expenses (UID, Date, TransactionID, Value) VALUES (@UID, @Date, @TransactionID, @Value)";

                            using (SqlCommand expenseCmd = new SqlCommand(insertExpenseQuery, con, transaction))
                            {
                                expenseCmd.Parameters.AddWithValue("@UID", userId);
                                expenseCmd.Parameters.AddWithValue("@Date", DateTime.Now);
                                expenseCmd.Parameters.AddWithValue("@TransactionID", transactionID);
                                expenseCmd.Parameters.AddWithValue("@Value", amount);

                                expenseCmd.ExecuteNonQuery();
                            }

                            // Update category amount
                            string updateCategoryQuery = "UPDATE Categories SET CatAmount = CatAmount - @Amount WHERE UID = @UID AND CatID = @CategoryID";

                            using (SqlCommand updateCmd = new SqlCommand(updateCategoryQuery, con, transaction))
                            {
                                updateCmd.Parameters.AddWithValue("@Amount", amount);
                                updateCmd.Parameters.AddWithValue("@UID", userId);
                                updateCmd.Parameters.AddWithValue("@CategoryID", categoryId);

                                updateCmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        // Handle the exception (e.g., log the error)
                        throw new Exception("Error saving transaction", ex);
                    }
                }
            }
        }


        public class Category
        {
            public int CatID { get; set; }
            public string CategoryName { get; set; }
            public double CatAmount { get; set; }
            public double CategoryBudget { get; set; }
        }

        public List<Category> GetTopCategories(int userId)
        {
            List<Category> topCategories = new List<Category>();

            using (SqlConnection con = GetConnection())
            {
                string query = "SELECT TOP 3 CategoryName, CatAmount " +
                               "FROM Categories " +
                               "WHERE UID = @UserId " +
                               "ORDER BY CatAmount DESC;";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Category category = new Category
                            {
                                CategoryName = reader["CategoryName"].ToString(),
                                CatAmount = Convert.ToDouble(reader["CatAmount"])
                            };
                            topCategories.Add(category);
                        }
                    }
                }
            }

            return topCategories;
        }

        // Retrieves the categories from the table.
        public List<Category> RetrieveCategories(int userId)
        {
            List<Category> categories = new List<Category>();

            using (SqlConnection con = GetConnection())
            {
                string query = "SELECT CatID, CategoryName, CatAmount, CategoryBudget FROM Categories WHERE UID = @UserId;";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Category category = new Category
                            {
                                CatID = Convert.ToInt32(reader["CatID"]),
                                CategoryName = reader["CategoryName"].ToString(),
                                CatAmount = Convert.ToDouble(reader["CatAmount"]),
                                CategoryBudget = Convert.ToDouble(reader["CategoryBudget"])
                            };
                            categories.Add(category);
                        }
                    }
                }
            }

            return categories;
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

        // Update user details
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

        public void UpdateBalanceGoal(int userId, int balance)
        {
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string query = "UPDATE Balance SET BalanceGoal = @Balance WHERE UID = @Uid;";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Balance", balance);
                    cmd.Parameters.AddWithValue("@Uid", userId);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                    }
                }
            }
        }

        // Create a new category
        public void SaveCategory(int userId, string catName, double catBudget)
        {
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string query = "INSERT INTO Categories (UID, CategoryName, CategoryBudget, CatAmount) " +
                               "VALUES (@UserId, @CatName, @CatBudget, @CatAmount);";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@CatName", catName);
                    cmd.Parameters.AddWithValue("@CatBudget", catBudget);
                    cmd.Parameters.AddWithValue("@CatAmount", 0); 

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        // Log the exception or handle accordingly
                        MessageBox.Show("An error occurred while saving the category: " + ex.Message);
                    }
                }
            }
        }

        // Update password.
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

        // see if the suer exist and if so get the userid and make it global
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
