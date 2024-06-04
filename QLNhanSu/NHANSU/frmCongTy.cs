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
    public partial class frmCongTy : DevExpress.XtraEditors.XtraForm
    {
        public frmCongTy()
        {
            InitializeComponent();
        }
        CongTy _congty;
        bool _add;
        int _id;
        bool _click;
        private void frmCongTy_Load(object sender, EventArgs e)
        {
            _add = false;
            _congty = new CongTy();
            showHide(true);
            LoadData();
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
            txtTenCT.Enabled = !check;
            txtSDT.Enabled = !check;
            txtEmail.Enabled = !check;
            txtDiaChi.Enabled = !check;
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _congty.getlist();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        //Lưu dữ liệu thông qua Add hoặc Update
        void SaveData()
        {
            if (_add)
            {
                tb_CongTy dt = new tb_CongTy();
                dt.TenCT = txtTenCT.Text;
                dt.DienThoai = txtSDT.Text;
                dt.Email = txtEmail.Text;
                dt.DiaChi = txtDiaChi.Text;
                _congty.Add(dt);
            }
            else
            {
                var dt = _congty.getItem(_id);
                dt.TenCT = txtTenCT.Text;
                dt.DienThoai = txtSDT.Text;
                dt.Email = txtEmail.Text;
                dt.DiaChi = txtDiaChi.Text;
                _congty.Update(dt);
            }
        }


        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _add = true;
            txtTenCT.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
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
                _congty.Delete(_id);
                LoadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTenCT.Text == string.Empty || txtSDT.Text == string.Empty || txtEmail.Text == string.Empty || txtDiaChi.Text == string.Empty)
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
            if (gvDanhSach.RowCount>0)
            {
                _click = true;
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID_CT").ToString());
                txtTenCT.Text = gvDanhSach.GetFocusedRowCellValue("TenCT").ToString();
                txtSDT.Text = gvDanhSach.GetFocusedRowCellValue("DienThoai").ToString();
                txtEmail.Text = gvDanhSach.GetFocusedRowCellValue("Email").ToString();
                txtDiaChi.Text = gvDanhSach.GetFocusedRowCellValue("DiaChi").ToString(); 
            }
            
        }
    }
}