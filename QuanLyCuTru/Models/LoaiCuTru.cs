using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyCuTru.Models
{
    public class LoaiCuTru
    {
        [Display(Name = "Loại cư trú")]
        public int Id { get; set; }

        [Display(Name = "Loại cư trú")]
        public string Ten { get; set; }

        // Các thông tin cư trú thuộc loại cư trú này (1-to-many)
        public ICollection<CuTru> CuTrus { get; set; }
    }
}