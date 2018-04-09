using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyCuTru.Models
{
    public class CuTru
    {
        public int Id { get; set; }

        [Display(Name = "Ngày tạo")]
        public DateTime NgayTao { get; set; }

        [Required(ErrorMessage = "Ngày đăng ký không được để trống")]
        [Display(Name = "Ngày đăng ký")]
        public DateTime NgayDangKy { get; set; }

        [Display(Name = "Ngày hết hạn")]
        public DateTime? NgayHetHan { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Điện thoại không được để trống")]
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

        [Display(Name = "Đã duyệt")]
        public bool DaDuyet { get; set; }

        // Loại cư trú (many-to-1)
        [Display(Name = "Loại cư trú")]
        public int LoaiCuTruId { get; set; }
        public virtual LoaiCuTru LoaiCuTru { get; set; }

        // Cán bộ duyệt (many-to-1)
        [Display(Name = "Cán bộ kiểm duyệt")]
        public int? CanBoId { get; set; }
        public virtual NguoiDung CanBo { get; set; }

        // Danh sách công dân (many-to-many)
        public virtual ICollection<NguoiDung> CongDans { get; set; }

        public CuTru()
        {
            DaDuyet = false;
        }
    }
}
