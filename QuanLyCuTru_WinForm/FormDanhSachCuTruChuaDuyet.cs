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
    public partial class FormDanhSachCuTruChuaDuyet : Form
    {
        public FormDanhSachCuTruChuaDuyet()
        {
            InitializeComponent();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FormChiTietCuTru form = new FormChiTietCuTru();
            form.Show();
        }
    }
}