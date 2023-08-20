using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;


namespace DAL
{
    public class ProductDAL:BDConnection
    {
        public List<ProductBEL> ReadCustomer()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from products", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<ProductBEL> lstPro = new List<ProductBEL>();
            while (reader.Read())
            {
                ProductBEL cus = new ProductBEL();
                cus.Id = int.Parse(reader["id"].ToString());
                cus.Name = reader["name"].ToString();
                cus.macl= reader["macl"].ToString();
                cus.soluong = reader["soluong"].ToString();
                cus.gianhap= reader["gianhap"].ToString();
                cus.giaban = reader["giaban"].ToString() ;
                cus.anh = reader["anh"].ToString();
                lstPro.Add(cus);
            }
            
            conn.Close();
            return lstPro;
        }
        public void DeleteCustomer(ProductBEL customer)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from products where id = @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", customer.Id));
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public void NewCustomer(ProductBEL cus)
        {
            
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO products (id, name, macl, soluong, gianhap, giaban) VALUES (@id, @name, @macl, @soluong, @gianhap, @giaban)", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
            cmd.Parameters.Add(new SqlParameter("@name", cus.Name));
            cmd.Parameters.Add(new SqlParameter("@macl", cus.macl));
            cmd.Parameters.Add(new SqlParameter("@soluong", cus.soluong));
            cmd.Parameters.Add(new SqlParameter("@gianhap", cus.gianhap));
            cmd.Parameters.Add(new SqlParameter("@giaban", cus.giaban));
            //cmd.Parameters.Add(new SqlParameter("@anh", cus.anh));

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void EditCustomer(ProductBEL cus)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();


                string sql = "UPDATE products SET Name = @name, macl = @macl, soluong = @soluong, gianhap = @gianhap, giaban = @giaban WHERE id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
                cmd.Parameters.Add(new SqlParameter("@name", cus.Name));
                cmd.Parameters.Add(new SqlParameter("@macl", cus.macl));
                cmd.Parameters.Add(new SqlParameter("@soluong", cus.soluong));
                cmd.Parameters.Add(new SqlParameter("@gianhap", cus.gianhap));
                cmd.Parameters.Add(new SqlParameter("@giaban", cus.giaban));

                cmd.ExecuteNonQuery();
              
            }
        }

    }
}

