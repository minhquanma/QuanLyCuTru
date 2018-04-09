﻿using System;
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

        [Display(Name = "Điện thoại")]
        public string DienThoai { get; set; }

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

        // ASP.NET Identity: User's authentication data are stored here.
        [ForeignKey("Identity")]
        public string IdentityId { get; set; } 
        public virtual ApplicationUser Identity { get; set; }

        // Cu Tru data  
        public virtual ICollection<CuTru> CuTrus { get; set; }

        [NotMapped]
        [Display(Name = "E-mail")]
        public string Email
        {
            /** Check user's registration email
            *  The user's email are stored in the AspNetUsers table
            *  If the user hasn't registered yet, the Identity object will be null
            **/
            get
            {
                try
                {
                    return Identity.Email;
                } 
                catch (NullReferenceException)
                {
                    return "Chưa đăng ký";
                }
            }
        }

        [NotMapped]
        [Display(Name = "Địa chỉ")]
        public string DiaChi
        {
            get { return $"{SoNha} {Duong}, {Phuong}, {Quan}, {ThanhPho}"; }
        }

        [NotMapped]
        [Display(Name = "Giới tính")]
        public string StringGioiTinh
        {
            get { return GioiTinh ? "Nam" : "Nữ"; }
        }
    }
}