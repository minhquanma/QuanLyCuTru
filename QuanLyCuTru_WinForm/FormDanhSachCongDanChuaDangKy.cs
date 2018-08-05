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
    public partial class FormDanhSachCongDanChuaDangKy : Form
    {
        NguoiDungService repo = new NguoiDungService();
        public FormDanhSachCongDanChuaDangKy()
        {
            InitializeComponent();
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FormChiTietCongDan form = new FormChiTietCongDan();
            form.Show();
        }

        private async void FormDanhSachCongDanChuaDangKy_Load(object sender, EventArgs e)
        {
            var list = await repo.GetAllAsync();
            ptbLoading.Show();
            ptbLoading.Update();
            try
            {
                //CuTruBindingSource.Bind(list, dgvCuTru);
            }
            catch (Exception ex)
            {
                //Handle Exception
            }
            ptbLoading.Hide();
        }
    }
}
