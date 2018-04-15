using Microsoft.AspNet.Identity;
using QuanLyCuTru.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyCuTru.Controllers
{
    public class NavbarController : Controller
    {
        private ApplicationDbContext db;

        public NavbarController()
        {
            db = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }

        // GET: Navbar
        public ActionResult Index(string pageTitle)
        {
            ViewBag.PageTitle = pageTitle;

            if (User.Identity.IsAuthenticated)
            {
                string uid = User.Identity.GetUserId();
                NguoiDung nguoiDung = db.NguoiDungs.SingleOrDefault(u => u.IdentityId.Contains(uid));

                return PartialView("_NavBar", nguoiDung);
            }
            return PartialView("_NavBar");
        }
    }
}