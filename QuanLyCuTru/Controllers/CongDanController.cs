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

namespace QuanLyCuTru.Controllers
{
    public class CongDanController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CongDan
        public ActionResult Index()
        {
            var cuTrus = db.CuTrus;
            return View(cuTrus);
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
