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
            return View(cuTrus);
        }

        public DangKyCuTruViewModel InitDangKyCuTruViewModel()
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

            return cuTru;
        }

        [Route("Create")]
        public ActionResult Create()
        { 
            var cuTru = InitDangKyCuTruViewModel();
           
            return View(cuTru);
        }

        [Route("Create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DangKyCuTruViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel = InitDangKyCuTruViewModel();
         
                return View(viewModel);
            }

            // Tao moi thong tin cu tru
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
                DaDuyet = true,
                CongDans = new Collection<NguoiDung>()
            };

           
            foreach (int value in viewModel.CongDans)
            {
                // Query each congdan
                var congDan = db.NguoiDungs.SingleOrDefault(c => c.Id == value);

                if (congDan == null)
                {
                    ModelState.AddModelError("", "Thông tin công dân không hợp lệ");
                    return View(InitDangKyCuTruViewModel());
                }

                cuTru.CongDans.Add(congDan);
            }
         

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

        // Test codes
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