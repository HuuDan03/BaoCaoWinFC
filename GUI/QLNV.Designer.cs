namespace GUI
{
    partial class QLNV
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
            this.label3 = new System.Windows.Forms.Label();
            this.btDel = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.dvgCustomer = new System.Windows.Forms.DataGridView();
            this.Mã = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tên = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbngaysinh = new System.Windows.Forms.TextBox();
            this.tbgt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbsdt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbdiachi = new System.Windows.Forms.TextBox();
            this.Export = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "tìm kiếm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btDel
            // 
            this.btDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.Location = new System.Drawing.Point(273, 405);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(83, 38);
            this.btDel.TabIndex = 42;
            this.btDel.Text = "Xóa";
            this.btDel.UseVisualStyleBackColor = false;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tbName.Location = new System.Drawing.Point(92, 344);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(127, 31);
            this.tbName.TabIndex = 40;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tbId.Location = new System.Drawing.Point(92, 294);
            this.tbId.Multiline = true;
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(87, 29);
            this.tbId.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Mã";
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(492, 405);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(72, 38);
            this.btExit.TabIndex = 36;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = false;
            // 
            // btNew
            // 
            this.btNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNew.Location = new System.Drawing.Point(169, 405);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(83, 38);
            this.btNew.TabIndex = 35;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = false;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(382, 405);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 38);
            this.btEdit.TabIndex = 33;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btRead
            // 
            this.btRead.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRead.Location = new System.Drawing.Point(51, 405);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(98, 38);
            this.btRead.TabIndex = 34;
            this.btRead.Text = "Đọc dữ liệu";
            this.btRead.UseVisualStyleBackColor = false;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // dvgCustomer
            // 
            this.dvgCustomer.AllowUserToAddRows = false;
            this.dvgCustomer.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dvgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mã,
            this.Tên,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dvgCustomer.Location = new System.Drawing.Point(51, 6);
            this.dvgCustomer.Name = "dvgCustomer";
            this.dvgCustomer.RowHeadersWidth = 51;
            this.dvgCustomer.RowTemplate.Height = 24;
            this.dvgCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCustomer.Size = new System.Drawing.Size(681, 283);
            this.dvgCustomer.TabIndex = 32;
            this.dvgCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCustomer_CellContentClick);
            // 
            // Mã
            // 
            this.Mã.DataPropertyName = "id";
            this.Mã.HeaderText = "Mã NV";
            this.Mã.MinimumWidth = 6;
            this.Mã.Name = "Mã";
            this.Mã.Width = 125;
            // 
            // Tên
            // 
            this.Tên.DataPropertyName = "name";
            this.Tên.HeaderText = "Tên NV";
            this.Tên.MinimumWidth = 6;
            this.Tên.Name = "Tên";
            this.Tên.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ngày Sinh";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giới tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SDT";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Địa chỉ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(273, 405);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(83, 38);
            this.btDelete.TabIndex = 41;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "Giới tính";
            // 
            // tbngaysinh
            // 
            this.tbngaysinh.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tbngaysinh.Location = new System.Drawing.Point(258, 294);
            this.tbngaysinh.Multiline = true;
            this.tbngaysinh.Name = "tbngaysinh";
            this.tbngaysinh.Size = new System.Drawing.Size(98, 29);
            this.tbngaysinh.TabIndex = 48;
            // 
            // tbgt
            // 
            this.tbgt.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tbgt.Location = new System.Drawing.Point(287, 347);
            this.tbgt.Multiline = true;
            this.tbgt.Name = "tbgt";
            this.tbgt.Size = new System.Drawing.Size(92, 29);
            this.tbgt.TabIndex = 49;
            this.tbgt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "SDT";
            // 
            // tbsdt
            // 
            this.tbsdt.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tbsdt.Location = new System.Drawing.Point(407, 291);
            this.tbsdt.Multiline = true;
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.Size = new System.Drawing.Size(121, 29);
            this.tbsdt.TabIndex = 51;
            this.tbsdt.TextChanged += new System.EventHandler(this.tbsdt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 52;
            this.label7.Text = "Địa chỉ";
            // 
            // tbdiachi
            // 
            this.tbdiachi.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tbdiachi.Location = new System.Drawing.Point(458, 356);
            this.tbdiachi.Multiline = true;
            this.tbdiachi.Name = "tbdiachi";
            this.tbdiachi.Size = new System.Drawing.Size(154, 29);
            this.tbdiachi.TabIndex = 53;
            // 
            // Export
            // 
            this.Export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export.Location = new System.Drawing.Point(672, 341);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(89, 29);
            this.Export.TabIndex = 54;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = false;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Import
            // 
            this.Import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Import.Location = new System.Drawing.Point(620, 405);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(89, 29);
            this.Import.TabIndex = 55;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = false;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(620, 301);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(100, 22);
            this.tb_timkiem.TabIndex = 56;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.tbdiachi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbsdt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbgt);
            this.Controls.Add(this.tbngaysinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
            this.Controls.Add(this.btDelete);
            this.Name = "QLNV";
            this.Text = "QLNV";
            this.Load += new System.EventHandler(this.QLNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.DataGridView dvgCustomer;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mã;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tên;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbngaysinh;
        private System.Windows.Forms.TextBox tbgt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbsdt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbdiachi;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.TextBox tb_timkiem;
    }
}