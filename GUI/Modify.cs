using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace GUI
{
    class Modify
    {
        public Modify()
        { 
        }
        
        SqlDataAdapter dataAdapter;
        SqlCommand SqlCommand;
        public DataTable Table(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        public void Command(string query,PB_Pro pro)// them,sua,xoa,string PB_Pro
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand = new SqlCommand(query, sqlConnection);
              
                ///
              SqlCommand.Parameters.Add("@name", pro.Name);
              SqlCommand.Parameters.Add("@anh", pro.Anh);
                SqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
