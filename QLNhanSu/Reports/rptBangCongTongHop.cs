using DataLayer;
using DevExpress.Office.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLNhanSu.Reports
{
    public partial class rptBangCongTongHop : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBangCongTongHop()
        {
            InitializeComponent();
        }
        public string title;
        List<tb_KyCongChiTiet> _lstKCCT;
        public rptBangCongTongHop(List<tb_KyCongChiTiet> lstKiCongChiTiet, string maKyCong)
        {
            InitializeComponent();
            this._lstKCCT = lstKiCongChiTiet;
            this.title = maKyCong;
            this.DataSource  = this._lstKCCT;
            BindData();
        }
        
        public void BindData()
        {
            lblTitle.Text = "BẢNG CÔNG TỔNG HỢP THÁNG " + title.Substring(4) +" NĂM "+title.Substring(0,4);
            ID.DataBindings.Add("Text", DataSource, "ID_NV");
            HOTEN.DataBindings.Add("Text", DataSource, "HoTen");
            //MACT.DataBindings.Add("Text", DataSource, "MACT");
            D1.DataBindings.Add("Text", DataSource, "D1");
            D2.DataBindings.Add("Text", DataSource, "D2");
            D3.DataBindings.Add("Text", DataSource, "D3");
            D4.DataBindings.Add("Text", DataSource, "D4");
            D5.DataBindings.Add("Text", DataSource, "D5");
            D6.DataBindings.Add("Text", DataSource, "D6");
            D7.DataBindings.Add("Text", DataSource, "D7");
            D8.DataBindings.Add("Text", DataSource, "D8");
            D9.DataBindings.Add("Text", DataSource, "D9");
            D10.DataBindings.Add("Text", DataSource, "D10");
            D11.DataBindings.Add("Text", DataSource, "D11");
            D12.DataBindings.Add("Text", DataSource, "D12");
            D13.DataBindings.Add("Text", DataSource, "D13");
            D14.DataBindings.Add("Text", DataSource, "D14");
            D15.DataBindings.Add("Text", DataSource, "D15");
            n16.DataBindings.Add("Text", DataSource, "D16");
            D17.DataBindings.Add("Text", DataSource, "D17");
            D18.DataBindings.Add("Text", DataSource, "D18");
            D19.DataBindings.Add("Text", DataSource, "D19");
            D20.DataBindings.Add("Text", DataSource, "D20");
            D21.DataBindings.Add("Text", DataSource, "D21");
            D22.DataBindings.Add("Text", DataSource, "D22");
            D23.DataBindings.Add("Text", DataSource, "D23");
            D24.DataBindings.Add("Text", DataSource, "D24");
            D25.DataBindings.Add("Text", DataSource, "D25");
            D26.DataBindings.Add("Text", DataSource, "D26");
            D27.DataBindings.Add("Text", DataSource, "D27");
            D28.DataBindings.Add("Text", DataSource, "D28");
            D29.DataBindings.Add("Text", DataSource, "D29");
            D30.DataBindings.Add("Text", DataSource, "D30");
            D31.DataBindings.Add("Text", DataSource, "D31");
            NGAYCONG.DataBindings.Add("Text", DataSource, "NgayCong");
            VANG.DataBindings.Add("Text", DataSource, "NghiKhongPhep");
            PHEP.DataBindings.Add("Text", DataSource, "NgayPhep");
            LE.DataBindings.Add("Text", DataSource, "CongNgayLe");
            CN.DataBindings.Add("Text", DataSource, "CongChuNhat");
            TONG.DataBindings.Add("Text", DataSource, "TongNgayCong");
        }

    }
}
