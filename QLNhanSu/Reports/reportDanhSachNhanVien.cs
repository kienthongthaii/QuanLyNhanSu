using BusinessLayer.DTO;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLNhanSu.Reports
{
    public partial class reportDanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public reportDanhSachNhanVien()
        {
            InitializeComponent();
        }
        List<NhanVien_DTO> _lstNhanVien;
        public reportDanhSachNhanVien(List<NhanVien_DTO> lstNhanVien)
        {
            InitializeComponent();
            this._lstNhanVien = lstNhanVien;
            this.DataSource = _lstNhanVien;
            LoadData();
        }
        void LoadData()
        {
            lbID_NV.DataBindings.Add("Text", _lstNhanVien, "ID_NV");
            lbTenNV.DataBindings.Add("Text", _lstNhanVien, "Ten");
            lbGioiTinh.DataBindings.Add("Text", _lstNhanVien, "GioiTinh");
            lbNgaySinh.DataBindings.Add("Text", _lstNhanVien, "NgaySinh");
            lbNgayLam.DataBindings.Add("Text", _lstNhanVien, "NgayLam");
            lbDienThoai.DataBindings.Add("Text", _lstNhanVien, "DienThoai");
            lbDiaChi.DataBindings.Add("Text", _lstNhanVien, "DiaChi");
            lbEmail.DataBindings.Add("Text", _lstNhanVien, "Email");
            lbCCCD.DataBindings.Add("Text", _lstNhanVien, "CCCD");
            lbPhongBan.DataBindings.Add("Text", _lstNhanVien, "TenPB");
            lbChucVu.DataBindings.Add("Text", _lstNhanVien, "TenCV");
            lbBoPhan.DataBindings.Add("Text", _lstNhanVien, "TenBP");
            lbTrinhDo.DataBindings.Add("Text", _lstNhanVien, "TenTD");
            lbDanToc.DataBindings.Add("Text", _lstNhanVien, "TenDT");
            lbTonGiao.DataBindings.Add("Text", _lstNhanVien, "TenTG");
            

        }

    }
}
