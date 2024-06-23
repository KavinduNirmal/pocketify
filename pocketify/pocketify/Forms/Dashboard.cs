﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pocketify.Forms
{
    public partial class Dashboard : Form
    {
        private readonly Button[] navbarButtons;
        private readonly Button focusButton;
        private Button currentButton;

        public Dashboard()
        {
            InitializeComponent();

            navbarButtons = new Button[] { dash_nav_dash_btn, dash_nav_trans_btn, dash_nav_category_btn, dash_nav_budget_btn };
            focusButton = dash_primarybtnbtn;

            foreach (Button button in navbarButtons) 
            {
                if (button != focusButton) { 
                    button.FlatStyle = FlatStyle.Flat;
                    button.ForeColor = Color.FromArgb(24,24,24);
                    button.BackColor = Color.White;
                    button.Click += Button_Click;
                }
            }

            currentButton = navbarButtons[0];
            currentButton.ForeColor = Color.White;
            currentButton.BackColor = Color.FromArgb(92, 133, 231);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (clickedButton != focusButton)
            {
                foreach (Button button in navbarButtons)
                {
                    currentButton.BackColor = Color.White;
                    currentButton.ForeColor = Color.FromArgb(24, 24, 24);

                    clickedButton.BackColor = Color.FromArgb(92, 133, 231);
                    clickedButton.ForeColor = Color.White;

                    currentButton = clickedButton;
                }
                
            }
            
        }

        private void LogoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Page_label_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void dash_nav_trans_btn_Click(object sender, EventArgs e)
        {

        }

        private void dash_primarybtnbtn_Click(object sender, EventArgs e)
        {
            foreach (Button button in navbarButtons)
            {
                if (button != focusButton) 
                {
                    button.BackColor = Color.White;
                    button.ForeColor = Color.FromArgb(24, 24, 24);
                }
            }
        }
    }
}
