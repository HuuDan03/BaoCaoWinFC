namespace GUI
{
    partial class DN
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fgmk = new System.Windows.Forms.LinkLabel();
            this.btdn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txtdn = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.Controls.Add(this.fgmk);
            this.panel1.Controls.Add(this.btdn);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.txtmk);
            this.panel1.Controls.Add(this.txtdn);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 573);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // fgmk
            // 
            this.fgmk.AutoSize = true;
            this.fgmk.Location = new System.Drawing.Point(215, 500);
            this.fgmk.Name = "fgmk";
            this.fgmk.Size = new System.Drawing.Size(96, 16);
            this.fgmk.TabIndex = 6;
            this.fgmk.TabStop = true;
            this.fgmk.Text = "Quên mật khẩu";
            this.fgmk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.fgmk_LinkClicked);
            // 
            // btdn
            // 
            this.btdn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btdn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdn.Location = new System.Drawing.Point(67, 401);
            this.btdn.Name = "btdn";
            this.btdn.Size = new System.Drawing.Size(185, 67);
            this.btdn.TabIndex = 5;
            this.btdn.Text = "Đăng nhập";
            this.btdn.UseVisualStyleBackColor = false;
            this.btdn.Click += new System.EventHandler(this.btdn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI.Properties.Resources.padlock_155000_640;
            this.pictureBox3.Location = new System.Drawing.Point(3, 259);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // txtmk
            // 
            this.txtmk.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txtmk.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmk.Location = new System.Drawing.Point(92, 259);
            this.txtmk.Multiline = true;
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '●';
            this.txtmk.Size = new System.Drawing.Size(219, 47);
            this.txtmk.TabIndex = 3;
            // 
            // txtdn
            // 
            this.txtdn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txtdn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdn.Location = new System.Drawing.Point(92, 150);
            this.txtdn.Multiline = true;
            this.txtdn.Name = "txtdn";
            this.txtdn.Size = new System.Drawing.Size(219, 47);
            this.txtdn.TabIndex = 2;
            this.txtdn.TextChanged += new System.EventHandler(this.txtdn_TextChanged);
            // 
            // username
            // 
            this.username.Image = global::GUI.Properties.Resources.user;
            this.username.Location = new System.Drawing.Point(10, 150);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(62, 48);
            this.username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.username.TabIndex = 1;
            this.username.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(108, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GUI.Properties.Resources.Screenshot_2023_08_19_0124481;
            this.pictureBox4.Location = new System.Drawing.Point(338, -6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(473, 58);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // DN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.gai4;
            this.ClientSize = new System.Drawing.Size(806, 576);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DN";
            this.Load += new System.EventHandler(this.DN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btdn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txtdn;
        private System.Windows.Forms.PictureBox username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.LinkLabel fgmk;
    }
}