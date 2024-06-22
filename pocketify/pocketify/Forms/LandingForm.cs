using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pocketify.Authentication;
using pocketify.Database;

namespace pocketify
{
    public partial class LandingForm : Form
    {
        private DbOperations dbOperations;
        public LandingForm()
        {
            InitializeComponent();
            dbOperations = new DbOperations();
        }

        private void login_login_btn_Click(object sender, EventArgs e)
        {
            string username = Login_un_inp.Text;
            string password = Login_pw_inp.Text;

            // Try to check if the user is already in the system
            try
            {
                if (!AuthenticateUser(username, password)) // if the credentials are wrong, Warn the user.
                {
                    MessageBox.Show("Invalid Username or Password");
                    // after 3 tries, suggest creating an account.
                }
                else
                {
                    MessageBox.Show("Login Successful"); // If succesful, send to dashboard.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Authenticate User.
        private bool AuthenticateUser(string username, string password)
        {
            string storedHash = dbOperations.GetPassword(username); // check the database for the right username, usernames must be unique.
            if (storedHash == null)
            {
                return false;
            }
            return PasswordHasher.VerifyPassword(password, storedHash); // if the user exist, check if the password is valid.
        }

        private void login_signup_btn_Click(object sender, EventArgs e)
        {
            //signup_form form = new signup_form();
            //form.Show();
            //this.Hide();
        }
    }
}
