using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyCuTru.Models
{
    public class NguoiDung
    {
        // Primary Key
        public int Id { get; set; }

        [Required]
        [Display(Name = "Họ tên")]
        public string HoTen { get; set; }

        [Required]
        [Display(Name = "Giới tính")]
        public bool GioiTinh { get; set; }

        [Required]
        [Display(Name = "Sinh nhật")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? SinhNhat { get; set; }

        // Chức vụ (many-to-1)
        public int ChucVuId { get; set; }
        public ChucVu ChucVu { get; set; }

        [Required]
        [Display(Name = "Số nhà")]
        public string SoNha { get; set; }

        [Required]
        [Display(Name = "Đường")]
        public string Duong { get; set; }

        [Required]
        [Display(Name = "Phường")]
        public string Phuong { get; set; }

        [Required]
        [Display(Name = "Quận")]
        public string Quan { get; set; }

        [Required]
        [Display(Name = "Thành phố")]
        public string ThanhPho { get; set; }

        [Display(Name = "Nơi sinh")]
        public string NoiSinh { get; set; }

        [Display(Name = "Quê quán")]
        public string QueQuan { get; set; }

        [Display(Name = "Quốc tịch")]
        public string QuocTich { get; set; }

        public string Avatar { get; set; }

        // ASP.NET Identity: Lưu thông xác thực đăng nhập Identity
        [ForeignKey("Identity")]
        public string IdentityId { get; set; } 
        public virtual ApplicationUser Identity { get; set; }

        // Thông tin đăng ký cư trú 
        public virtual ICollection<CuTru> CuTrus { get; set; }
    }
}