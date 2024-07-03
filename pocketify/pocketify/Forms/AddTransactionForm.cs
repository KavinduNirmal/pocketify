using pocketify.Database;
using pocketify.GlobalHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static pocketify.Database.DbOperations;

namespace pocketify.Forms
{
    public partial class AddTransactionForm : Form
    {
        DbOperations dbOperations;
        int userId = UserIDHelper.Instance.UserId;


        public AddTransactionForm()
        {
            InitializeComponent();
            dbOperations = new DbOperations();
            this.Load += AddTransactionForm_Load;
        }

        private void AddTransactionForm_Load(object sender, EventArgs e)
        {
            LoadCategories(userId);
        }

        private void LoadCategories(int userId)
        {
            List<Category> categories = dbOperations.RetrieveCategories(userId);
            Trans_cetegories.DataSource = categories;
            Trans_cetegories.DisplayMember = "CategoryName";
            Trans_cetegories.ValueMember = "CatID";
        }

        private void Trans_save_tranc_Click(object sender, EventArgs e)
        {
            TextBox[] inputs = new TextBox[] { Trans_amount_inp, Trans_desc_inp, Trans_title_inp };
            RadioButton[] checks = new RadioButton[] { Trans_type_income, Trans_type_expense };

            bool anyInputEmpty = false;
            foreach (TextBox textBox in inputs)
            {
                if (textBox.Text == "")
                {
                    anyInputEmpty = true;
                    break;
                }
            }

            bool anyCheckSelected = false;
            foreach (RadioButton radioButton in checks)
            {
                if (radioButton.Checked)
                {
                    anyCheckSelected = true;
                    break;
                }
            }

            if (anyInputEmpty || !anyCheckSelected)
            {
                MessageBox.Show("Please fill in all fields and select a transaction type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string t_title = Trans_title_inp.Text;
            string t_desc = Trans_desc_inp.Text;
            double t_amount = Convert.ToDouble(Trans_amount_inp.Text);
            int t_categoryId = (int)Trans_cetegories.SelectedValue;

            if (Trans_type_income.Checked)
            {
                dbOperations.SaveTransactionIncome(userId, t_title, t_desc, t_amount, t_categoryId);
                foreach (TextBox textBox in inputs)
                {
                    textBox.Text = "";
                }
                foreach (RadioButton radioButton in checks)
                {
                    radioButton.Checked = false;
                }
            }
            else if (Trans_type_expense.Checked)
            {
                dbOperations.SaveTransactionExpense(userId, t_title, t_desc, t_amount, t_categoryId);
                foreach (TextBox textBox in inputs)
                {
                    textBox.Text = "";
                }
                foreach (RadioButton radioButton in checks)
                {
                    radioButton.Checked = false;
                }
            }

            // Reload dashboard form
            var dashboardForm = new DashboardForm();
            dashboardForm.Dashboard_Load(null, EventArgs.Empty);
        }

        private void Trans_title_inp_TextChanged(object sender, EventArgs e)
        {
            Trans_desc_inp.Text = Trans_title_inp.Text;
        }
    }
}
