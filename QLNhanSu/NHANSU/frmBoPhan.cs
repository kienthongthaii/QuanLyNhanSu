using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu
{
    public partial class frmBoPhan : DevExpress.XtraEditors.XtraForm
    {
        public frmBoPhan()
        {
            InitializeComponent();
        }
        BoPhan _bophan;
        PhongBan _phongban;
        public string NV_Login;
        bool _add;
        string _id;
        bool _click;
        private void frmBoPhan_Load(object sender, EventArgs e)
        {
            _add = false;
            _bophan = new BoPhan();
            _phongban = new PhongBan();
            showHide(true);
            LoadData();
            loadPB();
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
            txtTenBP.Enabled = !check;
            txtMoTa.Enabled = !check;
            txtID_BP.Enabled = !check;
            cbPhongBan.Enabled = !check;
        }

        void reset()
        {
            
            txtID_BP.Text = string.Empty;
            txtTenBP.Text = string.Empty;
            txtMoTa.Text = string.Empty;
            txtKiHieuPB.Text = string.Empty;
            cbPhongBan.Text = string.Empty;
            txtNgayThanhLap.Text = string.Empty;
            txtSoLuongNV.Text = string.Empty;
            ckbConHoatDong.Checked = true;
            txtTenTruongBP.Text = string.Empty;
        }

        void loadPB()
        {
            cbPhongBan.DataSource = _phongban.getlist();
            cbPhongBan.ValueMember = "ID_PB";
            cbPhongBan.DisplayMember = "TenPB";
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _bophan.getlistFull();
            gvDanhSach.OptionsBehavior.Editable = false;
            
        }
        //Lưu dữ liệu thông qua Add hoặc Update
        void SaveData()
        {
            if (_add)
            {
                tb_BoPhan bp = new tb_BoPhan();
                
                bp.TenBP = txtTenBP.Text;
                bp.ID_PB = cbPhongBan.SelectedValue.ToString();
                bp.ID_BP = txtKiHieuPB.Text + "_" +txtID_BP.Text;
                bp.MoTa = txtMoTa.Text;

                bp.Create_By = NV_Login;
                bp.Create_Time = DateTime.Now;
                _bophan.Add(bp);
            }
            else
            {
                var bp = _bophan.getItem(_id);

                bp.TenBP = txtTenBP.Text;
                bp.ID_PB = cbPhongBan.SelectedValue.ToString();
                bp.MoTa = txtMoTa.Text;

                bp.Update_By = NV_Login;
                bp.Update_Time = DateTime.Now;
                
                _bophan.Update(bp);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            reset();
            txtID_BP.BackColor = Color.Yellow;
            txtTenBP.BackColor = Color.Yellow;
            cbPhongBan.BackColor = Color.Yellow;
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
                _bophan.Delete(_id, NV_Login);
                LoadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTenBP.Text == string.Empty || txtTenBP.Text ==string.Empty || cbPhongBan.Text == string.Empty)
            {
                showHide(true);
                MessageBox.Show("Vui lòng không để trống ô nhập bắt buộc!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtID_BP.BackColor = Color.White;
            txtTenBP.BackColor = Color.White;
            cbPhongBan.BackColor = Color.White;
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
            if(gvDanhSach.RowCount > 0)
            {
                _click = true;
                _id = gvDanhSach.GetFocusedRowCellValue("ID_BP").ToString();
                var bp = _bophan.getItem(_id);
                string MaBP = _id.Substring(_id.IndexOf('_') + 1);
                txtID_BP.Text = MaBP;
                txtTenBP.Text = bp.TenBP.ToString();
                txtMoTa.Text = bp.MoTa.ToString();
                txtTenTruongBP.Text = gvDanhSach.GetFocusedRowCellValue("TenTruongBP").ToString();
                txtSoLuongNV.Text = gvDanhSach.GetFocusedRowCellValue(SoThanhVien).ToString();
                txtNgayThanhLap.Text = bp.Create_Time.ToString();
                cbPhongBan.SelectedValue = bp.ID_PB;
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

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _id = gvDanhSach.GetFocusedRowCellValue("ID_BP").ToString();
            var bp = _bophan.getItem(_id);
            if (bp.Delete_By != null)
            {
                DialogResult result = MessageBox.Show("Bạn có xác nhận sẽ hồi phục dữ liệu này?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    bp.Delete_By = null;
                    bp.Delete_Time = null;
                    bp.Update_By = NV_Login;
                    bp.Update_Time = DateTime.Now;
                    _bophan.Update(bp);
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

        private void cbPhongBan_SelectedValueChanged(object sender, EventArgs e)
        {
            txtKiHieuPB.Text = cbPhongBan.SelectedValue.ToString();
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