using QuanLyCuTru.DTOs;
using QuanLyCuTru_WinForm.BindingSources;
using QuanLyCuTru_WinForm.Models;
using QuanLyCuTru_WinForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuTru_WinForm
{
    public partial class FormPrint : Form
    {
        public CuTruDTO _CuTru { get; set; }
        public NguoiDungDTO _nguoiDungs { get; set; }           
        public void LoadCuTruData()
        {

            rptChiTietCuTru.SetParameterValue("pMaSo", _CuTru.Id.ToString());
            rptChiTietCuTru.SetParameterValue("pDiaChi", _CuTru.DiaChi);
            rptChiTietCuTru.SetParameterValue("pLoaiCuTru", _CuTru.LoaiCuTru);
            rptChiTietCuTru.SetParameterValue("pNgayTao", _CuTru.NgayTao.ToShortDateString());
            rptChiTietCuTru.SetParameterValue("pEmail", _CuTru.Email);
            rptChiTietCuTru.SetParameterValue("pDienThoai", _CuTru.DienThoai);
            rptChiTietCuTru.SetParameterValue("pName", _CuTru.CanBoDuyet);
            rptChiTietCuTru.SetParameterValue("pNgayDangKy", _CuTru.NgayDangKy);
            rptChiTietCuTru.SetParameterValue("pNgayHetHan", _CuTru.NgayHetHan);
            crystalReportViewer.ReportSource = rptChiTietCuTru;
            crystalReportViewer.Refresh();
        }
        public void LoadCongDanData()
        {
            string _GioiTinh;

            if (_nguoiDungs.GioiTinh == true)
            {
                _GioiTinh = "Nam";
            }
            else
            {
                _GioiTinh = "Nữ";
            }
            rptChiTietCongDan.SetParameterValue("pMaSo", _nguoiDungs.Id);
            rptChiTietCongDan.SetParameterValue("pName", _nguoiDungs.HoTen);
            rptChiTietCongDan.SetParameterValue("pNamSinh", _nguoiDungs.SinhNhat);
            rptChiTietCongDan.SetParameterValue("pDiaChi", _nguoiDungs.DiaChi);
            rptChiTietCongDan.SetParameterValue("pGioiTinh", _GioiTinh);
            rptChiTietCongDan.SetParameterValue("pQuocTich", _nguoiDungs.QuocTich);
            rptChiTietCongDan.SetParameterValue("pQueQuan", _nguoiDungs.QueQuan);      
                crystalReportViewer.ReportSource = rptChiTietCongDan;
                crystalReportViewer.Refresh();
        }
        public FormPrint()
        {
            InitializeComponent();
        }
        public FormPrint(NguoiDungDTO nguoiDungs)
        {

            _nguoiDungs = nguoiDungs;
            InitializeComponent();
        }
        public FormPrint(CuTruDTO CuTru)
        {
            _CuTru = CuTru;
            InitializeComponent();
            RptChiTietCuTru cr = new RptChiTietCuTru();
            crystalReportViewer.ReportSource = cr;
            rptChiTietCuTru.SetDataSource(_CuTru.CongDans);
        }
        private void crystalReportViewer_Load(object sender, EventArgs e)
        {
            if(_CuTru!=null)
            {
                LoadCuTruData();
            }
            if (_nguoiDungs != null)
            {
                LoadCongDanData();
            }

        }
    }
}
