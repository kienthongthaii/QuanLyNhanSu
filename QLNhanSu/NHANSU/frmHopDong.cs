using DataLayer;
using BusinessLayer;
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
using BusinessLayer.DTO;

namespace QLNhanSu
{
    public partial class frmHopDong : DevExpress.XtraEditors.XtraForm
    {
        public frmHopDong()
        {
            InitializeComponent();
        }
        HopDongLaoDong _hdld;
        NhanVien _nhanvien;
        bool _add;
        string _soHD;
        bool _click;
        List<HopDong_DTO> _lstHD;
        void showHide(bool check)
        {
            btnLuu.Enabled = !check;
            btnHuy.Enabled = !check;
            btnThem.Enabled = check;
            btnSua.Enabled = check;
            btnXoa.Enabled = check;
            btnIn.Enabled = check;
            txtSoHD.Enabled = !check;
            dtNgayBatDau.Enabled = !check;
            dtNgayKetThuc.Enabled = !check;
            dtNgayKi.Enabled = !check;
            spLanKi.Enabled = !check;
            txtLuongThoaThuan.Enabled = !check;
            slkNhanVien.Enabled = !check;
            dtNgayKetThuc.Enabled= !check;

        }

        void LoadData()
        {
            gcDanhSach.DataSource = _hdld.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
           
        }
        void loadNV()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getlist();
            slkNhanVien.Properties.ValueMember = "ID_NV";
            slkNhanVien.Properties.DisplayMember = "Ten";
        }
        //Lưu dữ liệu thông qua Add hoặc Update
        void SaveData()
        {
            if (_add)
            {
                var soHDMAX = _hdld.soHopDongMAX();
                int so = int.Parse(soHDMAX.Substring(0,5))+1;

                tb_HopDong hd = new tb_HopDong();
                hd.SoHD = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/HĐLV";
                hd.NgayBatDau= dtNgayBatDau.Value;
                hd.NgayKetThuc = dtNgayKetThuc.Value;
                hd.NgayKy= dtNgayKetThuc.Value;
                hd.ThoiHan = cboThoiHan.Text;
                hd.LuongThoaThuan = double.Parse(txtLuongThoaThuan.EditValue.ToString());
                hd.LanKy = int.Parse(txtLuongThoaThuan.EditValue.ToString());
                hd.ID_NV = int.Parse(slkNhanVien.EditValue.ToString());
                hd.NoiDung = txtNoiDung.RtfText;
                hd.ID_CT = 1;
                hd.Create_Time = DateTime.Now;
                hd.Create_By = 1;
                _hdld.Add(hd);
            }
            else
            {
                var hd = _hdld.getItem(_soHD);
                
                hd.NgayBatDau = dtNgayBatDau.Value;
                hd.NgayKetThuc = dtNgayKetThuc.Value;
                hd.NgayKy = dtNgayKetThuc.Value;
                hd.ThoiHan = cboThoiHan.Text;
                hd.LuongThoaThuan = double.Parse(txtLuongThoaThuan.EditValue.ToString());
                hd.LanKy = int.Parse(txtLuongThoaThuan.EditValue.ToString());
                hd.ID_NV = int.Parse(slkNhanVien.EditValue.ToString());
                hd.NoiDung = txtNoiDung.RtfText;
                hd.ID_CT = 1;
                hd.Create_Time = DateTime.Now;
                hd.Create_By = 1;
                _hdld.Update(hd);
            }
        }
        void _reset()
        {
            txtSoHD.Text = string.Empty;
            dtNgayBatDau.Value = DateTime.Now;
            dtNgayKetThuc.Value = dtNgayBatDau.Value.AddMonths(6);
            dtNgayKi.Value = DateTime.Now;
            spLanKi.Text = "1";
            txtLuongThoaThuan.Text = "1";
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void frmHopDong_Load(object sender, EventArgs e)
        {
            _hdld = new HopDongLaoDong();
            _nhanvien = new NhanVien();

            _add = false;
            showHide(true);
            LoadData();
            loadNV();
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _add = true;
            _reset();
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!_click)
            {
                MessageBox.Show("Bạn vui lòng chọn đối tượng ?", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            showHide(false);
            _add = false;
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!_click)
            {
                MessageBox.Show("Bạn vui lòng chọn đối tượng ?", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có xác nhận xóa không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _hdld.Delete(_soHD,1);
                LoadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                SaveData();
                LoadData();
                showHide(true);
                _add = false;
                splitContainer1.Panel1Collapsed = true;
            
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            showHide(true);
            _add = false;
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _lstHD = _hdld.getItemFull(_soHD);
            rptHopDongLaoDong rpt = new rptHopDongLaoDong(_lstHD);
            rpt.ShowPreviewDialog();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount !=0)
            {
                _click = true;
                _soHD = gvDanhSach.GetFocusedRowCellValue("SoHD").ToString();
                var hd = _hdld.getItem(_soHD);
                txtSoHD.Text = _soHD;
                dtNgayBatDau.Value = hd.NgayBatDau;
                dtNgayKetThuc.Value = hd.NgayKetThuc;
                dtNgayKi.Value = hd.NgayKy;
                cboThoiHan.Text = hd.ThoiHan;
                txtLuongThoaThuan.EditValue = hd.LuongThoaThuan;
                spLanKi.EditValue = hd.LanKy;
                slkNhanVien.EditValue = hd.ID_NV;
                txtNoiDung.RtfText = hd.NoiDung;
                _lstHD = _hdld.getItemFull(_soHD);
                showHide(true);
                splitContainer1.Panel1Collapsed = false;
            }
            
        }

        private void txtLuongThoaThuan_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}