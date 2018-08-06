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
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }

        private void FormTrangchu_Load(object sender, EventArgs e)
        {
            lbUsername.Text = $"{HttpService.UserName} ({HttpService.RoleName})";

            // Load tin tuc
            ptbLoading.Hide();
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }
    }
}
