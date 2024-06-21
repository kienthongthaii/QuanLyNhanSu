using BusinessLayer;
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
    public partial class frmKyCong : DevExpress.XtraEditors.XtraForm
    {
        public frmKyCong()
        {
            InitializeComponent();
        }
        KyCong _KyCong;
        bool _add;
        string _maKyCong;
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
            cbNam.Enabled = !check;
            cbThang.Enabled = !check;
            ckbKhoaKyCong.Enabled = !check;
            ckbTrangThai.Enabled = !check;
        }
        private void loadThang()
        {
            for (int i = 1; i <= 12; i++)
            {
                cbThang.Items.Add(i);
            }
            cbThang.SelectedItem = DateTime.Now.Month;
        }
        private void loadNam(int namDau, int namCuoi)
        {
            cbNam.Items.Clear();
            for (int i = namDau; i <= namCuoi; i++)
            {
                cbNam.Items.Add(i);
            }
            cbNam.SelectedItem = DateTime.Now.Year;
            
        }

        void reset()
        {
            cbNam.Text = string.Empty;
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _KyCong.getlist();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        //Lưu dữ liệu thông qua Add hoặc Update
        void SaveData()
        {
            if (_add)
            {
                tb_KyCong kc = new tb_KyCong();
                kc.MaKyCong = cbNam.Text+ cbThang.Text;
                kc.Nam = int.Parse(cbNam.Text);
                kc.Thang = int.Parse(cbThang.Text);
                kc.Khoa = ckbKhoaKyCong.Checked;
                kc.TrangThai = ckbTrangThai.Checked;
                kc.CongChuan=Funcions.demSoNgayLamViecTrongThang(int.Parse(cbThang.Text),int.Parse(cbNam.Text));
                kc.Create_By = "1";
                kc.Create_Time = DateTime.Now;
                _KyCong.Add(kc);
            }
            else
            {
                var kc = _KyCong.getItem(_maKyCong);
                //kc.MaKyCong = int.Parse(cbNam.Text) * 100 + int.Parse(cbThang.Text);
                kc.Nam = int.Parse(cbNam.Text);
                kc.Thang = int.Parse(cbThang.Text);
                kc.Khoa = ckbKhoaKyCong.Checked;
                kc.TrangThai = ckbTrangThai.Checked;
                kc.CongChuan = Funcions.demSoNgayLamViecTrongThang(int.Parse(cbThang.Text), int.Parse(cbNam.Text));
                kc.Update_By = "1";
                kc.Update_Time = DateTime.Now;
                _KyCong.Update(kc);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmKyCong_Load(object sender, EventArgs e)
        {
            _add = false;
            _KyCong = new KyCong();
            loadNam(1960, 2050);
            loadThang();
            showHide(true);
            LoadData();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _add = true;
            reset();
            cbNam.Text=DateTime.Now.Year.ToString();
            cbThang.Text=DateTime.Now.Month.ToString();
            ckbKhoaKyCong.Checked=false;
            ckbTrangThai.Checked=false;
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
                _KyCong.Delete(_maKyCong, "1");
                LoadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cbNam.Text == string.Empty)
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
            _maKyCong = gvDanhSach.GetFocusedRowCellValue("MaKyCong").ToString();
            cbNam.Text = gvDanhSach.GetFocusedRowCellValue("Nam").ToString();
            cbThang.Text = gvDanhSach.GetFocusedRowCellValue("Thang").ToString();
            ckbKhoaKyCong.Checked=bool.Parse(gvDanhSach.GetFocusedRowCellValue("Khoa").ToString());
            ckbTrangThai.Checked= bool.Parse(gvDanhSach.GetFocusedRowCellValue("TrangThai").ToString());
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

        private void btnXemBangCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_click)
            {
                frmBangCongChiTiet frm = new frmBangCongChiTiet();
                frm._makycong = _maKyCong;
                frm._nam = int.Parse(cbNam.Text);
                frm._thang = int.Parse(cbThang.Text);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trong danh sách trước khi mở chi tiết bảng công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }
    }
}