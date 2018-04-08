using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyCuTru
{
    public static class ThongTin
    {
        public enum LoaiCuTru
        {
            TamTru = 1, TamVang = 2
        };

        public enum ChucVu
        {
            Admin = 1,
            CanhSatKhuVuc = 2,
            BaoVeDanPho = 3,
            CongDan = 4
        };
    }
}