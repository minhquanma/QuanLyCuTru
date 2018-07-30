using System;
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
using PagedList;

namespace QuanLyCuTru_WinForm
{
    public partial class FormDanhSachCongDan : Form
    {
        int pageNumber = 1;
        IPagedList<Student> list;

        public FormDanhSachCongDan()
        {
            InitializeComponent();   
        }

        class Student
        {
            public string Ten { get; set; }
            public string GioiTinh { get; set; }           
            public Student() {}
            public Student(string Ten, string GioiTinh)
            {
                this.Ten = Ten;
                this.GioiTinh = GioiTinh;
            }

        }
        private async void btnHienThiDanhSach_Click(object sender, EventArgs e)
        {
           
            List<Student> list = new List<Student>();
            int n = 10;
            for (int i = 0; i<n; i++)
            {

            }
            dataGridViewX.DataSource = list;
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
