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
                string query = "SELECT PwdHash FROM Users WHERE Username = @Username;";

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

        public bool GetUser(string username)
        {
            bool userExistance = false;

            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM Users WHERE Username = @Username;";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            userExistance = true;
                        }
                    }
                }


            }
            return userExistance;

        }

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
        }

        public UserBalance GetUserBalance(int userid)
        {
            UserBalance ub = new UserBalance();

            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string query = "SELECT Balance, BalanceGoal, BalanceDeadLine FROM Balance WHERE UID = @uid;";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@uid", userid);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ub.Balance = reader.GetFloat(0);
                            ub.BalanceGoal = reader.GetFloat(1);
                            ub.BalanceDeadline = Convert.ToString(reader.GetDateTime(2));
                        }
                    }
                }


            }
            return ub;
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
                string query = "SELECT UID FROM Users WHERE Username = @Username;";
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
