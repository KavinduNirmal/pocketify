using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pocketify.Database;
using pocketify.GlobalHelpers;
using static pocketify.Database.DbOperations;

namespace pocketify.Forms
{
    public partial class DashboardForm : Form
    {
        int userID;
        double balance;
        int balanceGoal;
        double totalIncome;
        double totalExpenses;
        float creditBalance;

        private Label[] recentLabels;
        private Label[] recentValues;
        private Panel[] recentPanels;
        private Label[] hideThese;
        private Label[] categoryLabels;
        private Label[] categoryValues;   

        DbOperations dbOperations = new DbOperations();
        

        public DashboardForm()
        {
            InitializeComponent();
            Dash_balance_goal_pnl.Visible = false;
            recentLabels = new Label[] { Dash_dash_trans_pnl1_txt, Dash_dash_trans_pnl2_txt, Dash_dash_trans_pnl3_txt, Dash_dash_trans_pnl4_txt };
            recentValues = new Label[] { Dash_dash_trans_pnl1_val, Dash_dash_trans_pnl2_val, Dash_dash_trans_pnl3_val, Dash_dash_trans_pnl4_val };
            recentPanels = new Panel[] { Dash_dash_trans_pnl1, Dash_dash_trans_pnl2, Dash_dash_trans_pnl3, Dash_dash_trans_pnl4 };
            this.Load += Dashboard_Load;

        }

        public void Dashboard_Load(object sender, EventArgs e)
        {
            dbOperations.GetUserBalance(userID);
            UserIDHelper.Instance.TotalExpenses = dbOperations.GetTotalExpenseThisMonth(userID);
            UserIDHelper.Instance.TotalIncome = dbOperations.GetTotalIncomeThisMonth(userID);

            userID = UserIDHelper.Instance.UserId;
            balance = UserIDHelper.Instance.Balance;
            balanceGoal = UserIDHelper.Instance.BalanceGoal;
            creditBalance = UserIDHelper.Instance.CreditBalance;
            totalIncome = UserIDHelper.Instance.TotalIncome;
            totalExpenses = UserIDHelper.Instance.TotalExpenses;

            List<Category> topCategories = dbOperations.GetTopCategories(userID);
                        
            hideThese = new Label[] { Dash_dash_income_prec, Dash_dash_expense_prec, label17, label21 };
            categoryLabels = new Label[] { Dash_dash_cat_main_pnl_txt, Dash_dash_cat_pnl1_txt, Dash_dash_cat_pnl2_txt};
            categoryValues = new Label[] { Dash_dash_cat_main_pnl_val, Dash_dash_cat_pnl1_val, Dash_dash_cat_pnl2_val };

            Dash_dash_balance_value.Text = "Rs. " + balance.ToString("N2");
            Dash_dash_cbp_value.Text = "Rs. " + creditBalance.ToString("N2");
            Dash_dash_income_month.Text = DateTime.Now.ToString("MMMM");
            Dash_dash_expense_month.Text = DateTime.Now.ToString("MMMM");
            Dash_dash_year_expenses.Text = DateTime.Now.ToString("yyyy");
            Dash_dash_year_income.Text = DateTime.Now.ToString("yyyy");

            Dash_total_income.Text = dbOperations.GetTotalIncome(userID).ToString("N2");
            Dash_total_expense.Text = dbOperations.GetTotalExpense(userID).ToString("N2");

            foreach (Label label in hideThese)
            {
                label.Visible = false;
            }

            if (balanceGoal != 0)
            {
                Dash_dash_balance_progress.Value = (int)((balance / balanceGoal) * 100);
            }
            else { Dash_dash_balance_progress.Value = 0; }

            for (int i = 0; i < categoryLabels.Length; i++)
            {
                if (i < topCategories.Count)
                {
                    categoryLabels[i].Text = topCategories[i].CategoryName;
                    categoryValues[i].Text = topCategories[i].CatAmount.ToString("N2"); // Format as currency
                }
                else
                {
                    categoryLabels[i].Text = "N/A";
                    categoryValues[i].Text = "Rs. 0.00";
                }
            }

            Dash_dash_noshow_pnl.Visible = false;
            

            Dash_dash_balance_value.Text = "Rs. " + (totalIncome - totalExpenses).ToString("N2");

            DisplayRecentTransactions();
        }

        private void DisplayRecentTransactions()
        {
            List<TopTransaction> recentTransactions = dbOperations.GetRecentTransactions(userID);

            if (recentTransactions.Count == 0)
            {
                Dash_dash_noshow_pnl.Visible = true;
            }
            else
            {
                Dash_dash_noshow_pnl.Visible = false;

                for (int i = 0; i < recentPanels.Length; i++)
                {
                    if (i < recentTransactions.Count)
                    {
                        recentLabels[i].Text = recentTransactions[i].Title;
                        recentValues[i].Text = "Rs. " + recentTransactions[i].Amount.ToString("N2");
                        recentPanels[i].Visible = true;
                    }
                    else
                    {
                        recentPanels[i].Visible = false;
                    }
                }
            }

            Dash_dash_income_value.Text = "Rs. " + dbOperations.GetTotalIncomeThisMonth(userID).ToString("N2");
            Dash_dash_expense_value.Text = "Rs. " + dbOperations.GetTotalExpenseThisMonth(userID).ToString("N2");
            Dash_dash_income_value.ForeColor = Color.FromArgb(4, 197, 94);
            Dash_dash_expense_value.ForeColor = Color.FromArgb(225, 29, 72);

            
        }


        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void Dash_balance_goal_save_Click(object sender, EventArgs e)
        {
            int balanceinput = Convert.ToInt32(Dash_balance_goal_inp.Text);

            if (Dash_balance_goal_inp.Text != "")
            {
                dbOperations.UpdateBalanceGoal(userID, balanceinput);
                Dashboard_Load(null, EventArgs.Empty);
                Dash_balance_goal_pnl.Visible = false;
                dbOperations.GetUserBalance(userID);
            }
            else
            {
                Dash_balance_goal_pnl.Visible = false;
            }
        }

        private void Dash_balance_edit_click(object sender, EventArgs e)
        {
            Dash_balance_goal_pnl.Visible = true;
            
        }

        private void Balance_edit_btn_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEvent = (MouseEventArgs)e;
            if (mouseEvent.Button == MouseButtons.Left)
            {

                List<ContextMenuHelper.MenuItem> menuItems = new List<ContextMenuHelper.MenuItem>();
                menuItems.Add(new ContextMenuHelper.MenuItem("Edit", Dash_balance_edit_click));

                // Create and show the context menu
                ContextMenuHelper helper = new ContextMenuHelper();
                helper.CreateContextMenu(Balance_edit_btn, menuItems, this);
            }
        }
    }
}
