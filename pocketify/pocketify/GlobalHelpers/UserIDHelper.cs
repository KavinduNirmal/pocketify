using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pocketify.GlobalHelpers
{
    public class UserIDHelper
    {
        private static UserIDHelper instance;
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public float Balance { get; set; }
        public float BalanceGoal { get; set; }
        public float CreditBalance { get; set; }
        public double TotalIncome { get; set; }
        public double TotalExpenses { get; set; }
        

        private UserIDHelper() { }

        public static UserIDHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserIDHelper();
                }
                return instance;
            }
        }
    }
}
