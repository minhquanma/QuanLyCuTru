using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuanLyCuTru.Models;

namespace QuanLyCuTru.Controllers.Api
{
    public class QuanLyCuTruController : ApiController
    {
        private ApplicationDbContext db;

        public QuanLyCuTruController()
        {
            db = new ApplicationDbContext();
        }

        // GET /api/quanlycutru
        [HttpGet]
        [Route("api/QuanLyCuTru/")]
        public IHttpActionResult GetCuTrus()    
        {
            var cuTrus = db.CuTrus.ToList().Select(c => new
                {
                    Id = c.Id,
                    Email = c.Email,
                    DiaChi = c.DiaChi,
                    DienThoai = c.DienThoai,
                    CanBo = c.CanBoId,
                    CongDans = c.CongDans.Select(d => new { Id = d.Id })
                }
            );
            return Ok(cuTrus);
        }

        // GET /api/quanlycutru/1
        [Route("api/QuanLyCuTru/{id}")]
        public IHttpActionResult GetCuTru(int id)
        {
            var cuTru = db.CuTrus.SingleOrDefault(c => c.Id == id);

            if (cuTru == null)
                return NotFound();

            return Ok(cuTru);
        }

        [HttpPatch]
        public IHttpActionResult Duyet(int id)
        {
            var cuTru = db.CuTrus.SingleOrDefault(c => c.Id == id);
            if (cuTru == null)
                return BadRequest();

            // Set DaDuyet to true
            cuTru.DaDuyet = true;
            db.SaveChanges();

            return Ok();
        }
    }
}
