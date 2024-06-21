using BusinessLayer.DTO;
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
    public partial class frmKhenThuong_KyLuat : DevExpress.XtraEditors.XtraForm
    {
        public frmKhenThuong_KyLuat()
        {
            InitializeComponent();
        }
        KhenThuong_KyLuat _ktkl;
        NhanVien _nhanvien;
        bool _add;
        string _soQD;
        bool _click;
        void showHide(bool check)
        {
            btnLuu.Enabled = !check;
            btnHuy.Enabled = !check;
            btnThem.Enabled = check;
            btnSua.Enabled = check;
            btnXoa.Enabled = check;
            btnIn.Enabled = check;
            txtSoQD.Enabled = !check;
            txtLiDo.Enabled = !check;
            txtNoiDung.Enabled = !check;
            slkNhanVien.Enabled = !check;
            dtTuNgay.Enabled = !check;
            cbLoai.Enabled = !check;
            dtNgay.Enabled = !check;
        }

        void LoadDataKhenThuong()
        {
            gcDanhSach.DataSource = _ktkl.getlistFull(1);
            gvDanhSach.OptionsBehavior.Editable = false;

        }
        void LoadDataKyLuat()
        {
            gcDanhSachKiLuat.DataSource = _ktkl.getlistFull(0);
            gvDanhSachKiLuat.OptionsBehavior.Editable = false;

        }
        void loadNV()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getlist();
            slkNhanVien.Properties.ValueMember = "ID_NV";
            slkNhanVien.Properties.DisplayMember = "Ten";
        }
        //Lưu dữ liệu thông qua Add hoặc Update
        void SaveData()
        {
            int x;
            string tenLoai;
            bool kethuc;
            if (cbLoai.SelectedIndex == 1)
            {
                x = 1;
                tenLoai = "KT";
                kethuc = false;
                
            }
            else
            {
                x = 0;
                tenLoai = "KL";
                kethuc = true;
            }
            if (_add)
            {
                
                var soQDMAX = _ktkl.SoQDMAX(x);
                int so = int.Parse(soQDMAX.Substring(0, 5)) + 1;

                tb_KhenThuongKyLuat kt = new tb_KhenThuongKyLuat();
                kt.SoQD = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/QD"+tenLoai;
                kt.TuNgay = dtTuNgay.Value;
                if (kethuc)
                {
                    kt.DenNgay = dtDenNgay.Value;
                }
                kt.NgayKi = dtNgay.Value;
                kt.LiDo = txtLiDo.Text;
                kt.NoiDung = txtNoiDung.Text;
                kt.ID_NV = slkNhanVien.EditValue.ToString();
                kt.Create_Time = DateTime.Now;
                kt.Create_By = "1";
                kt.Loai = x;
                _ktkl.Add(kt);
            }
            else
            {
                var kt = _ktkl.getItem(_soQD);
                kt.TuNgay = dtTuNgay.Value;
                if (kethuc)
                {
                    kt.DenNgay = dtDenNgay.Value;
                }
                kt.ID_NV = slkNhanVien.EditValue.ToString();
                kt.NgayKi = dtNgay.Value;
                kt.LiDo = txtLiDo.Text;
                kt.NoiDung = txtNoiDung.Text;
                kt.Create_Time = DateTime.Now;
                kt.Create_By = "1";
                _ktkl.Update(kt);
            }
        }
        void _reset()
        {
            txtSoQD.Text = string.Empty;
            txtNoiDung.Text = string.Empty;
            txtLiDo.Text = string.Empty;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmKhenThuong_Load(object sender, EventArgs e)
        {
            _ktkl = new KhenThuong_KyLuat();
            _nhanvien = new NhanVien();

            _add = false;
            showHide(true);
            LoadDataKhenThuong();
            LoadDataKyLuat();
            loadNV();
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
                _ktkl.Delete(_soQD,"1");
                LoadDataKhenThuong();
                LoadDataKyLuat();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            LoadDataKhenThuong();
            LoadDataKyLuat();
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
        private void gvDanhSach_Click_1(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount != 0)
            {
                _click = true;
                _soQD = gvDanhSach.GetFocusedRowCellValue("SoQD").ToString();
                var kt = _ktkl.getItem(_soQD);
                txtSoQD.Text = _soQD;
                dtTuNgay.Value = (DateTime)kt.TuNgay;
                slkNhanVien.EditValue = kt.ID_NV;
                dtNgay.Value = kt.NgayKi;
                txtLiDo.Text = kt.LiDo;
                txtNoiDung.Text = kt.NoiDung;
                cbLoai.SelectedIndex = 1;
                showHide(true);
                splitContainer1.Panel1Collapsed = false;
            }
        }

        private void gvDanhSachKiLuat_Click_1(object sender, EventArgs e)
        {
            if (gvDanhSachKiLuat.RowCount != 0)
            {
                _click = true;
                _soQD = gvDanhSachKiLuat.GetFocusedRowCellValue("SoQD").ToString();
                var kt = _ktkl.getItem(_soQD);
                txtSoQD.Text = _soQD;
                dtTuNgay.Value =(DateTime)kt.TuNgay;
                dtDenNgay.Value=(DateTime)kt.DenNgay;
                slkNhanVien.EditValue = kt.ID_NV;
                dtNgay.Value = kt.NgayKi;
                txtLiDo.Text = kt.LiDo;
                txtNoiDung.Text = kt.NoiDung;
                cbLoai.SelectedIndex = 0;
                showHide(true);
                splitContainer1.Panel1Collapsed = false;
            }
        }

        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoai.SelectedIndex == 1)
            {
                dtDenNgay.Enabled = false;

            }
            else
            {
                dtDenNgay.Enabled=true;
            }
        }
    }
}