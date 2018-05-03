using Microsoft.AspNet.Identity;
using QuanLyCuTru.Models;
using System;
using System.Data.Entity;
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

                // Get current logged in user profile based on Uid
                NguoiDung nguoiDung = db.NguoiDungs.Include(c => c.ChucVu).FirstOrDefault(u => u.IdentityId.Contains(uid));

                // If the current logged in user is CongDan
                if (User.IsInRole("CongDan"))
                    return PartialView("_NavBarUser", nguoiDung);

                return PartialView("_NavBar", nguoiDung);
            }
            return PartialView("_NavBar");
        }
    }
}