using QuanLyCuTru.DTOs;
using QuanLyCuTru.Global;
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
    public partial class FormSuaCongDan : Form
    {
        public NguoiDungDTO CongDan { get; set; }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public FormSuaCongDan(NguoiDungDTO congDan)
        {
            CongDan = congDan;
            InitializeComponent();
        }

        public FormSuaCongDan()
        {
            InitializeComponent();
        }

        public void LoadCongDanData()
        {
            txtHoTen.Text = CongDan.HoTen;
            dtpSinhNhat.Value = CongDan.SinhNhat;
            txtDienThoai.Text = CongDan.DienThoai;
            txtSoNha.Text = CongDan.SoNha;
            txtDuong.Text = CongDan.Duong;
            txtPhuong.Text = CongDan.Phuong;
            txtQuan.Text = CongDan.Quan;
            txtThanhPho.Text = CongDan.ThanhPho;
            txtNoiSinh.Text = CongDan.NoiSinh;
            txtQuocTich.Text = CongDan.QuocTich;
            txtQueQuan.Text = CongDan.QueQuan;
            rbNam.Checked = CongDan.GioiTinh == GioiTinh.Nam;
            cmbChucVu.SelectedIndex = CongDan.ChucVuId - 1;
        }

        public void GetCongDanFormInput()
        {
            CongDan.HoTen = txtHoTen.Text;
            CongDan.SinhNhat = dtpSinhNhat.Value;
            CongDan.DienThoai = txtDienThoai.Text;
            CongDan.SoNha = txtSoNha.Text;
            CongDan.Duong = txtDuong.Text;
            CongDan.Phuong = txtPhuong.Text;
            CongDan.Quan = txtQuan.Text;
            CongDan.ThanhPho = txtThanhPho.Text;
            CongDan.NoiSinh = txtNoiSinh.Text;
            CongDan.QuocTich = txtQuocTich.Text;
            CongDan.QueQuan = txtQueQuan.Text;
            CongDan.GioiTinh = rbNam.Checked ? GioiTinh.Nam : GioiTinh.Nu;
            CongDan.ChucVuId = cmbChucVu.SelectedIndex + 1;
        }

        private void FormSuaCongDan_Load(object sender, EventArgs e)
        {
            LoadCongDanData();
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

        private async void btnSua_Click(object sender, EventArgs e)
        {
            #region Form inputs validation logic (Logic xử lý lỗi đầu vào từ form)
            bool txtCompleted = true;

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
                MessageBox.Show("Nhập đầy đủ thông tin rồi thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            //Đổi màu checkbox chưa checked
            if (rbNam.Checked == false && rbNu.Checked == false)
            {
                rbNam.ForeColor = System.Drawing.Color.Red;
                rbNu.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                rbNam.ForeColor = this.ForeColor;
                rbNu.ForeColor = this.ForeColor;
            }
            #endregion

            if (txtCompleted)
            {
                var repo = new NguoiDungService();

                GetCongDanFormInput();

                // Call API
                bool result = await repo.UpdateAsync(CongDan);
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
        }

        private void btnChonTep_Click(object sender, EventArgs e)
        {

        }
    }  
}
