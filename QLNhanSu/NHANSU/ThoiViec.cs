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
    public partial class frmThoiViec : DevExpress.XtraEditors.XtraForm
    {
        public frmThoiViec()
        {
            InitializeComponent();
        }
        NhanVien _nhanvien;
        ThoiViec _thoiViec;

        string _soQD;
        bool _add;
        bool _click;

        void loadNV()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getlist();
            slkNhanVien.Properties.ValueMember = "ID_NV";
            slkNhanVien.Properties.DisplayMember = "Ten";

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
            slkNhanVien.Enabled = !check;
            dtNgayNopDon.Enabled = !check;
            dtNgayThoiViec.Enabled = !check;
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _thoiViec.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        //Lưu dữ liệu thông qua Add hoặc Update
        void SaveData()
        {
            tb_ThoiViec tv;
            if (_add)
            {
                tv = new tb_ThoiViec();
                var soQDMAX = _thoiViec.soQuyetDinhMAX();
                int so = int.Parse(soQDMAX.Substring(0, 5)) + 1;

                tv.SoQD = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/QDTV";
                tv.NgayNopDon = dtNgayNopDon.Value;
                tv.NgayThoiViec = dtNgayThoiViec.Value;
                tv.LyDo = txtLiDo.Text;
                tv.GhiChu = txtGhiChu.Text;
                tv.ID_NV = int.Parse(slkNhanVien.EditValue.ToString()); 
                tv.Create_By = 1;
                tv.Create_Time = DateTime.Now;
                _thoiViec.Add(tv);
            }
            else
            {
                tv = _thoiViec.getItem(_soQD);
                tv.NgayNopDon = dtNgayNopDon.Value;
                tv.NgayThoiViec = dtNgayThoiViec.Value;
                tv.LyDo = txtLiDo.Text;
                tv.GhiChu = txtGhiChu.Text;
                tv.ID_NV = int.Parse(slkNhanVien.EditValue.ToString());
                tv.Update_By = 1;
                tv.Update_Time = DateTime.Now;
                _thoiViec.Update(tv);
            }
            var nv = _nhanvien.getItem(tv.ID_NV);
            nv.DaThoiViec = true;
            _nhanvien.Update(nv);
        }

        void _reset()
        {
            txtGhiChu.Text = string.Empty;
            txtLiDo.Text = string.Empty;
            txtSoQD.Text = string.Empty;
            dtNgayNopDon.Value = DateTime.Now;
            dtNgayThoiViec.Value = dtNgayNopDon.Value.AddDays(30);

        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void frmThoiViec_Load(object sender, EventArgs e)
        {
            _add = false;
            _nhanvien = new NhanVien();
            _thoiViec= new ThoiViec();
            showHide(true);
            loadNV();
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
                _thoiViec.Delete(_soQD, 1);
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
                var tv = _thoiViec.getItem(_soQD);
                txtSoQD.Text = _soQD;
                dtNgayNopDon.Value = tv.NgayNopDon.Value;
                dtNgayThoiViec.Value = tv.NgayThoiViec.Value;
                slkNhanVien.EditValue = tv.ID_NV;
                txtGhiChu.Text = tv.GhiChu;
                txtLiDo.Text = tv.LyDo;
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

        private void dtNgayNopDon_ValueChanged(object sender, EventArgs e)
        {
            dtNgayThoiViec.Value = dtNgayNopDon.Value.AddDays(30);
        }
    }
}