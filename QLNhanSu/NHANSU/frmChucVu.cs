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
    public partial class frmChucVu : DevExpress.XtraEditors.XtraForm
    {
        public frmChucVu()
        {
            InitializeComponent();
        }
        ChucVu _chucvu;
        public string NV_Login;
        bool _add;
        string _id;
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
            txtTenCV.Enabled = !check;
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _chucvu.getlistFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        //Lưu dữ liệu thông qua Add hoặc Update
        void SaveData()
        {
            if (_add)
            {
                tb_ChucVu cv = new tb_ChucVu();
                cv.ID_CV = txtID_CV.Text;
                cv.TenCV = txtTenCV.Text;
                cv.MoTa = txtMoTa.Text;
                cv.Create_By = NV_Login;
                cv.Create_Time = DateTime.Now;
                _chucvu.Add(cv);
            }
            else
            {

                var cv = _chucvu.getItem(_id);
                cv.TenCV = txtTenCV.Text;
                cv.MoTa = txtMoTa.Text;
                cv.Update_By = NV_Login;
                cv.Update_Time = DateTime.Now;
                _chucvu.Update(cv);
            }
        }
        void reset()
        {

            txtID_CV.Text = string.Empty;
            txtTenCV.Text = string.Empty;
            txtMoTa.Text = string.Empty;
            txtNgayThanhLap.Text = string.Empty;
            txtSoLuongNV.Text = string.Empty;
            ckbConHoatDong.Checked = true;
           
        }
        private void frmChucVu_Load(object sender, EventArgs e)
        {
            _add = false;
            _chucvu = new ChucVu();
            showHide(true);
            LoadData();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            reset();
            txtID_CV.BackColor = Color.Yellow;
            txtTenCV.BackColor = Color.Yellow;
            _add = true;
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
                _chucvu.Delete(_id, NV_Login);
                LoadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTenCV.Text == string.Empty || txtID_CV.Text == string.Empty)
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
            txtID_CV.BackColor = Color.White;
            txtTenCV.BackColor = Color.White;
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
                _id = gvDanhSach.GetFocusedRowCellValue("ID_CV").ToString();
                var bp = _chucvu.getItem(_id);
                string MaPB = _id;
                txtID_CV.Text = MaPB;
                txtTenCV.Text = bp.TenCV.ToString();
                txtMoTa.Text = bp.MoTa.ToString();
                txtSoLuongNV.Text = gvDanhSach.GetFocusedRowCellValue(SoThanhVien).ToString();
                txtNgayThanhLap.Text = bp.Create_Time.ToString();
                if (bp.Delete_By != null)
                {
                    ckbConHoatDong.Checked = false;
                }
                else
                {
                    ckbConHoatDong.Checked = true;
                }
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

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _id = gvDanhSach.GetFocusedRowCellValue("ID_CV").ToString();
            var pb = _chucvu.getItem(_id);
            if (pb.Delete_By != null)
            {
                DialogResult result = MessageBox.Show("Bạn có xác nhận sẽ hồi phục dữ liệu này?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    pb.Delete_By = null;
                    pb.Delete_Time = null;
                    pb.Update_By = NV_Login;
                    pb.Update_Time = DateTime.Now;
                    _chucvu.Update(pb);
                    MessageBox.Show("Hồi phục thành công!", "Thông báo");
                    LoadData();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu này không bị xóa, không thể phục hồi!", "Thông báo!");
            }
        }
    }
}