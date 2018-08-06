namespace QuanLyCuTru_WinForm
{
    partial class FormDanhSachCongDanDaDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDanhSachCongDanDaDangKy));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhSachCongDanDaDangKy = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.cbbTen = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.ptbLoading = new System.Windows.Forms.PictureBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCongDanDaDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(850, 53);
            this.panel3.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách đã đăng ký";
            // 
            // dgvDanhSachCongDanDaDangKy
            // 
            this.dgvDanhSachCongDanDaDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachCongDanDaDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachCongDanDaDangKy.Location = new System.Drawing.Point(23, 107);
            this.dgvDanhSachCongDanDaDangKy.Name = "dgvDanhSachCongDanDaDangKy";
            this.dgvDanhSachCongDanDaDangKy.Size = new System.Drawing.Size(804, 369);
            this.dgvDanhSachCongDanDaDangKy.TabIndex = 31;
            this.dgvDanhSachCongDanDaDangKy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaDangKy_CellContentClick);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Location = new System.Drawing.Point(449, 62);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 37);
            this.btnTimKiem.TabIndex = 42;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChiTiet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTiet.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTiet.ForeColor = System.Drawing.Color.Transparent;
            this.btnChiTiet.Location = new System.Drawing.Point(621, 489);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(100, 37);
            this.btnChiTiet.TabIndex = 34;
            this.btnChiTiet.Text = "CHI TIẾT";
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // cbbTen
            // 
            this.cbbTen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbTen.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTen.FormattingEnabled = true;
            this.cbbTen.Location = new System.Drawing.Point(23, 65);
            this.cbbTen.Name = "cbbTen";
            this.cbbTen.Size = new System.Drawing.Size(100, 29);
            this.cbbTen.TabIndex = 36;
            this.cbbTen.Text = "Tên";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(243, 62);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 37);
            this.txtTimKiem.TabIndex = 38;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbGioiTinh.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.ItemHeight = 21;
            this.cbbGioiTinh.Location = new System.Drawing.Point(137, 66);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(100, 29);
            this.cbbGioiTinh.TabIndex = 41;
            this.cbbGioiTinh.Text = "Giới tính";
            this.cbbGioiTinh.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbbGioiTinh_DrawItem);
            // 
            // ptbLoading
            // 
            this.ptbLoading.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ptbLoading.Image = ((System.Drawing.Image)(resources.GetObject("ptbLoading.Image")));
            this.ptbLoading.Location = new System.Drawing.Point(243, 195);
            this.ptbLoading.Name = "ptbLoading";
            this.ptbLoading.Size = new System.Drawing.Size(212, 188);
            this.ptbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLoading.TabIndex = 56;
            this.ptbLoading.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.Brown;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Transparent;
            this.btnXoa.Location = new System.Drawing.Point(727, 489);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 37);
            this.btnXoa.TabIndex = 58;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // FormDanhSachCongDanDaDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 538);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.ptbLoading);
            this.Controls.Add(this.cbbGioiTinh);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.cbbTen);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvDanhSachCongDanDaDangKy);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDanhSachCongDanDaDangKy";
            this.Text = "FormDaDangKy";
            this.Load += new System.EventHandler(this.FormDanhSachCongDanDaDangKy_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCongDanDaDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhSachCongDanDaDangKy;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.ComboBox cbbTen;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.PictureBox ptbLoading;
        private System.Windows.Forms.Button btnXoa;
    }
}