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

        // GET /Api/QuanLyCuTru/id
        public CuTru GetCuTru(int id)
        {
            var customer = db.CuTrus.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return customer;
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
