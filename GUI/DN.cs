using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUI
{
   
    public partial class DN : Form
    {
        public DN()
        {
            InitializeComponent();
           
        }

        private void txtdn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btdn_Click(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS; Initial Catalog=sale; Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select *from TaiKhoan where TenDangnhap=N'" + txtdn.Text + "' and Matkhau=N'" + txtmk.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công !", " Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Trangchu tc = new Trangchu(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                tc.Show();
            }
            else
            {
                MessageBox.Show("Sai thông tin tài khoản hoặc mật khẩu");
            }
            //string dangnhap = txtdn.Text;
            //string matkhau = txtmk.Text;

            //if (dangnhap == "admin" && matkhau == "123")
            //{
            //    MessageBox.Show("Đăng nhập thành công ! Xin chào :" + dangnhap);
            //    this.Hide();
            //    Trangchu tc = new Trangchu();
            //    tc.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Sai thông tin tài khoản");
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtmk.UseSystemPasswordChar = true;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtmk.UseSystemPasswordChar = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void fgmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMK qmk= new QuenMK();
            qmk.Show();
        }

        private void DN_Load(object sender, EventArgs e)
        {

        }
    }
}
