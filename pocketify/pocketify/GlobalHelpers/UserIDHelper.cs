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
