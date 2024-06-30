using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pocketify.Database
{
    internal class DbConnection
    {
        private readonly string _connectionString;

        public DbConnection()
        {
            // TODO: Create an environment variable instead.
            _connectionString = "Data Source=MSI;Initial Catalog=Pocketify;Integrated Security=True;";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
