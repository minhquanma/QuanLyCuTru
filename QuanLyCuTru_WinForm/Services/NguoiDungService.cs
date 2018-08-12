using QuanLyCuTru.DTOs;
using QuanLyCuTru_WinForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuTru_WinForm.Services
{
    class NguoiDungService
    {
        private string host = HttpService.CongDan;
        private HttpClient client = HttpService.Client;

        // GET 
        public async Task<List<NguoiDungDTO>> GetAllAsync()
        {
            List<NguoiDungDTO> congDans = null;

            HttpResponseMessage res = await HttpService.Client.GetAsync(host);
            if (res.IsSuccessStatusCode)
            {
                congDans = await res.Content.ReadAsAsync<List<NguoiDungDTO>>();
            }

            return congDans;
        }

        // GET  /id
        public async Task<NguoiDungDTO> GetByIdAsync(string id)
        {
            NguoiDungDTO nguoiDung = null;

            HttpResponseMessage res = await client.GetAsync(host + id);
            if (res.IsSuccessStatusCode)
            {
                nguoiDung = await res.Content.ReadAsAsync<NguoiDungDTO>();
            }

            return nguoiDung;
        }


        // PUT 
        public async Task<bool> UpdateAsync(NguoiDungDTO nguoiDung)
        {
            HttpResponseMessage res = await client.PutAsJsonAsync(host + nguoiDung.Id, nguoiDung);

            if (res.StatusCode == HttpStatusCode.NoContent)
                return true;
            
            return false;
        }
    }
}
