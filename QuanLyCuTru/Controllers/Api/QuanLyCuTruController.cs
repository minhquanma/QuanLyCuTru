using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuanLyCuTru.Models;
using QuanLyCuTru.DTOs;
using AutoMapper;
using Microsoft.AspNet.Identity;
using System.Web;
using System.Web.Http.Description;
using System.Collections.ObjectModel;

namespace QuanLyCuTru.Controllers.Api
{
    [RoutePrefix("api/QuanLyCuTru")]
    //[Authorize(Roles = "Admin, CanhSatKhuVuc")]
    public class QuanLyCuTruController : ApiController
    {
        private ApplicationDbContext db;

        public QuanLyCuTruController()
        {
            db = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            db.Dispose();
        }

        // GET: /api/quanlycutru
        [ResponseType(typeof(CuTru))]
        [Route("")]
        public IHttpActionResult GetCuTrus()    
        {
            var cuTrus = db.CuTrus
                .Select(Mapper.Map<CuTru, CuTruDTO>)
                .ToList();
      
            return Ok(cuTrus);
        }

        // GET: /api/quanlycutru/{id}
        [ResponseType(typeof(CuTru))]
        [Route("{id}")]
        public IHttpActionResult GetCuTru(int id)
        {
            var cuTru = db.CuTrus.SingleOrDefault(c => c.Id == id);

            if (cuTru == null)
                return NotFound();

            return Ok(Mapper.Map<CuTru, CuTruDTO>(cuTru));
        }

        // Tìm kiếm cư trú theo loại cư trú (Tạm vắng / Tạm trú)
        // GET: /api/quanlycutru?loai=1|2
        [Route("")]
        [ResponseType(typeof(CuTru))]
        public IHttpActionResult GetCuTrusByType(int loai)
        {
            var cuTrus = db.CuTrus
                .Where(c => c.LoaiCuTruId == loai)
                .Select(Mapper.Map<CuTru, CuTruDTO>)
                .ToList();

            return Ok(cuTrus);
        }
        // GET /api/quanlycutru?duyet=true|false
        [Route("")]
        [ResponseType(typeof(CuTru))]
        public IHttpActionResult GetCuTrusByState(bool duyet)
        {
            var cuTrus = db.CuTrus
                .Where(c => c.DaDuyet == duyet)
                .Select(Mapper.Map<CuTru, CuTruDTO>)
                .ToList();

            return Ok(cuTrus);
        }
        
        // Tìm kiếm cư trú theo tên công dân
        // GET /api/quanlycutru?hoten="abc"
        [Route("")]
        [ResponseType(typeof(CuTru))]
        public IHttpActionResult GetCuTrusByName(string hoTen)
        {
            var cuTrus = db.NguoiDungs
                        .Where(c => c.HoTen.Contains(hoTen))
                        .SelectMany(x => x.CuTrus)
                        .Distinct()
                        .Select(Mapper.Map<CuTru, CuTruDTO>);

            return Ok(cuTrus);
        }

        // Tìm kiếm cư trú theo địa chỉ dân
        // GET /api/quanlycutru?diachidan="abc"
        [Route("")]
        [ResponseType(typeof(CuTru))]
        public IHttpActionResult GetCuTrusByPersonalAddress(string diaChiDan)
        {
            diaChiDan = diaChiDan.Trim();
            var cuTrus = db.NguoiDungs
                        .Where(c => (c.SoNha + " " + c.Duong + " " + c.Phuong + " " + c.Quan + " " + c.ThanhPho)
                                    .Contains(diaChiDan))
                        .SelectMany(x => x.CuTrus)
                        .Select(Mapper.Map<CuTru, CuTruDTO>)
                        .Distinct();

            return Ok(cuTrus);
        }

        // Tìm kiếm cư trú theo địa chỉ cư trú
        // GET: /api/quanlycutru?diachi="abc"
        [Route("")]
        [ResponseType(typeof(CuTru))]
        public IHttpActionResult GetCuTrusByAddress(string diaChi)
        {
            diaChi = HttpUtility.UrlDecode(diaChi.Trim());
            var cuTrus = db.CuTrus.Where(c => (c.SoNha + " " + c.Duong + " " + c.Phuong + " " + c.Quan + " " + c.ThanhPho)
                .Contains(diaChi))
                .Select(Mapper.Map<CuTru, CuTruDTO>);

            return Ok(cuTrus);
        }

        // POST: /api/quanlycutru/
        [HttpPost]
        [Route("")]
        [ResponseType(typeof(CuTru))]
        public IHttpActionResult CreateCuTru(CuTruDTO dto)
        {
            if (ModelState.IsValid == false)
                return BadRequest();
            
            var cuTru = Mapper.Map<CuTruDTO, CuTru>(dto);

            // Create an empty CongDans instance
            cuTru.CongDans = new Collection<NguoiDung>();

            // Add CongDan entities into posted CuTru
            foreach (var id in dto.CongDanIds)
            {
                // Query each congdan
                var congDan = db.NguoiDungs.SingleOrDefault(c => c.Id == id);

                if (congDan == null)
                    return BadRequest();

                cuTru.CongDans.Add(congDan);
            }

            db.CuTrus.Add(cuTru);
            db.SaveChanges();

            return Created(new Uri(Request.RequestUri + "" + cuTru.Id), cuTru);
        }

        // POST: /api/quanlycutru/{id}
        [HttpPut]
        [Route("{id}")]
        public IHttpActionResult UpdateCuTru(int id, CuTruDTO dto)
        {
            if (ModelState.IsValid == false)
                return BadRequest();

            var cuTru = db.CuTrus.SingleOrDefault(c => c.Id == id);

            if (cuTru == null)
                return NotFound();

            Mapper.Map(dto, cuTru);

            //// Perform update Cong Dan infos
            //foreach (int value in dto.CongDans)
            //{
            //    // Query each congdan
            //    var congDan = db.NguoiDungs.SingleOrDefault(c => c.Id == value);

            //    if (congDan == null)
            //    {
            //        // Non existent
            //        return BadRequest();
            //    }

            //    cuTru.CongDans.Add(congDan);
            //}


            db.SaveChanges();

            return Ok();
        }

        [HttpPatch]
        [Route("Duyet/{id}")]
        public IHttpActionResult Duyet(int id)
        {
            // Get CuTru entity from database
            var cuTru = db.CuTrus.SingleOrDefault(c => c.Id == id);

            if (cuTru == null)
                return BadRequest();

            // Get the logged in CanBo's id
            var currentId = User.Identity.GetUserId();
        
            // Get CanBo entity in db
            var canBo = db.NguoiDungs.SingleOrDefault(c => c.IdentityId.Equals(currentId));

            cuTru.DaDuyet = true; // Set DaDuyet state to true
            cuTru.CanBoId = canBo.Id; // Set CanBo Duyet id
            db.SaveChanges();

            return Ok();
        }
    }
}
