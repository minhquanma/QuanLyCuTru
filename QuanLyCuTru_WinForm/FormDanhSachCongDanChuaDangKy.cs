﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuTru_WinForm
{
    public partial class FormDanhSachCongDanChuaDangKy : Form
    {
        public FormDanhSachCongDanChuaDangKy()
        {
            InitializeComponent();
        }

        private void FormChuaDangKy_Load(object sender, EventArgs e)
        {

        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FormChiTietCongDan form = new FormChiTietCongDan();
            form.Show();
        }
    }
}