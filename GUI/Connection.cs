using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
     class Connection

    {
        private static string stringConnection= @"Data Source=MSI\SQLEXPRESS; Initial Catalog=sale; User Id=sa; Password=123";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
