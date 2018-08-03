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
    class CuTruRepository : Repository
    {
        protected override void DefineHost()
        {
            host = Server.CuTru;
        }

        public CuTruRepository():base()
        {

        }

        public async Task<List<CuTruDTO>> GetAll()
        {
            List<CuTruDTO> cuTrus = null;

            HttpResponseMessage res = await client.GetAsync(host);
            if (res.IsSuccessStatusCode)
            {
                cuTrus = await res.Content.ReadAsAsync<List<CuTruDTO>>();
            }

            return cuTrus;
        }

        public async Task<List<CuTruDTO>> GetByAddress(string diaChi)
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

        public async Task<List<CuTruDTO>> GetByType(int loai)
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

        public async Task<CuTruDTO> GetById(int id)
        {
            CuTruDTO cuTru = null;

            HttpResponseMessage res = await client.GetAsync(host + id.ToString());
            if (res.IsSuccessStatusCode)
            {
                cuTru = await res.Content.ReadAsAsync<CuTruDTO>();
            }

            return cuTru;
        }

    }
}
