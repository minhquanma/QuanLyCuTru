using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyCuTru.Models
{
    public class ChucVu
    {
        [Display(Name = "Chức vụ")]
        public int Id { get; set; }

        [Display(Name = "Chức vụ")]
        public string Ten { get; set; }

        // 1-to-many
        public ICollection<NguoiDung> NguoiDungs { get; set; }

        public static readonly byte Admin = 1;
        public static readonly byte CanhSatKhuVuc = 2;
        public static readonly byte BaoVeDanPho = 3;
        public static readonly byte CongDan = 4;
    }
}