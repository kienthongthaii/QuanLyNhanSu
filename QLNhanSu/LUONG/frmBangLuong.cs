using BusinessLayer.TINHLUONG_BL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhanSu.Reports;
using DevExpress.XtraReports.UI;
using DataLayer;

namespace QLNhanSu.LUONG
{
    public partial class frmBangLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmBangLuong()
        {
            InitializeComponent();
        }
        BangLuong _bangLuong;
        List<tb_BangLuong> _lstBangLuong;
        string _namKy;
        private void loadThang()
        {
            for (int i = 1; i <= 12; i++)
            {
                cboThang.Items.Add(i);
            }
            cboThang.SelectedItem = DateTime.Now.Month;
        }
        private void loadNam(int namDau, int namCuoi)
        {
            cboNam.Items.Clear();
            for (int i = namDau; i <= namCuoi; i++)
            {
                cboNam.Items.Add(i);
            }
            cboNam.SelectedItem = DateTime.Now.Year;

        }
        void loadData()
        {
            gcDanhSach.DataSource = _bangLuong.getList(cboNam.Text  + cboThang.Text);
            gvDanhSach.OptionsBehavior.Editable = false;
            _lstBangLuong = _bangLuong.getList(cboNam.Text +cboThang.Text);
            _namKy = cboNam.Text + cboThang.Text;


        }
        private void btnXemBangLuong_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void frmBangLuong_Load(object sender, EventArgs e)
        {
            _bangLuong = new BangLuong();
            loadNam(1950, 2050);
            loadThang();
            loadData();
        }

        private void btnTinhLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _bangLuong.tinhLuongNhanVien(cboNam.Text + cboThang.Text);
            loadData();
            
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptBangLuong rpt = new rptBangLuong(_lstBangLuong,_namKy);
            rpt.ShowPreviewDialog();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}