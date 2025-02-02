﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pocketify.GlobalHelpers;
using pocketify.Database;
using static pocketify.Database.DbOperations;
using pocketify.Authentication;

namespace pocketify.Forms
{
    public partial class SettingsPage : Form
    {
        private ContextMenuHelper contextMenuHelper;
        private TextBox[] editButtons;
        private DbOperations dbOperations;
        public int userId = UserIDHelper.Instance.UserId;
        public string userName = UserIDHelper.Instance.UserName;
        public string userEmail = UserIDHelper.Instance.Email;
        private Dashboard dashboard;

        public SettingsPage(Dashboard dash)
        {
            InitializeComponent();
            contextMenuHelper = new ContextMenuHelper();
            dbOperations = new DbOperations();
            Settings_username_input.Text = userName;
            Settings_email_edit_Input.Text = userEmail;
            Settings_pw_conf_input.Visible = false;
            this.Load += SettingsPage_Load;
            Settings_version_label.Text = ApplicationInfoHelper.Instance.Version;
            dashboard = dash;
        }

        private void SettingsPage_Load(object sender, EventArgs e)
        {
            editButtons = new TextBox[] { Settings_username_input, Settings_email_edit_Input, Setting_pw_edit_input };

            // Fetch and update data on form load
            UpdateData();

            foreach (TextBox items in editButtons)
            {
                items.Enabled = false;
            }
        }

        private void Settings_un_edit_btn_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEvent = (MouseEventArgs)e;
            if (mouseEvent.Button == MouseButtons.Left)
            {

                List<ContextMenuHelper.MenuItem> menuItems = new List<ContextMenuHelper.MenuItem>();
                menuItems.Add(new ContextMenuHelper.MenuItem("Edit", Settings_un_edit_click));

                // Create and show the context menu
                ContextMenuHelper helper = new ContextMenuHelper();
                helper.CreateContextMenu(Settings_un_edit_btn, menuItems, this);
            }
        }

        private void Settings_un_edit_click(object sender, EventArgs e)
        {
            Settings_username_input.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Settings_save_btn_Click(object sender, EventArgs e)
        {
            string previousName = userName;
            string previousEmail = userEmail;
            string givenName = Settings_username_input.Text;
            string givenEmail = Settings_email_edit_Input.Text;
            string currentPwHash = dbOperations.GetPasswordHash(userId);
            string newPassword = Setting_pw_edit_input.Text;

            

            if (Settings_username_input.Enabled || Settings_email_edit_Input.Enabled || Setting_pw_edit_input.Enabled)
            {
                if (!dbOperations.GetUser(givenName) || givenName == previousName)
                {
                    if (AuthenticatePassword(currentPwHash, newPassword))
                    {
                        MessageBox.Show("Your new password cannot be the same as your old one");
                        Setting_pw_edit_input.Text = ""; // Clear the password field
                    }
                    else
                    {
                        // Update database with new data
                        dbOperations.UpdateData(givenName, givenEmail, userId);

                        // Update password if provided
                        if (!string.IsNullOrWhiteSpace(newPassword))
                        {
                            dbOperations.UpdatePassword(userId, PasswordHasher.HashPassword(newPassword));
                        }

                        // Fetch updated details and update UserIDHelper
                        UserDetails updatedDetails = dbOperations.GetUserDetails(userId);
                        UserIDHelper.Instance.UserName = updatedDetails.Username;
                        UserIDHelper.Instance.Email = updatedDetails.Email;

                        // Refresh the displayed data
                        UpdateData();

                        // Disable editing after save
                        foreach (TextBox items in editButtons)
                        {
                            items.Enabled = false;
                        }

                        Settings_pw_conf_input.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Username Taken, Please choose another");
                    Settings_username_input.Text = previousName;
                    Settings_email_edit_Input.Text = previousEmail;
                }
            }
        }

        private bool AuthenticatePassword(string currentpw,string newpw)
        {
            if (string.IsNullOrEmpty(newpw)) return false;

            // Check if the new password matches the current password
            bool passwordStatus = PasswordHasher.VerifyPassword(newpw, currentpw);
            return passwordStatus;
        }

        private void UpdateData()
        {
            // Fetch latest user details
            UserDetails userDetails = dbOperations.GetUserDetails(userId);

            if (userDetails != null)
            {
                userName = userDetails.Username;
                userEmail = userDetails.Email;

                // Update UserIDHelper
                UserIDHelper.Instance.UserName = userName;
                UserIDHelper.Instance.Email = userEmail;

                // Update the input fields
                Settings_username_input.Text = userName;
                Settings_email_edit_Input.Text = userEmail;
                Setting_pw_edit_input.Text = "*******";
            }
            else
            {
                // Handle case where user details are not found
                MessageBox.Show("User details not found.");
            }
        }


        private void Settings_email_edit_btn_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEvent = (MouseEventArgs)e;
            if (mouseEvent.Button == MouseButtons.Left)
            {

                List<ContextMenuHelper.MenuItem> menuItems = new List<ContextMenuHelper.MenuItem>();
                menuItems.Add(new ContextMenuHelper.MenuItem("Edit", Settings_pw_edit_click));

                // Create and show the context menu
                ContextMenuHelper helper = new ContextMenuHelper();
                helper.CreateContextMenu(Settings_email_edit_btn, menuItems, this);
            }
        }

        private void Settings_change_pw_btn_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEvent = (MouseEventArgs)e;
            if (mouseEvent.Button == MouseButtons.Left)
            {

                List<ContextMenuHelper.MenuItem> menuItems = new List<ContextMenuHelper.MenuItem>();
                menuItems.Add(new ContextMenuHelper.MenuItem("Edit", Settings_pw_edit_click));

                // Create and show the context menu
                ContextMenuHelper helper = new ContextMenuHelper();
                helper.CreateContextMenu(Settings_change_pw_btn, menuItems, this);
            }
        }

        private void Settings_pw_edit_click(object sender, EventArgs e) 
        {
            Setting_pw_edit_input.Enabled = true;
            Setting_pw_edit_input.Text = "";
            Settings_pw_conf_input.Visible = true;
            if (!Setting_pw_edit_input.Focused || !Settings_pw_conf_input.Focused)
            {
                Setting_pw_edit_input.PasswordChar = '*';
                Settings_pw_conf_input.PasswordChar = '*';
            }
            else
            {
                Setting_pw_edit_input.PasswordChar = '\0';
                Settings_pw_conf_input.PasswordChar = '\0';
            }

            // Manage focus changes
            Setting_pw_edit_input.GotFocus += (s, args) => Setting_pw_edit_input.PasswordChar = '\0';
            Setting_pw_edit_input.LostFocus += (s, args) => Setting_pw_edit_input.PasswordChar = '*';
            Settings_pw_conf_input.GotFocus += (s, args) => Settings_pw_conf_input.PasswordChar = '\0';
            Settings_pw_conf_input.LostFocus += (s, args) => Settings_pw_conf_input.PasswordChar = '*';
        }



        public void Settings_logout_btn_Click(object sender, EventArgs e)
        {
            dashboard.Close();
            LandingForm landingForm = new LandingForm();
            landingForm.Show();
        }
    }
}
