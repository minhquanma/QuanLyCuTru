using QuanLyCuTru_WinForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuTru_WinForm
{
    public partial class FormDangNhap : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        string configPath = Path.GetFullPath(".") + "\\config.mmq";
        string savedUserName = "";
        bool isSaved = false;

        public FormDangNhap()
        {
            InitializeComponent();
            LoadConfigData();
            // Hide loading icon
            ptbloading.Hide();
        }

        private void LoadConfigData()
        {
            using (StreamReader sr = File.OpenText(configPath))
            {
                isSaved = bool.Parse(sr.ReadLine());
                savedUserName = sr.ReadLine();
            }

            if (!string.IsNullOrEmpty(savedUserName))
            {
                txtUsername.Text = savedUserName;
            }

            chkLuu.Checked = isSaved;
        }

        private void SaveConfigData()
        {
            using (StreamWriter sw = File.CreateText(configPath))
            {
                sw.WriteLine(isSaved);
                sw.WriteLine(txtUsername.Text);
            }
        }

        private void ClearConfigData()
        {
            using (StreamWriter sw = File.CreateText(configPath))
            {
                sw.WriteLine(false);
                sw.WriteLine("");
            }
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDangNhap_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Tài khoản")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.LightGray;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Tài khoản";
                txtUsername.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Mật khẩu")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Mật khẩu";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Hiện loading 
            ptbloading.Show();
            // Disable nút DangNhap
            btnDangNhap.Enabled = false;
            // Chức năng đăng nhập
            //var loginResult = true;
            var loginResult = await HttpService.LoginAsync(txtUsername.Text, txtPassword.Text);

            if (loginResult)
            {   
                FormCanBoQuanLy form = new FormCanBoQuanLy();
                form.Show();

                if (chkLuu.Checked)
                    SaveConfigData();
                else
                    ClearConfigData();

                Hide();
            }
            else
            {
                ptbloading.Hide();
                MessageBox.Show("Đăng nhập thất bại, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Disable nút DangNhap
            btnDangNhap.Enabled = true;
        }
    }
}
