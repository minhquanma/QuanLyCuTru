using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyCuTru.Models
{
    public class DangKyCongDanViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Họ tên")]
        public string HoTen { get; set; }

        [Display(Name = "Chức vụ")]
        public int ChucVuId { get; set; }

        [Display(Name = "Chức vụ")]
        public string ChucVu { get; set; }

        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [StringLength(100, ErrorMessage = "{0} phải có ít nhất {2} ký tự.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Xác nhận mật khẩu")]
        [Compare("Password", ErrorMessage = "Mật khẩu xác nhận không trùng khớp")]
        public string ConfirmPassword { get; set; }
    }
}