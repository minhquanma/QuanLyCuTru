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
        [Display(Name = "Mã số")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Họ tên không được để trống")]
        [Display(Name = "Họ tên")]
        public string HoTen { get; set; }

        [Required]
        [Display(Name = "Giới tính")]
        public bool GioiTinh { get; set; }

        [Required(ErrorMessage = "Sinh nhật không được để trống")]
        [Display(Name = "Sinh nhật")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? SinhNhat { get; set; }

        // Chức vụ (many-to-1)
        [Display(Name = "Chức vụ")]
        public int ChucVuId { get; set; }

        [Display(Name = "Chức vụ")]
        public ChucVu ChucVu { get; set; }

        [Display(Name = "Điện thoại")]
        public string DienThoai { get; set; }

        [Required(ErrorMessage = "Số nhà không được để trống")]
        [Display(Name = "Số nhà")]
        public string SoNha { get; set; }

        [Required(ErrorMessage = "Đường không được để trống")]
        [Display(Name = "Đường")]
        public string Duong { get; set; }

        [Required(ErrorMessage = "Phường không được để trống")]
        [Display(Name = "Phường")]
        public string Phuong { get; set; }

        [Required(ErrorMessage = "Quận không được để trống")]
        [Display(Name = "Quận")]
        public string Quan { get; set; }

        [Required(ErrorMessage = "Thành phố không được để trống")]
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

        [NotMapped]
        public bool HasEmail 
        {
            get 
            {
                /** Check user's registration email
                *  The user's email are stored in the AspNetUsers table
                *  If the user hasn't registered yet, the Identity object will be null
                **/
                try
                {
                    // try returning the Email, if it's not null => the user HasEmail
                    return Identity.Email != null ? true : false;
                }
                catch (NullReferenceException)
                {
                    // the operation fails when the user has no email (the Identity is null)
                    // when it throws NullReferenceException => return false 
                    return false;
                }
            }
        }

        [NotMapped]
        [Display(Name = "E-mail")]
        public string Email
        {
            get
            {
                return HasEmail ? Identity.Email : "Chưa đăng ký";
            }
        }

        [NotMapped]
        [Display(Name = "Địa chỉ")]
        public string DiaChi
        {
            get { return $"{SoNha} {Duong}, Phường {Phuong}, Quận {Quan}, {ThanhPho}"; }
        }

        [NotMapped]
        [Display(Name = "Giới tính")]
        public string StringGioiTinh
        {
            get { return GioiTinh ? "Nam" : "Nữ"; }
        }
    }
}