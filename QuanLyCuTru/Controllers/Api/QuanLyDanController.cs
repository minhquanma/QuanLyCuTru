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

        // GET: api/QuanLyDan
        [Route("")]
        [ResponseType(typeof(NguoiDung))]
        public IHttpActionResult GetNguoiDungs()
        {
            var nguoiDungs = db.NguoiDungs
                .Select(Mapper.Map<NguoiDung, NguoiDungDTO>)
                .ToList();

            return Ok(nguoiDungs);
        }

        // GET: api/QuanLyDan?HoTen="abc"
        [ResponseType(typeof(NguoiDung))]
        [Route("")]
        public IHttpActionResult GetNguoiDungsByName(string hoTen)
        {
            var nguoiDungs = db.NguoiDungs
                .Where(ng => ng.HoTen.Contains(hoTen))
                .Select(Mapper.Map<NguoiDung, NguoiDungDTO>)
                .ToList();

            return Ok(nguoiDungs);
        }

        // GET: api/QuanLyDan?GioiTinh=true|false
        [ResponseType(typeof(NguoiDung))]
        [Route("")]
        public IHttpActionResult GetNguoiDungsByGender(bool gioiTinh)
        {
            var nguoiDungs = db.NguoiDungs
                .Where(ng => ng.GioiTinh == gioiTinh)
                .Select(Mapper.Map<NguoiDung, NguoiDungDTO>)
                .ToList();

            return Ok(nguoiDungs);
        }

        // GET: api/QuanLyDan/5
        [ResponseType(typeof(NguoiDung))]
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

        // PUT: api/QuanLyDan/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutNguoiDung(int id, NguoiDung nguoiDung)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != nguoiDung.Id)
            {
                return BadRequest();
            }

            db.Entry(nguoiDung).State = EntityState.Modified;

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

        // POST: api/QuanLyDan
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

        // DELETE: api/QuanLyDan/5
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