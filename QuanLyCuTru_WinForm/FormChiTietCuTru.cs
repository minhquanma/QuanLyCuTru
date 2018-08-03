using QuanLyCuTru.DTOs;
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
            this.lbDiaChi.Text = CuTru.DiaChi;
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
            FormSuaCuTru form = new FormSuaCuTru();
            form.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
