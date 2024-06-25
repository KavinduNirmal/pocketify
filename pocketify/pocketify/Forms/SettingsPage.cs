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

namespace pocketify.Forms
{
    public partial class SettingsPage : Form
    {
        private ContextMenuHelper contextMenuHelper;
        private TextBox[] editButtons;

        public SettingsPage()
        {
            InitializeComponent();
            contextMenuHelper = new ContextMenuHelper();
            editButtons = new TextBox[] { Settings_username_input, textBox2, textBox3 };

            foreach (TextBox items in editButtons)
            {
                items.Enabled = false;
                items.Text = items.Text;
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
