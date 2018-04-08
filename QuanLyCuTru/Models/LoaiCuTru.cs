using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyCuTru.Models
{
    public class LoaiCuTru
    {
        public int Id { get; set; }
        public string Ten { get; set; }

        // Các thông tin cư trú thuộc loại cư trú này (1-to-many)
        public ICollection<CuTru> CuTrus { get; set; }
    }
}