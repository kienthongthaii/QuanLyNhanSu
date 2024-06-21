using DataLayer;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLNhanSu.Reports
{
    public partial class rptBangLuong : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBangLuong()
        {
            InitializeComponent();
        }
        List<tb_BangLuong> _lst;
        string _namKy;
        public rptBangLuong(List<tb_BangLuong> _lstBanLuong , string namKy)
        {
            InitializeComponent();
            this._lst= _lstBanLuong;
            this._namKy= namKy;
            lblThangNam.Text = "Tháng "+_namKy.ToString().Substring(4)+" Năm "+ _namKy.ToString().Substring(0,4);
            this.DataSource = _lst;
            loadData();
        }
        void loadData()
        {
            lblID_NV.DataBindings.Add("Text", DataSource, "ID_NV");
            lblHoTen.DataBindings.Add("Text", DataSource, "HoTen");
            lblNgayCong.DataBindings.Add("Text", DataSource, "NgayCong");
            lblNgayLe.DataBindings.Add("Text", DataSource, "NgayLe");
            lblNgayPhep.DataBindings.Add("Text", DataSource, "NgayPhep");
            lblNgayKhongPhep.DataBindings.Add("Text", DataSource, "NgayKhongPhep");
            lblNgayChuNhat.DataBindings.Add("Text", DataSource, "NgayChuNhat");
            lblNgayThuong.DataBindings.Add("Text", DataSource, "NgayThuong");
            lblTangCa.DataBindings.Add("Text", DataSource, "TangCa");
            lblPhuCap.DataBindings.Add("Text", DataSource, "PhuCap");
            lblUngLuong.DataBindings.Add("Text", DataSource, "UngLuong");
            lblThucLanh.DataBindings.Add("Text", DataSource, "ThucLanh");

        }

    }
}
