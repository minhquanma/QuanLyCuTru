using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuTru_WinForm.Services
{
    static class HttpService
    {
        public const string CuTru = "api/QuanLyCuTru/";
        public const string CongDan = "api/QuanLyDan/";
        public const string Server = "http://localhost:58360";

        public static HttpClient Client { get; }
        public static string Token { get; set; }
        public static string UserName { get; set; }
        public static string RoleName { get; set; }

        static HttpService()
        {
            Client = InitHttpClient();
        }

        public static async Task<bool> LoginAsync(string username, string password)
        {
            var data = new Dictionary<string, string>();
            data.Add("grant_type", "password");
            data.Add("username", username);
            data.Add("password", password);

            var req = new HttpRequestMessage(HttpMethod.Post, Server + "/Token") { Content = new FormUrlEncodedContent(data) };
            var res = await Client.SendAsync(req);

            if (res.IsSuccessStatusCode)
            {
                // Deserialize body responsed data
                dynamic body = JsonConvert.DeserializeObject(res.Content.ReadAsStringAsync().Result);

                // Assign data
                Token = body.access_token;
                UserName = body.user_name;
                RoleName = body.role;

                SetAuthentionToken();

                return true;
            }
            return false;                                                                                                                                                                                                                                                                                                                                                                                                                                       
        }

        private static void SetAuthentionToken()
        {
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
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
