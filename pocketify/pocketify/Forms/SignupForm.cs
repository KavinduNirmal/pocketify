using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using pocketify.Authentication;
using pocketify.Database;
using pocketify.GlobalHelpers;
using static pocketify.Database.DbOperations;

namespace pocketify.Forms
{
    public partial class SignupForm : Form
    {
        private DbOperations dbOperations;
        public SignupForm()
        {
            InitializeComponent();
            dbOperations = new DbOperations();
        }

        private void signup_signin_btn_Click(object sender, EventArgs e)
        {
            string username = signup_username_inp.Text;
            string email = signup_email_input.Text;
            string password = signiup_pwd_input.Text;
            string confPassword = signup_pwdc_inp.Text;
            bool terms = Signup_term_check.Checked;

            if (password != confPassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confPassword))
            {
                MessageBox.Show("Password cannot be empty");
                return;
            }
            if (!terms)
            {
                Signup_term_check.ForeColor = Color.FromArgb(221, 38, 38);
                MessageBox.Show("You must agree to terms of service");
                return;
            }

            string passwordHash = PasswordHasher.HashPassword(password);

            try
            {
                // Save the user and check if the username already exists
                if (!SaveUser(email, username, passwordHash))
                {
                    MessageBox.Show("Error in signup, Username might already exist!");
                }
                else
                {
                    // Get the user ID of the newly created user
                    int uid = dbOperations.GetUid(username);
                    if (uid != 0)
                    {
                        var userDetails = dbOperations.GetUserDetails(uid);
                        UserIDHelper.Instance.UserId = uid;
                        UserIDHelper.Instance.UserName = userDetails.Username;
                        UserIDHelper.Instance.Email = userDetails.Email;

                        // Get or initialize the user's balance
                        dbOperations.SetUserBalance(uid);
                        dbOperations.GetUserCreditBalance(uid);

                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();
                        MessageBox.Show("Signup Successful! Logging in as " + uid + " " + username);
                    }
                    else
                    {
                        MessageBox.Show("User not found or UID is invalid for " + username);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        // Save the user credentials in the database.
        private bool SaveUser(string email, string username, string passwordHash)
        {
            return dbOperations.SaveUser(email, username, passwordHash);
        }

        private bool IsTermsAgreed(bool terms)
        {
            return !terms;
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);
                return regex.IsMatch(email);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void signup_login_btn_Click(object sender, EventArgs e)
        {
            LandingForm landingForm = new LandingForm();
            landingForm.Show();
            this.Hide();
        }
    }
}
