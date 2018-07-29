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

namespace QuanLyCuTru_WinForm
{
    public partial class FormChoDuyet : Form
    {
        private HttpClient client;
        public FormChoDuyet()
        {
            InitializeComponent();
            // Initialize HttpClient
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:58360");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "Uyi1bj34Gl0ZabPiTdvlKCA8gp2yi1QZjD7h-cto9F-TSN_V-elmy_9BLMeKPWhJZRIaSPr98NOh8WM7sxyMsncGAyhhyCGyPBfVd_QlfLh65h4BY_T4NOENfgWyzS2d3Y8uau2hCUnS3d1luIiwLIXRXzlZSCFU5xCbttULNkYFqITjG8lVcwRu4i-0h-O7VVPL-nul7LZ_QWPPxtGJv_YUfCLaXtbNTVDC6pkB84qUFYzXKMqosalsZZEpKQrLwdMIzWt99I0RphDoONtQQU4fiBPry6tU_hQe84wL_wcn679I6yaQLZLwtpqaCngaW76WDyicS6a6bUbM9a22JTYOEn-8UQ9amzF4wb4mwvMv7jdpqN7iysNzyOgWtWrOmjxJLM82JwPUrb42wU-SaNf4VaVKGc1w1HuGga7e2xM");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
