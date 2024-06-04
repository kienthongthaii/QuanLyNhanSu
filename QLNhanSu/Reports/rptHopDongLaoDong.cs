using BusinessLayer.DTO;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLNhanSu.Reports
{
    public partial class rptHopDongLaoDong : DevExpress.XtraReports.UI.XtraReport
    {
        public rptHopDongLaoDong()
        {
            InitializeComponent();
        }
        
        public rptHopDongLaoDong(List<HopDong_DTO> lstHD)
        {
            InitializeComponent();
            this._lstHD = lstHD;
            this.DataSource = _lstHD;
            loadData();

        }
        List<HopDong_DTO> _lstHD;   
        void loadData()
        {
            lbSoHD.DataBindings.Add("Text", _lstHD, "SoHD");
        }
    }
}
