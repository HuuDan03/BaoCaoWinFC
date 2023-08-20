using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BDConnection
    {
        public BDConnection()
        {
        }
        public SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=sale; User Id=sa; Password=123";
            return conn;
        }
    }
}
