using QuanLyCuTru.DTOs;
using QuanLyCuTru_WinForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuTru_WinForm.Services
{
    class NguoiDungService
    {
        private string host = HttpService.CongDan;
        private HttpClient client = HttpService.Client;

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
    }
}
