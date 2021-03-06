﻿using QuanLyCuTru.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace QuanLyCuTru.DTOs
{
    public class CuTruDTO
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayTao { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayDangKy { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayHetHan { get; set; }

        public string Email { get; set; }

        [Required]
        public string DienThoai { get; set; }

        [Required]
        public string SoNha { get; set; }

        [Required]
        public string Duong { get; set; }

        [Required]
        public string Phuong { get; set; }

        [Required]
        public string Quan { get; set; }

        [Required]
        public string ThanhPho { get; set; }

        public bool DaDuyet { get; set; }
        public string TrangThai => DaDuyet ? "Đã duyệt" : "Chưa duyệt";

        public int LoaiCuTruId { get; set; }
        public string LoaiCuTru { get; set; }

        public int? CanBoId { get; set; }
        public string CanBoDuyet { get; set; }

        // Chứa danh sách Id Công Dân dùng để gửi dữ liệu lên server.
        public List<int> CongDanIds { get; set; }

        // Chứa danh sách Công Dân dùng để gửi dữ liệu cho client.
        public virtual ICollection<NguoiDungDTO> CongDans { get; set; }

        public string DiaChi
        {
            get { return $"{SoNha} {Duong}, Phường {Phuong}, Quận {Quan}, {ThanhPho}"; }
        }

        public int ThoiHan
        {
            get
            {
                // Calculate remaining valid day
                int remainingDays = NgayHetHan.Subtract(NgayDangKy).Days;

                return remainingDays;
            }
        }
    }
}