using BusinessLayer.TINHLUONG_BL;
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
using DataLayer;
using BusinessLayer.CHAMCONG_BL;

namespace QLNhanSu.LUONG
{
    public partial class frmTangCa : DevExpress.XtraEditors.XtraForm
    {
        public frmTangCa()
        {
            InitializeComponent();
        }
        TangCa _TangCa;
        NhanVien _NhanVien;
        bool _add;
        string _id;
        bool _click;
        void showHide(bool check)
        {
            btnLuu.Enabled = !check;
            btnHuy.Enabled = !check;
            btnThem.Enabled = check;
            btnSua.Enabled = check;
            btnXoa.Enabled = check;
            btnIn.Enabled = check;
            slkNhanVien.Enabled = !check;
            cboLoaiCa.Enabled = !check;
            txtGhiChu.Enabled = !check;
            spSoGio.Enabled = !check;
        }
        void reset()
        {
            txtGhiChu.Text = string.Empty;
            spSoGio.EditValue = 0;
            slkNhanVien.EditValue = 0;
            cboLoaiCa.SelectedIndex = 0;
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _TangCa.getlistFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void LoadNhanVien()
        {
            slkNhanVien.Properties.DataSource = _NhanVien.getlistFull();
            slkNhanVien.Properties.DisplayMember = "Ten";
            slkNhanVien.Properties.ValueMember = "ID_NV";

        }
        //Lưu dữ liệu thông qua Add hoặc Update
        void SaveData()
        {
            if (_add)
            {

                tb_TangCa tc = new tb_TangCa();
                tc.SoGio = double.Parse(spSoGio.EditValue.ToString());
                tc.ID_NV = slkNhanVien.EditValue.ToString();
                tc.GhiChu = txtGhiChu.Text;
                tc.NgayTC = DateTime.Now;
                tc.SoTien = (decimal)(tc.SoGio * tc.HeSo);


                tc.Create_By = "1";
                tc.Create_Time = DateTime.Now;
                _TangCa.Add(tc);
            }
            else
            {
                var tc = _TangCa.getItem(_id);
                tc.SoGio = double.Parse(spSoGio.EditValue.ToString());
                tc.ID_NV = slkNhanVien.EditValue.ToString();
                tc.GhiChu = txtGhiChu.Text;
                tc.NgayTC = DateTime.Now;
                tc.Update_By = "1";
                tc.Update_Time = DateTime.Now;
                _TangCa.Update(tc);
            }
        }

        private void frmTangCa_Load(object sender, EventArgs e)
        {
            _add = false;
            _TangCa = new TangCa();
            _NhanVien = new NhanVien();
            showHide(true);

            LoadNhanVien();
            LoadData();
            
            
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _add = true;
            reset();
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
                _TangCa.Delete(_id, "1");
                LoadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (slkNhanVien.Text == string.Empty)
            {
                showHide(true);
                MessageBox.Show("Vui lòng không để trống ô nhập!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SaveData();
                LoadData();
                showHide(true);
                _add = false;
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(true);
            _add = false;
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
            _click = true;
            _id = gvDanhSach.GetFocusedRowCellValue("ID_TC").ToString();
            txtGhiChu.Text = gvDanhSach.GetFocusedRowCellValue("GhiChu").ToString();
            spSoGio.Text = gvDanhSach.GetFocusedRowCellValue("SoGio").ToString();
            cboLoaiCa.SelectedValue = gvDanhSach.GetFocusedRowCellValue("ID_LCa");
            slkNhanVien.EditValue = gvDanhSach.GetFocusedRowCellValue("ID_NV");
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
    }
}