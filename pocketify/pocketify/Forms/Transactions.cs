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
    public partial class Transactions : Form
    {
        DbOperations dbOperations = new DbOperations();
        private int userId = UserIDHelper.Instance.UserId;

        public Transactions()
        {
            InitializeComponent();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        private void Transaction_first_date_ValueChanged(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        private void Transaction_end_date_ValueChanged(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        private void LoadTransactions()
        {
            DateTime? startDate = Transaction_first_date.Value.Date;
            DateTime? endDate = Transaction_end_date.Value.Date.AddDays(1).AddTicks(-1); 

            List<Transaction> transactions = dbOperations.GetTransactions(userId, startDate, endDate);

            TransactionDataset.DataSource = transactions;
            TransactionDataset.Columns["Date"].DefaultCellStyle.Format = "yyyy-MM-dd";
        }

        private void Cat_action_btn_Click(object sender, EventArgs e)
        {
            LoadTransactions();
        }
    }
}
