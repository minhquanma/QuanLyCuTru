using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using QuanLyCuTru_WinForm.Services;

namespace QuanLyCuTru_WinForm
{
    public partial class FormCanBoQuanLy : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public FormCanBoQuanLy()
        {
            InitializeComponent();

            // Xử lý nghiệp vụ
            if (HttpService.RoleName == "BaoVeDanPho")
            {
                panelCongdan.Visible = false;
            }
            
        } 

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            string message = "Bạn có muốn thoát?";
            string caption = "Thông báo";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Closes the parent form.
                Application.Exit();
            }          
        }

        private void iconmaxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaxi.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaxi.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormInPanel(object ob)
        {
            if (this.panelContent.Controls.Count > 0)
                this.panelContent.Controls.RemoveAt(0);
            Form form = ob as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(form);
            this.panelContent.Tag = form;
            form.Show();

        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuCutru_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlienhe_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormLienHe());
        }

        private void btncongdan_Click(object sender, EventArgs e)
        {
            if (MenuCongdan.Visible == false)
            {
                MenuCongdan.Visible = true;
                panelCongdan.Height = 178;
                MenuCutru.Visible = false;
                panelCutru.Height = 54;
            }
            else
            {
                MenuCongdan.Visible = false;
                panelCongdan.Height = 54;
            }
        }


        private void panelContent_Paint(object sender, PaintEventArgs e)
        {
            if (this.panelContent.Controls.Count == 0)
            {
                FormTrangChu form = new FormTrangChu();
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                this.panelContent.Controls.Add(form);
                this.panelContent.Tag = form;
                form.Show();
            }
        }

        private void btnDanhSachCongDan_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormDanhSachCongDan());
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormTrangChu());
        }
        private void btnDangKyCuTru_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormDangKyCuTru());
        }

        private void btnCuTru_Click(object sender, EventArgs e)
        {
            if (MenuCutru.Visible == false)
            {
                MenuCutru.Visible = true;
                panelCutru.Height = 178;
                MenuCongdan.Visible = false;
                panelCongdan.Height = 54;
            }
            else
            {
                MenuCutru.Visible = false;
                panelCutru.Height = 54;
            }
        }

        private void btnCongDan_Click(object sender, EventArgs e)
        {
            if (MenuCongdan.Visible == false)
            {
                MenuCongdan.Visible = true;
                panelCongdan.Height = 95;
                MenuCutru.Visible = false;
                panelCutru.Height = 54;
            }
            else
            {
                MenuCongdan.Visible = false;
                panelCongdan.Height = 54;
            }
        }

        private void btnHetHanCuTru_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormDanhSachCuTruHetHan());
        }
        private void btnDanhSachCuTru_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormDanhSachCuTru());
        }

        private void btnChoDuyet_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormChoDuyet());
        }
    }
}
