using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;

namespace ADO
{
    public partial class Form1 : Form
    {
        CustomerBAL cusBAL = new CustomerBAL();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<CustomerBEL> lstCus = cusBAL.ReadCustomer();
            foreach (CustomerBEL cus in lstCus)
            {
                dvgCustomer.Rows.Add(cus.Id, cus.Name);
            }
        }

       

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btNew_Click(object sender, EventArgs e)
        {

            CustomerBEL cus = new CustomerBEL();
            cus.Id = int.Parse(tbId.Text);
            cus.Name = tbName.Text;

            cusBAL.NewCustomer(cus);
            dvgCustomer.Rows.Add(cus.Id, cus.Name);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=sale; User Id=sa; Password=123";
            conn.Open();
            SqlCommand cmd = new SqlCommand("update customer set Name='" + tbName.Text + "' where id=" + tbId.Text, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            int idx = dvgCustomer.CurrentCell.RowIndex;
            dvgCustomer.Rows[idx].Cells[1].Value = tbName.Text;
        }

        

        private void btRead_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS; Initial Catalog=sale; User Id=sa; Password=123");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dvgCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1));

                }
            }
            conn.Close();
        }

      

        private void btDelete_Click(object sender, EventArgs e)
        {
            CustomerBEL cus = new CustomerBEL();
            cus.Id = int.Parse(tbId.Text);
            cus.Name = tbName.Text;
            cusBAL.NewCustomer(cus);
            dvgCustomer.Rows.Add(cus.Id, cus.Name);
        }
        private void btExit_Click(object sender, EventArgs e)
        {

        }
        private void dvgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            tbId.Text = dvgCustomer.Rows[idx].Cells[0].Value.ToString();
            tbName.Text = dvgCustomer.Rows[idx].Cells[1].Value.ToString();
        }
    }
}
