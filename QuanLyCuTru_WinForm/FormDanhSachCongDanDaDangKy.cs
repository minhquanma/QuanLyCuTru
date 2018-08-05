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

    public partial class FormDanhSachCongDanDaDangKy : Form
    {
        NguoiDungService repo = new NguoiDungService();
        public FormDanhSachCongDanDaDangKy()
        {

            InitializeComponent();
        }
        class Student
        {
            public string Ten { get; set; }
            public string GioiTinh { get; set; }
            public Student() { }
            public Student(string Ten, string GioiTinh)
            {
                this.Ten = Ten;
                this.GioiTinh = GioiTinh;
            }

        }
        private void dataGridViewDaDangKy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {         
            List<Student> list = new List<Student>();
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                list.Add(new Student("Luong", "nam"));
                list.Add(new Student("Quan", "nam"));
                list.Add(new Student("Tan", "nam"));
                list.Add(new Student("Viet", "nam"));
            }
            dgvDanhSachCongDanDaDangKy.DataSource = list;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void cbbGioiTinh_DrawItem(object sender, DrawItemEventArgs e)
        {
            
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FormChiTietCongDan form = new FormChiTietCongDan();
            form.Show();
        }

        private async void FormDanhSachCongDanDaDangKy_Load(object sender, EventArgs e)
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
