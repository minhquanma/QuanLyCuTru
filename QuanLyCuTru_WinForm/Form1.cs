using Newtonsoft.Json;
using QuanLyCuTru.DTOs;
using QuanLyCuTru.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuTru_WinForm
{
    public partial class Form1 : Form
    {
        private HttpClient client;

        public Form1()
        {
            InitializeComponent();

            // Init HttpClient
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:58360/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private async Task<CuTruDTO> GetCuTruAsync(int id)
        {
            CuTruDTO cuTru = null;
            HttpResponseMessage res = await client.GetAsync("api/QuanLyCuTru/" + id.ToString());
            if (res.IsSuccessStatusCode)
            {
                cuTru = await res.Content.ReadAsAsync<CuTruDTO>();
            }
            return cuTru;
        }

        private async Task<IEnumerable<CuTruDTO>> GetCuTrusAsync()
        {
            IEnumerable<CuTruDTO> cuTru = null;

            HttpResponseMessage res = await client.GetAsync("api/QuanLyCuTru/");
            if (res.IsSuccessStatusCode)
            {
                cuTru = await res.Content.ReadAsAsync<IEnumerable<CuTruDTO>>();
            }
            return cuTru;
        }

        private async Task Login(string username, string password)
        {
            // Login 
            var login = new Dictionary<string, string>
            {
                { "grant_type", "password" },
                { "username", username },
                { "password", password }
            };

            HttpResponseMessage response = await client.PostAsync("token", new FormUrlEncodedContent(login));

            // Get token
            dynamic data = JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);

            if (response.IsSuccessStatusCode)
            {
                lblUserName.Text = data.user_name;
            }
            else if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                lblUserName.Text = data.error_description;
            }         
        }

        private async void buttonGET_Click(object sender, EventArgs e)
        {
            var cuTrus = await GetCuTrusAsync();

            var cuTruId4 = cuTrus.SingleOrDefault(c => c.Id == 4);

            MessageBox.Show(cuTruId4.Email);
            dataGridView.DataSource = cuTrus;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtAccount.Text;
            var password = txtPassword.Text;
            await Login(username, password);
        }
    }
}
