using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyCuTru.Models
{
    public class QuyenHanViewModel
    {
        public string RoleName { get; set; }
        public List<IdentityRole> IdentityRoles { get; set; }
    }
}