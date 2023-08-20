using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
namespace DAL
{
    public class NhanvienDAL : BDConnection
    {
        public List<NhanvienBEL> ReadCustomer()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<NhanvienBEL> lstCus = new List<NhanvienBEL>();
            while (reader.Read())
            {
                NhanvienBEL cus = new NhanvienBEL();
                cus.Id = int.Parse(reader["id"].ToString());
                cus.Name = reader["name"].ToString();
                cus.ngaysinh = reader["ngaysinh"].ToString();
                cus.gioitinh = reader["gioitinh"].ToString();
                cus.sdt = reader["sdt"].ToString();
                cus.diachi = reader["diachi"].ToString();
                lstCus.Add(cus);
            }

            conn.Close();
            return lstCus;
        }
        public void DeleteCustomer(NhanvienBEL customer)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from customer where id = @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", customer.Id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void NewCustomer(NhanvienBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO customer (id, name, ngaysinh, gioitinh, sdt, diachi) VALUES (@id, @name, @ngaysinh, @gioitinh, @sdt, @diachi)", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
            cmd.Parameters.Add(new SqlParameter("@name", cus.Name));
            cmd.Parameters.Add(new SqlParameter("@ngaysinh", cus.ngaysinh));
            cmd.Parameters.Add(new SqlParameter("@gioitinh", cus.gioitinh));
            cmd.Parameters.Add(new SqlParameter("@sdt", cus.sdt));
            cmd.Parameters.Add(new SqlParameter("@diachi", cus.diachi));

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void EditCustomer(NhanvienBEL cus)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();

                // Câu truy vấn UPDATE đúng cú pháp
                SqlCommand cmd = new SqlCommand("UPDATE customer SET name = @name, ngaysinh = @ngaysinh, gioitinh = @gioitinh, sdt = @sdt, diachi = @diachi WHERE id = @id", conn);
                cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
                cmd.Parameters.Add(new SqlParameter("@name", cus.Name));
                cmd.Parameters.Add(new SqlParameter("@ngaysinh", cus.ngaysinh));
                cmd.Parameters.Add(new SqlParameter("@gioitinh", cus.gioitinh));
                cmd.Parameters.Add(new SqlParameter("@sdt", cus.sdt));
                cmd.Parameters.Add(new SqlParameter("@diachi", cus.diachi));

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

    }
}


