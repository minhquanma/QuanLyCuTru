﻿using QuanLyCuTru_WinForm.BindingSources;
using QuanLyCuTru_WinForm.Models;
using System;
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
    public partial class FormDanhSachCuTru : Form
    {
        CuTruRepository repo = new CuTruRepository();

        public FormDanhSachCuTru()
        {
            InitializeComponent();
        }

        private async void FormDanhSachCuTru_Load(object sender, EventArgs e)
        {
            var list = await repo.GetAll();
            CuTruBindingSource.Bind(list, dgvCuTrus);
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            FormDangKyCuTru form = new FormDangKyCuTru();
            form.Show();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FormChiTietCuTru form = new FormChiTietCuTru();
            form.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
