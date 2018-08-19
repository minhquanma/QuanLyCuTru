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
        private CuTruDTO SelectedCuTru { get; set; }
        public FormChoDuyet()
        {
            InitializeComponent();
        }
        private async void FormChoDuyet_Load(object sender, EventArgs e)
        {
            CuTruBindingSource.Bind(await repo.GetByStateAsync(false), dgvDanhSachChoDuyet);
        }

        private async void btnDuyet_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Bạn có muốn duyệt cư trú này?", "Hahaha",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                var selectedRow = dgvDanhSachChoDuyet.SelectedRows[0];
                var selectedCuTru = (CuTruDTO)selectedRow.DataBoundItem;

                var result = await repo.DuyetCuTru(SelectedCuTru.Id);

                if (result == true)
                    MessageBox.Show("Đã duyệt thành công!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Đã có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);              
                // Tải lại danh sách
                CuTruBindingSource.Bind(await repo.GetByStateAsync(false), dgvDanhSachChoDuyet);
            }
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
                SelectedCuTru = (CuTruDTO)selectedRow.DataBoundItem;
                LoadDetailedData(SelectedCuTru);
            }
        }
    }
}
