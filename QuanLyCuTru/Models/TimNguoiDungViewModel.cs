 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyCuTru.Models
{
    public class TimNguoiDungViewModel
    {
        public byte? LoaiTimKiemId { get; set; }
        public IEnumerable<LoaiTimKiem> LoaiTimKiems
        {
            get
            {
                return new List<LoaiTimKiem>
                {
                    new LoaiTimKiem(1, "Tên"),
                    new LoaiTimKiem(2, "Nơi sinh"),
                    new LoaiTimKiem(3, "Quê quán"),
                    new LoaiTimKiem(4, "Quốc tịch"),
                    new LoaiTimKiem(5, "Địa chỉ")
                };
            }
        }

        public byte? LoaiTaiKhoanId { get; set; }
        public IEnumerable<LoaiTimKiem> LoaiTaiKhoans
        {
            get
            {
                return new List<LoaiTimKiem>
                {
                    new LoaiTimKiem(1, "Tất cả"),
                    new LoaiTimKiem(2, "Đã đăng ký"),
                    new LoaiTimKiem(3, "Chưa đăng ký")
                };
            }
        }

        public byte? LoaiGioiTinhId { get; set; }
        public IEnumerable<LoaiTimKiem> LoaiGioiTinhs
        {
            get
            {
                return new List<LoaiTimKiem>
                {
                    new LoaiTimKiem(1, "Tất cả"),
                    new LoaiTimKiem(2, "Nam"),
                    new LoaiTimKiem(3, "Nữ")
                };
            }
        }

        public List<NguoiDung> CongDans { get; set; }
        [Required]
        public string TimKiem { get; set; }
    }
}