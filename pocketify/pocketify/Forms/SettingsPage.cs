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

        public SettingsPage()
        {
            InitializeComponent();
            contextMenuHelper = new ContextMenuHelper();
        }

        private void Settings_un_edit_btn_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEvent = (MouseEventArgs)e;
            if (mouseEvent.Button == MouseButtons.Left)
            {

                List<ContextMenuHelper.MenuItem> menuItems = new List<ContextMenuHelper.MenuItem>();
                menuItems.Add(new ContextMenuHelper.MenuItem("Copy", menu_item_copy_click));

                // Create and show the context menu
                ContextMenuHelper helper = new ContextMenuHelper();
                helper.CreateContextMenu(Settings_un_edit_btn, menuItems, this);
            }
        }

        private void menu_item_copy_click(object sender, EventArgs e)
        {
            MessageBox.Show("It works");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEvent = (MouseEventArgs)e;
            if (mouseEvent.Button == MouseButtons.Left)
            {

                List<ContextMenuHelper.MenuItem> menuItems = new List<ContextMenuHelper.MenuItem>();
                menuItems.Add(new ContextMenuHelper.MenuItem("Copy", menu_item_copy_click));

                // Create and show the context menu
                ContextMenuHelper helper = new ContextMenuHelper();
                helper.CreateContextMenu(button1, menuItems, this);
            }
        }
    }
}
