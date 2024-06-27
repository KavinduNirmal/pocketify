using System;
using System.Windows.Forms;
using pocketify.Authentication;
using pocketify.Database;
using pocketify.Forms;
using pocketify.GlobalHelpers;

namespace pocketify
{
    public partial class LandingForm : Form
    {
        private DbOperations dbOperations;

        public LandingForm()
        {
            InitializeComponent();
            dbOperations = new DbOperations();
            ApplicationInfoHelper.Instance.Version = "V A.0.0.5";
        }

        private void login_login_btn_Click(object sender, EventArgs e)
        {
            string username = Login_un_inp.Text;
            string password = Login_pw_inp.Text;

            try
            {
                if (!dbOperations.GetUser(username))
                {
                    MessageBox.Show("User doesn't exist. Please create a new account.");
                    return;
                }
                else if (!AuthenticateUser(username, password))
                {
                    MessageBox.Show("Invalid username or password.");
                    Login_pw_inp.Text = "";
                    login_pw_label.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int uid = dbOperations.GetUid(username);

                    if (uid != 0)
                    {
                        UserIDHelper.Instance.UserId = uid;
                        var userDetails = dbOperations.GetUserDetails(uid);
                        UserIDHelper.Instance.UserName = userDetails.Username;
                        UserIDHelper.Instance.Email = userDetails.Email;

                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();

                        MessageBox.Show("Login successful: Logged in as " + uid + " " + username);
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

        private bool AuthenticateUser(string username, string password)
        {
            string storedHash = dbOperations.GetPasswordHash(dbOperations.GetUid(username));

            if (storedHash == null)
            {
                return false;
            }
            return PasswordHasher.VerifyPassword(password, storedHash);
        }

        private void login_signup_btn_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
        }
    }
}
