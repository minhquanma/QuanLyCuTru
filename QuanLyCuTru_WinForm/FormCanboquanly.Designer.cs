﻿namespace QuanLyCuTru_WinForm
{
    partial class FormCanBoQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCanBoQuanLy));
            this.iconminimizar = new System.Windows.Forms.PictureBox();
            this.iconmaxi = new System.Windows.Forms.PictureBox();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconrestaurar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLienHe = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnChoDuyet = new System.Windows.Forms.Button();
            this.panelCongdan = new System.Windows.Forms.Panel();
            this.MenuCongdan = new System.Windows.Forms.Panel();
            this.btnDanhSachCongDan = new System.Windows.Forms.Button();
            this.btnCongDan = new System.Windows.Forms.Button();
            this.panelCutru = new System.Windows.Forms.Panel();
            this.btnCuTru = new System.Windows.Forms.Button();
            this.MenuCutru = new System.Windows.Forms.Panel();
            this.btnHetHanCuTru = new System.Windows.Forms.Button();
            this.btnDanhSachCuTru = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuVertical.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panelCongdan.SuspendLayout();
            this.MenuCongdan.SuspendLayout();
            this.panelCutru.SuspendLayout();
            this.MenuCutru.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconminimizar
            // 
            this.iconminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconminimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconminimizar.Image")));
            this.iconminimizar.InitialImage = null;
            this.iconminimizar.Location = new System.Drawing.Point(780, 4);
            this.iconminimizar.Name = "iconminimizar";
            this.iconminimizar.Size = new System.Drawing.Size(25, 25);
            this.iconminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconminimizar.TabIndex = 12;
            this.iconminimizar.TabStop = false;
            this.iconminimizar.Click += new System.EventHandler(this.iconminimizar_Click);
            // 
            // iconmaxi
            // 
            this.iconmaxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconmaxi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconmaxi.Image = ((System.Drawing.Image)(resources.GetObject("iconmaxi.Image")));
            this.iconmaxi.Location = new System.Drawing.Point(811, 4);
            this.iconmaxi.Name = "iconmaxi";
            this.iconmaxi.Size = new System.Drawing.Size(25, 25);
            this.iconmaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconmaxi.TabIndex = 13;
            this.iconmaxi.TabStop = false;
            this.iconmaxi.Click += new System.EventHandler(this.iconmaxi_Click);
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(842, 4);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(25, 25);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconcerrar.TabIndex = 11;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconrestaurar);
            this.panel1.Controls.Add(this.iconminimizar);
            this.panel1.Controls.Add(this.iconmaxi);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.iconcerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 32);
            this.panel1.TabIndex = 16;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // iconrestaurar
            // 
            this.iconrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("iconrestaurar.Image")));
            this.iconrestaurar.Location = new System.Drawing.Point(811, 4);
            this.iconrestaurar.Name = "iconrestaurar";
            this.iconrestaurar.Size = new System.Drawing.Size(25, 25);
            this.iconrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconrestaurar.TabIndex = 14;
            this.iconrestaurar.TabStop = false;
            this.iconrestaurar.Visible = false;
            this.iconrestaurar.Click += new System.EventHandler(this.iconrestaurar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.panel12);
            this.MenuVertical.Controls.Add(this.panelCongdan);
            this.MenuVertical.Controls.Add(this.panelCutru);
            this.MenuVertical.Controls.Add(this.panel9);
            this.MenuVertical.Controls.Add(this.panel7);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 570);
            this.MenuVertical.TabIndex = 15;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLienHe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 326);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 52);
            this.panel2.TabIndex = 5;
            // 
            // btnLienHe
            // 
            this.btnLienHe.BackColor = System.Drawing.Color.Transparent;
            this.btnLienHe.FlatAppearance.BorderSize = 0;
            this.btnLienHe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLienHe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLienHe.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLienHe.ForeColor = System.Drawing.Color.White;
            this.btnLienHe.Image = ((System.Drawing.Image)(resources.GetObject("btnLienHe.Image")));
            this.btnLienHe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLienHe.Location = new System.Drawing.Point(3, 6);
            this.btnLienHe.Name = "btnLienHe";
            this.btnLienHe.Size = new System.Drawing.Size(230, 40);
            this.btnLienHe.TabIndex = 9;
            this.btnLienHe.Text = " Liên Hệ";
            this.btnLienHe.UseVisualStyleBackColor = false;
            this.btnLienHe.Click += new System.EventHandler(this.btnlienhe_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnChoDuyet);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 274);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(250, 52);
            this.panel12.TabIndex = 4;
            // 
            // btnChoDuyet
            // 
            this.btnChoDuyet.BackColor = System.Drawing.Color.Transparent;
            this.btnChoDuyet.FlatAppearance.BorderSize = 0;
            this.btnChoDuyet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnChoDuyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoDuyet.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoDuyet.ForeColor = System.Drawing.Color.White;
            this.btnChoDuyet.Image = ((System.Drawing.Image)(resources.GetObject("btnChoDuyet.Image")));
            this.btnChoDuyet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChoDuyet.Location = new System.Drawing.Point(2, 6);
            this.btnChoDuyet.Name = "btnChoDuyet";
            this.btnChoDuyet.Size = new System.Drawing.Size(230, 40);
            this.btnChoDuyet.TabIndex = 10;
            this.btnChoDuyet.Text = "      Chờ duyệt";
            this.btnChoDuyet.UseVisualStyleBackColor = false;
            this.btnChoDuyet.Click += new System.EventHandler(this.btnChoDuyet_Click);
            // 
            // panelCongdan
            // 
            this.panelCongdan.Controls.Add(this.MenuCongdan);
            this.panelCongdan.Controls.Add(this.btnCongDan);
            this.panelCongdan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCongdan.Location = new System.Drawing.Point(0, 222);
            this.panelCongdan.Name = "panelCongdan";
            this.panelCongdan.Size = new System.Drawing.Size(250, 52);
            this.panelCongdan.TabIndex = 3;
            // 
            // MenuCongdan
            // 
            this.MenuCongdan.Controls.Add(this.btnDanhSachCongDan);
            this.MenuCongdan.Location = new System.Drawing.Point(56, 50);
            this.MenuCongdan.Name = "MenuCongdan";
            this.MenuCongdan.Size = new System.Drawing.Size(174, 36);
            this.MenuCongdan.TabIndex = 15;
            this.MenuCongdan.Visible = false;
            // 
            // btnDanhSachCongDan
            // 
            this.btnDanhSachCongDan.BackColor = System.Drawing.Color.Transparent;
            this.btnDanhSachCongDan.FlatAppearance.BorderSize = 0;
            this.btnDanhSachCongDan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnDanhSachCongDan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachCongDan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachCongDan.ForeColor = System.Drawing.Color.White;
            this.btnDanhSachCongDan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachCongDan.Location = new System.Drawing.Point(51, -1);
            this.btnDanhSachCongDan.Name = "btnDanhSachCongDan";
            this.btnDanhSachCongDan.Size = new System.Drawing.Size(127, 30);
            this.btnDanhSachCongDan.TabIndex = 11;
            this.btnDanhSachCongDan.Text = "Danh sách";
            this.btnDanhSachCongDan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachCongDan.UseVisualStyleBackColor = false;
            this.btnDanhSachCongDan.Click += new System.EventHandler(this.btnDanhSachCongDan_Click);
            // 
            // btnCongDan
            // 
            this.btnCongDan.BackColor = System.Drawing.Color.Transparent;
            this.btnCongDan.FlatAppearance.BorderSize = 0;
            this.btnCongDan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCongDan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCongDan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCongDan.ForeColor = System.Drawing.Color.White;
            this.btnCongDan.Image = ((System.Drawing.Image)(resources.GetObject("btnCongDan.Image")));
            this.btnCongDan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCongDan.Location = new System.Drawing.Point(-3, 4);
            this.btnCongDan.Name = "btnCongDan";
            this.btnCongDan.Size = new System.Drawing.Size(230, 40);
            this.btnCongDan.TabIndex = 7;
            this.btnCongDan.Text = "        Công Dân";
            this.btnCongDan.UseVisualStyleBackColor = false;
            this.btnCongDan.Click += new System.EventHandler(this.btnCongDan_Click);
            // 
            // panelCutru
            // 
            this.panelCutru.Controls.Add(this.btnCuTru);
            this.panelCutru.Controls.Add(this.MenuCutru);
            this.panelCutru.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCutru.Location = new System.Drawing.Point(0, 170);
            this.panelCutru.Name = "panelCutru";
            this.panelCutru.Size = new System.Drawing.Size(250, 52);
            this.panelCutru.TabIndex = 2;
            // 
            // btnCuTru
            // 
            this.btnCuTru.BackColor = System.Drawing.Color.Transparent;
            this.btnCuTru.FlatAppearance.BorderSize = 0;
            this.btnCuTru.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCuTru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuTru.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuTru.ForeColor = System.Drawing.Color.White;
            this.btnCuTru.Image = ((System.Drawing.Image)(resources.GetObject("btnCuTru.Image")));
            this.btnCuTru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuTru.Location = new System.Drawing.Point(0, 9);
            this.btnCuTru.Name = "btnCuTru";
            this.btnCuTru.Size = new System.Drawing.Size(230, 41);
            this.btnCuTru.TabIndex = 6;
            this.btnCuTru.Text = "Cư Trú";
            this.btnCuTru.UseVisualStyleBackColor = false;
            this.btnCuTru.Click += new System.EventHandler(this.btnCuTru_Click);
            // 
            // MenuCutru
            // 
            this.MenuCutru.Controls.Add(this.btnHetHanCuTru);
            this.MenuCutru.Controls.Add(this.btnDanhSachCuTru);
            this.MenuCutru.Location = new System.Drawing.Point(53, 55);
            this.MenuCutru.Name = "MenuCutru";
            this.MenuCutru.Size = new System.Drawing.Size(177, 106);
            this.MenuCutru.TabIndex = 10;
            this.MenuCutru.Visible = false;
            this.MenuCutru.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuCutru_Paint);
            // 
            // btnHetHanCuTru
            // 
            this.btnHetHanCuTru.BackColor = System.Drawing.Color.Transparent;
            this.btnHetHanCuTru.FlatAppearance.BorderSize = 0;
            this.btnHetHanCuTru.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnHetHanCuTru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHetHanCuTru.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHetHanCuTru.ForeColor = System.Drawing.Color.White;
            this.btnHetHanCuTru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHetHanCuTru.Location = new System.Drawing.Point(42, 45);
            this.btnHetHanCuTru.Name = "btnHetHanCuTru";
            this.btnHetHanCuTru.Size = new System.Drawing.Size(132, 40);
            this.btnHetHanCuTru.TabIndex = 13;
            this.btnHetHanCuTru.Text = "Hết hạn";
            this.btnHetHanCuTru.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHetHanCuTru.UseVisualStyleBackColor = false;
            this.btnHetHanCuTru.Click += new System.EventHandler(this.btnHetHanCuTru_Click);
            // 
            // btnDanhSachCuTru
            // 
            this.btnDanhSachCuTru.BackColor = System.Drawing.Color.Transparent;
            this.btnDanhSachCuTru.FlatAppearance.BorderSize = 0;
            this.btnDanhSachCuTru.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnDanhSachCuTru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachCuTru.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachCuTru.ForeColor = System.Drawing.Color.White;
            this.btnDanhSachCuTru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachCuTru.Location = new System.Drawing.Point(43, 3);
            this.btnDanhSachCuTru.Name = "btnDanhSachCuTru";
            this.btnDanhSachCuTru.Size = new System.Drawing.Size(132, 40);
            this.btnDanhSachCuTru.TabIndex = 12;
            this.btnDanhSachCuTru.Text = "Danh sách";
            this.btnDanhSachCuTru.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachCuTru.UseVisualStyleBackColor = false;
            this.btnDanhSachCuTru.Click += new System.EventHandler(this.btnDanhSachCuTru_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnTrangChu);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 118);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(250, 52);
            this.panel9.TabIndex = 1;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.Transparent;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangChu.Image")));
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 6);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(230, 40);
            this.btnTrangChu.TabIndex = 9;
            this.btnTrangChu.Text = "       Trang Chủ";
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pictureBox8);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(250, 118);
            this.panel7.TabIndex = 0;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(3, 22);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(61, 66);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(70, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 43);
            this.label16.TabIndex = 5;
            this.label16.Text = "Cán Bộ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 21);
            this.label12.TabIndex = 5;
            this.label12.Text = "© 2018 - Quản Lý Cư Trú";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label12);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 570);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1120, 30);
            this.panel6.TabIndex = 14;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.ForeColor = System.Drawing.Color.White;
            this.panelContent.Location = new System.Drawing.Point(250, 32);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(870, 538);
            this.panelContent.TabIndex = 29;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // FormCanBoQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1120, 600);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCanBoQuanLy";
            this.Text = "FormCanboquanly";
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panelCongdan.ResumeLayout(false);
            this.MenuCongdan.ResumeLayout(false);
            this.panelCutru.ResumeLayout(false);
            this.MenuCutru.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox iconminimizar;
        private System.Windows.Forms.PictureBox iconmaxi;
        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox iconrestaurar;
        private System.Windows.Forms.Button btnCuTru;
        private System.Windows.Forms.Button btnLienHe;
        private System.Windows.Forms.Button btnCongDan;
        private System.Windows.Forms.Panel MenuCutru;
        private System.Windows.Forms.Button btnHetHanCuTru;
        private System.Windows.Forms.Button btnDanhSachCuTru;
        private System.Windows.Forms.Panel MenuCongdan;
        private System.Windows.Forms.Button btnDanhSachCongDan;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panelCongdan;
        private System.Windows.Forms.Panel panelCutru;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnChoDuyet;
        private System.Windows.Forms.Panel panelContent;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}