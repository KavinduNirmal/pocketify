using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pocketify.Database;
using pocketify.GlobalHelpers;
using static pocketify.Database.DbOperations;

namespace pocketify.Forms
{
    public partial class Categories : Form
    {
        DbOperations dbOperations = new DbOperations();
        private int userId = UserIDHelper.Instance.UserId;

        public Categories()
        {
            InitializeComponent();
            Cat_new_cat_pnl.Visible = false;
            AddCategoryData();
        }

        private void Cat_action_btn_Click(object sender, EventArgs e)
        {
            Cat_new_cat_pnl.Visible = true;
            Cat_action_btn.Enabled = false;
            Cat_action_btn.BackColor = Color.Gray;
            Cat_action_btn.ForeColor = Color.White;

        }

        private void Cat_cat_save_btn_Click(object sender, EventArgs e)
        {
            string categoryName = Cat_cat_name_inp.Text;
            string categoryBudget = Cat_cat_budget_inp.Text;

            if (!string.IsNullOrWhiteSpace(categoryName) && !string.IsNullOrWhiteSpace(categoryBudget))
            {
                double budget;
                if (double.TryParse(categoryBudget, out budget))
                {
                    dbOperations.SaveCategory(userId, categoryName, budget);
                    Cat_cat_budget_inp.Text = " ";
                    Cat_cat_name_inp.Text = " ";
                    Cat_new_cat_pnl.Visible = false;
                    Cat_action_btn.Enabled = true;
                    AddCategoryData();
                }
                else
                {
                    // Handle invalid budget input
                    MessageBox.Show("Invalid budget amount.");
                }
            }
            else
            {
                // Handle empty fields
                MessageBox.Show("Please fill in all fields.");
            }
        }

        private void AddCategoryData()
        {
            List<Category> categories = dbOperations.RetrieveCategories(userId);
            CategoriesDataset.DataSource = categories;

            CategoriesDataset.Columns["CategoryName"].HeaderText = "Category";
            CategoriesDataset.Columns["CategoryBudget"].HeaderText = "Budget";
            CategoriesDataset.Columns["CatAmount"].HeaderText = "Current Spendings";
        }
    }
}
