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
    public partial class FormChiTietCongDan : Form
    {
        public FormChiTietCongDan()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FormChiTietCongDan_Load(object sender, EventArgs e)
        {

        }
        private void AbrirFormInPanel(object ob)
        {
            this.panelContent.Controls.Clear();
            Form form = ob as Form;
            form.TopLevel = false;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(form);
            form.Show();
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
            AbrirFormInPanel(new FormSuaCongDan());
        }
    }
}
