    using iTextSharp.text;
    using iTextSharp.text.pdf;
    using MaterialSkin.Controls;
    using System;
    using System.Configuration;
    using System.Data.SqlClient;
    using System.IO;
    using System.Windows.Controls;
    using System.Windows.Forms;


    namespace GUI
    {
        public partial class HoaDon_Form : MaterialForm
        {
            readonly MaterialSkin.MaterialSkinManager mtskin;
            public HoaDon_Form()
            {
                InitializeComponent();
                mtskin = MaterialSkin.MaterialSkinManager.Instance;
                mtskin.EnforceBackcolorOnAllComponents = true;
                mtskin.AddFormToManage(this);
                mtskin.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
                mtskin.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500,
               MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100,
               MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
            }

            private void HoaDon_Form_Load(object sender, EventArgs e)
            {

            }

            private void btm_Them_Click(object sender, EventArgs e)
            {

                string tensp = tbm_tensp.Text;
                string size = tbm_size.Text;
                string dongia = tbm_dgia.Text;
                string sol = tbm_soluong.Text;
                string ma = tbm_mahd. Text;
                string tenkh = tbm_tenkh.Text;
                string time = tbm_tg.Text;
                //IsNullOrEmpty là một phương thức tĩnh được cung cấp bởi lớp String trong C#.
                //Phương thức này được sử dụng để kiểm tra xem một chuỗi có giá trị null hoặc trống (không có ký tự nào) hay không.
                //Nó trả về true nếu chuỗi có giá trị null hoặc trống,
                //và trả về false nếu chuỗi có ít nhất một ký tự hoặc không phải null.

                if (!string.IsNullOrEmpty(tensp) && !string.IsNullOrEmpty(size) && !string.IsNullOrEmpty(dongia)
                && !string.IsNullOrEmpty(sol) &&!string.IsNullOrEmpty(ma))
                {
                    // Kiểm tra giá trị của dongia, sol và size
                    if (int.TryParse(dongia, out int parsedDongia) && int.TryParse(sol, out int parsedSol) &&int.TryParse(ma,out int parsedMa))
                    {
                        // Kiểm tra số âm
                        if (parsedDongia >= 0 && parsedSol >= 0 &&parsedMa>0)
                        {
                            // Kiểm tra size
                            if (size == "S" || size == "M" || size == "L" || size == "XL" || size == "XXL")
                            {
                                // Lưu dữ liệu vào cơ sở dữ liệu
                                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                                {
                                    connection.Open();

                                    string query = "INSERT INTO Orderdetail (Tensp, size, dongia, sol,mahd,tenkh,times) VALUES (@Tensp, @Size, @Dongia, @Sol,@Mahd,@Tenkh,@Times)";
                                    using (SqlCommand command = new SqlCommand(query, connection))
                                    {
                                        command.Parameters.AddWithValue("@Tensp", tensp);
                                        command.Parameters.AddWithValue("@Size", size);
                                        command.Parameters.AddWithValue("@Dongia", parsedDongia);
                                        command.Parameters.AddWithValue("@Sol", parsedSol);
                                        command.Parameters.AddWithValue("@Mahd", parsedMa);
                                        command.Parameters.AddWithValue("@Tenkh", tenkh);
                                        command.Parameters.AddWithValue("@times", time);


                                    command.ExecuteNonQuery();
                                    }
                                }

                                // Hiển thị dữ liệu trong materialListView3
                                System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem(tensp);
                                item.SubItems.Add(size);
                                item.SubItems.Add(parsedDongia.ToString());
                                item.SubItems.Add(parsedSol.ToString());
                                item.SubItems.Add(parsedMa.ToString());
                                item.SubItems.Add(tenkh);
                                item.SubItems.Add(time);


                            materialListView3.Items.Add(item);

                                // Xóa dữ liệu từ các TextBox sau khi thêm
                                tbm_tensp.Text = "";
                                tbm_size.Text = "";
                                tbm_dgia.Text = "";
                                tbm_soluong.Text = "";

                                MessageBox.Show("Thêm dữ liệu thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Kích thước không hợp lệ! Hãy chọn size S, M, L, XL, hoặc XXL.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Đơn giá và số lượng không được âm!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đơn giá, kích thước và số lượng phải là số nguyên!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                }
            }
            //xoa
            private void btm_Xoa_Click(object sender, EventArgs e)
            {
                if (materialListView3.SelectedItems.Count > 0)
                {
                System.Windows.Forms.ListViewItem selectedItem = materialListView3.SelectedItems[0];
                    string tensp = selectedItem.SubItems[0].Text; // vd cột đầu tiên 'tensp'

                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        connection.Open();

                        string query = "DELETE FROM Orderdetail WHERE Tensp = @Tensp";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Tensp", tensp);
                            command.ExecuteNonQuery();
                        }
                    }

                    materialListView3.Items.Remove(selectedItem);
                    MessageBox.Show("Xóa dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một mục để xóa.");
                }
            }

            // in hd
            private void Excel(string path)
            {

                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));
                document.Open();

                PdfPTable table = new PdfPTable(materialListView3.Columns.Count);

                // Thiết lập font Unicode để hỗ trợ ký tự có dấu
                BaseFont bf = BaseFont.CreateFont("c:\\windows\\fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 12);

                // Xuất tiêu đề cột
                for (int i = 0; i < materialListView3.Columns.Count; i++)
                {
                    PdfPCell cell = new PdfPCell(new iTextSharp.text.Phrase(materialListView3.Columns[i].Text, font));// them new iTextSharp.text. để khỏi bị xung đột font và phrase

                    table.AddCell(cell);
                }

                // Xuất dữ liệu hàng
                for (int i = 0; i < materialListView3.Items.Count; i++)
                {
                    for (int j = 0; j < materialListView3.Columns.Count; j++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(materialListView3.Items[i].SubItems[j].Text, font));
                        table.AddCell(cell);
                    }
                }

                document.Add(table);
                document.Close();

            }

     
            private void btm_In_Click(object sender, EventArgs e)
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

       
        }
        


            //private void tbm_tensp_TextChanged(object sender, EventArgs e)
            //{

            //}
    
    

    }
