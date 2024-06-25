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

        // the following function loads a given form into a panel
        public void loadForm(object Form)
        {
            if (this.FormContainer.Controls.Count > 0) this.FormContainer.Controls.RemoveAt(0); // Check if a form is already loaded.
            Form f = Form as Form; // make sure the given value is an actual form.
            f.TopLevel = false; // prevent the form to load as a separate application.
            f.Dock = DockStyle.Fill; // fill the FormContainer with the form.
            this.FormContainer.Controls.Add(f); // add the newly loaded form into the current controls count.
            this.FormContainer.Tag = f;
            f.Show();
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
            MouseEventArgs mouseEvent = (MouseEventArgs)e;
            
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

        private void Dash_acc_btn_Click(object sender, EventArgs e)
        {
            loadForm(new SettingsPage());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dash_nav_dash_btn_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEvent = (MouseEventArgs)e;
            
        }

        private void menu_item_copy_click(object sender, EventArgs e)
        {
            // Do something here
        }
    }
}
