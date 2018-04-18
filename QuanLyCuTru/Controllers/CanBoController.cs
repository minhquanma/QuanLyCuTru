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
            var viewModel = new CanBoViewModel
            {
                TongSo = db.CuTrus.Count(),
                DangKyHomNay = db.CuTrus.Where(c => DateTime.Compare(c.NgayHetHan, DateTime.Now) == 0).Count(),
                ChoDuyet = db.CuTrus.Where(c => c.DaDuyet == false).Count(),
                HetHan = db.CuTrus.Where(c => DateTime.Compare(c.NgayHetHan, DateTime.Now) < 0).Count()
             };
            return View(viewModel);
        }

        [ChildActionOnly]
        public ActionResult _TableView()
        {
            var cuTrus = db.CuTrus.Where(c => c.DaDuyet == false);

            return PartialView("_TableView",  cuTrus);
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