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
    public partial class DashboardForm : Form
    {
        int userID;
        float balance;
        float balanceGoal;
        float creditBalance;

        private Label[] recentLabels;
        private Label[] recentValues;
        private Panel[] recentPanels;

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

            recentLabels = new Label[] { Dash_dash_trans_pnl1_txt, Dash_dash_trans_pnl2_txt, Dash_dash_trans_pnl3_txt, Dash_dash_trans_pnl4_txt };
            recentValues = new Label[] { Dash_dash_trans_pnl1_val, Dash_dash_trans_pnl2_val, Dash_dash_trans_pnl3_val, Dash_dash_trans_pnl4_val };
            recentPanels = new Panel[] { Dash_dash_trans_pnl1, Dash_dash_trans_pnl2, Dash_dash_trans_pnl3, Dash_dash_trans_pnl4 };

            Dash_dash_balance_value.Text = "Rs. " + Convert.ToString(balance);
            Dash_dash_cbp_value.Text = "Rs. " + Convert.ToString(creditBalance);

            if (balanceGoal != 0)
            {
                Dash_dash_balance_progress.Value = (int)((balance / balanceGoal) * 100);
            }
            else { Dash_dash_balance_progress.Value = 0; }

            Dash_dash_noshow_pnl.Visible = false;

            DisplayRecentTransactions();
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
