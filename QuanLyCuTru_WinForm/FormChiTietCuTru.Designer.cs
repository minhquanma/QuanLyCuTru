namespace QuanLyCuTru_WinForm
{
    partial class FormChiTietCuTru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChiTietCuTru));
            this.panelTop = new System.Windows.Forms.Panel();
            this.ptbThoat = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDanhSachCongDan = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbCanBoDangKy = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.chkDaDuyet = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbNgayTao = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbDienThoai = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbNgayHetHan = new System.Windows.Forms.Label();
            this.lbNgayDangKy = new System.Windows.Forms.Label();
            this.lbLoaiCuTru = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbThoat)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCongDan)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.panelTop.Controls.Add(this.ptbThoat);
            this.panelTop.Controls.Add(this.label10);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1265, 37);
            this.panelTop.TabIndex = 90;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // ptbThoat
            // 
            this.ptbThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbThoat.Image = ((System.Drawing.Image)(resources.GetObject("ptbThoat.Image")));
            this.ptbThoat.Location = new System.Drawing.Point(1228, 2);
            this.ptbThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbThoat.Name = "ptbThoat";
            this.ptbThoat.Size = new System.Drawing.Size(33, 31);
            this.ptbThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbThoat.TabIndex = 65;
            this.ptbThoat.TabStop = false;
            this.ptbThoat.Click += new System.EventHandler(this.ptbThoat_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(4, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(287, 32);
            this.label10.TabIndex = 33;
            this.label10.Text = "Thông tin chi tiết cư trú";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbID.Location = new System.Drawing.Point(105, 14);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(38, 32);
            this.lbID.TabIndex = 82;
            this.lbID.Text = "10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 14);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 32);
            this.label12.TabIndex = 73;
            this.label12.Text = "Mã số:";
            // 
            // line2
            // 
            this.line2.Location = new System.Drawing.Point(0, 43);
            this.line2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(1268, 12);
            this.line2.TabIndex = 72;
            this.line2.Text = "line2";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(992, 9);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(125, 62);
            this.btnSua.TabIndex = 69;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lbID);
            this.panel2.Controls.Add(this.line2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1265, 52);
            this.panel2.TabIndex = 93;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.line1);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 560);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 74);
            this.panel1.TabIndex = 94;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Brown;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1124, 10);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 62);
            this.btnXoa.TabIndex = 93;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(0, 0);
            this.line1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(1268, 12);
            this.line1.TabIndex = 92;
            this.line1.Text = "line1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDanhSachCongDan);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 89);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(488, 471);
            this.panel3.TabIndex = 95;
            // 
            // dgvDanhSachCongDan
            // 
            this.dgvDanhSachCongDan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachCongDan.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachCongDan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachCongDan.Location = new System.Drawing.Point(3, 66);
            this.dgvDanhSachCongDan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDanhSachCongDan.Name = "dgvDanhSachCongDan";
            this.dgvDanhSachCongDan.Size = new System.Drawing.Size(483, 405);
            this.dgvDanhSachCongDan.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(488, 64);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Danh sách công dân";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbCanBoDangKy);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.chkDaDuyet);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.lbNgayTao);
            this.panel5.Controls.Add(this.lbDiaChi);
            this.panel5.Controls.Add(this.lbDienThoai);
            this.panel5.Controls.Add(this.lbEmail);
            this.panel5.Controls.Add(this.lbNgayHetHan);
            this.panel5.Controls.Add(this.lbNgayDangKy);
            this.panel5.Controls.Add(this.lbLoaiCuTru);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(488, 89);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(777, 471);
            this.panel5.TabIndex = 96;
            // 
            // lbCanBoDangKy
            // 
            this.lbCanBoDangKy.AutoSize = true;
            this.lbCanBoDangKy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCanBoDangKy.Location = new System.Drawing.Point(213, 406);
            this.lbCanBoDangKy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCanBoDangKy.Name = "lbCanBoDangKy";
            this.lbCanBoDangKy.Size = new System.Drawing.Size(125, 23);
            this.lbCanBoDangKy.TabIndex = 111;
            this.lbCanBoDangKy.Text = "Mã Minh Quân";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(50, 401);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 25);
            this.label15.TabIndex = 110;
            this.label15.Text = "Cán bộ đăng ký";
            // 
            // chkDaDuyet
            // 
            this.chkDaDuyet.AutoSize = true;
            this.chkDaDuyet.Location = new System.Drawing.Point(217, 363);
            this.chkDaDuyet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDaDuyet.Name = "chkDaDuyet";
            this.chkDaDuyet.Size = new System.Drawing.Size(18, 17);
            this.chkDaDuyet.TabIndex = 109;
            this.chkDaDuyet.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(50, 355);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 25);
            this.label14.TabIndex = 107;
            this.label14.Text = "Đã duyệt?";
            // 
            // lbNgayTao
            // 
            this.lbNgayTao.AutoSize = true;
            this.lbNgayTao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayTao.Location = new System.Drawing.Point(213, 120);
            this.lbNgayTao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayTao.Name = "lbNgayTao";
            this.lbNgayTao.Size = new System.Drawing.Size(96, 23);
            this.lbNgayTao.TabIndex = 106;
            this.lbNgayTao.Text = "12/04/2018";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(213, 26);
            this.lbDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(409, 23);
            this.lbDiaChi.TabIndex = 105;
            this.lbDiaChi.Text = "200 Le Trong Tan, Phường 1, Quận Tan Phu, TP.HCM";
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.AutoSize = true;
            this.lbDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDienThoai.Location = new System.Drawing.Point(213, 312);
            this.lbDienThoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Size = new System.Drawing.Size(100, 23);
            this.lbDienThoai.TabIndex = 103;
            this.lbDienThoai.Text = "0909997771";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(213, 264);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(155, 23);
            this.lbEmail.TabIndex = 102;
            this.lbEmail.Text = "yeeeu@yahoo.com";
            // 
            // lbNgayHetHan
            // 
            this.lbNgayHetHan.AutoSize = true;
            this.lbNgayHetHan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayHetHan.Location = new System.Drawing.Point(213, 218);
            this.lbNgayHetHan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayHetHan.Name = "lbNgayHetHan";
            this.lbNgayHetHan.Size = new System.Drawing.Size(96, 23);
            this.lbNgayHetHan.TabIndex = 101;
            this.lbNgayHetHan.Text = "26/04/2018";
            // 
            // lbNgayDangKy
            // 
            this.lbNgayDangKy.AutoSize = true;
            this.lbNgayDangKy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayDangKy.Location = new System.Drawing.Point(213, 169);
            this.lbNgayDangKy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayDangKy.Name = "lbNgayDangKy";
            this.lbNgayDangKy.Size = new System.Drawing.Size(96, 23);
            this.lbNgayDangKy.TabIndex = 100;
            this.lbNgayDangKy.Text = "13/04/2018";
            // 
            // lbLoaiCuTru
            // 
            this.lbLoaiCuTru.AutoSize = true;
            this.lbLoaiCuTru.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiCuTru.Location = new System.Drawing.Point(213, 73);
            this.lbLoaiCuTru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLoaiCuTru.Name = "lbLoaiCuTru";
            this.lbLoaiCuTru.Size = new System.Drawing.Size(88, 23);
            this.lbLoaiCuTru.TabIndex = 98;
            this.lbLoaiCuTru.Text = "Tạm Vắng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(50, 309);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 25);
            this.label9.TabIndex = 97;
            this.label9.Text = "Điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(50, 261);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 25);
            this.label8.TabIndex = 96;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(50, 215);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 25);
            this.label7.TabIndex = 95;
            this.label7.Text = "Ngày hết hạn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(50, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 94;
            this.label6.Text = "Ngày đăng ký";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(50, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 92;
            this.label4.Text = "Ngày tạo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(50, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 91;
            this.label3.Text = "Loại cư trú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 90;
            this.label2.Text = "Địa chỉ";
            // 
            // FormChiTietCuTru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 634);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormChiTietCuTru";
            this.Text = "FormChiTietCuTru";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbThoat)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCongDan)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox ptbThoat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label12;
        private DevComponents.DotNetBar.Controls.Line line2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.Line line1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvDanhSachCongDan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbCanBoDangKy;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbNgayTao;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbDienThoai;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbNgayHetHan;
        private System.Windows.Forms.Label lbNgayDangKy;
        private System.Windows.Forms.Label lbLoaiCuTru;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoa;
        public System.Windows.Forms.CheckBox chkDaDuyet;
    }
}