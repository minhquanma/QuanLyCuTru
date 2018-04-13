using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyCuTru.Models
{
    public class DangKyCuTruViewModel
    {
        [Display(Name = "Ngày tạo")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayTao { get; set; }

        [Required(ErrorMessage = "Ngày đăng ký không được để trống")]
        [Display(Name = "Ngày đăng ký")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayDangKy { get; set; }

        [Display(Name = "Ngày hết hạn")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
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

        [Display(Name = "Loại cư trú")]
        public IEnumerable<LoaiCuTru> LoaiCuTru { get; set; }

        // Cán bộ duyệt (many-to-1)
        [Display(Name = "Cán bộ kiểm duyệt")]
        public int? CanBoId { get; set; }
        public NguoiDung CanBo { get; set; }

        [Display(Name = "Danh sách công dân")]
        public List<int> CongDans { get; set; }

        public DangKyCuTruViewModel()
        {
            NgayTao = DateTime.Now;
            NgayDangKy = DateTime.Now;
            NgayHetHan = DateTime.Now.AddMonths(1);
        }
    }
}