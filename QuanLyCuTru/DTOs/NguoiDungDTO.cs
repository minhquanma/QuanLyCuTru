using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using QuanLyCuTru.Global;

namespace QuanLyCuTru.DTOs
{
    public class NguoiDungDTO
    {
        // Primary Key
        [Display(Name = "Mã số")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Họ tên không được để trống")]
        [Display(Name = "Họ tên")]
        public string HoTen { get; set; }

        [Required]
        [Display(Name = "Giới tính")]
        public short GioiTinh { get; set; }

        [Required(ErrorMessage = "Sinh nhật không được để trống")]
        [Display(Name = "Sinh nhật")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime SinhNhat { get; set; }

        // Chức vụ (many-to-1)
        [Display(Name = "Chức vụ")]
        public int ChucVuId { get; set; }

        [Display(Name = "Điện thoại")]
        public string DienThoai { get; set; }

        [Required(ErrorMessage = "Số nhà không được để trống")]
        [Display(Name = "Số nhà")]
        public string SoNha { get; set; }

        [Required(ErrorMessage = "Đường không được để trống")]
        [Display(Name = "Đường")]
        public string Duong { get; set; }

        [Required(ErrorMessage = "Phường không được để trống")]
        public string Phuong { get; set; }

        [Required(ErrorMessage = "Quận không được để trống")]
        public string Quan { get; set; }

        [Required(ErrorMessage = "Thành phố không được để trống")]
        public string ThanhPho { get; set; }

        public string NoiSinh { get; set; }

        public string QueQuan { get; set; }

        public string QuocTich { get; set; }

        public string Avatar { get; set; }

        public string Email { get; set; }

        public string DiaChi
        {
            get { return $"{SoNha} {Duong}, Phường {Phuong}, Quận {Quan}, {ThanhPho}"; }
        }

        public string StringGioiTinh
        {
            get
            {
                switch (GioiTinh)
                {
                    case Global.GioiTinh.Nam:
                        return "Nam";
                    case Global.GioiTinh.Nu:
                        return "Nữ";
                    default:
                        return "Không biết";
                }
            }
        }

        public int Tuoi
        {
            get { return DateTime.Now.Year - SinhNhat.Year; }
        }
    }
}