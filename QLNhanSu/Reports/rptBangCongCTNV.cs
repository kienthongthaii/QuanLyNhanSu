using DataLayer;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLNhanSu.Reports
{
    public partial class rptBangCongCTNV : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBangCongCTNV()
        {
            InitializeComponent();
        }
        public List<tb_BangCong_NV_CT> _bcct;
        public rptBangCongCTNV(List<tb_BangCong_NV_CT> bcct)
        {
            InitializeComponent();
            this._bcct = bcct;
            this.DataSource = this._bcct;
            BindingData();
            
        }
        void BindingData()
        {
            lbl_ID_NV.DataBindings.Add("Text", DataSource, "ID_NV");
            lblHOTEN.DataBindings.Add("Text", DataSource, "HOTEN");
            lblNGAY.DataBindings.Add("Text", DataSource, "NGAY");
            lblTHU.DataBindings.Add("Text", DataSource, "THU");
            lblGIOVAO.DataBindings.Add("Text", DataSource, "GIOVAO");
            lblGIORA.DataBindings.Add("Text", DataSource, "GIORA");
            lblCONGNGAYLE.DataBindings.Add("Text", DataSource, "CONGNGAYLE");
            lblNGAYPHEP.DataBindings.Add("Text", DataSource, "NGAYPHEP");
            lblCHUNHAT.DataBindings.Add("Text", DataSource, "CONGCHUNHAT");
            lblNGAYCONG.DataBindings.Add("Text", DataSource, "NGAYCONG");
            lblKYHIEU.DataBindings.Add("Text", DataSource, "KYHIEU");
            lblMAKYCONG.DataBindings.Add("Text", DataSource, "MAKYCONG");
            //lbl.DataBindings.Add("Text", DataSource, "D11");
        }
    }
}
