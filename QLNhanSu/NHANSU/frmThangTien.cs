using BusinessLayer;
using DataLayer;
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

namespace QLNhanSu
{
    public partial class frmThangTien : DevExpress.XtraEditors.XtraForm
    {
        public frmThangTien()
        {
            InitializeComponent();
        }
        HopDongLaoDong _hopDong;
        ChucVu _chucVu;
        ThangTien _thangTien;
        NhanVien _nhanVien;
        string _soQD;
        bool _add;
        bool _click;

        void loadHD()
        {
            slkHopDong.Properties.DataSource = _hopDong.getListFull();
            slkHopDong.Properties.ValueMember = "SoHD";
            slkHopDong.Properties.DisplayMember = "SoHD";

        }
        void loadCV()
        {
            slkChucVu.Properties.DataSource = _chucVu.getlist();
            slkChucVu.Properties.ValueMember = "ID_CV";
            slkChucVu.Properties.DisplayMember = "TenCV";

        }

        //Ẩn hiện các nút
        void showHide(bool check)
        {
            btnLuu.Enabled = !check;
            btnHuy.Enabled = !check;
            btnThem.Enabled = check;
            btnSua.Enabled = check;
            btnXoa.Enabled = check;
            btnIn.Enabled = check;
            txtLiDo.Enabled = !check;
            txtGhiChu.Enabled = !check;
            slkHopDong.Enabled = !check;
            dtNgayApDung.Enabled = !check;
            dtNgayKy.Enabled = !check;
            txtHeSoLuongMoi.Enabled = !check;
            ckbThangChuc.Enabled = !check;
            
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _thangTien.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        //Lưu dữ liệu thông qua Add hoặc Update
        void SaveData()
        {
            string noiDUng;
            if (ckbThangChuc.Checked)
            {
                noiDUng = "TC";
            }else
            {
                noiDUng = "DCL";
            }
            tb_ThangTien dcl;
            if (_add)
            {
                dcl = new tb_ThangTien();
                var soQDMAX = _thangTien.soQuyetDinhMAX();
                int so = int.Parse(soQDMAX.Substring(0, 5)) + 1;

                dcl.SoQD = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/QD"+noiDUng;
                dcl.SoHD = slkHopDong.EditValue.ToString();
                dcl.NgayApDung = dtNgayApDung.Value;
                dcl.NgayKi = dtNgayKy.Value;
                dcl.LiDo = txtLiDo.Text;
                dcl.GhiChu = txtGhiChu.Text;
                dcl.HeSoLuong_OLD = double.Parse(txtHeSoLuongCu.Text);
                dcl.HeSoLuong_NEW = double.Parse(txtHeSoLuongMoi.Text);
                dcl.ID_NV = _hopDong.getItem(slkHopDong.EditValue.ToString()).ID_NV;
                dcl.ID_CV_OLD = _nhanVien.getItem(dcl.ID_NV).ID_CV;
                if (ckbThangChuc.Checked)
                {
                    dcl.ID_CV_NEW = slkChucVu.EditValue.ToString();
                }
                else
                {
                    dcl.ID_CV_NEW = dcl.ID_CV_OLD;
                }
               
                dcl.Create_By = "1";
                dcl.Create_Time = DateTime.Now;
                _thangTien.Add(dcl);
            }
            else
            {
                dcl = _thangTien.getItem(_soQD);
                dcl.SoHD = slkHopDong.EditValue.ToString();
                dcl.NgayApDung = dtNgayApDung.Value;
                dcl.NgayKi = dtNgayKy.Value;
                dcl.LiDo = txtLiDo.Text;
                dcl.GhiChu = txtGhiChu.Text;
                dcl.ID_NV = _hopDong.getItem(slkHopDong.EditValue.ToString()).ID_NV;
                dcl.ID_CV_NEW = slkChucVu.EditValue.ToString();
                dcl.Update_By = "1";
                dcl.Update_Time = DateTime.Now;
                _thangTien.Update(dcl);
            }
            var hd = _hopDong.getItem(slkHopDong.EditValue.ToString());
            hd.HeSoLuong = double.Parse(txtHeSoLuongMoi.Text);
            _hopDong.Update(hd);
            if (ckbThangChuc.Checked)
            {
                var nv = _hopDong.getItemFull(slkHopDong.EditValue.ToString());
                var nv_Upd = _nhanVien.getItem(nv[0].ID_NV);
                nv_Upd.ID_CV = slkChucVu.EditValue.ToString();
                _nhanVien.Update(nv_Upd);
            }
            
        }

        void _reset()
        {
            txtGhiChu.Text = string.Empty;
            txtLiDo.Text = string.Empty;
            txtSoQD.Text = string.Empty;
            dtNgayApDung.Value = DateTime.Now;
            dtNgayKy.Value = dtNgayApDung.Value.AddDays(30);

        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void frmDieuChinhLuong_Load(object sender, EventArgs e)
        {
            _add = false;
            _hopDong = new HopDongLaoDong();
            _thangTien = new ThangTien();
            _nhanVien = new NhanVien();
            _chucVu = new ChucVu();
            showHide(true);
            loadHD();
            loadCV();
            LoadData();
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
                _thangTien.Delete(_soQD,"1");
                var hd = _hopDong.getItem(slkHopDong.EditValue.ToString());
                hd.HeSoLuong = double.Parse(txtHeSoLuongCu.Text);
                _hopDong.Update(hd);
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

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _click = true;
                _soQD = gvDanhSach.GetFocusedRowCellValue("SoQD").ToString();
                var dcl = _thangTien.getItem(_soQD);
                txtSoQD.Text = _soQD;
                dtNgayApDung.Value = dcl.NgayApDung;
                dtNgayKy.Value = dcl.NgayKi;
                txtHeSoLuongCu.Text = dcl.HeSoLuong_OLD.ToString();
                txtHeSoLuongMoi.Text = dcl.HeSoLuong_NEW.ToString();
                slkHopDong.EditValue = dcl.ID_NV;
                txtGhiChu.Text = dcl.GhiChu;
                txtLiDo.Text = dcl.LiDo;
                slkHopDong.EditValue = dcl.SoHD;
                txtInfor_NV.Text = gvDanhSach.GetFocusedRowCellValue("Ten").ToString();
                txtChucVuCu.Text = gvDanhSach.GetFocusedRowCellValue("TenCV_Old").ToString();
                slkChucVu.EditValue = dcl.ID_CV_NEW;
                showHide(true);
                splitContainer1.Panel1Collapsed = false;
            }
        }

        private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "Delete_By" && e.CellValue != null)
            {
                Image image = Properties.Resources.del_x16;
                e.Graphics.DrawImage(image, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }

        private void slkHopDong_EditValueChanged(object sender, EventArgs e)
        {
            var hd = _hopDong.getItemFull(slkHopDong.EditValue.ToString());
            if (hd.Count!=0)
            {
                txtInfor_NV.Text = hd[0].ID_NV + " - " + hd[0].TenNV;
                txtHeSoLuongCu.Text = hd[0].HeSoLuong.ToString();
                txtChucVuCu.Text = hd[0].TenCV.ToString();
            }
        }

        private void ckbThangChuc_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbThangChuc.Checked)
            {
                slkChucVu.Enabled = true;
            }
            else
            {
                slkChucVu.Enabled = false;
            }
        }
    }
}