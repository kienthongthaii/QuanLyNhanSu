using BusinessLayer;
using BusinessLayer.DTO;
using DataLayer;
using DevExpress.XtraEditors;
using QLNhanSu.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Serialization;
using System.Reflection;
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;
using DevExpress.Utils.Extensions;

namespace QLNhanSu
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        NhanVien _nhanvien;
        DanToc _dantoc;
        TonGiao _tongiao;
        PhongBan _phongban;
        ChucVu _chucvu;
        BoPhan _bophan;
        TrinhDo _trinhdo;

        bool _add;
        int _id;
        bool _click;
        bool flag = false;

        List<NhanVien_DTO> _listNVDTO;
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            _add = false;
            _nhanvien = new NhanVien();
            _phongban = new PhongBan();
            _chucvu = new ChucVu();
            _bophan = new BoPhan();
            _trinhdo = new TrinhDo();
            _dantoc = new DanToc();
            _tongiao = new TonGiao();
            showHide(true);
            LoadData();
            loadCombo();
            flag = true;

        }
        void loadCombo()
        {
            cbPhongBan.DataSource = _phongban.getlist();
            cbPhongBan.DisplayMember = "TenPB";
            cbPhongBan.ValueMember = "ID_PB";

            cbChucVu.DataSource = _chucvu.getlist();
            cbChucVu.DisplayMember = "TenCV";
            cbChucVu.ValueMember = "ID_CV"; 

            cbTrinhDo.DataSource = _trinhdo.getlist();
            cbTrinhDo.DisplayMember = "TenTD";
            cbTrinhDo.ValueMember = "ID_TD";

            cbDanToc.DataSource = _dantoc.getlist();
            cbDanToc.DisplayMember = "TenDT";
            cbDanToc.ValueMember = "ID_DT";

            cbTonGiao.DataSource = _tongiao.getlist();
            cbTonGiao.DisplayMember = "TenTG";
            cbTonGiao.ValueMember = "ID_TG";

        }
        void loadBoPhan(int x)
        {
            cbBoPhan.DataSource = _bophan.getlistWithPB(x);
            cbBoPhan.ValueMember = "ID_BP";
            cbBoPhan.DisplayMember = "TenBP";

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
            txtTenNV.Enabled = !check;
            chkGioiTinh.Enabled = !check;
            txtEmail.Enabled = !check;
            dtNgaySinh.Enabled = !check;
            dtNgayLam.Enabled = !check;
            btnChonAnh.Enabled = !check;
            txtCCCD.Enabled = !check;
            txtDiaChi.Enabled = !check;
            txtDienThoai.Enabled = !check;
            cbTrinhDo.Enabled = !check;
            cbDanToc.Enabled = !check;
            cbTonGiao.Enabled = !check;
            cbChucVu.Enabled = !check;
            cbBoPhan.Enabled = !check;
            cbPhongBan.Enabled = !check;

        }

        void LoadData()
        {
            gcDanhSach.DataSource = _nhanvien.getlistFull();
            gvDanhSach.OptionsBehavior.Editable = false;
            _listNVDTO = _nhanvien.getlistFull();
        }
        public bool BoPhanCoTruongBoPhan(int idBoPhan)
        {
            var boPhan = _bophan.getItem(idBoPhan);
            return boPhan.ID_TruongBP.HasValue;
        }
        //Lưu dữ liệu thông qua Add hoặc Update
        void SaveData()
        {
            tb_NhanVien nv;
            if (_add)
            {
                nv = new tb_NhanVien();
                nv.Ten = txtTenNV.Text;
                nv.GioiTinh = chkGioiTinh.Checked;
                nv.NgaySinh = dtNgaySinh.Value;
                nv.NgayLam = dtNgayLam.Value;
                nv.DienThoai = txtDienThoai.Text;
                nv.Email = txtEmail.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.CCCD = txtCCCD.Text;
                nv.Anh = ImageToBase64(pAnh.Image, pAnh.Image.RawFormat);
                nv.ID_PB = int.Parse(cbPhongBan.SelectedValue.ToString());
                nv.ID_CV = int.Parse(cbChucVu.SelectedValue.ToString());
                nv.ID_BP = int.Parse(cbBoPhan.SelectedValue.ToString());
                nv.ID_DT = int.Parse(cbDanToc.SelectedValue.ToString());
                nv.ID_TD = int.Parse(cbTrinhDo.SelectedValue.ToString());
                nv.ID_TG = int.Parse(cbTonGiao.SelectedValue.ToString());
                nv.ID_CT = 1;
                _nhanvien.Add(nv);
            }
            else
            {

                nv = _nhanvien.getItem(_id);
                nv.Ten = txtTenNV.Text;
                nv.GioiTinh = chkGioiTinh.Checked;
                nv.NgaySinh = dtNgaySinh.Value;
                nv.NgayLam = dtNgayLam.Value;
                nv.Email = txtEmail.Text;
                nv.DienThoai = txtDienThoai.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.CCCD = txtCCCD.Text;
                nv.Anh = ImageToBase64(pAnh.Image, pAnh.Image.RawFormat);
                nv.ID_PB = int.Parse(cbPhongBan.SelectedValue.ToString());
                nv.ID_CV = int.Parse(cbChucVu.SelectedValue.ToString());
                nv.ID_BP = int.Parse(cbBoPhan.SelectedValue.ToString());
                nv.ID_DT = int.Parse(cbDanToc.SelectedValue.ToString());
                nv.ID_TD = int.Parse(cbTrinhDo.SelectedValue.ToString());
                nv.ID_TG = int.Parse(cbTonGiao.SelectedValue.ToString());
                nv.ID_CT = 1;

                _nhanvien.Update(nv);
            }
            
        }
        //Chuyển đổi hình ảnh thành x64 lưu vào database
        public byte[] ImageToBase64(Image img, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, format);
                byte[] data = ms.ToArray();
                return data;
            }
        }
        //Chuyển từ x64 sang Image
        public Image Base64ToImage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data, 0, data.Length);
            ms.Write(data, 0, data.Length);
            Image img = Image.FromStream(ms,true);
            return img;

        }

        void _reset()
        {
            txtTenNV.Text = string.Empty;
            txtCCCD.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            dtNgayLam.Value = DateTime.Now;
            chkGioiTinh.Checked = false;

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
            cbChucVu.Enabled = false;
            cbBoPhan.Enabled = false;
            cbPhongBan.Enabled = false;
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
                _nhanvien.Delete(_id);
                LoadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTenNV.Text == string.Empty)
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
            reportDanhSachNhanVien rpt = new reportDanhSachNhanVien(_listNVDTO);
            rpt.ShowRibbonPreview();
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
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID_NV").ToString());
                var nv = _nhanvien.getItem(_id);
                txtTenNV.Text = nv.Ten;
                chkGioiTinh.Checked = nv.GioiTinh;
                dtNgaySinh.Value = nv.NgaySinh;
                dtNgayLam.Value = nv.NgayLam;
                txtDienThoai.Text = nv.DienThoai;
                txtDiaChi.Text = nv.DiaChi;
                txtEmail.Text = nv.Email;
                txtCCCD.Text = nv.CCCD;
                pAnh.Image = Base64ToImage(nv.Anh);
                cbPhongBan.SelectedValue = nv.ID_PB;
                cbChucVu.SelectedValue = nv.ID_CV;
                cbBoPhan.SelectedValue = nv.ID_BP;
                cbDanToc.SelectedValue = nv.ID_DT;
                cbTrinhDo.SelectedValue = nv.ID_TD;
                cbTonGiao.SelectedValue = nv.ID_TG;
                //nv.ID_CT = 1;
                showHide(true);
               
                
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file (.png, .jpg)|*.png; *.jpg";
            openFile.Title = "Chọn hình ảnh";
            if (openFile.ShowDialog()==DialogResult.OK)
            {
                pAnh.Image = Image.FromFile(openFile.FileName);
                pAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                loadBoPhan(int.Parse(cbPhongBan.SelectedValue.ToString()));
            }
        }
    }
}