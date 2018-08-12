namespace QuanLyCuTru_WinForm
{
    partial class FormSuaCuTru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuaCuTru));
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.ptbThoat = new System.Windows.Forms.PictureBox();
            this.txtDuong = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtThanhPho = new System.Windows.Forms.TextBox();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.txtPhuong = new System.Windows.Forms.TextBox();
            this.txtSoNha = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.lbMaCongDan = new System.Windows.Forms.ListBox();
            this.cbLoaiCuTru = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtNhapMaCongDan = new System.Windows.Forms.TextBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbThoat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Sửa thông tin cư trú";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.panelTop.Controls.Add(this.ptbThoat);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1160, 37);
            this.panelTop.TabIndex = 95;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // ptbThoat
            // 
            this.ptbThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbThoat.Image = ((System.Drawing.Image)(resources.GetObject("ptbThoat.Image")));
            this.ptbThoat.Location = new System.Drawing.Point(1123, 2);
            this.ptbThoat.Margin = new System.Windows.Forms.Padding(4);
            this.ptbThoat.Name = "ptbThoat";
            this.ptbThoat.Size = new System.Drawing.Size(33, 31);
            this.ptbThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbThoat.TabIndex = 65;
            this.ptbThoat.TabStop = false;
            this.ptbThoat.Click += new System.EventHandler(this.ptbThoat_Click);
            // 
            // txtDuong
            // 
            this.txtDuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDuong.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.txtDuong.Location = new System.Drawing.Point(149, 512);
            this.txtDuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuong.Multiline = true;
            this.txtDuong.Name = "txtDuong";
            this.txtDuong.Size = new System.Drawing.Size(355, 45);
            this.txtDuong.TabIndex = 75;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(1005, 581);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(133, 46);
            this.btnSua.TabIndex = 83;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtThanhPho
            // 
            this.txtThanhPho.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtThanhPho.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.txtThanhPho.Location = new System.Drawing.Point(625, 242);
            this.txtThanhPho.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhPho.Multiline = true;
            this.txtThanhPho.Name = "txtThanhPho";
            this.txtThanhPho.Size = new System.Drawing.Size(355, 45);
            this.txtThanhPho.TabIndex = 78;
            // 
            // txtQuan
            // 
            this.txtQuan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQuan.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.txtQuan.Location = new System.Drawing.Point(625, 171);
            this.txtQuan.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuan.Multiline = true;
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(355, 45);
            this.txtQuan.TabIndex = 77;
            // 
            // txtPhuong
            // 
            this.txtPhuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPhuong.BackColor = System.Drawing.Color.White;
            this.txtPhuong.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.txtPhuong.Location = new System.Drawing.Point(625, 96);
            this.txtPhuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhuong.Multiline = true;
            this.txtPhuong.Name = "txtPhuong";
            this.txtPhuong.Size = new System.Drawing.Size(355, 45);
            this.txtPhuong.TabIndex = 76;
            // 
            // txtSoNha
            // 
            this.txtSoNha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoNha.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.txtSoNha.Location = new System.Drawing.Point(149, 438);
            this.txtSoNha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoNha.Multiline = true;
            this.txtSoNha.Name = "txtSoNha";
            this.txtSoNha.Size = new System.Drawing.Size(355, 45);
            this.txtSoNha.TabIndex = 74;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDienThoai.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.txtDienThoai.Location = new System.Drawing.Point(149, 364);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtDienThoai.Multiline = true;
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(355, 45);
            this.txtDienThoai.TabIndex = 73;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.txtEmail.Location = new System.Drawing.Point(149, 292);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(355, 45);
            this.txtEmail.TabIndex = 72;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(621, 292);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 23);
            this.label12.TabIndex = 93;
            this.label12.Text = "Loại cư trú";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(621, 220);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 23);
            this.label11.TabIndex = 92;
            this.label11.Text = "Thành phố";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(621, 145);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 23);
            this.label10.TabIndex = 91;
            this.label10.Text = "Quận";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(621, 71);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 23);
            this.label9.TabIndex = 90;
            this.label9.Text = "Phường";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(145, 487);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 89;
            this.label8.Text = "Đường";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(145, 414);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 23);
            this.label7.TabIndex = 88;
            this.label7.Text = "Số nhà";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(145, 340);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 23);
            this.label6.TabIndex = 87;
            this.label6.Text = "Điện thoại";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(145, 267);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 85;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(145, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 84;
            this.label4.Text = "Ngày hết hạn";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(145, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 81;
            this.label3.Text = "Ngày đăng ký";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(145, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 79;
            this.label2.Text = "Ngày tạo";
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayHetHan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpNgayHetHan.Location = new System.Drawing.Point(149, 224);
            this.dtpNgayHetHan.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(355, 34);
            this.dtpNgayHetHan.TabIndex = 71;
            // 
            // dtpNgayDangKy
            // 
            this.dtpNgayDangKy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayDangKy.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpNgayDangKy.Location = new System.Drawing.Point(149, 160);
            this.dtpNgayDangKy.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayDangKy.Name = "dtpNgayDangKy";
            this.dtpNgayDangKy.Size = new System.Drawing.Size(355, 34);
            this.dtpNgayDangKy.TabIndex = 70;
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayTao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTao.Location = new System.Drawing.Point(149, 96);
            this.dtpNgayTao.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(355, 34);
            this.dtpNgayTao.TabIndex = 69;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(621, 369);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 23);
            this.label13.TabIndex = 100;
            this.label13.Text = "Danh sách công dân";
            // 
            // lbMaCongDan
            // 
            this.lbMaCongDan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaCongDan.FormattingEnabled = true;
            this.lbMaCongDan.ItemHeight = 25;
            this.lbMaCongDan.Location = new System.Drawing.Point(625, 394);
            this.lbMaCongDan.Margin = new System.Windows.Forms.Padding(4);
            this.lbMaCongDan.Name = "lbMaCongDan";
            this.lbMaCongDan.Size = new System.Drawing.Size(355, 104);
            this.lbMaCongDan.TabIndex = 99;
            // 
            // cbLoaiCuTru
            // 
            this.cbLoaiCuTru.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiCuTru.FormattingEnabled = true;
            this.cbLoaiCuTru.Items.AddRange(new object[] {
            "Tạm vắng",
            "Tạm trú"});
            this.cbLoaiCuTru.Location = new System.Drawing.Point(625, 319);
            this.cbLoaiCuTru.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoaiCuTru.Name = "cbLoaiCuTru";
            this.cbLoaiCuTru.Size = new System.Drawing.Size(355, 40);
            this.cbLoaiCuTru.TabIndex = 98;
            this.cbLoaiCuTru.Text = "(Chọn loại cư trú)";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.btnThem.Enabled = false;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(892, 503);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 46);
            this.btnThem.TabIndex = 97;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtNhapMaCongDan
            // 
            this.txtNhapMaCongDan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNhapMaCongDan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNhapMaCongDan.Enabled = false;
            this.txtNhapMaCongDan.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapMaCongDan.Location = new System.Drawing.Point(625, 502);
            this.txtNhapMaCongDan.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhapMaCongDan.Multiline = true;
            this.txtNhapMaCongDan.Name = "txtNhapMaCongDan";
            this.txtNhapMaCongDan.Size = new System.Drawing.Size(276, 46);
            this.txtNhapMaCongDan.TabIndex = 96;
            this.txtNhapMaCongDan.Text = "Nhập mã công dân";
            // 
            // FormSuaCuTru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1160, 640);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbMaCongDan);
            this.Controls.Add(this.cbLoaiCuTru);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtNhapMaCongDan);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.txtDuong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtThanhPho);
            this.Controls.Add(this.txtQuan);
            this.Controls.Add(this.txtPhuong);
            this.Controls.Add(this.txtSoNha);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpNgayHetHan);
            this.Controls.Add(this.dtpNgayDangKy);
            this.Controls.Add(this.dtpNgayTao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSuaCuTru";
            this.Text = "FormSuaCuTru";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbThoat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox ptbThoat;
        private System.Windows.Forms.TextBox txtDuong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtThanhPho;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.TextBox txtPhuong;
        private System.Windows.Forms.TextBox txtSoNha;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHan;
        private System.Windows.Forms.DateTimePicker dtpNgayDangKy;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lbMaCongDan;
        private System.Windows.Forms.ComboBox cbLoaiCuTru;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtNhapMaCongDan;
    }
}