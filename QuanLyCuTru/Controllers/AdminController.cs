using QuanLyCuTru.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using System.Net;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System.Threading.Tasks;

namespace QuanLyCuTru.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        ApplicationDbContext db;

        public AdminController()
        {
            db = new ApplicationDbContext();
            ViewBag.PageTitle = "Admin";
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
            //var congDans = db.NguoiDungs.Include(m => m.ChucVu).ToList();
            //var viewModel = new TimNguoiDungViewModel
            //{
            //    CongDans = congDans
            //};
            return View();
        }

        // GET: Admin/ChiTietCongDan/id
        public ActionResult ChiTietCongDan(int id)
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

        public ActionResult XoaCongDan(int? id)
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

        [HttpPost, ActionName("XoaCongDan")]
        public ActionResult _XoaCongDan(int id)
        {
            var nguoiDung = db.NguoiDungs.Find(id);
            db.NguoiDungs.Remove(nguoiDung);
            db.SaveChanges();
            return RedirectToAction("CongDan");
        }
        // GET: Admin/ThemCongDan
        public ActionResult ThemCongDan()
        {
            var nguoiDung = new AddCongDanViewModel
            {
                NguoiDung = new NguoiDung(),
                ChucVus = db.ChucVus.ToList()
            };

            return View(nguoiDung);
        }

        // POST: Admin/ThemCongDan
        [HttpPost]
        public ActionResult ThemCongDan(NguoiDung nguoiDung)
        {
            if (ModelState.IsValid)
            {
                db.NguoiDungs.Add(nguoiDung);
                db.SaveChanges();
                return RedirectToAction("CongDan");
            }

            var viewModel = new AddCongDanViewModel
            {
                NguoiDung = nguoiDung,
                ChucVus = db.ChucVus.ToList()
            };

            return View(viewModel);
        }

        public ActionResult DangKyCongDan(int? id)
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

            var viewModel = new DangKyCongDanViewModel 
            {
                Id = nguoiDung.Id,
                HoTen = nguoiDung.HoTen,
                ChucVuId = nguoiDung.ChucVuId,
                ChucVu = nguoiDung.ChucVu.Ten
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DangKyCongDan(DangKyCongDanViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // Lấy thông tin chức vụ
                string roleName = "";

                if (viewModel.ChucVuId == ChucVu.Admin)
                    roleName = "Admin";
                else if (viewModel.ChucVuId == ChucVu.BaoVeDanPho)
                    roleName = "BaoVeDanPho";
                else if (viewModel.ChucVuId == ChucVu.CanhSatKhuVuc)
                    roleName = "CanhSatKhuVuc";
                else if (viewModel.ChucVuId == ChucVu.CongDan)
                    roleName = "CongDan";

                // Khởi tạo biến để thao tác với ASP.NET Identity
                var UserManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var SignInManager = HttpContext.GetOwinContext().Get<ApplicationSignInManager>();

                var user = new ApplicationUser { UserName = viewModel.Email, Email = viewModel.Email };
                var result = await UserManager.CreateAsync(user, viewModel.Password);

                if (result.Succeeded)
                {
                    // Thêm quyền cho người dùng
                    var roleresult = UserManager.AddToRole(user.Id, roleName);

                    // Thêm cột IdentityId cho người dùng
                    var nguoiDung = db.NguoiDungs.Find(viewModel.Id);
                    nguoiDung.IdentityId = user.Id;
                    db.SaveChanges();

                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

                    // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                    // Send an email with this link
                    // string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
                    // var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
                    // await UserManager.SendEmailAsync(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>");


                    return RedirectToAction("Index", "Admin");
                }
                AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            return View(viewModel);
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        public ActionResult QuyenHan()
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>());
            var roles = roleManager.Roles.ToList();

            QuyenHanViewModel viewModel = new QuyenHanViewModel
            {
                IdentityRoles = roles
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult ThemQuyenHan(QuyenHanViewModel viewModel)
        {
            // Create role
            if (!ModelState.IsValid)
                return View("QuyenHan");

            var roleName = viewModel.RoleName;
            var roleStore = new RoleStore<IdentityRole>(new ApplicationDbContext());
            var roleManager = new RoleManager<IdentityRole>(roleStore);
            var roleCanBo = new IdentityRole(roleName);

            roleManager.Create(roleCanBo);

            return RedirectToAction("QuyenHan");
        }
    }
}