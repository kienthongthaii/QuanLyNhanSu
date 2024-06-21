using BusinessLayer;
using BusinessLayer.CHAMCONG_BL;
using BusinessLayer.TINHLUONG_BL;
using DataLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraGauges.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.LUONG
{
    public partial class frmPhuCap : DevExpress.XtraEditors.XtraForm
    {
        public frmPhuCap()
        {
            InitializeComponent();
        }
        PhuCap _PhuCap;
        NhanVien _NhanVien;
        bool _add;
        int _id;
        bool _click;

        private void frmPhuCap_Load(object sender, EventArgs e)
        {

            _add = false;
            _PhuCap = new PhuCap();
            _NhanVien = new NhanVien();
            showHide(true);
            
            LoadNhanVien();
            
            LoadData();
            // Gọi hàm LoadPhuCap để tải dữ liệu phụ cấp vào cboLoaiPhuCap
            LoadPhuCap();
            // Gọi hàm LoadPhuCapData để tải thông tin chi tiết của phụ cấp mặc định
            //LoadPhuCapData(int.Parse(cboLoaiPhuCap.SelectedValue.ToString()));


        }
        private void cboLoaiPhuCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
            slkNhanVien.Enabled = !check;
            cboLoaiPhuCap.Enabled = !check;
            txtGhiChu.Enabled = !check;
            spSoTien.Enabled = !check;
        }
        void reset()
        {
            txtGhiChu.Text = string.Empty;
            spSoTien.EditValue = 0;
            slkNhanVien.EditValue = 0;
            cboLoaiPhuCap.SelectedIndex = 0;
        }

        void LoadData()
        {
            gcDanhSach.DataSource = _PhuCap.getlistFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void LoadNhanVien()
        {
            slkNhanVien.Properties.DataSource = _NhanVien.getlistFull();
            slkNhanVien.Properties.DisplayMember = "Ten";
            slkNhanVien.Properties.ValueMember = "ID_NV";

        }
        void LoadPhuCap()
        {
            cboLoaiPhuCap.DataSource = _PhuCap.getlistPC();
            cboLoaiPhuCap.DisplayMember = "TenPC";
            cboLoaiPhuCap.ValueMember = "ID_PC";

        }
        //Lưu dữ liệu thông qua Add hoặc Update
        void SaveData()
        {
            if (_add)
            {
                
                tb_NhanVien_PhuCap pc = new tb_NhanVien_PhuCap();
                pc.ID_PC = cboLoaiPhuCap.SelectedValue.ToString();
                pc.ID_NV = slkNhanVien.EditValue.ToString();
                pc.NoiDung = txtGhiChu.Text;
                pc.NgayKi = DateTime.Now;
                pc.Create_By = "1";
                pc.Create_Time = DateTime.Now;
                _PhuCap.Add(pc);
            }
            else
            {
                var pc = _PhuCap.getItem(_id);
                pc.ID_PC = cboLoaiPhuCap.SelectedValue.ToString();
                pc.ID_NV = slkNhanVien.EditValue.ToString();
                pc.NoiDung = txtGhiChu.Text;
                pc.NgayKi = DateTime.Now;
                pc.Update_By = "1";
                pc.Update_Time = DateTime.Now;
                _PhuCap.Update(pc);
            }
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
                _PhuCap.Delete(_id, "1");
                LoadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (slkNhanVien.Text == string.Empty)
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
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
            txtGhiChu.Text = gvDanhSach.GetFocusedRowCellValue("NoiDung").ToString();
            spSoTien.Text = gvDanhSach.GetFocusedRowCellValue("SoTien").ToString();
            cboLoaiPhuCap.SelectedValue = gvDanhSach.GetFocusedRowCellValue("ID_PC");
            slkNhanVien.EditValue = gvDanhSach.GetFocusedRowCellValue("ID_NV");
            
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
        private void LoadPhuCapData(string loaiPhuCapId)
        {
            var pc = _PhuCap.getItemPC(loaiPhuCapId);
            if (pc != null)
            {
                spSoTien.EditValue = pc.SoTien;
                // Cập nhật các điều khiển khác với thông tin phụ cấp
            }
            else
            {
                // Xử lý trường hợp không tìm thấy phụ cấp tương ứng
                // Ví dụ: clear các điều khiển hiển thị thông tin phụ cấp
            }
        }

        private void cboLoaiPhuCap_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboLoaiPhuCap.SelectedValue == null || string.IsNullOrEmpty(cboLoaiPhuCap.SelectedValue.ToString()))
            {
                // Xử lý trường hợp không có giá trị được chọn (ví dụ: clear các điều khiển hiển thị thông tin phụ cấp)
                return;
            }

            string loaiPhuCapId = cboLoaiPhuCap.SelectedValue.ToString();

            if (!string.IsNullOrEmpty(loaiPhuCapId))
            {
                LoadPhuCapData(loaiPhuCapId);
            }
            else
            {
                // Xử lý trường hợp giá trị được chọn không phải là chuỗi hợp lệ
                // Ví dụ: hiển thị thông báo lỗi hoặc clear các điều khiển hiển thị thông tin phụ cấp
            }
        }
    }
}