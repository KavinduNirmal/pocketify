using System;
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

        public SettingsPage()
        {
            InitializeComponent();
            contextMenuHelper = new ContextMenuHelper();
            editButtons = new TextBox[] { Settings_username_input, Settings_email_edit_Input, Setting_pw_edit_input };

            dbOperations = new DbOperations();

            foreach (TextBox items in editButtons)
            {
                items.Enabled = false;
                UpdateData();
            }

            Settings_username_input.Text = userName;
            Settings_email_edit_Input.Text = userEmail;
            Setting_pw_edit_input.Text = "*******";

        }


        private void UpdateData()
        {
            Settings_username_input.Text = UserIDHelper.Instance.UserName;
            Settings_email_edit_Input.Text = UserIDHelper.Instance.Email;
            Setting_pw_edit_input.Text = "*******";
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
            string givenName = Settings_username_input.Text;
            string givenEmail = Settings_email_edit_Input.Text;

            // Update database with new data
            dbOperations.UpdateData(givenName, givenEmail, userId);

            // Fetch updated details and update UserIDHelper
            UserDetails updatedDetails = dbOperations.GetUserDetails(userId);
            UserIDHelper.Instance.UserName = updatedDetails.username;
            UserIDHelper.Instance.Email = updatedDetails.email;

            // Refresh the displayed data
            UpdateData();

            // Disable editing after save
            foreach (TextBox items in editButtons)
            {
                items.Enabled = false;
            }
        }

        private void Settings_email_edit_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void Settings_change_pw_btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
