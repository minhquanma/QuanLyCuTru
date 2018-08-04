using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuTru_WinForm.Models
{
    abstract class Repository
    {
        // Get server configuration data from Server class
        protected static string host;
        protected static HttpClient client;
        protected abstract void DefineHost();

        private string loginToken; // this var stores login token for auth

        public Repository()
        {
            InitHttpClient();
        }

        private void InitHttpClient()
        {
            // Initialize HttpClient
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:58360");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            DefineHost();
        }
    }
}
