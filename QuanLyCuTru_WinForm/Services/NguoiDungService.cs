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

        public async Task<List<NguoiDungDTO>> GetDataAsync(string url)
        {
            List<NguoiDungDTO> congDans = null;

            HttpResponseMessage res = await HttpService.Client.GetAsync(url);
            if (res.IsSuccessStatusCode)
            {
                congDans = await res.Content.ReadAsAsync<List<NguoiDungDTO>>();
            }

            return congDans;
        }
        // GET 
        public async Task<List<NguoiDungDTO>> GetAllAsync()
        {
            return await GetDataAsync(host);
        }

        public async Task<List<NguoiDungDTO>> GetByName(string hoTen)
        {
            // Request url template
            var url = $"{host}?hoten={hoTen}";

            return await GetDataAsync(url);
        }

        public async Task<List<NguoiDungDTO>> GetByBirthPlace(string noiSinh)
        {
            // Request url template
            var url = $"{host}?noiSinh={noiSinh}";

            return await GetDataAsync(url);
        }

        public async Task<List<NguoiDungDTO>> GetByHomeTown(string queQuan)
        {
            // Request url template
            var url = $"{host}?queQuan={queQuan}";

            return await GetDataAsync(url);
        }

        public async Task<List<NguoiDungDTO>> GetByNation(string quocTich)
        {
            // Request url template
            var url = $"{host}?quocTich={quocTich}";

            return await GetDataAsync(url);
        }

        public async Task<List<NguoiDungDTO>> GetByAddress(string diaChi)
        {
            // Request url template
            var url = $"{host}?diaChi={diaChi}";

            return await GetDataAsync(url);
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
