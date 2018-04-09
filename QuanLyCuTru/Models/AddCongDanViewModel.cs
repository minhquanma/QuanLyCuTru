using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyCuTru.Models
{
    public class AddCongDanViewModel
    {
        public NguoiDung NguoiDung { get; set; }
        public IEnumerable<ChucVu> ChucVus { get; set; }
    }
}