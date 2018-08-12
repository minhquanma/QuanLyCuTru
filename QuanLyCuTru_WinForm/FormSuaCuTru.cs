using QuanLyCuTru.DTOs;
using QuanLyCuTru_WinForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuTru_WinForm
{
    public partial class FormSuaCuTru : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public CuTruDTO CuTru { get; set; }

        public FormSuaCuTru(CuTruDTO cuTru)
        {
            CuTru = cuTru;
            InitializeComponent();
            LoadCuTruData();
        }

        public FormSuaCuTru()
        {
            InitializeComponent();
        }

        public void LoadCuTruData()
        {
            dtpNgayTao.Value = CuTru.NgayTao;
            dtpNgayDangKy.Value = CuTru.NgayDangKy;
            dtpNgayHetHan.Value = CuTru.NgayHetHan;
            txtEmail.Text = CuTru.Email;
            txtDienThoai.Text = CuTru.DienThoai;
            txtSoNha.Text = CuTru.SoNha;
            txtDuong.Text = CuTru.Duong;
            txtPhuong.Text = CuTru.Phuong;
            txtQuan.Text = CuTru.Quan;
            txtThanhPho.Text = CuTru.ThanhPho;
            cbLoaiCuTru.SelectedIndex = CuTru.LoaiCuTruId - 1;

            // Load danh sách công dân
            CuTru.CongDans
                .ToList()
                .ForEach(congDan =>
                {
                    lbMaCongDan.Items.Add($"{congDan.Id} {congDan.HoTen} ({congDan.StringGioiTinh})");
                });
        }

        public void GetCuTruFormInput()
        {
            CuTru.NgayTao = dtpNgayTao.Value;
            CuTru.NgayDangKy = dtpNgayDangKy.Value;
            CuTru.NgayHetHan = dtpNgayHetHan.Value;
            CuTru.Email = txtEmail.Text;
            CuTru.DienThoai = txtDienThoai.Text;
            CuTru.SoNha = txtSoNha.Text;
            CuTru.Duong = txtDuong.Text;
            CuTru.Phuong = txtPhuong.Text;
            CuTru.Quan = txtQuan.Text;
            CuTru.ThanhPho = txtThanhPho.Text;
            CuTru.LoaiCuTruId = cbLoaiCuTru.SelectedIndex + 1;
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            GetCuTruFormInput();

            var repo = new CuTruService();

            // Call API
            bool result = await repo.UpdateAsync(CuTru);

            if (result)
            {
                MessageBox.Show("Đã cập nhật thành công", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại", "Thất bại",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {

        }

        private void ptbThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
