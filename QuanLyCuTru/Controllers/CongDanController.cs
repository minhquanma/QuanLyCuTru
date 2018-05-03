using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLyCuTru;
using System.Web.Security;
using QuanLyCuTru.Models;
using Microsoft.AspNet.Identity;
using System.Collections.ObjectModel;

namespace QuanLyCuTru.Controllers
{
    [Authorize]
    public class CongDanController : Controller
    {
        private ApplicationDbContext db;

        public CongDanController()
        {
            db = new ApplicationDbContext();
        }

        public DangKyCuTruViewModel InitDangKyCuTruViewModel()
        {
            // Lay thong tin dang nhap hien tai cua user
            var currentId = User.Identity.GetUserId();
            var nguoiDung = db.NguoiDungs.SingleOrDefault(s => s.IdentityId.Contains(currentId));
         
            var cuTru = new DangKyCuTruViewModel
            {
                Email = nguoiDung.Email,
                DienThoai = nguoiDung.DienThoai,
                LoaiCuTru = db.LoaiCuTrus,
                CongDans = new List<int>()
            };

            return cuTru;
        }

        // GET: CongDan
        public ActionResult Index()
        {
            // Get all CuTru entity created by me
            var currentId = User.Identity.GetUserId();
            var nguoiDung = db.NguoiDungs.SingleOrDefault(s => s.IdentityId.Contains(currentId));

            var cuTrus = db.CuTrus.Where(c => c.Email.Contains(nguoiDung.Email));
            return View(cuTrus);
        }

        // GET: CongDan/Create
        public ActionResult Create()
        {
            var cuTru = InitDangKyCuTruViewModel();

            return View(cuTru);
        }

        // POST: CongDan/Create
        [HttpPost]
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
                DaDuyet = false,
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

        // GET: CongDan/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var congDan = db.NguoiDungs.Find(id);
            if (congDan == null)
            {
                return HttpNotFound();
            }
            return View(congDan);
        }

        //// GET: CongDan/Create
        //public ActionResult Create()
        //{
        //    //ViewBag.MaCongDan = new SelectList(db.DangNhapCongDans, "MaCongDan", "TaiKhoan");
        //    //ViewBag.MaCongDan = new SelectList(db.DiaChiDans, "MaCongDan", "SoNha");
        //    return View();
        //}

        //// POST: CongDan/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "MaCongDan,HoTen,GioiTinh,SinhNhat,NoiSinh,QueQuan,QuocTich,Avatar")] CongDan congDan)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.CongDans.Add(congDan);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }


        //    return View(congDan);
        //}

        //// GET: CongDan/Edit/5
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

        //// POST: CongDan/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        ////[Bind(Include = "MaCongDan,HoTen,GioiTinh,SinhNhat,NoiSinh,QueQuan,QuocTich,Avatar")] 
        //public ActionResult Edit(CongDan congDan)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(congDan).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(congDan);
        //}

        //// GET: CongDan/Delete/5
        //public ActionResult Delete(int? id)
        //{
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //CongDan congDan = db.CongDans.Find(id);
            //if (congDan == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(congDan);
        //}

//// POST: CongDan/Delete/5
//[HttpPost, ActionName("Delete")]
//[ValidateAntiForgeryToken]
//public ActionResult DeleteConfirmed(int id)
//{
//    CongDan congDan = db.CongDans.Find(id);
//    db.CongDans.Remove(congDan);
//    db.SaveChanges();
//    return RedirectToAction("Index");
//}

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
