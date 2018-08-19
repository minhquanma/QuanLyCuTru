namespace QuanLyCuTru_WinForm
{
    partial class FormDanhSachCongDan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDanhSachCongDan));
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDanhSachCongDan = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panelDanhSachCongDan = new System.Windows.Forms.Panel();
            this.ptbLoading = new System.Windows.Forms.PictureBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbbLoaiTimKiem = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCongDan)).BeginInit();
            this.panelDanhSachCongDan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnThemMoi.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThemMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnThemMoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThemMoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ForeColor = System.Drawing.Color.White;
            this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoi.Location = new System.Drawing.Point(967, 148);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(133, 46);
            this.btnThemMoi.TabIndex = 17;
            this.btnThemMoi.Text = "THÊM MỚI";
            this.btnThemMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnIn
            // 
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.White;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(967, 455);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(133, 43);
            this.btnIn.TabIndex = 18;
            this.btnIn.Text = "&In";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1139, 65);
            this.panel3.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách";
            // 
            // dgvDanhSachCongDan
            // 
            this.dgvDanhSachCongDan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachCongDan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDanhSachCongDan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachCongDan.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachCongDan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvDanhSachCongDan.Location = new System.Drawing.Point(19, 148);
            this.dgvDanhSachCongDan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDanhSachCongDan.MultiSelect = false;
            this.dgvDanhSachCongDan.Name = "dgvDanhSachCongDan";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvDanhSachCongDan.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachCongDan.SelectAllSignVisible = false;
            this.dgvDanhSachCongDan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachCongDan.Size = new System.Drawing.Size(923, 406);
            this.dgvDanhSachCongDan.TabIndex = 30;
            // 
            // panelDanhSachCongDan
            // 
            this.panelDanhSachCongDan.BackColor = System.Drawing.SystemColors.Control;
            this.panelDanhSachCongDan.Controls.Add(this.ptbLoading);
            this.panelDanhSachCongDan.Controls.Add(this.txtTimKiem);
            this.panelDanhSachCongDan.Controls.Add(this.cbbLoaiTimKiem);
            this.panelDanhSachCongDan.Controls.Add(this.btnTimKiem);
            this.panelDanhSachCongDan.Controls.Add(this.btnXoa);
            this.panelDanhSachCongDan.Controls.Add(this.btnChiTiet);
            this.panelDanhSachCongDan.Controls.Add(this.dgvDanhSachCongDan);
            this.panelDanhSachCongDan.Controls.Add(this.panel3);
            this.panelDanhSachCongDan.Controls.Add(this.btnIn);
            this.panelDanhSachCongDan.Controls.Add(this.btnThemMoi);
            this.panelDanhSachCongDan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDanhSachCongDan.Location = new System.Drawing.Point(0, 0);
            this.panelDanhSachCongDan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDanhSachCongDan.Name = "panelDanhSachCongDan";
            this.panelDanhSachCongDan.Size = new System.Drawing.Size(1139, 592);
            this.panelDanhSachCongDan.TabIndex = 31;
            // 
            // ptbLoading
            // 
            this.ptbLoading.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ptbLoading.Image = ((System.Drawing.Image)(resources.GetObject("ptbLoading.Image")));
            this.ptbLoading.Location = new System.Drawing.Point(371, 231);
            this.ptbLoading.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbLoading.Name = "ptbLoading";
            this.ptbLoading.Size = new System.Drawing.Size(267, 231);
            this.ptbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLoading.TabIndex = 56;
            this.ptbLoading.TabStop = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(265, 76);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(348, 45);
            this.txtTimKiem.TabIndex = 44;
            // 
            // cbbLoaiTimKiem
            // 
            this.cbbLoaiTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbLoaiTimKiem.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiTimKiem.FormattingEnabled = true;
            this.cbbLoaiTimKiem.Items.AddRange(new object[] {
            "Tên",
            "Nơi sinh",
            "Quê quán",
            "Quốc tịch",
            "Địa chỉ"});
            this.cbbLoaiTimKiem.Location = new System.Drawing.Point(41, 81);
            this.cbbLoaiTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbLoaiTimKiem.Name = "cbbLoaiTimKiem";
            this.cbbLoaiTimKiem.Size = new System.Drawing.Size(216, 36);
            this.cbbLoaiTimKiem.TabIndex = 43;
            this.cbbLoaiTimKiem.Text = "(Loại tìm kiếm)";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Location = new System.Drawing.Point(621, 76);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(133, 46);
            this.btnTimKiem.TabIndex = 46;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.Brown;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(967, 506);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(133, 46);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChiTiet.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnChiTiet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnChiTiet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnChiTiet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTiet.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnChiTiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChiTiet.Location = new System.Drawing.Point(967, 201);
            this.btnChiTiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(133, 46);
            this.btnChiTiet.TabIndex = 31;
            this.btnChiTiet.Text = "CHI TIẾT";
            this.btnChiTiet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // FormDanhSachCongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 592);
            this.Controls.Add(this.panelDanhSachCongDan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDanhSachCongDan";
            this.Text = "FormDanhSachCongDan";
            this.Load += new System.EventHandler(this.FormDanhSachCongDan_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCongDan)).EndInit();
            this.panelDanhSachCongDan.ResumeLayout(false);
            this.panelDanhSachCongDan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDanhSachCongDan;
        private System.Windows.Forms.Panel panelDanhSachCongDan;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbbLoaiTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.PictureBox ptbLoading;
    }
}