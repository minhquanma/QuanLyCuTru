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
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: CanBo/QuanLyDan
        [Route("")]
        public ActionResult Index()
        {
            var congDans = db.NguoiDungs.ToList();
            var viewModel = new TimNguoiDungViewModel
            {
                CongDans = congDans
            };
            return View(viewModel);
        }

        // POST: CanBo/QuanLyDan: used to search cong dan
        [Route("")]
        [HttpPost]
        public ActionResult Index(TimNguoiDungViewModel viewModel)
        {
            if (ModelState.IsValid == false)
            {
                return RedirectToAction("Index");
            }

            // Input search string submitted by user
            var search = viewModel.TimKiem;

            // Create a cong dan reference
            IEnumerable<NguoiDung> congDans;

            switch (viewModel.LoaiTimKiemId)
            {
                case 1:
                    congDans = db.NguoiDungs.Where(d => d.HoTen.Contains(search));
                    break;
                case 2:
                    congDans = db.NguoiDungs.Where(d => d.NoiSinh.Contains(search));
                    break;
                case 3:
                    congDans = db.NguoiDungs.Where(d => d.QueQuan.Contains(search));
                    break;
                case 4:
                    congDans = db.NguoiDungs.Where(d => d.QuocTich.Contains(search));
                    break;
                default:
                    congDans = db.NguoiDungs;
                    break;
            }

            // Assign cong dan list to view model
            viewModel.CongDans = congDans.ToList();
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