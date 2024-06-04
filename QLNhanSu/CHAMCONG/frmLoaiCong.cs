using BusinessLayer.CHAMCONG_BL;
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

namespace QLNhanSu.CHAMCONG
{
    public partial class frmLoaiCong : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiCong()
        {
            InitializeComponent();
        }
        LoaiCong _loaiCong;
        bool _add;
        int _id;
        bool _click;

        //Ẩn hiện các nút
        void showHide(bool check)
        {
            btnLuu.Enabled = !check;
            btnHuy.Enabled = !check;
            btnThem.Enabled = check;
            btnSua.Enabled = check;
            btnXoa.Enabled = check;
            btnIn.Enabled = check;
            txtTenLoaiCong.Enabled = !check;
            spHS.Enabled = !check;
        }
        void reset()
        {
            txtTenLoaiCong.Text = string.Empty;
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _loaiCong.getlist();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        //Lưu dữ liệu thông qua Add hoặc Update
        void SaveData()
        {
            if (_add)
            {
                tb_LoaiCong lca = new tb_LoaiCong();
                lca.TenLoaiCong = txtTenLoaiCong.Text;
                lca.HeSo = double.Parse(spHS.EditValue.ToString());
                lca.Create_By = 1;
                lca.Create_Time = DateTime.Now;
                _loaiCong.Add(lca);
            }
            else
            {
                var lca = _loaiCong.getItem(_id);
                lca.TenLoaiCong = txtTenLoaiCong.Text;
                lca.HeSo = double.Parse(spHS.EditValue.ToString());
                lca.Update_By = 1;
                lca.Update_Time = DateTime.Now;
                _loaiCong.Update(lca);
            }
        }


        private void frmLoaiCong_Load(object sender, EventArgs e)
        {
            _add = false;
            _loaiCong = new LoaiCong();
            showHide(true);
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
                _loaiCong.Delete(_id, 1);
                LoadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTenLoaiCong.Text == string.Empty)
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
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID_LCo").ToString());
            txtTenLoaiCong.Text = gvDanhSach.GetFocusedRowCellValue("TenLoaiCong").ToString();
            spHS.Text = gvDanhSach.GetFocusedRowCellValue("HeSo").ToString();
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