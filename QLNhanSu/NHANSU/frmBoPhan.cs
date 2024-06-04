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
    public partial class frmBoPhan : DevExpress.XtraEditors.XtraForm
    {
        public frmBoPhan()
        {
            InitializeComponent();
        }
        BoPhan _bophan;
        PhongBan _phongban;
        bool _add;
        int _id;
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
                bp.ID_PB = int.Parse(cbPhongBan.SelectedValue.ToString());
                _bophan.Add(bp);
            }
            else
            {
                var bp = _bophan.getItem(_id);
                bp.TenBP = txtTenBP.Text;
                bp.ID_PB = int.Parse(cbPhongBan.SelectedValue.ToString());
                _bophan.Update(bp);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _add = true;
            txtTenBP.Text = string.Empty;
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
                _bophan.Delete(_id);
                LoadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTenBP.Text == string.Empty)
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
            if(gvDanhSach.RowCount > 0)
            {
                _click = true;
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID_BP").ToString());
                var bp = _bophan.getItem(_id);
                txtTenBP.Text = bp.TenBP.ToString();
                cbPhongBan.SelectedValue = bp.ID_PB;
            }
            
        }

        private void btnLoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}