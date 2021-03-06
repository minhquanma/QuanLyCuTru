﻿using QuanLyCuTru_WinForm.Services;
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

        private string GetRoleString()
        {
            switch (HttpService.RoleName)
            {
                case "Admin":
                    return "Admin";
                case "CanhSatKhuVuc":
                    return "Cảnh Sát Khu Vực";
                case "BaoVeDanPho":
                    return "Bảo Vệ Dân Phố";
                default:
                    return "Không";
            }
        }
        private void FormTrangchu_Load(object sender, EventArgs e)
        {
            lbUsername.Text = $"{HttpService.UserName} ({GetRoleString()})";
            timer1.Enabled = true;
            // Load tin tuc

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
