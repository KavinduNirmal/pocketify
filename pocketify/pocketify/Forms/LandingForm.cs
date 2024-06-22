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
        public LandingForm()
        {
            InitializeComponent();
        }

        private void login_login_btn_Click(object sender, EventArgs e)
        {
            string username = login_un_inp.Text;
            string password = login_pw_inp.Text;

            try
            {
                if (!AuthenticateUser(username, password))
                {
                    MessageBox.Show("Invalid Username or Password");
                }
                else
                {
                    MessageBox.Show("Login Successful");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
