using QuanLyCuTru.DTOs;
using QuanLyCuTru.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuTru_WinForm.Models
{
    sealed class CuTruRepository : Repository
    {
        protected override void DefineHost()
        {
            host = Server.CuTru;
        }

        public CuTruRepository():base()
        {

        }

        private static readonly CuTruRepository instance = new CuTruRepository();
        public static CuTruRepository Instance => instance;

        public async Task<List<CuTruDTO>> GetAllAsync()
        {
            List<CuTruDTO> cuTrus = null;

            HttpResponseMessage res = await client.GetAsync(host);
            if (res.IsSuccessStatusCode)
            {
                cuTrus = await res.Content.ReadAsAsync<List<CuTruDTO>>();
            }

            return cuTrus;
        }

        public async Task<List<CuTruDTO>> GetByAddressAsync(string diaChi)
        {
            List<CuTruDTO> cuTrus = null;

            // Request url template
            var url = $"{host}?diaChi={diaChi}";

            HttpResponseMessage res = await client.GetAsync(url);
            if (res.IsSuccessStatusCode)
            {
                cuTrus = await res.Content.ReadAsAsync<List<CuTruDTO>>();
            }

            return cuTrus;
        }

        public async Task<List<CuTruDTO>> GetByTypeAsync(int loai)
        {
            List<CuTruDTO> cuTrus = null;

            // Request url template
            var url = $"{host}?loai={loai}";

            HttpResponseMessage res = await client.GetAsync(url);
            if (res.IsSuccessStatusCode)
            {
                cuTrus = await res.Content.ReadAsAsync<List<CuTruDTO>>();
            }

            return cuTrus;
        }

        public async Task<CuTruDTO> GetByIdAsync(int id)
        {
            CuTruDTO cuTru = null;

            HttpResponseMessage res = await client.GetAsync(host + id.ToString());
            if (res.IsSuccessStatusCode)
            {
                cuTru = await res.Content.ReadAsAsync<CuTruDTO>();
            }

            return cuTru;
        }

        public async Task<Uri> CreateCuTruAsync(CuTruDTO cuTru)
        {
            HttpResponseMessage res = await client.PostAsJsonAsync(host, cuTru);
            res.EnsureSuccessStatusCode();

            return res.Headers.Location;
        }
    }
}
