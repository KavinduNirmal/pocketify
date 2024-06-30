using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pocketify.GlobalHelpers
{
    internal class ApplicationInfoHelper
    {
        private static ApplicationInfoHelper instance;
        public string Version { get; set; }
        
        private ApplicationInfoHelper() { }

        public static ApplicationInfoHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ApplicationInfoHelper();
                }
                return instance;
            }
        }
    }
}
