using QuanLyCuTru.DTOs;
using QuanLyCuTru_WinForm.Models;
using QuanLyCuTru_WinForm.Services;
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
    public partial class FormDangKyCuTru : Form
    {
        CuTruService repo = new CuTruService();
        List<int> danhSachCongDan = new List<int>();

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public FormDangKyCuTru()
        {
            InitializeComponent();

            this.dtpNgayHetHan.Value = DateTime.Now.AddMonths(1);

        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Text = "";
            }
            foreach (DateTimePicker tb in this.Controls.OfType<DateTimePicker>())
            {
                tb.Value = localDate;
            }
            txtNhapMaCongDan.Text = "Nhập mã công dân";
            lbMaCongDan.DataSource = null;
        }

        private void txtNhapMaCongDan_Click(object sender, EventArgs e)
        {
            txtNhapMaCongDan.Text = "";
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNhapMaCongDan.Text))
            {
                MessageBox.Show("Chưa nhập mã số công dân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ptbLoading.Visible = true;
                txtNhapMaCongDan.Enabled = false;

                // Lay data tu server
                var service = new NguoiDungService();
                var congDan = await service.GetByIdAsync(txtNhapMaCongDan.Text);

                if (congDan == null)
                    MessageBox.Show($"Mã số công dân {txtNhapMaCongDan.Text} không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    lbMaCongDan.Items.Add($"{congDan.Id} {congDan.HoTen} ({congDan.StringGioiTinh})");
                    danhSachCongDan.Add(congDan.Id);
                }

                txtNhapMaCongDan.Enabled = true;
                ptbLoading.Visible = false;
            }
        }

        public async void CreateCuTru()
        {
            var cuTru = new CuTruDTO
            {
                NgayDangKy = dtpNgayDangKy.Value,
                NgayHetHan = dtpNgayHetHan.Value,
                NgayTao = dtpNgayTao.Value,
                Email = txtEmail.Text,
                DienThoai = txtDienThoai.Text,
                SoNha = txtSoNha.Text,
                Duong = txtDuong.Text,
                Phuong = txtPhuong.Text,
                Quan = txtQuan.Text,
                ThanhPho = txtThanhPho.Text,
                LoaiCuTruId = cbLoaiCuTru.SelectedIndex + 1,
                CongDanIds = danhSachCongDan
            };

            try
            {
                var url = await repo.CreateAsync(cuTru);
                MessageBox.Show("Đã tạo thành công cư trú mới", url.ToString());
            } catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            bool txtCompleted = true;
            string errorMessage = "Nhập đầy đủ thông tin rồi thử lại";
            string successMessage = "Thành công";

            //Kiểm tra textbox có rỗng ko
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    if (String.IsNullOrEmpty(c.Text))
                    {
                        txtCompleted = false;
                    }
                }
            }

            if (txtCompleted == false)
            {
                MessageBox.Show(errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtCompleted == true)
            {
                MessageBox.Show(successMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CreateCuTru();
            }

            // Đổi màu textbox rỗng
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (String.IsNullOrEmpty(tb.Text))
                {
                    tb.BackColor = Color.FromArgb(255, 235, 238);
                }
                else
                {
                    tb.BackColor = System.Drawing.Color.White;
                }
            }
        }

        private void ptbThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
