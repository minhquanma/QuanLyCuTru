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
    public partial class FormChuaDangKy : Form
    {
        public FormChuaDangKy()
        {
            InitializeComponent();
        }

        private void FormChuaDangKy_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemCongDan form = new FormThemCongDan();
            form.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FormSuaCongDan form = new FormSuaCongDan();
            form.Show();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            FormChiTietCongDan form = new FormChiTietCongDan();
            form.Show();
        }
    }
}
