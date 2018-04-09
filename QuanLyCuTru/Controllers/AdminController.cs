using QuanLyCuTru.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;

namespace QuanLyCuTru.Controllers
{
    public class AdminController : Controller
    {
        ApplicationDbContext db;

        public AdminController()
        {
            db = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }

        // GET: Admin
        public ActionResult Index()
        {
            return View();  
        }

        // GET: Admin/CongDan
        public ActionResult CongDan()
        {
            var congDans = db.NguoiDungs.Include(m => m.ChucVu).ToList();
            var viewModel = new SearchNguoiDungViewModel
            {
                CongDans = congDans
            };
            return View(viewModel);
        }

        // GET: Admin/AddCongDan
        public ActionResult AddCongDan()
        {
            var nguoiDung = new AddCongDanViewModel
            {
                NguoiDung = new NguoiDung(),
                ChucVus = db.ChucVus.ToList()
            };

            return View(nguoiDung);
        }

        // POST: Admin/AddCongDan
        [HttpPost]
        public ActionResult AddCongDan(AddCongDanViewModel viewModel)
        {
            if (ModelState.IsValid)
            {

            }
            viewModel.ChucVus = db.ChucVus.ToList();
            return View(viewModel);
        }
    }
}