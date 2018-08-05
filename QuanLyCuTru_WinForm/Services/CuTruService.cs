using QuanLyCuTru.DTOs;
using QuanLyCuTru.Models;
using QuanLyCuTru_WinForm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<List<CuTruDTO>> GetAllAsync()
        {
            List<CuTruDTO> cuTrus = null;

            HttpResponseMessage res = await HttpService.Client.GetAsync(host);
            if (res.IsSuccessStatusCode)
            {
                cuTrus = await res.Content.ReadAsAsync<List<CuTruDTO>>();
            }

            return cuTrus;
        }

        internal Task<List<CuTruDTO>> GetByState(bool v, DataGridView dgvDanhSachChoDuyet)
        {
            throw new NotImplementedException();
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

        public async Task<List<CuTruDTO>> GetByState(bool daDuyet)
        {
            List<CuTruDTO> cuTrus = null;

            // Request url template
            var url = $"{host}?duyet={daDuyet.ToString()}";

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
