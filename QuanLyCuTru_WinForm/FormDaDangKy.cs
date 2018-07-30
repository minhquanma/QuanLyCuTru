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

    public partial class FormDaDangKy : Form
    {        
            
        public FormDaDangKy()
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
            dataGridViewDaDangKy.DataSource = list;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void cbbGioiTinh_DrawItem(object sender, DrawItemEventArgs e)
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
