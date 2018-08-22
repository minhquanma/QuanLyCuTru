using QuanLyCuTru.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using System.Net;
using PagedList;
using PagedList.Mvc;
using System.IO;

namespace QuanLyCuTru.Controllers
{
    // This is a child route
    [Authorize(Roles = "Admin, CanhSatKhuVuc")]
    [RoutePrefix("CanBo/QuanLyDan")]
    public class QuanLyDanController : Controller
    {
        private ApplicationDbContext db;
        private static int pageNumber = 5;

        private string[] imageTypes = new string[]
            {
                "image/gif",
                "image/jpeg",
                "image/pjpeg",
                "image/png"
            };

        public QuanLyDanController()
        {
            db = new ApplicationDbContext();
            ViewBag.PageTitle = "Cán bộ";
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
   
        public IEnumerable<NguoiDung> SearchCongDan(byte? LoaiTimKiemId, byte? LoaiTaiKhoanId, byte? LoaiGioiTinhId, string TimKiem)
        {
            // Create a cong dan list reference
            IEnumerable<NguoiDung> congDans = null;

            if (TimKiem == null)
            {
                congDans = db.NguoiDungs;
                goto TimKiemIsNull;
            }

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
                case 5:
                    // Địa chỉ
                    congDans = db.NguoiDungs.Where(c => (c.SoNha + " " + c.Duong + " " + c.Phuong + " " + c.Quan + " " + c.ThanhPho).Contains(TimKiem));
                    break;
                default:
                    congDans = db.NguoiDungs;
                    break;
            }

            TimKiemIsNull:
            switch(LoaiTaiKhoanId)
            {
                case 1:
                    // Do nothing
                    break;
                case 2:
                    // Đã đăng ký
                    congDans = congDans.Where(d => d.IdentityId != null);
                    break;
                case 3:
                    // Chưa đăng ký
                    congDans = congDans.Where(d => d.IdentityId == null);
                    break;
            }

            switch (LoaiGioiTinhId)
            {
                case 1:
                    break;
                case 2:
                    congDans = congDans.Where(d => d.GioiTinh == 1);
                    break;
                case 3:
                    congDans = congDans.Where(d => d.GioiTinh == 0);
                    break;
            }
            return congDans;
        }

        // GET: CanBo/QuanLyDan
        [Route("")]
        public ActionResult Index(byte? LoaiTimKiemId, byte? LoaiTaiKhoanId, byte? LoaiGioiTinhId, string TimKiem, int? page)
        {
            // Get CongDan list
            IEnumerable<NguoiDung> congDans = SearchCongDan(LoaiTimKiemId, LoaiTaiKhoanId, LoaiGioiTinhId, TimKiem);
                
            var viewModel = new TimNguoiDungViewModel
            {
                CongDans = congDans.OrderBy(c => c.Id).ToPagedList(page ?? 1, pageNumber),
                TimKiem = TimKiem,
                LoaiTimKiemId = LoaiTimKiemId,
                LoaiTaiKhoanId = LoaiTaiKhoanId,
                LoaiGioiTinhId = LoaiGioiTinhId
            };

            return View(viewModel);
        }

        // POST: CanBo/QuanLyDan: used to search cong dan
        [Route("")]
        [HttpPost]
        public ActionResult Index(TimNguoiDungViewModel viewModel)
        {
            int? page = null;
            byte? LoaiTimKiemId = viewModel.LoaiTimKiemId;
            byte? LoaiTaiKhoanId = viewModel.LoaiTaiKhoanId;
            byte? LoaiGioiTinhId = viewModel.LoaiGioiTinhId;
            string TimKiem = viewModel.TimKiem;

            // Assign cong dan list to view model
            viewModel.CongDans = SearchCongDan(LoaiTimKiemId, LoaiTaiKhoanId, LoaiGioiTinhId, TimKiem).OrderBy(c => c.Id).ToPagedList(page ?? 1, pageNumber);
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
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            var nguoiDung = new AddCongDanViewModel
            {
                NguoiDung = new NguoiDung(),
                ChucVus = db.ChucVus.ToList()
            };

            return View(nguoiDung);
        }

        [HttpPost]
        [Route("Create")]
        [Authorize(Roles = "Admin")]
        public ActionResult Create(AddCongDanViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // Get user posted NguoiDung entity
                var congDan = viewModel.NguoiDung;

                if (viewModel.ImageFile != null && viewModel.ImageFile.ContentLength > 0)
                {
                    if (!imageTypes.Contains(viewModel.ImageFile.ContentType))
                    {
                        ModelState.AddModelError("ImageFile", "Định dạng ảnh không hợp lệ");
                        goto ModelStateIsNotValid;
                    }

                    int unixTimestamp = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                    var uploadDir = "/Content/avatar";
                    var imageExtension = Path.GetExtension(viewModel.ImageFile.FileName);
                    var imageName = unixTimestamp.ToString() + imageExtension;
                    var imagePath = Path.Combine(Server.MapPath(uploadDir), imageName);
                    var imageUrl = Path.Combine(uploadDir, imageName);

                    // Save to directory
                    viewModel.ImageFile.SaveAs(imagePath);
                   
                    congDan.Avatar = imageUrl;
                }
                db.NguoiDungs.Add(congDan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ModelStateIsNotValid:
            var view = new AddCongDanViewModel
            {
                NguoiDung = viewModel.NguoiDung,
                ChucVus = db.ChucVus.ToList()
            };

            return View(view);
        }

        [Route("Edit")]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NguoiDung nguoiDung = db.NguoiDungs.Include(m => m.ChucVu).FirstOrDefault(m => m.Id == id);
            var viewModel = new AddCongDanViewModel
            {
                NguoiDung = nguoiDung,
                ChucVus = db.ChucVus.ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        [Route("Edit")]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(AddCongDanViewModel viewModel)
        { 
            if (ModelState.IsValid)
            {
                // Get user posted NguoiDung entity
                var congDan = viewModel.NguoiDung;

                if (viewModel.ImageFile != null && viewModel.ImageFile.ContentLength > 0)
                {
                    if (!imageTypes.Contains(viewModel.ImageFile.ContentType))
                    {
                        ModelState.AddModelError("ImageFile", "Định dạng ảnh không hợp lệ");
                        goto ModelStateIsNotValid;
                    }

                    int unixTimestamp = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                    var uploadDir = "/Content/avatar";
                    var imageExtension = Path.GetExtension(viewModel.ImageFile.FileName);
                    var imageName = unixTimestamp.ToString() + imageExtension;
                    var imagePath = Path.Combine(Server.MapPath(uploadDir), imageName);
                    var imageUrl = Path.Combine(uploadDir, imageName);

                    // Save to directory
                    viewModel.ImageFile.SaveAs(imagePath);

                    // Assign new avatar url
                    congDan.Avatar = imageUrl;
                }

                db.Entry(congDan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ModelStateIsNotValid:
            var view = new AddCongDanViewModel
            {
                NguoiDung = viewModel.NguoiDung,
                ChucVus = db.ChucVus.ToList()
            };
            return View(view);
        }

        [Route("Delete")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NguoiDung nguoiDung = db.NguoiDungs.Include(m => m.ChucVu).FirstOrDefault(m => m.Id == id);
            if (nguoiDung == null)
            {
                return HttpNotFound();
            }
            return View(nguoiDung);
        }

        [Route("Delete")]
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(NguoiDung viewModel)
        {
            var nguoiDung = db.NguoiDungs.Find(viewModel.Id);
            db.NguoiDungs.Remove(nguoiDung);
            db.SaveChanges();
            return RedirectToAction("Index");
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