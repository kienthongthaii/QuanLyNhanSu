using BusinessLayer;
using BusinessLayer.CHAMCONG_BL;
using BusinessLayer.DTO;
using DataLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using QLNhanSu.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.CHAMCONG
{
    public partial class frmBangCongCT : DevExpress.XtraEditors.XtraForm
    {
        public frmBangCongCT()
        {
            InitializeComponent();
        }
        NhanVien _nhanVien;
        BangCong_NV_CT _bcct;
        
        private void frmBangCongCT_Load(object sender, EventArgs e)
        {
            _nhanVien = new NhanVien();
            _bcct = new BangCong_NV_CT();
            loadNhanVien();
            cboKyCong.SelectedIndex = DateTime.Now.Month-1;
        }
        
        void loadNhanVien()
        {
            cboNhanVien.DataSource = _nhanVien.getlist();
            cboNhanVien.DisplayMember = "Ten";
            cboNhanVien.ValueMember = "ID_NV";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
           
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click_1(object sender, EventArgs e)
        {
            var lst = _bcct.getBangCongCT(DateTime.Now.Year + cboKyCong.Text, cboNhanVien.SelectedValue.ToString());
            rptBangCongCTNV rpt = new rptBangCongCTNV(lst);
            rpt.ShowPreviewDialog();
        }
    }
}