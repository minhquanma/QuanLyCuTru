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
    public partial class FormDanhSachCuTruChuaDuyet : Form
    {
        NguoiDungService repo = new NguoiDungService();
        public FormDanhSachCuTruChuaDuyet()
        {
            InitializeComponent();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FormChiTietCuTru form = new FormChiTietCuTru();
            form.Show();
        }

        private async void FormDanhSachCuTruChuaDuyet_Load(object sender, EventArgs e)
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
