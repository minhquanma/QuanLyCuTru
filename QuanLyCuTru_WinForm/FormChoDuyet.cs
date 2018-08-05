using QuanLyCuTru.DTOs;
using QuanLyCuTru_WinForm.BindingSources;
using QuanLyCuTru_WinForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuTru_WinForm
{
    public partial class FormChoDuyet : Form
    {
        CuTruService repo = new CuTruService();

        public FormChoDuyet()
        {
            InitializeComponent();
        }

        private async void FormChoDuyet_Load(object sender, EventArgs e)
        {
            CuTruBindingSource.Bind(await repo.GetByState(false), dgvDanhSachChoDuyet);
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void LoadDetailedData(CuTruDTO cuTru)
        {
            txtId.Text = cuTru.Id.ToString();
            txtEmail.Text = cuTru.Email;
            txtDienThoai.Text = cuTru.DienThoai;
            txtNgayDangKy.Text = cuTru.NgayDangKy.ToShortDateString();
            txtLoaiCuTru.Text = cuTru.LoaiCuTru;
            txtDiaChi.Text = cuTru.DiaChi;
        }

        private void dgvDanhSachChoDuyet_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhSachChoDuyet.SelectedRows.Count > 0)
            {
                var selectedRow = dgvDanhSachChoDuyet.SelectedRows[0];
                var selectedCuTru = (CuTruDTO)selectedRow.DataBoundItem;

                LoadDetailedData(selectedCuTru);
            }
        }
    }
}
