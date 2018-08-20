using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using QuanLyCuTru.Models;
using QuanLyCuTru.DTOs;
using AutoMapper;
using System.Web;
using System.IO;

namespace QuanLyCuTru.Controllers.Api
{
    [RoutePrefix("api/QuanLyDan")]
    //[Authorize(Roles = "Admin, CanhSatKhuVuc")]
    public class QuanLyDanController : ApiController
    {
        private ApplicationDbContext db;

        public QuanLyDanController()
        {
            db = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            db.Dispose();
        }

        // GET: api/quanlydan
        [Route("")]
        [ResponseType(typeof(NguoiDungDTO))]
        public IHttpActionResult GetNguoiDungs()
        {
            var nguoiDungs = db.NguoiDungs
                .Select(Mapper.Map<NguoiDung, NguoiDungDTO>)
                .ToList();

            return Ok(nguoiDungs);
        }

        // GET: api/quanlydan?hoten="abc"
        [ResponseType(typeof(NguoiDungDTO))]
        [Route("")]
        public IHttpActionResult GetNguoiDungsByName(string hoTen)
        {
            var nguoiDungs = db.NguoiDungs
                .Where(ng => ng.HoTen.Contains(hoTen))
                .Select(Mapper.Map<NguoiDung, NguoiDungDTO>)
                .ToList();

            return Ok(nguoiDungs);
        }

        // GET: api/quanlydan?noisinh="abc"
        [ResponseType(typeof(NguoiDungDTO))]
        [Route("")]
        public IHttpActionResult GetNguoiDungsByBirthPlace(string noiSinh)
        {
            var nguoiDungs = db.NguoiDungs
                .Where(ng => ng.NoiSinh.Contains(noiSinh))
                .Select(Mapper.Map<NguoiDung, NguoiDungDTO>)
                .ToList();

            return Ok(nguoiDungs);
        }

        // GET: api/quanlydan?quequan="abc"
        [ResponseType(typeof(NguoiDungDTO))]
        [Route("")]
        public IHttpActionResult GetNguoiDungsByHomeTown(string queQuan)
        {
            var nguoiDungs = db.NguoiDungs
                .Where(ng => ng.QueQuan.Contains(queQuan))
                .Select(Mapper.Map<NguoiDung, NguoiDungDTO>)
                .ToList();

            return Ok(nguoiDungs);
        }

        // GET: api/quanlydan?quoctich="abc"
        [ResponseType(typeof(NguoiDungDTO))]
        [Route("")]
        public IHttpActionResult GetNguoiDungsByNation(string quocTich)
        {
            var nguoiDungs = db.NguoiDungs
                .Where(ng => ng.QuocTich.Contains(quocTich))
                .Select(Mapper.Map<NguoiDung, NguoiDungDTO>)
                .ToList();

            return Ok(nguoiDungs);
        }

        // GET: api/quanlydan?diachi="abc"
        [ResponseType(typeof(NguoiDungDTO))]
        [Route("")]
        public IHttpActionResult GetNguoiDungsByAddress(string diaChi)
        {
            var nguoiDungs = db.NguoiDungs
                .Where(ng => ng.DiaChi.Contains(diaChi))
                .Select(Mapper.Map<NguoiDung, NguoiDungDTO>)
                .ToList();

            return Ok(nguoiDungs);
        }

        // GET: api/quanlydan?gioitinh=true|false
        [ResponseType(typeof(NguoiDungDTO))]
        [Route("")]
        public IHttpActionResult GetNguoiDungsByGender(bool gioiTinh)
        {
            var nguoiDungs = db.NguoiDungs
                .Where(ng => ng.GioiTinh == gioiTinh)
                .Select(Mapper.Map<NguoiDung, NguoiDungDTO>)
                .ToList();

            return Ok(nguoiDungs);
        }

        // GET: api/quanlydan/5
        [ResponseType(typeof(NguoiDungDTO))]
        [Route("{id}")]
        public async Task<IHttpActionResult> GetNguoiDung(int id)
        {
            NguoiDung nguoiDung = await db.NguoiDungs.FindAsync(id);
            if (nguoiDung == null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<NguoiDung, NguoiDungDTO>(nguoiDung));
        }

        // POST: UPDATE USER AVATAR
        [HttpPost]
        [Route("UpdateAvatar/{id}")]
        public IHttpActionResult UploadJsonFile(int id)
        {
            var nguoiDung = db.NguoiDungs.FirstOrDefault(c => c.Id == id);

            if (nguoiDung == null)
                return BadRequest();

            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                foreach (string file in httpRequest.Files)
                {
                    var postedFile = httpRequest.Files[file];
                    int unixTimestamp = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                    var uploadDir = "/Content/avatar";
                    var imageExtension = Path.GetExtension(postedFile.FileName);
                    var imageName = unixTimestamp.ToString() + imageExtension;
                    var imagePath = Path.Combine(HttpContext.Current.Server.MapPath(uploadDir), imageName);
                    var imageUrl = Path.Combine(uploadDir, imageName);

                    
                    postedFile.SaveAs(imagePath);

                    // Update avatar
                    nguoiDung.Avatar = imageUrl;
                    db.SaveChanges();

                    return Created(imageUrl, nguoiDung);
                }
            }
            return BadRequest();
        }

        // PUT: api/quanlydan/5
        [ResponseType(typeof(void))]
        [Route("{id}")]
        [HttpPut]
        public async Task<IHttpActionResult> PutNguoiDung(int id, NguoiDungDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dto.Id)
            {
                return BadRequest();
            }

            var nguoiDung = db.NguoiDungs.FirstOrDefault(c => c.Id == id);

            Mapper.Map(dto, nguoiDung);

            try
            {
                await db.SaveChangesAsync();
            }

            catch (DbUpdateConcurrencyException)
            {
                if (!NguoiDungExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Quanlydan
        [ResponseType(typeof(NguoiDung))]
        public async Task<IHttpActionResult> PostNguoiDung(NguoiDung nguoiDung)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.NguoiDungs.Add(nguoiDung);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = nguoiDung.Id }, nguoiDung);
        }

        // DELETE: api/quanlydan/5
        [ResponseType(typeof(NguoiDung))]
        public async Task<IHttpActionResult> DeleteNguoiDung(int id)
        {
            NguoiDung nguoiDung = await db.NguoiDungs.FindAsync(id);
            if (nguoiDung == null)
            {
                return NotFound();
            }

            db.NguoiDungs.Remove(nguoiDung);
            await db.SaveChangesAsync();

            return Ok(nguoiDung);
        }

        private bool NguoiDungExists(int id)
        {
            return db.NguoiDungs.Count(e => e.Id == id) > 0;
        }
    }
}