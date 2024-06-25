using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pocketify.Authentication;
using pocketify.Database;
using pocketify.GlobalHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            public string username { get; set; }
            public string email { get; set; }
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
                            userDetails.username = reader.GetString(0);
                            userDetails.email = reader.GetString(1);
                        }
                    }
                }


            }
            return userDetails;
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
