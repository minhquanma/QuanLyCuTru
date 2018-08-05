using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuTru_WinForm.Services
{
    class HttpService
    {
        public const string CuTru = "api/QuanLyCuTru/";
        public const string CongDan = "api/QuanLyDan/";
        public const string Server = "http://localhost:58360";
        public static HttpClient Client => InitHttpClient();
        public static string Token { get; set; }

        private static readonly HttpService instance;
        public static HttpService Instance()
        {
            if (instance == null)
            {
                InitHttpClient();
                return new HttpService();
            }
            return instance;
        }

        private static HttpClient InitHttpClient()
        {
            // Initialize HttpClient
            var client = new HttpClient();
            client.BaseAddress = new Uri(Server);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
    }
}
