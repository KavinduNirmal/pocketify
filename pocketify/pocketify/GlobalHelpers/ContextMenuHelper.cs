﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pocketify.GlobalHelpers
{
    public class ContextMenuHelper
    {
        public void CreateContextMenu(Button button, List<MenuItem> menuItems, Form form)
        {
            // Create a ContextMenuStrip for the menu
            ContextMenuStrip menu = new ContextMenuStrip();

            // Add menu items from the list
            foreach (MenuItem menuItem in menuItems)
            {
                ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(menuItem.Text);
                toolStripMenuItem.Click += menuItem.ClickHandler; 
                menu.Items.Add(toolStripMenuItem);
            }

            // Show the ContextMenuStrip at the current mouse position
            Point location = button.PointToScreen(new Point(button.Width, 0));

            // Show the ContextMenuStrip at the calculated position
            menu.Show(location, ToolStripDropDownDirection.BelowRight);

        }

        // Create a nested class or structure for MenuItem
        public class MenuItem
        {
            public string Text { get; set; }
            public EventHandler ClickHandler { get; set; }

            public MenuItem(string text, EventHandler clickHandler)
            {
                Text = text;
                ClickHandler = clickHandler;
            }
        }
    }
}

