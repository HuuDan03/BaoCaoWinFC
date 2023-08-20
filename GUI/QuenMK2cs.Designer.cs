namespace GUI
{
    partial class QuenMK2cs
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_newpass = new System.Windows.Forms.TextBox();
            this.tb_newpassC = new System.Windows.Forms.TextBox();
            this.bt_con = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(215, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tb_newpass
            // 
            this.tb_newpass.Location = new System.Drawing.Point(196, 245);
            this.tb_newpass.Name = "tb_newpass";
            this.tb_newpass.Size = new System.Drawing.Size(208, 22);
            this.tb_newpass.TabIndex = 4;
            // 
            // tb_newpassC
            // 
            this.tb_newpassC.Location = new System.Drawing.Point(196, 294);
            this.tb_newpassC.Name = "tb_newpassC";
            this.tb_newpassC.Size = new System.Drawing.Size(208, 22);
            this.tb_newpassC.TabIndex = 5;
            // 
            // bt_con
            // 
            this.bt_con.Location = new System.Drawing.Point(259, 373);
            this.bt_con.Name = "bt_con";
            this.bt_con.Size = new System.Drawing.Size(75, 23);
            this.bt_con.TabIndex = 6;
            this.bt_con.Text = "Xác nhận";
            this.bt_con.UseVisualStyleBackColor = true;
            this.bt_con.Click += new System.EventHandler(this.bt_con_Click);
            // 
            // QuenMK2cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_con);
            this.Controls.Add(this.tb_newpassC);
            this.Controls.Add(this.tb_newpass);
            this.Controls.Add(this.pictureBox1);
            this.Name = "QuenMK2cs";
            this.Text = "QuenMK2cs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_newpass;
        private System.Windows.Forms.TextBox tb_newpassC;
        private System.Windows.Forms.Button bt_con;
    }
}