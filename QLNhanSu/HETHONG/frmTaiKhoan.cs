using BusinessLayer;
using BusinessLayer.CHAMCONG_BL;
using BusinessLayer.HETHONG_BL;
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

namespace QLNhanSu.HETHONG
{
    public partial class frmTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }
        TaiKhoan _taiKhoan;
        NhanVien _nhanVien;
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
            txtUserName.Enabled = !check;
            txtPassWord.Enabled = !check;
            slkNhanVien.Enabled = !check;
            cboRole.Enabled = !check;
        }
        void reset()
        {
            txtUserName.Text = string.Empty;
            txtPassWord.Text = string.Empty;
            slkNhanVien.Text = string.Empty;
            //cboRole.SelectedIndex = 0;
        }
        void LoadNhanVien()
        {
            slkNhanVien.Properties.DataSource = _nhanVien.getlistFull();
            slkNhanVien.Properties.DisplayMember = "Ten";
            slkNhanVien.Properties.ValueMember = "ID_NV";

        }

        void LoadData()
        {
            gcDanhSach.DataSource = _taiKhoan.getlist();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        //Lưu dữ liệu thông qua Add hoặc Update
        void SaveData()
        {
            if (_add)
            {
                tb_SYS_User user = new tb_SYS_User();
                user.UserName = txtUserName.Text;
                user.PassWord = txtPassWord.Text;
                user.ID_NV = slkNhanVien.EditValue.ToString();
                user.Disable = false;
                _taiKhoan.Add(user);
            }
            else
            {
                var user = _taiKhoan.getItem(_id);
                user.UserName = txtUserName.Text;
                user.PassWord = txtPassWord.Text;
                user.Last_PWD_Change = DateTime.Now;
                user.Disable = false;
                _taiKhoan.Update(user);
            }
        }


        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            _add = false;
            _taiKhoan = new TaiKhoan();
            _nhanVien = new NhanVien();
            showHide(true);
            LoadData();
            LoadNhanVien();
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
                _taiKhoan.Delete(_id, 1);
                LoadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtUserName.Text == string.Empty || txtPassWord.Text == string.Empty)
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
            if (gvDanhSach.RowCount > 0)
            {
                _click = true;
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
                var tk = _taiKhoan.getItem(_id);
                txtUserName.Text = tk.UserName;
                txtPassWord.Text = tk.PassWord;
                showHide(true);
                splitContainer1.Panel1Collapsed = false;
            }
        }
    }
}