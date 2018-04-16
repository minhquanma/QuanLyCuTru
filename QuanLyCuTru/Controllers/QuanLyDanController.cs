using QuanLyCuTru.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace QuanLyCuTru.Controllers
{
    // This is a child route
    [RoutePrefix("CanBo/QuanLyDan")]
    public class QuanLyDanController : Controller
    {
        ApplicationDbContext db;

        public QuanLyDanController()
        {
            db = new ApplicationDbContext();
            ViewBag.PageTitle = "Cán bộ";
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }

        public IEnumerable<NguoiDung> SearchCongDan(byte? LoaiTimKiemId, string TimKiem)
        {
            // Create a cong dan list reference
            IEnumerable<NguoiDung> congDans;

            switch (LoaiTimKiemId)
            {
                case 1:
                    congDans = db.NguoiDungs.Where(d => d.HoTen.Contains(TimKiem));
                    break;
                case 2:
                    congDans = db.NguoiDungs.Where(d => d.NoiSinh.Contains(TimKiem));
                    break;
                case 3:
                    congDans = db.NguoiDungs.Where(d => d.QueQuan.Contains(TimKiem));
                    break;
                case 4:
                    congDans = db.NguoiDungs.Where(d => d.QuocTich.Contains(TimKiem));
                    break;
                default:
                    congDans = db.NguoiDungs;
                    break;
            }

            return congDans;
        }

        // GET: CanBo/QuanLyDan
        [Route("")]
        public ActionResult Index(byte? LoaiTimKiemId, string TimKiem)
        {
            IEnumerable<NguoiDung> congDans;

            if (LoaiTimKiemId == null || TimKiem == null)
            {
                LoaiTimKiemId = null;
                congDans = db.NguoiDungs.ToList();
            }
            else
            {
                congDans = SearchCongDan(LoaiTimKiemId, TimKiem);
            }
                

            var viewModel = new TimNguoiDungViewModel
            {
                CongDans = congDans.ToList(),
                TimKiem = TimKiem,
                LoaiTimKiemId = LoaiTimKiemId
            };
            return View(viewModel);
        }

        // POST: CanBo/QuanLyDan: used to search cong dan
        [Route("")]
        [HttpPost]
        public ActionResult Index([Bind(Include = "LoaiTimKiemId, TimKiem")]TimNguoiDungViewModel viewModel)
        {
            if (ModelState.IsValid == false)
            {
                return RedirectToAction("Index");
            }

            // Input search string submitted by user
            byte? LoaiTimKiemId = viewModel.LoaiTimKiemId;
            var TimKiem = viewModel.TimKiem;

            // Assign cong dan list to view model
            viewModel.CongDans = SearchCongDan(LoaiTimKiemId, TimKiem).ToList();
            return View(viewModel);
        }

        // GET: CanBo/QuanLyDan/Details/id
        [Route("Details")]
        public ActionResult Details(int id)
        {
            // Query
            var congDan = db.NguoiDungs
                .Include(d => d.Identity)
                .FirstOrDefault(c => c.Id == id);
     
            return View(congDan);
        }

        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }

        //// GET: CanBo/QuanLyDan/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //[Route("Create")]
        //public ActionResult Create(CongDan congDan)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.CongDans.Add(congDan);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(congDan);
        //}

        //[Route("Edit")]
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    CongDan congDan = db.CongDans.Find(id);
        //    if (congDan == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    return View(congDan);
        //}

        //[HttpPost]
        //[Route("Edit")]
        //public ActionResult Edit(int id, CongDan congDan)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(congDan).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(congDan);
 
        //}
    }
}