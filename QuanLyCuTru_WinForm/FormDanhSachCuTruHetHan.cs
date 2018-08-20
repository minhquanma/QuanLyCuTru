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
    public partial class FormDanhSachCuTruHetHan : Form
    {
        CuTruService service = new CuTruService();

        public FormDanhSachCuTruHetHan()
        {
            InitializeComponent();
        }

        private async void FormDanhSachCuTru_Load(object sender, EventArgs e)
        {
            ptbLoading.Show();
            CuTruBindingSource.Bind(await service.GetExpiredAsync(), dgvCuTru);
            ptbLoading.Hide();
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
            FormSuaCuTru form = new FormSuaCuTru();
            form.Show();
        }

        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            switch (cbbTen.SelectedIndex)
            {
                // Ten
                case 0:
                    CuTruBindingSource.Bind(await service.GetByNameAsync(txtTimKiem.Text), dgvCuTru);
                    break;
                // Noi sinh
                case 1:
                    CuTruBindingSource.Bind(await service.GetByBirthPlaceAsync(txtTimKiem.Text), dgvCuTru);
                    break;
                // Que quan
                case 2:
                    CuTruBindingSource.Bind(await service.GetByHometownAsync(txtTimKiem.Text), dgvCuTru);
                    break;
                // Quoc tich
                case 3:
                    CuTruBindingSource.Bind(await service.GetByNationAsync(txtTimKiem.Text), dgvCuTru);
                    break;
                // Dia chi cu tru
                case 4:
                    CuTruBindingSource.Bind(await service.GetByAddressAsync(txtTimKiem.Text), dgvCuTru);
                    break;
                // Dia chi cong dan
                case 5:
                    CuTruBindingSource.Bind(await service.GetByPersonalAddressAsync(txtTimKiem.Text), dgvCuTru);
                    break;
            }
        }
    }
}
