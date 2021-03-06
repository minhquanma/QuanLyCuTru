﻿using System;
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
    public partial class FormThemCongDan : Form
    {
        public FormThemCongDan()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void ptbThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            bool txtCompleted = true;
            string errorMessage = "Nhập đầy đủ thông tin rồi thử lại";
            string successMessage = "Thành công";
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
                MessageBox.Show(errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtCompleted == true)
            {
                MessageBox.Show(successMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Đổi màu textbox rỗng
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
            }
        }
    }

