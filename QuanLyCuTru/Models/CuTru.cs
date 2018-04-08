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

        [Display(Name = "Ngày tạo")]
        public DateTime NgayDangKy { get; set; }

        [Display(Name = "Ngày hết hạn")]
        public DateTime? NgayHetHan { get; set; }

        [Display(Name = "Số nhà")]
        public string SoNha { get; set; }

        [Display(Name = "Đường")]
        public string Duong { get; set; }

        [Display(Name = "Phường")]
        public string Phuong { get; set; }

        [Display(Name = "Quận")]
        public string Quan { get; set; }

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
    }
}
