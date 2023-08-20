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

namespace GUI
{
    public partial class CustomerGUI : Form
    {

      

        ProductBAL cusBAL = new ProductBAL();
        public CustomerGUI()
        {
            InitializeComponent();
           

        }
        Modify modify=new Modify();

        // Xử lý sự kiện Form1_Load để hiển thị dữ liệu từ danh sách sản phẩm lên DataGridView
        private void Form1_Load(object sender, EventArgs e)
        {
            List<ProductBEL> lstProd = cusBAL.ReadCustomer();
            foreach (ProductBEL cus in lstProd)
            {
                // Thêm dữ liệu vào DataGridView
                int rowIndex = dvgCustomer.Rows.Add(cus.Id, cus.Name, cus.macl, cus.soluong, cus.gianhap, cus.giaban);

                // Nếu có dữ liệu hình ảnh trong cus.anh, bạn cần cập nhật cột hình ảnh tại dòng tương ứng
                if (cus.anh != null)
                {
                    dvgCustomer.Rows[rowIndex].Cells[6].Value = cus.anh;
                }
            }
        }


        private bool Kiemtra(string input)
        {
            if (int.TryParse(input, out int value) && value > 0)
            {
                return true;
            }
            return false;
        }
       

        private void btNew_Click(object sender, EventArgs e)
        {
            ProductBEL cus = new ProductBEL();
            int newId;

            // Kiểm tra trùng lặp ID trong DataGridView trước khi thêm
            if (!int.TryParse(tbId.Text, out newId) || newId <= 0)
            {
                MessageBox.Show("Mã sản phẩm không hợp lệ. Mã phải là số dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra trường thông tin trống
            if (string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(tbcl.Text) ||
                string.IsNullOrWhiteSpace(tbsoluong.Text) || string.IsNullOrWhiteSpace(tbgianhap.Text) ||
                string.IsNullOrWhiteSpace(tbgiaban.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewRow row in dvgCustomer.Rows)
            {
                if (row.Cells[0].Value != null && Convert.ToInt32(row.Cells[0].Value) == newId)
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Kiểm tra số dương cho các giá trị
            if (!Kiemtra(tbsoluong.Text))
            {
                MessageBox.Show("Số lượng phải là số dương và không phải chữ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Kiemtra(tbgianhap.Text))
            {
                MessageBox.Show("Giá nhập phải là số dương và không phải chữ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Kiemtra(tbgiaban.Text))
            {
                MessageBox.Show("Giá bán phải là số dương và không phải chữ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cus.Id = newId;
            cus.Name = tbName.Text;
            cus.macl = tbcl.Text;
            cus.soluong = tbsoluong.Text;
            cus.gianhap = tbgianhap.Text;
            cus.giaban = tbgiaban.Text;

            // Gán giá trị ảnh từ PictureBox
            //cus.anh = ConvertImageToByteArray(pb_anh.ImageLocation);

            cusBAL.NewCustomer(cus);

            // Thêm dữ liệu vào DataGridView
            dvgCustomer.Rows.Add(cus.Id, cus.Name, cus.macl, cus.soluong, cus.gianhap, cus.giaban, cus.anh);
        }

        private byte[] ConvertImageToByteArray(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                return File.ReadAllBytes(imagePath);
            }
            return null;
        }


        //private void btNew_Click(object sender, EventArgs e)
        //{ 




        //        ProductBEL cus = new ProductBEL();
        //    int newId;

        //    // Kiểm tra trùng lặp ID trong DataGridView trước khi thêm
        //    if (!int.TryParse(tbId.Text, out newId)|| newId <=0)
        //        {
        //        MessageBox.Show("Mã sản phẩm không hợp lệ. Mã phải là số dương .", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //        }
        //    // Kiểm tra trường thông tin trống
        //    if (string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(tbcl.Text) ||
        //        string.IsNullOrWhiteSpace(tbsoluong.Text) || string.IsNullOrWhiteSpace(tbgianhap.Text) ||
        //        string.IsNullOrWhiteSpace(tbgiaban.Text))
        //    {
        //        MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    foreach (DataGridViewRow row in dvgCustomer.Rows)
        //        {
        //            if (row.Cells[0].Value != null && Convert.ToInt32(row.Cells[0].Value) == newId)
        //            {
        //                MessageBox.Show("Mã sản phẩm đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return;
        //            }
        //        }
        //    //string query = "insert into products values(@anh)";
        //        cus.Id = newId;
        //        cus.Name = tbName.Text;
        //        cus.macl = tbcl.Text;
        //        cus.soluong = tbsoluong.Text;
        //        cus.gianhap = tbgianhap.Text;
        //        cus.giaban = tbgiaban.Text;
        //        cus.anh=cus.anh;

        //        cusBAL.NewCustomer(cus);
        //        dvgCustomer.Rows.Add(cus.Id, cus.Name, cus.macl, cus.soluong, cus.gianhap, cus.giaban,cus.anh);

        //}


        private void dvgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            tbId.Text = dvgCustomer.Rows[idx].Cells[0].Value.ToString();
            tbName.Text = dvgCustomer.Rows[idx].Cells[1].Value.ToString();
            tbcl.Text = dvgCustomer.Rows[idx].Cells[2].Value.ToString();
            tbsoluong.Text = dvgCustomer.Rows[idx].Cells[3].Value.ToString();
            tbgianhap.Text = dvgCustomer.Rows[idx].Cells[4].Value.ToString();
            tbgiaban.Text = dvgCustomer.Rows[idx].Cells[5].Value.ToString();
            //pb_anh.Text = dvgCustomer.Rows[idx].Cells[6].Value.Image();
        }


            private void btDel_Click(object sender, EventArgs e)

        {

            

             
            ProductBEL customer = new ProductBEL();

            if (int.TryParse(tbId.Text, out int id))
            {
                customer.Id = id;
            }
            else
            {
                MessageBox.Show("xóa không thành công");
                return;
            }

            customer.Name = tbName.Text;
            customer.macl = tbcl.Text;
            customer.soluong = tbsoluong.Text;
            customer.gianhap = tbgianhap.Text;
            customer.giaban = tbgiaban.Text;

            cusBAL.DeleteCustomer(customer);
            int idx = dvgCustomer.CurrentCell.RowIndex;
            dvgCustomer.Rows.RemoveAt(idx);
            }
           
        


       

            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=sale; User Id=sa; Password=123";
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("update customer set Name='" + tbName.Text + "' where id=" + tbId.Text, conn);
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //int idx = dvgCustomer.CurrentCell.RowIndex;
            //dvgCustomer.Rows[idx].Cells[1].Value = tbName.Text;
            private void btEdit_Click(object sender, EventArgs e)
            {
                ProductBEL cus = new ProductBEL();

                // Kiểm tra nếu không có hàng nào được chọn
                if (dvgCustomer.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một hàng để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int selectedRowIndex = dvgCustomer.CurrentRow.Index;
                int id = Convert.ToInt32(dvgCustomer.Rows[selectedRowIndex].Cells[0].Value);

            // Kiểm tra số dương cho các giá trị
            if (!Kiemtra(tbsoluong.Text))
            {
                MessageBox.Show("Số lượng phải là số dương và không phải chữ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Kiemtra(tbgianhap.Text))
            {
                MessageBox.Show("Giá nhập phải là số dương và không phải chữ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Kiemtra(tbgiaban.Text))
            {
                MessageBox.Show("Giá bán phải là số dương và không phải chữ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Gán giá trị ID mà không cần kiểm tra mới/đã tồn tại
            cus.Id = id;
                cus.Name = tbName.Text;
                cus.macl = tbcl.Text;
                cus.soluong = tbsoluong.Text;
                cus.gianhap = tbgianhap.Text;
                cus.giaban = tbgiaban.Text;

                cusBAL.EditCustomer(cus);

                // Cập nhật thông tin trong DataGridView
                dvgCustomer.Rows[selectedRowIndex].Cells[1].Value = cus.Name;
                dvgCustomer.Rows[selectedRowIndex].Cells[2].Value = cus.macl;
                dvgCustomer.Rows[selectedRowIndex].Cells[3].Value = cus.soluong;
                dvgCustomer.Rows[selectedRowIndex].Cells[4].Value = cus.gianhap;
                dvgCustomer.Rows[selectedRowIndex].Cells[5].Value = cus.giaban;
            }



            private void btRead_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS; Initial Catalog=sale; User Id=sa; Password=123");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from products ORDER BY id ASC", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            dvgCustomer.Rows.Clear(); // Xóa dữ liệu cũ trong DataGridView trước khi thêm dữ liệu mới
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dvgCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1),reader.GetString(2), reader.GetString(3), reader.GetString(4)
                        ,reader.GetString(5));

                }
            }
            conn.Close();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btqlnv_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //QLNV tc = new QLNV();
            //tc.Show();
           

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbsoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void ExportExcel(string path)
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
            SaveFileDialog saveFileDialog=new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx| Excel 2003 (*.xls)|*.xls";
            if(saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công !");

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công !\n" + ex.Message);
                }
            }
        }
        private void Import(string path)
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
                    List<string> rowValues = new List<string>();
                    for (int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
                    {
                        rowValues.Add(excelWorksheet.Cells[i, j].Value.ToString());
                    }
                    data.Rows.Add(rowValues.ToArray());
                }

                dvgCustomer.DataSource = data;
            }
        }

        private void Impor_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import Excel";
            openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx| Excel 2003 (*.xls)|*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Import(openFileDialog.FileName);
                    MessageBox.Show("Nhập file thành công !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhập file không thành công !\n" + ex.ToString());
                }
            }
        }



        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            string name = tb_timkiem.Text.Trim();
            if (name == "")
            {
                Form1_Load(sender, e);
            }
            else
            {
                string query = "SELECT * FROM products WHERE name LIKE '%" + name + "%'";

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

        PB_Pro pro;
        private void GetValues()
        {
            string name = pb_anh.Text;
            byte[] anh = ImageToByArray(pb_anh);
             pro=new PB_Pro(name,anh);
             
            //PB_Pro=new PB_Pro(name,anh);

        }

       

        private byte[] ImageToByArray(PictureBox pic)
        {
            MemoryStream memory = new MemoryStream();
            pic.Image.Save(memory, pic.Image.RawFormat);
            return memory.ToArray();
        }
        private void bt_anh_Click(object sender, EventArgs e)
        {
            //pb_anh.SizeMode = PictureBoxSizeMode.StretchImage;
            //OpenFileDialog dlg = new OpenFileDialog();
            //dlg.Title = "Open Image";
            //dlg.Filter = "JPEG file(*.jpg)|*.jpg|PNG file(*.png)|*.png";

            //if (dlg.ShowDialog() == DialogResult.OK)
            //{
            //    pb_anh.ImageLocation = dlg.FileName;
            //}

            string filepath = null;
            OpenFileDialog ofd = new OpenFileDialog();
            PictureBox pb = new PictureBox();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filepath = ofd.FileName;
            }
            MessageBox.Show("Tải ảnh thành công", "thông báo", MessageBoxButtons.OK);
            pb_anh.Image = Image.FromFile(filepath.ToString());
            pb_anh.SizeMode = PictureBoxSizeMode.StretchImage;


        }
    //    

    private void dvgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            

        //   string query = "select anh from products  "; //(id, name, macl, soluong, gianhap, giaban)

        //    try
        //    {
        //        GetValues();
        //        modify.Command(query, pro);
        //        MessageBox.Show("Thêm thành công");
        //        Form1_Load(sender, e);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi thêm"+ex.Message);
        //    }
        }
    }
}
