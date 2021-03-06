﻿using PagedList;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyCuTru.Models
{
    public class TimCuTruViewModel
    {
        // DropDownList Loại Tìm Kiếm
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
                    new LoaiTimKiem(5, "Địa chỉ cư trú"),
                    new LoaiTimKiem(6, "Địa chỉ công dân")
                };
            }
        }

        // DropDownList Loại Cư Trú
        public byte? LoaiCuTruId { get; set; }
        public IEnumerable<LoaiTimKiem> LoaiCuTrus
        {
            get
            {
                return new List<LoaiTimKiem>
                {
                    new LoaiTimKiem(1, "Tất cả"),
                    new LoaiTimKiem(2, "Tạm vắng"),
                    new LoaiTimKiem(3, "Tạm trú")
                };
            }
        }

        // DropDownList Hạn cu trú
        public byte? LoaiHanId { get; set; }
        public IEnumerable<LoaiTimKiem> LoaiHans
        {
            get
            {
                return new List<LoaiTimKiem>
                {
                    new LoaiTimKiem(1, "Tất cả"),
                    new LoaiTimKiem(2, "Còn hạn"),
                    new LoaiTimKiem(3, "Hết hạn")
                };
            }
        }

        // DropDownList Trạng thái 
        public byte? LoaiTrangThaiId { get; set; }
        public IEnumerable<LoaiTimKiem> LoaiTrangThais
        {
            get
            {
                return new List<LoaiTimKiem>
                {
                    new LoaiTimKiem(1, "Tất cả"),
                    new LoaiTimKiem(2, "Đã duyệt"),
                    new LoaiTimKiem(3, "Chưa duyệt")
                };
            }
        }
        public IPagedList<CuTru> CuTrus { get; set; }

        [Required]
        public string TimKiem { get; set; }
    }
}