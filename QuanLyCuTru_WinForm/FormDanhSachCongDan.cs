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

namespace QuanLyCuTru_WinForm
{
    public partial class FormDanhSachCongDan : Form
    {
        CuTruRepository repo = new CuTruRepository();

        public FormDanhSachCongDan()
        {
            InitializeComponent();   
        }

        class Student
        {
            public string Ten { get; set; }
            public string GioiTinh { get; set; }           
            public Student() {}
            public Student(string Ten, string GioiTinh)
            {
                this.Ten = Ten;
                this.GioiTinh = GioiTinh;
            }

        }
        private async void btnHienThiDanhSach_Click(object sender, EventArgs e)
        {
            dgvDanhSachCongDan.DataSource = await repo.GetAll();
        }

        private void panelDanhSachCongDan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            FormThemCongDan form = new FormThemCongDan();
            form.Show();
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FormChiTietCongDan form = new FormChiTietCongDan();
            form.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
