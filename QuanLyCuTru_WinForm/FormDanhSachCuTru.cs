using QuanLyCuTru.DTOs;
using QuanLyCuTru_WinForm.BindingSources;
using QuanLyCuTru_WinForm.Models;
using QuanLyCuTru_WinForm.Services;
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
        CuTruService repo = new CuTruService();

        public FormDanhSachCuTru()
        {
            InitializeComponent();
        }

        public async void LoadDanhSach()
        {
            ptbLoading.Show();
            CuTruBindingSource.Bind(await repo.GetAllAsync(), dgvCuTru);
            ptbLoading.Hide();
        }

        private async void FormDanhSachCuTru_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            FormDangKyCuTru form = new FormDangKyCuTru();
            form.Show();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            // Lấy ra 1 Cư Trú đầu tiên trong danh sách
            var selectedRow = dgvCuTru.SelectedRows[0];
            var selectedCuTru = (CuTruDTO)selectedRow.DataBoundItem;
            if (selectedCuTru == null)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng", "Huhu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Tạo form Chi Tiết đồng thời truyền object CuTru qua
                FormChiTietCuTru form = new FormChiTietCuTru(selectedCuTru);
                form.Show();
            }     
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lấy ra 1 Cư Trú đầu tiên trong danh sách
            var selectedRow = dgvCuTru.SelectedRows[0];
            var selectedCuTru = (CuTruDTO)selectedRow.DataBoundItem;

            FormSuaCuTru form = new FormSuaCuTru(selectedCuTru);
            form.Show();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            switch (cbbLoaiTimKiem.SelectedIndex)
            {
                // Ten
                case 0:
                    CuTruBindingSource.Bind(await repo.GetByNameAsync(txtTimKiem.Text), dgvCuTru);
                    break;
                // Noi sinh
                case 1:
                    CuTruBindingSource.Bind(await repo.GetByBirthPlaceAsync(txtTimKiem.Text), dgvCuTru);
                    break;
                // Que quan
                case 2:
                    CuTruBindingSource.Bind(await repo.GetByHometownAsync(txtTimKiem.Text), dgvCuTru);
                    break;
                // Quoc tich
                case 3:
                    CuTruBindingSource.Bind(await repo.GetByNationAsync(txtTimKiem.Text), dgvCuTru);
                    break;
                // Dia chi cu tru
                case 4:
                    CuTruBindingSource.Bind(await repo.GetByAddressAsync(txtTimKiem.Text), dgvCuTru);
                    break;
                // Dia chi cong dan
                case 5:
                    break;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvCuTru.SelectedRows[0];
            var selectedCuTru = (CuTruDTO)selectedRow.DataBoundItem;
            if (selectedCuTru == null)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng", "Huhu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Tạo form Chi Tiết đồng thời truyền object CuTru qua
                FormPrint form = new FormPrint(selectedCuTru);
                form.ShowDialog();
            }
        }
    }
}
