﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyCuTru.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();  
        }

        // GET: Admin/CongDan
        public ActionResult CongDan()
        {
            return View();
        }
    }
}