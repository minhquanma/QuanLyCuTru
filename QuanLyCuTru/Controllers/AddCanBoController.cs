using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLyCuTru;
using QuanLyCuTru.Models;

namespace QuanLyCuTru.Controllers
{
    public class AddCanBoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: AddCanBo
        public ActionResult Index()
        {
            var canBoes = db.NguoiDungs.Include(c => c.ChucVu);
            return View(canBoes.ToList());
        }

        // GET: AddCanBo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var canBo = db.NguoiDungs.Find(id);
            if (canBo == null)
            {
                return HttpNotFound();
            }
            return View(canBo);
        }

        //// GET: AddCanBo/Create
        //public ActionResult Create()
        //{
        //    ViewBag.MaChucVu = new SelectList(db.ChucVus, "MaChucVu", "TenChucVu");
        //    return View();
        //}

        //// POST: AddCanBo/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(NguoiDung canBo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.NguoiDungs.Add(canBo);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.MaChucVu = new SelectList(db.ChucVus, "MaChucVu", "TenChucVu", canBo.Id);
        //    return View(canBo);
        //}

        //// GET: AddCanBo/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    var canBo = db.NguoiDungs.Find(id);
        //    if (canBo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.MaChucVu = new SelectList(db.ChucVus, "MaChucVu", "TenChucVu", canBo.MaChucVu);
        //    return View(canBo);
        //}

        //// POST: AddCanBo/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "MaCanBo,HoTen,GioiTinh,SinhNhat,MaChucVu,Avatar,TaiKhoan,MatKhau,Email")] CanBo canBo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(canBo).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.MaChucVu = new SelectList(db.ChucVus, "MaChucVu", "TenChucVu", canBo.MaChucVu);
        //    return View(canBo);
        //}

        //// GET: AddCanBo/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    var canBo = db..Find(id);
        //    if (canBo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(canBo);
        //}

        //// POST: AddCanBo/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    var canBo = db.CanBoes.Find(id);
        //    db.CanBoes.Remove(canBo);
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
