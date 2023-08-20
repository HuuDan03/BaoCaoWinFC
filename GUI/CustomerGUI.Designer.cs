namespace GUI
{
    partial class CustomerGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.dvgCustomer = new System.Windows.Forms.DataGridView();
            this.Mã = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tên = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btDel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbcl = new System.Windows.Forms.TextBox();
            this.tbsoluong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbgianhap = new System.Windows.Forms.TextBox();
            this.tbgiaban = new System.Windows.Forms.TextBox();
            this.btNew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Export = new System.Windows.Forms.Button();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.bt_anh = new System.Windows.Forms.Button();
            this.pb_anh = new System.Windows.Forms.PictureBox();
            this.Impor = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anh)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tbName.Location = new System.Drawing.Point(97, 339);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(145, 28);
            this.tbName.TabIndex = 27;
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tbId.Location = new System.Drawing.Point(97, 289);
            this.tbId.Multiline = true;
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(145, 29);
            this.tbId.TabIndex = 26;
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã";
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.PapayaWhip;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(480, 400);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 38);
            this.btExit.TabIndex = 23;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = false;
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(387, 400);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(77, 38);
            this.btEdit.TabIndex = 20;
            this.btEdit.Text = "Sửa";
            this.btEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btRead
            // 
            this.btRead.BackColor = System.Drawing.Color.PapayaWhip;
            this.btRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRead.Location = new System.Drawing.Point(32, 400);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(98, 38);
            this.btRead.TabIndex = 21;
            this.btRead.Text = "Đọc dữ liệu";
            this.btRead.UseVisualStyleBackColor = false;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // dvgCustomer
            // 
            this.dvgCustomer.AllowUserToAddRows = false;
            this.dvgCustomer.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dvgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mã,
            this.Tên,
            this.macl,
            this.soluong,
            this.gianhap,
            this.giaban,
            this.Column1});
            this.dvgCustomer.Location = new System.Drawing.Point(56, 5);
            this.dvgCustomer.Name = "dvgCustomer";
            this.dvgCustomer.RowHeadersWidth = 51;
            this.dvgCustomer.RowTemplate.Height = 24;
            this.dvgCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCustomer.Size = new System.Drawing.Size(681, 283);
            this.dvgCustomer.TabIndex = 19;
            this.dvgCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCustomer_CellClick);
            this.dvgCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCustomer_CellContentClick);
            // 
            // Mã
            // 
            this.Mã.DataPropertyName = "id";
            this.Mã.HeaderText = "Mã";
            this.Mã.MinimumWidth = 6;
            this.Mã.Name = "Mã";
            this.Mã.Width = 125;
            // 
            // Tên
            // 
            this.Tên.DataPropertyName = "name";
            this.Tên.HeaderText = "Tên";
            this.Tên.MinimumWidth = 6;
            this.Tên.Name = "Tên";
            this.Tên.Width = 125;
            // 
            // macl
            // 
            this.macl.HeaderText = "Mã chất liệu";
            this.macl.MinimumWidth = 6;
            this.macl.Name = "macl";
            this.macl.Width = 125;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.Width = 125;
            // 
            // gianhap
            // 
            this.gianhap.HeaderText = "Giá nhập";
            this.gianhap.MinimumWidth = 6;
            this.gianhap.Name = "gianhap";
            this.gianhap.Width = 125;
            // 
            // giaban
            // 
            this.giaban.HeaderText = "Giá bán";
            this.giaban.MinimumWidth = 6;
            this.giaban.Name = "giaban";
            this.giaban.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Hình ảnh";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // btDel
            // 
            this.btDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.Location = new System.Drawing.Point(258, 400);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(99, 38);
            this.btDel.TabIndex = 29;
            this.btDel.Text = "Xóa";
            this.btDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDel.UseVisualStyleBackColor = false;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(553, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tìm kiếm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Mã chất liệu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Số Lượng";
            // 
            // tbcl
            // 
            this.tbcl.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tbcl.Location = new System.Drawing.Point(332, 292);
            this.tbcl.Multiline = true;
            this.tbcl.Name = "tbcl";
            this.tbcl.Size = new System.Drawing.Size(91, 26);
            this.tbcl.TabIndex = 37;
            // 
            // tbsoluong
            // 
            this.tbsoluong.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tbsoluong.Location = new System.Drawing.Point(319, 342);
            this.tbsoluong.Multiline = true;
            this.tbsoluong.Name = "tbsoluong";
            this.tbsoluong.Size = new System.Drawing.Size(88, 29);
            this.tbsoluong.TabIndex = 38;
            this.tbsoluong.TextChanged += new System.EventHandler(this.tbsoluong_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Giá nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(429, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "Giá Bán";
            // 
            // tbgianhap
            // 
            this.tbgianhap.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tbgianhap.Location = new System.Drawing.Point(497, 299);
            this.tbgianhap.Multiline = true;
            this.tbgianhap.Name = "tbgianhap";
            this.tbgianhap.Size = new System.Drawing.Size(104, 26);
            this.tbgianhap.TabIndex = 41;
            // 
            // tbgiaban
            // 
            this.tbgiaban.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tbgiaban.Location = new System.Drawing.Point(497, 352);
            this.tbgiaban.Multiline = true;
            this.tbgiaban.Name = "tbgiaban";
            this.tbgiaban.Size = new System.Drawing.Size(104, 26);
            this.tbgiaban.TabIndex = 42;
            // 
            // btNew
            // 
            this.btNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNew.Location = new System.Drawing.Point(146, 398);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(96, 43);
            this.btNew.TabIndex = 22;
            this.btNew.Text = "Thêm";
            this.btNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNew.UseVisualStyleBackColor = false;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(204, 402);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.delete;
            this.pictureBox2.Location = new System.Drawing.Point(307, 403);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI.Properties.Resources.edit;
            this.pictureBox3.Location = new System.Drawing.Point(432, 403);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            // 
            // Export
            // 
            this.Export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export.Location = new System.Drawing.Point(576, 405);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(89, 29);
            this.Export.TabIndex = 46;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = false;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(621, 330);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(60, 22);
            this.tb_timkiem.TabIndex = 47;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // bt_anh
            // 
            this.bt_anh.Location = new System.Drawing.Point(607, 355);
            this.bt_anh.Name = "bt_anh";
            this.bt_anh.Size = new System.Drawing.Size(75, 23);
            this.bt_anh.TabIndex = 48;
            this.bt_anh.Text = "Chọn ảnh";
            this.bt_anh.UseVisualStyleBackColor = true;
            this.bt_anh.Click += new System.EventHandler(this.bt_anh_Click);
            // 
            // pb_anh
            // 
            this.pb_anh.BackColor = System.Drawing.Color.Chocolate;
            this.pb_anh.Location = new System.Drawing.Point(688, 292);
            this.pb_anh.Name = "pb_anh";
            this.pb_anh.Size = new System.Drawing.Size(100, 94);
            this.pb_anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_anh.TabIndex = 49;
            this.pb_anh.TabStop = false;
            // 
            // Impor
            // 
            this.Impor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Impor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Impor.Location = new System.Drawing.Point(687, 402);
            this.Impor.Name = "Impor";
            this.Impor.Size = new System.Drawing.Size(89, 29);
            this.Impor.TabIndex = 50;
            this.Impor.Text = "Import";
            this.Impor.UseVisualStyleBackColor = false;
            this.Impor.Click += new System.EventHandler(this.Impor_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(743, 263);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 23);
            this.bt_luu.TabIndex = 51;
            this.bt_luu.Text = "lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // CustomerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.Impor);
            this.Controls.Add(this.pb_anh);
            this.Controls.Add(this.bt_anh);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbgiaban);
            this.Controls.Add(this.tbgianhap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbsoluong);
            this.Controls.Add(this.tbcl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.dvgCustomer);
            this.Name = "CustomerGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.DataGridView dvgCustomer;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mã;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tên;
        private System.Windows.Forms.DataGridViewTextBoxColumn macl;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbcl;
        private System.Windows.Forms.TextBox tbsoluong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbgianhap;
        private System.Windows.Forms.TextBox tbgiaban;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button bt_anh;
        private System.Windows.Forms.PictureBox pb_anh;
        private System.Windows.Forms.Button Impor;
        private System.Windows.Forms.Button bt_luu;
    }
}

