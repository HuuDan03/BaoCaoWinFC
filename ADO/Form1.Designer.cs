namespace ADO
{
    partial class Form1
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
            this.btNew = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.Tên = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mã = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgCustomer = new System.Windows.Forms.DataGridView();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(118, 349);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(298, 29);
            this.tbName.TabIndex = 17;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(118, 299);
            this.tbId.Multiline = true;
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(298, 29);
            this.tbId.TabIndex = 16;
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(574, 397);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(72, 38);
            this.btExit.TabIndex = 13;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(258, 397);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(83, 38);
            this.btNew.TabIndex = 12;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(461, 397);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 38);
            this.btEdit.TabIndex = 9;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(53, 397);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(98, 38);
            this.btRead.TabIndex = 11;
            this.btRead.Text = "Đọc dữ liệu";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // Tên
            // 
            this.Tên.DataPropertyName = "name";
            this.Tên.HeaderText = "Tên";
            this.Tên.MinimumWidth = 6;
            this.Tên.Name = "Tên";
            this.Tên.Width = 400;
            // 
            // Mã
            // 
            this.Mã.DataPropertyName = "id";
            this.Mã.HeaderText = "Mã";
            this.Mã.MinimumWidth = 6;
            this.Mã.Name = "Mã";
            this.Mã.Width = 200;
            // 
            // dvgCustomer
            // 
            this.dvgCustomer.AllowUserToAddRows = false;
            this.dvgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mã,
            this.Tên});
            this.dvgCustomer.Location = new System.Drawing.Point(53, 12);
            this.dvgCustomer.Name = "dvgCustomer";
            this.dvgCustomer.RowHeadersWidth = 51;
            this.dvgCustomer.RowTemplate.Height = 24;
            this.dvgCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCustomer.Size = new System.Drawing.Size(695, 427);
            this.dvgCustomer.TabIndex = 8;
            this.dvgCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCustomer_CellContentClick);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(357, 397);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(83, 38);
            this.btDelete.TabIndex = 18;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.dvgCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCustomer)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Tên;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mã;
        private System.Windows.Forms.DataGridView dvgCustomer;
        private System.Windows.Forms.Button btDelete;
    }
}

