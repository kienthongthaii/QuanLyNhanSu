using BusinessLayer.DTO;
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
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;

namespace QLNhanSu
{
    public partial class frmDieuChuyen : DevExpress.XtraEditors.XtraForm
    {
        public frmDieuChuyen()
        {
            InitializeComponent();
        }
        NhanVien _nhanvien;
        PhongBan _phongban;
        BoPhan _bophan;
        NhanVienDieuChuyen _nvdc;
        string _soQD;
        bool _add;
        bool _click;
        bool flag = false;

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void loadNV()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getlist();
            slkNhanVien.Properties.ValueMember = "ID_NV";
            slkNhanVien.Properties.DisplayMember = "Ten";

        }
        void loadPBNEW()
        {
            cboPB_New.DataSource = _phongban.getlist();
            cboPB_New.ValueMember = "ID_PB";
            cboPB_New.DisplayMember = "TenPB";
            
        }
        void loadBPNEW(int x)
        {
            cboBPNew.DataSource = _bophan.getlistWithPB(x);
            cboBPNew.ValueMember = "ID_BP";
            cboBPNew.DisplayMember = "TenBP";

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
            txtLiDo.Enabled = !check;
            txtGhiChu.Enabled = !check;
            slkNhanVien.Enabled = !check;
            cboPB_New.Enabled = !check;
            dtNgay.Enabled = !check;
            

        }

        void LoadData()
        {
            gcDanhSach.DataSource =_nvdc.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false; 
        }
        //Lưu dữ liệu thông qua Add hoặc Update
        void SaveData()
        {
            tb_DieuChuyen dc;
            if (_add)
            {
                dc = new tb_DieuChuyen();
                var soQDMAX = _nvdc.soQuyetDinhMAX();
                int so = int.Parse(soQDMAX.Substring(0,5))+1;
                dc.SoQD = so.ToString("00000")+@"/"+DateTime.Now.Year.ToString()+@"/QDĐC";
                dc.Ngay = dtNgay.Value;
                dc.LiDo = txtLiDo.Text;
                dc.GhiChu = txtGhiChu.Text;
                dc.ID_NV = int.Parse(slkNhanVien.EditValue.ToString());
                dc.ID_PB = _nhanvien.getItem(int.Parse(slkNhanVien.EditValue.ToString())).ID_PB;
                dc.ID_PBNew = int.Parse(cboPB_New.SelectedValue.ToString());
                dc.ID_BP = _nhanvien.getItem(int.Parse(slkNhanVien.EditValue.ToString())).ID_BP;
                dc.ID_BPNew = int.Parse(cboBPNew.SelectedValue.ToString());
                dc.Create_By = 1;
                dc.Create_Time = DateTime.Now;
                _nvdc.Add(dc);
            }
            else
            {
                dc = _nvdc.getItem(_soQD);
                dc.Ngay = dtNgay.Value;
                dc.LiDo = txtLiDo.Text;
                dc.GhiChu = txtGhiChu.Text;
                dc.ID_NV = int.Parse(slkNhanVien.EditValue.ToString());
                dc.ID_PBNew = int.Parse(cboPB_New.SelectedValue.ToString());
                dc.ID_BPNew = int.Parse(cboBPNew.SelectedValue.ToString());
                dc.Update_By = 1;
                dc.Update_Time = DateTime.Now;
                _nvdc.Update(dc);
            }
            var nv = _nhanvien.getItem(dc.ID_NV.Value);
            nv.ID_PB = (int)dc.ID_PBNew;
            _nhanvien.Update(nv);
        }

        void _reset()
        {
            txtGhiChu.Text = string.Empty;
            txtLiDo.Text = string.Empty;
            txtSoQD.Text = string.Empty;

        }

        private void frmDieuChuyen_Load(object sender, EventArgs e)
        {
            _add = false;
            _nhanvien = new NhanVien();
            _phongban = new PhongBan();
            _bophan = new BoPhan();
            _nvdc = new NhanVienDieuChuyen();
            showHide(true);
            loadNV();
            loadPBNEW();
            LoadData();
            flag = true;


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
                _nvdc.Delete(_soQD,1);
                LoadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                SaveData();
                LoadData();
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

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _click = true;
                _soQD = gvDanhSach.GetFocusedRowCellValue("SoQD").ToString();
                var dc = _nvdc.getItem(_soQD);
                txtSoQD.Text = _soQD;
                dtNgay.Value = dc.Ngay.Value;
                slkNhanVien.EditValue = dc.ID_NV;
                txtGhiChu.Text = dc.GhiChu;
                txtLiDo.Text = dc.LiDo;
                cboPB_New.SelectedValue = dc.ID_PBNew;
                cboBPNew.SelectedValue = dc.ID_BPNew;
                showHide(true);
                splitContainer1.Panel1Collapsed = false;
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
        
        private void cboPB_New_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                loadBPNEW(int.Parse(cboPB_New.SelectedValue.ToString()));
            }
        }

        private void cboBPNew_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void cboPB_New_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}