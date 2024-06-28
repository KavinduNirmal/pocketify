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
        float balance;
        float balanceGoal;
        double totalIncome;
        double totalExpenses;
        float creditBalance;
        private string[] imgpath;



        private Label[] recentLabels;
        private Label[] recentValues;
        private Panel[] recentPanels;
        private Label[] hideThese;
        private Label[] categoryLabels;
        private Label[] categoryValues;
        private PictureBox[] categoryIcons;   

        DbOperations dbOperations = new DbOperations();
        

        public DashboardForm()
        {
            InitializeComponent();
            this.Load += Dashboard_Load;

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            userID = UserIDHelper.Instance.UserId;
            balance = UserIDHelper.Instance.Balance;
            balanceGoal = UserIDHelper.Instance.BalanceGoal;
            creditBalance = UserIDHelper.Instance.CreditBalance;
            totalIncome = UserIDHelper.Instance.TotalIncome;
            totalExpenses = UserIDHelper.Instance.TotalExpenses;

            List<Category> topCategories = dbOperations.GetTopCategories(userID);

            recentLabels = new Label[] { Dash_dash_trans_pnl1_txt, Dash_dash_trans_pnl2_txt, Dash_dash_trans_pnl3_txt, Dash_dash_trans_pnl4_txt };
            recentValues = new Label[] { Dash_dash_trans_pnl1_val, Dash_dash_trans_pnl2_val, Dash_dash_trans_pnl3_val, Dash_dash_trans_pnl4_val };
            recentPanels = new Panel[] { Dash_dash_trans_pnl1, Dash_dash_trans_pnl2, Dash_dash_trans_pnl3, Dash_dash_trans_pnl4 };
            hideThese = new Label[] { Dash_dash_income_prec, Dash_dash_income_month, Dash_dash_expense_month, Dash_dash_expense_prec, };
            categoryLabels = new Label[] { Dash_dash_cat_main_pnl_txt, Dash_dash_cat_pnl1_txt, Dash_dash_cat_pnl2_txt};
            categoryValues = new Label[] { Dash_dash_cat_main_pnl_val, Dash_dash_cat_pnl1_val, Dash_dash_cat_pnl2_val };
            categoryIcons = new PictureBox[] { Dash_dash_cat_main_pnl_ico, Dash_dash_cat_pnl1_ico, Dash_dash_cat_pnl2_ico };

            Dash_dash_balance_value.Text = "Rs. " + balance.ToString("F2");
            Dash_dash_cbp_value.Text = "Rs. " + creditBalance.ToString("F2");
            

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
                    categoryValues[i].Text = "Rs. " + topCategories[i].CatAmount.ToString("F2");

                    // is the given path a valid path to the image
                    string iconPath = topCategories[i].IconPath;
                    if (System.IO.File.Exists(iconPath))
                    {
                        categoryIcons[i].Image = Image.FromFile(iconPath);
                    }
                    else
                    {
                        categoryIcons[i].Image = null;
                    }
                }
                else
                {
                    categoryLabels[i].Text = "N/A";
                    categoryValues[i].Text = "Rs. 0.00";
                    categoryIcons[i].Image = null;
                }

                Dash_dash_noshow_pnl.Visible = false;
                dbOperations.GetTotalIncomeThisMonth(userID);
                dbOperations.GetTotalExpenseThisMonth(userID);
                DisplayRecentTransactions();
            }
        }

        private void DisplayRecentTransactions()
        {
            List<Transaction> recentTransactions = dbOperations.GetRecentTransactions(userID);

            if (recentTransactions.Count == 0) 
            {
                Dash_dash_noshow_pnl.Visible = true;
            }
            else
            {
                for (int i = 0; i < recentPanels.Length; i++)
                {
                    if (i < recentTransactions.Count)
                    {
                        recentLabels[i].Text = recentTransactions[i].Title;
                        recentValues[i].Text = "Rs. " + recentTransactions[i].Amount.ToString("F2");
                        recentPanels[i].Visible = true;
                    }
                    else
                    {
                        recentPanels[i].Visible = false;
                        Dash_dash_noshow_pnl.Visible = true;
                    }
                }
            }

            Dash_dash_income_value.Text = "Rs. " + totalIncome.ToString("F2");
            Dash_dash_expense_value.Text = "Rs. " + totalExpenses.ToString("F2");
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


    }
}
