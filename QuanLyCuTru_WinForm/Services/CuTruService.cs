using QuanLyCuTru.DTOs;
using QuanLyCuTru.Models;
using QuanLyCuTru_WinForm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuTru_WinForm.Models
{
    class CuTruService
    {
        private string host = HttpService.CuTru;
        private HttpClient client = HttpService.Client;

        public CuTruService()
        {
        }

        public async Task<List<CuTruDTO>> GetDataAsync(string url)
        {
            List<CuTruDTO> cuTrus = null;

            HttpResponseMessage res = await client.GetAsync(url);
            if (res.IsSuccessStatusCode)
            {
                cuTrus = await res.Content.ReadAsAsync<List<CuTruDTO>>();
            }

            return cuTrus;
        }

        public async Task<List<CuTruDTO>> GetAllAsync()
        {
            return await GetDataAsync(host);
        }

        public async Task<List<CuTruDTO>> GetByAddressAsync(string diaChi)
        {
            // Request url template
            var url = $"{host}?diachi={diaChi}";

            return await GetDataAsync(url);
        }

        public async Task<CuTruDTO> GetByIdAsync(int id)
        {
            CuTruDTO cuTru = null;

            // Request url template
            var url = $"{host}/{id}";

            HttpResponseMessage res = await client.GetAsync(url);
            if (res.IsSuccessStatusCode)
            {
                cuTru = await res.Content.ReadAsAsync<CuTruDTO>();
            }

            return cuTru;
        }

        public async Task<List<CuTruDTO>> GetByPersonalAddressAsync(string diaChi)
        {
            // Request url template
            var url = $"{host}?diachidan={diaChi}";

            return await GetDataAsync(url);
        }

        // GET /api/quanlycutru?hoten="abc"
        public async Task<List<CuTruDTO>> GetByNameAsync(string hoTen)
        {
            // Request url template
            var url = $"{host}?hoten={hoTen}";

            return await GetDataAsync(url);
        }

        // GET/api/quanlycutri?noisinh="abc
        public async Task<List<CuTruDTO>> GetByBirthPlaceAsync(string noiSinh)
        {
            // Request url template
            var url = $"{host}?noisinh={noiSinh}";

            return await GetDataAsync(url);
        }

        //GET/api/quanlycutri?quequan="abc
        public async Task<List<CuTruDTO>> GetByHometownAsync(string queQuan)
        {
            // Request url template
            var url = $"{host}?quequan={queQuan}";

            return await GetDataAsync(url);
        }

        //GET/api/quanlycutri?quoctich="abc
        public async Task<List<CuTruDTO>> GetByNationAsync(string quocTich)
        {
            // Request url template
            var url = $"{host}?quoctich={quocTich}";

            return await GetDataAsync(url);
        }



        public async Task<List<CuTruDTO>> GetByTypeAsync(int loai)
        {
            // Request url template
            var url = $"{host}?loai={loai}";

            return await GetDataAsync(url);
        }

        public async Task<List<CuTruDTO>> GetByStateAsync(bool daDuyet)
        {
            // Request url template
            var url = $"{host}?duyet={daDuyet.ToString()}";

            return await GetDataAsync(url);
        }

        // GET /api/quanlycutru?hethan=true|false
        public async Task<List<CuTruDTO>> GetExpiredAsync()
        {
            // Request url template
            var url = $"{host}/hethan";

            return await GetDataAsync(url);
        }

        public async Task<Uri> CreateAsync(CuTruDTO cuTru)
        {
            HttpResponseMessage res = await client.PostAsJsonAsync(host, cuTru);
            res.EnsureSuccessStatusCode();

            return res.Headers.Location;
        }

        // PUT 
        public async Task<bool> UpdateAsync(CuTruDTO cuTru)
        {
            HttpResponseMessage res = await client.PutAsJsonAsync(host + cuTru.Id, cuTru);

            if (res.StatusCode == HttpStatusCode.NoContent)
                return true;

            return false;
        }
        //[HttpPatch]
        //[Route("Duyet/{id}")]
        //public IHttpActionResult Duyet(int id)
        //{
        //    // Get CuTru entity from database
        //    var cuTru = db.CuTrus.SingleOrDefault(c => c.Id == id);

        //    if (cuTru == null)
        //        return BadRequest();

        //    // Get the logged in CanBo's id
        //    var currentId = User.Identity.GetUserId();

        //    // Get CanBo entity in db
        //    var canBo = db.NguoiDungs.SingleOrDefault(c => c.IdentityId.Equals(currentId));

        //    cuTru.DaDuyet = true; // Set DaDuyet state to true
        //    cuTru.CanBoId = canBo.Id; // Set CanBo Duyet id
        //    db.SaveChanges();

        //    return Ok();
        //}

        public async Task<bool> DuyetCuTru(int id)
        {
            var url = host + "Duyet/" + id.ToString();
            HttpRequestMessage req = new HttpRequestMessage(new HttpMethod("PATCH"), url);
            HttpResponseMessage res = await client.SendAsync(req);

            if (res.IsSuccessStatusCode)
                return true;
            return false;
        }
    }
}
