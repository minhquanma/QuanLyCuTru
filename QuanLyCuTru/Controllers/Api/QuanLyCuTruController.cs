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

namespace QuanLyCuTru.Controllers.Api
{
    [RoutePrefix("api/QuanLyCuTru")]
    [Authorize(Roles = "Admin, CanhSatKhuVuc")]
    public class QuanLyCuTruController : ApiController
    {
        private ApplicationDbContext db;

        public QuanLyCuTruController()
        {
            db = new ApplicationDbContext();
        }

        // GET /api/quanlycutru
        [Route("")]
        public IHttpActionResult GetCuTrus()    
        {
            var cuTrus = db.CuTrus.ToList().Select(Mapper.Map<CuTru, CuTruDTO>);
      
            return Ok(cuTrus);
        }

        // GET /api/quanlycutru/1
        [Route("{id}")]
        public IHttpActionResult GetCuTru(int id)
        {
            var cuTru = db.CuTrus.SingleOrDefault(c => c.Id == id);

            if (cuTru == null)
                return NotFound();

            return Ok(Mapper.Map<CuTru, CuTruDTO>(cuTru));
        }

        // POST /api/quanlycutru/
        [HttpPost]
        [Route("")]
        public IHttpActionResult CreateCuTru(CuTruDTO dto)
        {
            if (ModelState.IsValid)
            {
                var cuTru = Mapper.Map<CuTruDTO, CuTru>(dto);
                db.CuTrus.Add(cuTru);
                db.SaveChanges();

                return Created(new Uri(Request.RequestUri + "/" + cuTru.Id), cuTru);
            }
            return BadRequest();
        }

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

            // Set DaDuyet to true
            cuTru.DaDuyet = true;

            // Set CanBo duyet id 
            var currentUserId = User.Identity.GetUserId();
            var currentUserName = User.Identity.GetUserName();

            if (currentUserId == null)
                currentUserId = RequestContext.Principal.Identity.GetUserId();
            // Get CanBo Entity
            var canBo = db.NguoiDungs.SingleOrDefault(c => c.IdentityId.Equals(currentUserId));

            cuTru.CanBoId = canBo.Id;

            db.SaveChanges();

            return Ok();
        }
    }
}
