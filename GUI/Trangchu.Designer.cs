namespace GUI
{
    partial class Trangchu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trangchu));
            this.panel_left = new System.Windows.Forms.Panel();
            this.btsanpham = new System.Windows.Forms.Button();
            this.btqlnv = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_body = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.AddHD = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.bt_Load = new MaterialSkin.Controls.MaterialButton();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dash = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.Color2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.Color1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.themeTog = new MaterialSkin.Controls.MaterialSwitch();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_left.Controls.Add(this.btsanpham);
            this.panel_left.Controls.Add(this.btqlnv);
            this.panel_left.Controls.Add(this.pictureBox1);
            this.panel_left.Location = new System.Drawing.Point(80, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(187, 587);
            this.panel_left.TabIndex = 0;
            // 
            // btsanpham
            // 
            this.btsanpham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsanpham.Location = new System.Drawing.Point(15, 145);
            this.btsanpham.Name = "btsanpham";
            this.btsanpham.Size = new System.Drawing.Size(120, 52);
            this.btsanpham.TabIndex = 36;
            this.btsanpham.Text = "Sản Phẩm\r\n";
            this.btsanpham.UseVisualStyleBackColor = false;
            this.btsanpham.Click += new System.EventHandler(this.btsanpham_Click);
            // 
            // btqlnv
            // 
            this.btqlnv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btqlnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btqlnv.Location = new System.Drawing.Point(15, 212);
            this.btqlnv.Name = "btqlnv";
            this.btqlnv.Size = new System.Drawing.Size(120, 52);
            this.btqlnv.TabIndex = 35;
            this.btqlnv.Text = "Nhân Viên";
            this.btqlnv.UseVisualStyleBackColor = false;
            this.btqlnv.Click += new System.EventHandler(this.btqlnv_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(21, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.Color.Brown;
            this.panel_body.Controls.Add(this.pictureBox4);
            this.panel_body.Controls.Add(this.pictureBox3);
            this.panel_body.Controls.Add(this.pictureBox2);
            this.panel_body.Location = new System.Drawing.Point(212, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1119, 589);
            this.panel_body.TabIndex = 0;
            this.panel_body.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GUI.Properties.Resources.thiet_ke_shop_quan_ao_40m2_nhu_the_nao_2;
            this.pictureBox4.Location = new System.Drawing.Point(608, 95);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(508, 449);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI.Properties.Resources.Screenshot_2023_08_19_012448;
            this.pictureBox3.Location = new System.Drawing.Point(3, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1113, 95);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.ttpink;
            this.pictureBox2.Location = new System.Drawing.Point(49, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(608, 481);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(6, 77);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1335, 608);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.panel_left);
            this.tabPage1.Controls.Add(this.panel_body);
            this.tabPage1.ImageKey = "home-187-32.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1327, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.AddHD);
            this.tabPage5.Controls.Add(this.materialButton3);
            this.tabPage5.Controls.Add(this.bt_Load);
            this.tabPage5.Controls.Add(this.materialListView1);
            this.tabPage5.ImageKey = "185103_shopping_bag_icon.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1327, 565);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Đơn hàng";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // AddHD
            // 
            this.AddHD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddHD.BackColor = System.Drawing.Color.IndianRed;
            this.AddHD.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddHD.Depth = 0;
            this.AddHD.HighEmphasis = true;
            this.AddHD.Icon = null;
            this.AddHD.Location = new System.Drawing.Point(1114, 9);
            this.AddHD.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddHD.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddHD.Name = "AddHD";
            this.AddHD.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddHD.Size = new System.Drawing.Size(64, 36);
            this.AddHD.TabIndex = 4;
            this.AddHD.Text = "Tạo";
            this.AddHD.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddHD.UseAccentColor = false;
            this.AddHD.UseVisualStyleBackColor = false;
            this.AddHD.Click += new System.EventHandler(this.AddHD_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.BackColor = System.Drawing.Color.IndianRed;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(897, 427);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(83, 36);
            this.materialButton3.TabIndex = 3;
            this.materialButton3.Text = "Xuất HD";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = false;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click_1);
            // 
            // bt_Load
            // 
            this.bt_Load.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_Load.BackColor = System.Drawing.Color.IndianRed;
            this.bt_Load.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_Load.Depth = 0;
            this.bt_Load.HighEmphasis = true;
            this.bt_Load.Icon = null;
            this.bt_Load.Location = new System.Drawing.Point(1011, 427);
            this.bt_Load.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_Load.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_Load.Name = "bt_Load";
            this.bt_Load.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_Load.Size = new System.Drawing.Size(75, 36);
            this.bt_Load.TabIndex = 2;
            this.bt_Load.Text = "Dữ liệu";
            this.bt_Load.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_Load.UseAccentColor = false;
            this.bt_Load.UseVisualStyleBackColor = false;
            this.bt_Load.Click += new System.EventHandler(this.bt_Load_Click);
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(141, 6);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(966, 469);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.SelectedIndexChanged += new System.EventHandler(this.materialListView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Số HD";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Khách hàng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Trị giá";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.ImageKey = "80-online-support-32.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1327, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tác vụ";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chart1);
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.ImageKey = "dashboard.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1327, 565);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Thống kê";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(660, 114);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(534, 292);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dash);
            this.panel1.Location = new System.Drawing.Point(121, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 68);
            this.panel1.TabIndex = 0;
            // 
            // dash
            // 
            this.dash.AutoSize = true;
            this.dash.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash.Location = new System.Drawing.Point(27, 18);
            this.dash.Name = "dash";
            this.dash.Size = new System.Drawing.Size(152, 34);
            this.dash.TabIndex = 0;
            this.dash.Text = "THỐNG KÊ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialButton2);
            this.tabPage3.Controls.Add(this.materialRadioButton1);
            this.tabPage3.Controls.Add(this.materialLabel1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.Color2);
            this.tabPage3.Controls.Add(this.Color1);
            this.tabPage3.Controls.Add(this.materialProgressBar1);
            this.tabPage3.Controls.Add(this.themeTog);
            this.tabPage3.Controls.Add(this.materialButton1);
            this.tabPage3.ImageKey = "settings-85-32.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1327, 565);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cài đặt";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(751, 6);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(99, 36);
            this.materialButton2.TabIndex = 8;
            this.materialButton2.Text = "thông tin";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Location = new System.Drawing.Point(217, 456);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(102, 37);
            this.materialRadioButton1.TabIndex = 7;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "Mặc định";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            this.materialRadioButton1.CheckedChanged += new System.EventHandler(this.materialRadioButton1_CheckedChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(117, 383);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(51, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Chủ đề";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chế độ tối";
            // 
            // Color2
            // 
            this.Color2.AutoSize = true;
            this.Color2.Depth = 0;
            this.Color2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Color2.Location = new System.Drawing.Point(217, 383);
            this.Color2.Margin = new System.Windows.Forms.Padding(0);
            this.Color2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Color2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Color2.Name = "Color2";
            this.Color2.Ripple = true;
            this.Color2.Size = new System.Drawing.Size(107, 37);
            this.Color2.TabIndex = 4;
            this.Color2.TabStop = true;
            this.Color2.Text = "Màu hồng";
            this.Color2.UseVisualStyleBackColor = true;
            this.Color2.CheckedChanged += new System.EventHandler(this.Color2_CheckedChanged);
            // 
            // Color1
            // 
            this.Color1.AutoSize = true;
            this.Color1.Depth = 0;
            this.Color1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Color1.Location = new System.Drawing.Point(217, 323);
            this.Color1.Margin = new System.Windows.Forms.Padding(0);
            this.Color1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Color1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Color1.Name = "Color1";
            this.Color1.Ripple = true;
            this.Color1.Size = new System.Drawing.Size(123, 37);
            this.Color1.TabIndex = 3;
            this.Color1.TabStop = true;
            this.Color1.Text = "Màu xanh lá";
            this.Color1.UseVisualStyleBackColor = true;
            this.Color1.CheckedChanged += new System.EventHandler(this.Color1_CheckedChanged);
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Location = new System.Drawing.Point(217, 143);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(206, 5);
            this.materialProgressBar1.TabIndex = 2;
            // 
            // themeTog
            // 
            this.themeTog.AutoSize = true;
            this.themeTog.Depth = 0;
            this.themeTog.ForeColor = System.Drawing.Color.Indigo;
            this.themeTog.Location = new System.Drawing.Point(217, 255);
            this.themeTog.Margin = new System.Windows.Forms.Padding(0);
            this.themeTog.MouseLocation = new System.Drawing.Point(-1, -1);
            this.themeTog.MouseState = MaterialSkin.MouseState.HOVER;
            this.themeTog.Name = "themeTog";
            this.themeTog.Ripple = true;
            this.themeTog.Size = new System.Drawing.Size(58, 37);
            this.themeTog.TabIndex = 1;
            this.themeTog.UseVisualStyleBackColor = true;
            this.themeTog.CheckedChanged += new System.EventHandler(this.themeTog_CheckedChanged);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(998, 414);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(103, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Đăng xuất";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home-187-32.png");
            this.imageList1.Images.SetKeyName(1, "80-online-support-32.png");
            this.imageList1.Images.SetKeyName(2, "settings-85-32.png");
            this.imageList1.Images.SetKeyName(3, "dashboard.png");
            this.imageList1.Images.SetKeyName(4, "185103_shopping_bag_icon.png");
            // 
            // Trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1372, 666);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Trangchu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trangchu";
            this.Load += new System.EventHandler(this.Trangchu_Load);
            this.panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btsanpham;
        private System.Windows.Forms.Button btqlnv;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MaterialSkin.Controls.MaterialSwitch themeTog;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
        private MaterialSkin.Controls.MaterialRadioButton Color1;
        private MaterialSkin.Controls.MaterialRadioButton Color2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dash;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private System.Windows.Forms.TabPage tabPage5;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MaterialSkin.Controls.MaterialButton bt_Load;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton AddHD;
    }
}