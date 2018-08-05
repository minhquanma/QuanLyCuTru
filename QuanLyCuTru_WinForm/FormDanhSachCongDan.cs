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
using PagedList;
using QuanLyCuTru_WinForm.Models;
using QuanLyCuTru_WinForm.Services;
using QuanLyCuTru_WinForm.BindingSources;
using QuanLyCuTru.DTOs;

namespace QuanLyCuTru_WinForm
{
    public partial class FormDanhSachCongDan : Form
    {
        NguoiDungService repo = new NguoiDungService();

        public FormDanhSachCongDan()
        {
            InitializeComponent();   
        }

        private async void FormDanhSachCongDan_Load(object sender, EventArgs e)
        {
            NguoiDungBindingSource.Bind(await repo.GetAllAsync(), dgvDanhSachCongDan);
        }

        private void btnHienThiDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            FormThemCongDan form = new FormThemCongDan();
            form.Show();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            //// Lấy ra 1 Công Dân đầu tiên trong danh sách
            var selectedRow = dgvDanhSachCongDan.SelectedRows[0];
            var selectedCongDan = (NguoiDungDTO)selectedRow.DataBoundItem;

            if (selectedCongDan == null)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng", "Huhuhu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Tạo form Chi Tiết đồng thời truyền object CuTru qua
                FormChiTietCongDan form = new FormChiTietCongDan(selectedCongDan);
                form.Show();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
