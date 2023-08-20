using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BAL;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

using System.Data.SqlClient;
using MaterialSkin.Controls;

namespace GUI
{
    public partial class QLNV : Form
    {
        NhanvienBAL cusBAL = new NhanvienBAL();
        public QLNV()
        {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS; Initial Catalog=sale; User Id=sa; Password=123");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer ORDER BY id ASC", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            dvgCustomer.Rows.Clear(); // Xóa dữ liệu cũ trong DataGridView trước khi thêm dữ liệu mới
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dvgCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(3), reader.GetString(2), reader.GetString(4)
                        , reader.GetString(5));

                }
            }
            conn.Close();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            
            NhanvienBEL cus = new NhanvienBEL();
            int newId;

            // Kiểm tra trùng lặp ID trong DataGridView trước khi thêm
            if (!int.TryParse(tbId.Text, out newId)||newId<=0)
            {
                MessageBox.Show("Mã nhân viên không hợp lệ.Mã phải là số dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(tbngaysinh.Text) ||
                string.IsNullOrWhiteSpace(tbgt.Text) || string.IsNullOrWhiteSpace(tbsdt.Text) ||
                string.IsNullOrWhiteSpace(tbdiachi.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (DataGridViewRow row in dvgCustomer.Rows)
            {
                if (row.Cells[0].Value != null && Convert.ToInt32(row.Cells[0].Value) == newId)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            cus.Id = int.Parse(tbId.Text);
            cus.Name = tbName.Text;
            cus.ngaysinh = tbngaysinh.Text;
            cus.gioitinh = tbgt.Text;
            cus.sdt = tbsdt.Text;
            cus.diachi = tbdiachi.Text;



            cusBAL.NewCustomer(cus);
            dvgCustomer.Rows.Add(cus.Id, cus.Name,cus.ngaysinh, cus.gioitinh, cus.sdt, cus.diachi);
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            List<NhanvienBEL> lstCus = cusBAL.ReadCustomer();
            foreach (NhanvienBEL cus in lstCus)
            {
                dvgCustomer.Rows.Add(cus.Id, cus.Name, cus.ngaysinh, cus.gioitinh, cus.sdt, cus.diachi);
            }

        }

        private void dvgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            tbId.Text = dvgCustomer.Rows[idx].Cells[0].Value.ToString();
            tbName.Text = dvgCustomer.Rows[idx].Cells[1].Value.ToString();
            tbngaysinh.Text = dvgCustomer.Rows[idx].Cells[2].Value.ToString();
            tbgt.Text = dvgCustomer.Rows[idx].Cells[3].Value.ToString();
            tbsdt.Text = dvgCustomer.Rows[idx].Cells[4].Value.ToString();
            tbdiachi.Text = dvgCustomer.Rows[idx].Cells[5].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            NhanvienBEL customer = new NhanvienBEL();
            customer.Id = int.Parse(tbId.Text);
            customer.Name = tbName.Text;
            customer.ngaysinh = tbngaysinh.Text;
            customer.gioitinh = tbgt.Text;
            customer.sdt = tbsdt.Text;
            customer.diachi = tbdiachi.Text;

            cusBAL.DeleteCustomer(customer);
            int idx = dvgCustomer.CurrentCell.RowIndex;
            dvgCustomer.Rows.RemoveAt(idx);
        }

        private bool Kiemtra(string input)
        {
            if (int.TryParse(input, out int value) && value > 0)
            {
                return true;
            }
            return false;
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            NhanvienBEL cus = new NhanvienBEL();
            if (dvgCustomer.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Kiemtra(tbsdt.Text))
            {
                MessageBox.Show("Số điện thoại phải là số dương và không phải chữ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                cus.Id = int.Parse(tbId.Text);
            cus.Name = tbName.Text;
            cus.ngaysinh = tbngaysinh.Text;
            cus.gioitinh = tbgt.Text;
            cus.sdt = tbsdt.Text;
            cus.diachi = tbdiachi.Text;

            cusBAL.EditCustomer(cus);
            DataGridViewRow row = dvgCustomer.CurrentRow;
            row.Cells[0].Value = cus.Id;
            row.Cells[1].Value = cus.Name;
            row.Cells[2].Value = cus.ngaysinh;
            row.Cells[3].Value = cus.gioitinh;
            row.Cells[4].Value = cus.sdt;
            row.Cells[5].Value = cus.diachi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //CustomerGUI tc = new CustomerGUI();
            //tc.Show();
        }

        private void Export_Excel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);

            for (int i = 0; i < dvgCustomer.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dvgCustomer.Columns[i].HeaderText;

            }
            for (int i = 0; i < dvgCustomer.Rows.Count; i++)
            {
                for (int j = 0; j < dvgCustomer.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dvgCustomer.Rows[i].Cells[j].Value;

                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;



        }
        private void Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx| Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Export_Excel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công !");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công !\n" + ex.Message);
                }
            }
        }
        private void Impor_Excel(string path)
        {
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                DataTable data = new DataTable();

                for (int i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++)
                {
                    data.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
                }

                for (int i = excelWorksheet.Dimension.Start.Row + 1; i <= excelWorksheet.Dimension.End.Row; i++)
                {
                    List<string> ListR = new List<string>();
                    for (int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
                    {
                        ListR.Add(excelWorksheet.Cells[i, j].Value.ToString());
                     }
                    data.Rows.Add(ListR.ToArray());
                }

                dvgCustomer.DataSource = data;
            }
        }
        private void Import_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Export Excel";
            openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx| Excel 2003 (*.xls)|*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Impor_Excel(openFileDialog.FileName);
                    MessageBox.Show("Nhập file thành công !");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhập file không thành công !\n" + ex.Message);
                }
            }
        }
        Modify modify = new Modify();

        private void materialMaskedTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            string name = tb_timkiem.Text.Trim();
            if (name == "")
            {
                QLNV_Load(sender, e);
            }
            else
            {
                string query = "SELECT * FROM customer WHERE name LIKE '%" + name + "%'";

                // Tạm thời gỡ bỏ ràng buộc dữ liệu
                dvgCustomer.DataSource = null;

                // Thêm dòng mới vào DataGridView
                dvgCustomer.Rows.Clear();

                // Thêm dữ liệu vào DataGridView
                DataTable data = modify.Table(query);
                foreach (DataRow row in data.Rows)
                {
                    dvgCustomer.Rows.Add(row.ItemArray);
                }

                // Ràng buộc lại dữ liệu (nếu cần)
                // dvgCustomer.DataSource = yourDataSource; 
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void tbsdt_TextChanged(object sender, EventArgs e)
        {
            string input = tbsdt.Text.Trim();

            if (!string.IsNullOrEmpty(input) && input.Length > 10)
            {
                MessageBox.Show("Số điện thoại không được quá 10 chữ số.");
                tbsdt.Text = input.Substring(0, 10); // Cắt bớt chuỗi nếu dài hơn 10 kí tự
            }
        }
    }
}
