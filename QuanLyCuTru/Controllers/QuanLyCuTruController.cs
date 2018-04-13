using QuanLyCuTru.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace QuanLyCuTru.Controllers
{
    // This is a child route
    [Authorize(Roles = "Admin")]
    [RoutePrefix("CanBo/QuanLyCuTru")]
    public class QuanLyCuTruController : Controller
    {
        ApplicationDbContext db;

        public QuanLyCuTruController()
        {
            db = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }

        // GET: CanBo/QuanLyCuTru
        [Route("")]
        public ActionResult Index()
        {
            var cuTrus = db.CuTrus.ToList();

            cuTrus.Add(new CuTru() { Id = 1, Email = "Hem có" });
            cuTrus.Add(new CuTru() { Id = 2, Email = "Hem biết" });
            cuTrus.Add(new CuTru() { Id = 3, Email = "Ahihih" });

            return View(cuTrus);
        }

        [Route("Create")]
        public ActionResult Create()
        {
            // Lay thong tin dang nhap hien tai cua can bo
            var currentId = User.Identity.GetUserId();
            var canBo = db.NguoiDungs.SingleOrDefault(s => s.IdentityId.Contains(currentId));
            var loaiCuTrus = db.LoaiCuTrus;

            var cuTru = new DangKyCuTruViewModel
            {
                CanBoId = canBo.Id,
                LoaiCuTru = loaiCuTrus,
                CongDans = new List<int>()
            };

            return View(cuTru);
        }

        [Route("Create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DangKyCuTruViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                // Lay thong tin dang nhap hien tai cua can bo
                var currentId = User.Identity.GetUserId();
                var canBo = db.NguoiDungs.SingleOrDefault(s => s.IdentityId.Contains(currentId));
                var loaiCuTrus = db.LoaiCuTrus;

                viewModel.CanBoId = canBo.Id;
                viewModel.LoaiCuTru = loaiCuTrus;
         
                return View(viewModel);
            }

            var cuTru = new CuTru
            {
                NgayDangKy = viewModel.NgayDangKy,
                NgayHetHan = viewModel.NgayHetHan,
                NgayTao = viewModel.NgayTao,
                Email = viewModel.Email,
                DienThoai = viewModel.DienThoai,
                SoNha = viewModel.SoNha,
                Duong = viewModel.Duong,
                Phuong = viewModel.Phuong,
                Quan = viewModel.Quan,
                ThanhPho = viewModel.ThanhPho,
                LoaiCuTruId = viewModel.LoaiCuTruId,
                CanBoId = viewModel.CanBoId,
                CongDans = new Collection<NguoiDung>()
            };

            viewModel.CongDans.ForEach(value =>
            {
                // Query each congdan
                var congDan = db.NguoiDungs.SingleOrDefault(c => c.Id == value);
                cuTru.CongDans.Add(congDan);
            });
         

            db.CuTrus.Add(cuTru);
            db.SaveChanges();
            return RedirectToAction("Index");
            
        }

        // POST: CanBo/QuanLyCuTru
        [Route("Index2")]
        [HttpPost]
        public ActionResult Index2(DangKyCuTruViewModel viewModel)
        {
            // Test code
            return View();
        }

        [Route("AddUser")]
        [HttpPost]
        public ActionResult AddUser(DangKyCuTruViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                return Json("Success");
            }

            return View("Index", viewModel);
        }
    }
}