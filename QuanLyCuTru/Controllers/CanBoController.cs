using QuanLyCuTru.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyCuTru.Controllers
{
    public class CanBoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public CanBoController()
        {
            ViewBag.PageTitle = "Cán bộ";   
        }

        // GET: CanBo
        public ActionResult Index()
        {
            return View();
        }
       
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}