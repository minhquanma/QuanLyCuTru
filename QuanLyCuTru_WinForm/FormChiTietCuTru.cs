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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuTru_WinForm
{
    public partial class FormChiTietCuTru : Form
    {
        public CuTruDTO CuTru { get; set; }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void LoadCuTruData()
        {
            lbID.Text = CuTru.Id.ToString();
            lbDiaChi.Text = CuTru.DiaChi;
            lbLoaiCuTru.Text = CuTru.LoaiCuTru;
            lbNgayTao.Text = CuTru.NgayTao.ToShortDateString();
            lbEmail.Text = CuTru.Email;
            lbDienThoai.Text = CuTru.DienThoai;
            lbCanBoDangKy.Text = CuTru.CanBoDuyet;

            // Load danh sách công dân
            if (CuTru.CongDans != null)
            {
                NguoiDungBindingSource.BindCuTru(CuTru.CongDans, dgvDanhSachCongDan);
            }

            // Nếu cư trú này đã được duyệt
            if (CuTru.DaDuyet)
            {
                // ẩn nút duyệt đi
                btnDuyetCuTru.Hide();

                // hiện check box
                chkDaDuyet.Visible = true;
                chkDaDuyet.Checked = CuTru.DaDuyet;
            }
            else if (HttpService.RoleName == "BaoVeDanPho") // Nếu là BVDP
            {
                // ẩn nút duyệt đi
                btnDuyetCuTru.Hide();
            }
            else
            {
                // ẩn checkbox đi
                chkDaDuyet.Visible = false;
                chkDaDuyet.Checked = false;
            }
        }

        public FormChiTietCuTru(CuTruDTO cuTru)
        {
            CuTru = cuTru;
            InitializeComponent();
            LoadCuTruData();
        }

        public FormChiTietCuTru()
        {
            InitializeComponent();
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.Close();
            FormSuaCuTru form = new FormSuaCuTru(CuTru);
            form.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnDuyetCuTru_Click(object sender, EventArgs e)
        {
            var service = new CuTruService();

            var dialogResult = MessageBox.Show("Bạn có muốn duyệt cư trú này?", "Hahaha",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                var result = await service.DuyetCuTru(CuTru.Id);

                if (result == true)
                {
                    MessageBox.Show("Đã duyệt thành công!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CuTru.DaDuyet = true;
                }
                else
                    MessageBox.Show("Đã có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Tải lại form
                LoadCuTruData();
            }
        }
    }
}
