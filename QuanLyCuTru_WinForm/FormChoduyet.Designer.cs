namespace QuanLyCuTru_WinForm
{
    partial class FormChoDuyet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhSachChoDuyet = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLoaiCuTru = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtNgayDangKy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDuyet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpreciofff = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbSoNguoi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChoDuyet)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(-33, 660);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(133, 37);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "CHỌN";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 41);
            this.label1.TabIndex = 13;
            this.label1.Text = "Chờ Duyệt";
            // 
            // dgvDanhSachChoDuyet
            // 
            this.dgvDanhSachChoDuyet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachChoDuyet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachChoDuyet.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachChoDuyet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachChoDuyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachChoDuyet.Location = new System.Drawing.Point(4, 62);
            this.dgvDanhSachChoDuyet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDanhSachChoDuyet.Name = "dgvDanhSachChoDuyet";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvDanhSachChoDuyet.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachChoDuyet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachChoDuyet.Size = new System.Drawing.Size(644, 479);
            this.dgvDanhSachChoDuyet.TabIndex = 20;
            this.dgvDanhSachChoDuyet.SelectionChanged += new System.EventHandler(this.dgvDanhSachChoDuyet_SelectionChanged);
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(151, 81);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(324, 50);
            this.txtId.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(11, 318);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 23);
            this.label7.TabIndex = 56;
            this.label7.Text = "Loại cư trú:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(151, 145);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(324, 50);
            this.txtEmail.TabIndex = 43;
            // 
            // txtLoaiCuTru
            // 
            this.txtLoaiCuTru.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLoaiCuTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiCuTru.Location = new System.Drawing.Point(151, 318);
            this.txtLoaiCuTru.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoaiCuTru.Multiline = true;
            this.txtLoaiCuTru.Name = "txtLoaiCuTru";
            this.txtLoaiCuTru.Size = new System.Drawing.Size(324, 50);
            this.txtLoaiCuTru.TabIndex = 55;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(151, 375);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(324, 87);
            this.txtDiaChi.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(11, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 23);
            this.label5.TabIndex = 54;
            this.label5.Text = "ID";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienThoai.Location = new System.Drawing.Point(151, 203);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDienThoai.Multiline = true;
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(324, 50);
            this.txtDienThoai.TabIndex = 45;
            // 
            // txtNgayDangKy
            // 
            this.txtNgayDangKy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNgayDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayDangKy.Location = new System.Drawing.Point(151, 261);
            this.txtNgayDangKy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNgayDangKy.Multiline = true;
            this.txtNgayDangKy.Name = "txtNgayDangKy";
            this.txtNgayDangKy.Size = new System.Drawing.Size(324, 50);
            this.txtNgayDangKy.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(11, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 47;
            this.label6.Text = "Email:";
            // 
            // btnDuyet
            // 
            this.btnDuyet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDuyet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnDuyet.FlatAppearance.BorderSize = 0;
            this.btnDuyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyet.ForeColor = System.Drawing.Color.White;
            this.btnDuyet.Location = new System.Drawing.Point(372, 484);
            this.btnDuyet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(103, 43);
            this.btnDuyet.TabIndex = 51;
            this.btnDuyet.Text = "DUYỆT";
            this.btnDuyet.UseVisualStyleBackColor = false;
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(11, 379);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 48;
            this.label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(11, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 50;
            this.label4.Text = "Ngày đăng ký:";
            // 
            // txtpreciofff
            // 
            this.txtpreciofff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtpreciofff.AutoSize = true;
            this.txtpreciofff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreciofff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpreciofff.Location = new System.Drawing.Point(11, 203);
            this.txtpreciofff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtpreciofff.Name = "txtpreciofff";
            this.txtpreciofff.Size = new System.Drawing.Size(93, 23);
            this.txtpreciofff.TabIndex = 49;
            this.txtpreciofff.Text = "Điện thoại:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1160, 65);
            this.panel3.TabIndex = 57;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.dgvDanhSachChoDuyet);
            this.panel1.Location = new System.Drawing.Point(16, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 544);
            this.panel1.TabIndex = 58;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel5.Controls.Add(this.label8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(648, 58);
            this.panel5.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(31, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 28);
            this.label8.TabIndex = 20;
            this.label8.Text = "Danh sách";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.txtLoaiCuTru);
            this.panel2.Controls.Add(this.txtpreciofff);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.lbSoNguoi);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnDuyet);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtDiaChi);
            this.panel2.Controls.Add(this.txtNgayDangKy);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDienThoai);
            this.panel2.Location = new System.Drawing.Point(672, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 544);
            this.panel2.TabIndex = 59;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.panel4.Controls.Add(this.label9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(488, 58);
            this.panel4.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(13, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 28);
            this.label9.TabIndex = 21;
            this.label9.Text = "Thông tin";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(14, 494);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 23);
            this.label10.TabIndex = 48;
            this.label10.Text = "Số người:";
            // 
            // lbSoNguoi
            // 
            this.lbSoNguoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSoNguoi.AutoSize = true;
            this.lbSoNguoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoNguoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbSoNguoi.Location = new System.Drawing.Point(147, 494);
            this.lbSoNguoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoNguoi.Name = "lbSoNguoi";
            this.lbSoNguoi.Size = new System.Drawing.Size(30, 23);
            this.lbSoNguoi.TabIndex = 48;
            this.lbSoNguoi.Text = "10";
            // 
            // FormChoDuyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1160, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormChoDuyet";
            this.Text = "FormChoduyet";
            this.Load += new System.EventHandler(this.FormChoDuyet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChoDuyet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhSachChoDuyet;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtLoaiCuTru;
        public System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtDienThoai;
        public System.Windows.Forms.TextBox txtNgayDangKy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDuyet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtpreciofff;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbSoNguoi;
        private System.Windows.Forms.Label label10;
    }
}