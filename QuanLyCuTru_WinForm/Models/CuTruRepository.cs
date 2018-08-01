using QuanLyCuTru.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuTru_WinForm.Models
{
    class CuTruRepository
    {
        // Get server configuration data from Server class
        private const string Host = Server.CuTru; 

        private HttpClient client;
        private string loginToken; // this var stores login token for auth

        public CuTruRepository()
        {
            // Initialize HttpClient
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:58360");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            // Authorization
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", loginToken);
        }

        public async Task<List<CuTruDTO>> GetAll()
        {
            List<CuTruDTO> cuTrus = null;

            HttpResponseMessage res = await client.GetAsync(Host);
            if (res.IsSuccessStatusCode)
            {
                cuTrus = await res.Content.ReadAsAsync<List<CuTruDTO>>();
            }

            return cuTrus;
        }

        public async Task<CuTruDTO> GetById(int id)
        {
            CuTruDTO cuTru = null;

            HttpResponseMessage res = await client.GetAsync(Host + id.ToString());
            if (res.IsSuccessStatusCode)
            {
                cuTru = await res.Content.ReadAsAsync<CuTruDTO>();
            }

            return cuTru;
        } 
    }
}
