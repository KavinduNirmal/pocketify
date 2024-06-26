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
using pocketify.GlobalHelpers;
using static pocketify.Database.DbOperations;

namespace pocketify.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            DbOperations dbOperations = new DbOperations();
            int userID = UserIDHelper.Instance.UserId;

            // Check the database for the balance
            UserBalance userBalance = dbOperations.GetUserBalance(userID);
            if (userBalance != null) // if the user have a balance retrieve it ana populate.
            {
                float currentBalance = userBalance.Balance;
                float balanceGoal = userBalance.BalanceGoal;
                Dash_dash_balance_value.Text = "Rs." + currentBalance;

                if (currentBalance <= balanceGoal && balanceGoal != 0)
                {
                    int percentage = (int)((currentBalance / (float)balanceGoal) * 100); // make the progressbar go brr.
                    Dash_dash_balance_progress.Value = percentage;
                }
            }
            else // if the user doesnt have a balance, create one.
            {
                UserBalance newBalance = dbOperations.IntitalizeBalance(userID);
                Dash_dash_balance_value.Text = "Rs." + newBalance.Balance;
                Dash_dash_balance_progress.Value = 0; // Initial progress
            }

            // retrieve the user credit balance
            float userCreditBalance = dbOperations.GetUserCredit(userID);
            if (userCreditBalance >= 0) // Check if the balance is above or equal to 0 | if the user already have a balance
            {
                Dash_dash_cbp_value.Text = "Rs. " + userCreditBalance; // retrieve it
            }
            else // if the user doesnt have a balace create one
            {
                float newCreditBalance = dbOperations.InitializeCreditBalance(userID);
                Dash_dash_cbp_value.Text = "Rs. " + newCreditBalance;
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
