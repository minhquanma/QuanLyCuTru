﻿using System;
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

namespace QuanLyCuTru_WinForm
{
    public partial class FormDanhSachCongDan : Form
    {
  
        public FormDanhSachCongDan()
        {
            InitializeComponent();   
        }

        private async void btnHienThiDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void AbrirFormInPanel(object ob)
        {
            //truyền form vào panel
            this.panelDanhSachCongDan.Controls.Clear();
            Form form = ob as Form;
            form.TopLevel = false;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            panelDanhSachCongDan.Controls.Add(form);
            form.Show();
        }

        private async void btnChon_Click(object sender, EventArgs e)
        {
            FormChiTietCongDan form = new FormChiTietCongDan();
            form.Show();
        }
    }
}