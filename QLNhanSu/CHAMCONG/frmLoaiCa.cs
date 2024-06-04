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
using BusinessLayer.CHAMCONG_BL;
namespace QLNhanSu
{
    public partial class frmLoaiCa : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiCa()
        {
            InitializeComponent();
        }
        LoaiCa _loaiCa;
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
            txtTenLoaiCa.Enabled = !check;
            spHS.Enabled = !check;
        }
        void reset()
        {
            txtTenLoaiCa.Text = string.Empty;
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _loaiCa.getlist();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        //Lưu dữ liệu thông qua Add hoặc Update
        void SaveData()
        {
            if (_add)
            {
                tb_LoaiCa lca = new tb_LoaiCa();
                lca.TenLoaiCa = txtTenLoaiCa.Text;
                lca.HeSo = double.Parse(spHS.EditValue.ToString());
                lca.Create_By = 1;
                lca.Create_Time = DateTime.Now;
                _loaiCa.Add(lca);
            }
            else
            {
                var lca = _loaiCa.getItem(_id);
                lca.TenLoaiCa = txtTenLoaiCa.Text;
                lca.HeSo = double.Parse(spHS.EditValue.ToString());
                lca.Update_By = 1;
                lca.Update_Time = DateTime.Now;
                _loaiCa.Update(lca);
            }
        }
        private void frmLoaiCa_Load(object sender, EventArgs e)
        {
            _add = false;
            _loaiCa = new LoaiCa();
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
                _loaiCa.Delete(_id, 1);
                LoadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTenLoaiCa.Text == string.Empty)
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
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID_LCa").ToString());
            txtTenLoaiCa.Text = gvDanhSach.GetFocusedRowCellValue("TenLoaiCa").ToString();
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