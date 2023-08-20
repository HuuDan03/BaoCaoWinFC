using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Dapper;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


using Excel = Microsoft.Office.Interop.Excel;


namespace GUI
{
    public partial class Trangchu : MaterialForm

    {


        readonly MaterialSkin.MaterialSkinManager mtskin;

        string TenDangnhap = "", TenNhanvien = "", Matkhau = "", Quyen = "";
        public Trangchu(string TenDangnhap, string TenNhanvien, string Matkhau, string Quyen)
        {
            InitializeComponent();
            mtskin= MaterialSkin.MaterialSkinManager.Instance;
            mtskin.EnforceBackcolorOnAllComponents= true;
            mtskin.AddFormToManage(this);
            mtskin.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            mtskin.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
            
            
            this.TenDangnhap = TenDangnhap;
            this.TenNhanvien = TenNhanvien;
            this.Matkhau = Matkhau;
            this.Quyen = Quyen;
        }
        public Trangchu()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btqlnv_Click(object sender, EventArgs e)
        {

            //if(Quyen=="admin")
            //{
            OpenChildForm(new QLNV());
            //}    
        }

        private void btsanpham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerGUI());

        }

        private void Trangchu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DN tc = new DN();
            tc.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }
        MaterialSkinManager Theme = MaterialSkinManager.Instance;

        private void themeTog_CheckedChanged(object sender, EventArgs e)
        {
            if(themeTog.Checked)
            {
                Theme.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                Theme.Theme = MaterialSkinManager.Themes.LIGHT;
            }    
        }

        private void Color1_CheckedChanged(object sender, EventArgs e)
        {
            Theme.ColorScheme = new ColorScheme(Primary.Green700, Primary.Green900, Primary.Green500, Accent.Green400, TextShade.WHITE);

        }

        private void Color2_CheckedChanged(object sender, EventArgs e)
        {
            Theme.ColorScheme = new ColorScheme(Primary.Pink700, Primary.Pink900, Primary.Pink500, Accent.Pink400, TextShade.WHITE);

        }

        private void bt_sp_Click(object sender, EventArgs e)
        {
            QLNV ql = new QLNV();
            ql.Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLNV());
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Theme.ColorScheme= new ColorScheme(Primary.Indigo500,Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            string currentYear = DateTime.Now.Year.ToString();
            String tt = "";
            tt += "Phần mềm : Quản Lý Thời Trang DNA  ";
            tt += "\n ";
            tt += "\nversion : 1.5 @ năm " + currentYear + "\n";
            tt += "\n";
            tt += "Học phần : ";
            tt += "\t";
            tt += "____WINFORM C#____";
            tt += "\n";
            tt += "\nSinh viên thực hiện : - Nguyễn Huỳnh Hữu Đan \n";
            tt += "\n";
            tt += "Email : huudandeptrai@gmail.com";
            tt += "\n";
            tt += "Facebook : https://www.facebook.com/huudan0g";
            tt += "\n";
            MessageBox.Show((tt), "Thông tin phần mềm", MessageBoxButtons.OK);
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {

        }

        private void bt_Load_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if( db.State==ConnectionState.Closed)
               db.Open();
                var data = db.Query<DonHang>("select MaHD,KH,Ngay,Gia from Orders", commandType: CommandType.Text);
            materialListView1.Items.Clear();
                foreach( DonHang dh in data)
                {
                    ListViewItem item = new ListViewItem(dh.MaHD.ToString());
                    item.SubItems.Add(dh.KH);
                    item.SubItems.Add(dh.Ngay.ToString());
                    item.SubItems.Add(dh.Gia.ToString());
                    materialListView1.Items.Add(item);

                }
            }
        }


      

// ...

        private void Excel(string path)
            {

            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));
            document.Open();

            PdfPTable table = new PdfPTable(materialListView1.Columns.Count);

            // Thiết lập font Unicode để hỗ trợ ký tự có dấu
            BaseFont bf = BaseFont.CreateFont("c:\\windows\\fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 12);

            // Xuất tiêu đề cột
            for (int i = 0; i < materialListView1.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell(new iTextSharp.text.Phrase(materialListView1.Columns[i].Text, font));// them new iTextSharp.text. để khỏi bị xung đột font và phrase

                table.AddCell(cell);
            }

            // Xuất dữ liệu hàng
            for (int i = 0; i < materialListView1.Items.Count; i++)
            {
                for (int j = 0; j < materialListView1.Columns.Count; j++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(materialListView1.Items[i].SubItems[j].Text, font));
                    table.AddCell(cell);
                }
            }

            document.Add(table);
            document.Close();

        }

       

        private void materialButton3_Click_1(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "PDF Documment";
            saveFileDialog.Filter = "PDF Documment (*.pdf)|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Excel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công !");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công !\n" + ex.Message);
                }
            }

        }

        private void AddHD_Click(object sender, EventArgs e)
        {
            HoaDon_Form hdf=new HoaDon_Form();
            hdf.ShowDialog();
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
