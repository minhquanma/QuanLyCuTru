using QuanLyCuTru.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using System;

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
            ViewBag.PageTitle = "Cán bộ";
            db = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }

        public IEnumerable<CuTru> SearchCuTru(byte? LoaiTimKiemId,
            byte? LoaiCuTruId,
            byte? LoaiTrangThaiId,
            byte? LoaiHanId,
            string TimKiem)
        {
            IEnumerable<CuTru> cuTrus = null;

            if (TimKiem == null)
            {
                cuTrus = db.CuTrus;
                goto TimKiemIsNull;
            }

            // First step: Filtering data by Loại Tìm Kiếm
            switch (LoaiTimKiemId)
            {
                // Tên
                case 1:
                    cuTrus = db.NguoiDungs
                        .Where(c => c.HoTen.Contains(TimKiem))
                        .SelectMany(x => x.CuTrus)
                        .Distinct();
                    break;
                // Nơi sinh
                case 2:
                    cuTrus = db.NguoiDungs
                        .Where(c => c.NoiSinh.Contains(TimKiem))
                        .SelectMany(x => x.CuTrus)
                        .Distinct();
                    break;
                // Quê quán
                case 3:
                    cuTrus = db.NguoiDungs
                        .Where(c => c.QueQuan.Contains(TimKiem))
                        .SelectMany(x => x.CuTrus)
                        .Distinct();
                    break;
                // Quốc tịch
                case 4:
                    cuTrus = db.NguoiDungs
                        .Where(c => c.QuocTich.Contains(TimKiem))
                        .SelectMany(x => x.CuTrus)
                        .Distinct();
                    break;
                // Địa chỉ cư trú
                case 5:
                    cuTrus = db.CuTrus.Where(c => (c.SoNha + " " + c.Duong + " " + c.Phuong + " " + c.Quan + " " + c.ThanhPho).Contains(TimKiem.Trim()));
                    break;
                // Địa chỉ dân
                case 6:
                    cuTrus = db.NguoiDungs
                        .Where(c => (c.SoNha + " " + c.Duong + " " + c.Phuong + " " + c.Quan + " " + c.ThanhPho).Contains(TimKiem.Trim()))
                        .SelectMany(x => x.CuTrus)
                        .Distinct();
                    break;

                default:
                    cuTrus = db.CuTrus;
                    break;
            }

            TimKiemIsNull:
            // Filtering data by Loại cư trú
            switch (LoaiCuTruId)
            {
                case 1:
                    // Not touching
                    break;
                case 2:
                    cuTrus = cuTrus.Where(c => c.LoaiCuTruId == 1);
                    break;
                case 3:
                    cuTrus = cuTrus.Where(c => c.LoaiCuTruId == 2);
                    break;
            }

            // Filtering data by Loại trạng thái
            switch (LoaiTrangThaiId)
            {
                case 1:
                    // Not touching
                    break;
                case 2:
                    // Đã duyệt
                    cuTrus = cuTrus.Where(c => c.DaDuyet == true);
                    break;
                case 3:
                    // Chưa duyệt
                    cuTrus = cuTrus.Where(c => c.DaDuyet == false);
                    break;
            }

            // Filtering data by Loại thời hạn
            switch (LoaiHanId)
            {
                case 1:
                    // Not touching
                    break;
                case 2:
                    // Còn hạn
                    cuTrus = cuTrus.Where(c => DateTime.Compare(c.NgayHetHan, DateTime.Now) > 0);
                    break;
                case 3:
                    // Hết hạn
                    cuTrus = cuTrus.Where(c => DateTime.Compare(c.NgayHetHan, DateTime.Now) < 0);
                    break;
            }

            return cuTrus;
        }

        // GET: CanBo/QuanLyCuTru
        [Route("")]
        public ActionResult Index(byte? LoaiTimKiemId, byte? LoaiCuTruId, byte? LoaiTrangThaiId, byte? LoaiHanId, string TimKiem)
        {
            // Get CuTru list
            IEnumerable<CuTru> cuTrus = SearchCuTru(LoaiTimKiemId,
                LoaiCuTruId,
                LoaiTrangThaiId,
                LoaiHanId,
                TimKiem);

            // Create TimCuTruViewModel based on params data
            var viewModel = new TimCuTruViewModel
            {
                CuTrus = cuTrus.ToList(),
                TimKiem = TimKiem,
                LoaiTimKiemId = LoaiTimKiemId,
                LoaiCuTruId = LoaiCuTruId,
                LoaiHanId = LoaiHanId,
                LoaiTrangThaiId = LoaiTrangThaiId
            };

            return View(viewModel);
        }

        // POST: CanBo/QuanLyCuTru
        [HttpPost]
        [Route("")]
        public ActionResult Index(TimCuTruViewModel viewModel)
        {
            byte? LoaiTimKiemId = viewModel.LoaiTimKiemId;
            byte? LoaiCuTruId = viewModel.LoaiCuTruId;
            byte? LoaiTrangThaiId = viewModel.LoaiTrangThaiId;
            byte? LoaiHanId = viewModel.LoaiHanId;
            string TimKiem = viewModel.TimKiem;

            viewModel.CuTrus = SearchCuTru(LoaiTimKiemId,
                LoaiCuTruId,
                LoaiTrangThaiId,
                LoaiHanId,
                TimKiem).ToList();

            return View(viewModel);
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

            // Create a new CuTru
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
                    // Non existent
                    ModelState.AddModelError("", "Thông tin công dân không hợp lệ");
                    return View(InitDangKyCuTruViewModel());
                }

                cuTru.CongDans.Add(congDan);
            }
         
            db.CuTrus.Add(cuTru);
            db.SaveChanges();
            return RedirectToAction("Index");
            
        }

        // GET: CanBo/QuanLyCuTru/Details/:id

        [Route("Details/{id}")]
        public ActionResult Details(int id)
        {
            var cuTru = db.CuTrus.Include(m => m.CongDans).SingleOrDefault(c => c.Id == id);

            if (cuTru == null)
                return HttpNotFound();

            return View(cuTru);
        }
    }
}