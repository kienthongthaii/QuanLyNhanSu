using BusinessLayer;
using QLNhanSu.CHAMCONG;
using QLNhanSu.HETHONG;
using QLNhanSu.LUONG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNhanSu
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        NhanVien nhanVien;
        HopDongLaoDong _hopDong;
        // Ngăn việc mở trùng form khi nhấn đúp
        void openForm(Type typeForm)
        {
            foreach (var frm in MdiChildren)
            {
                if (frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }
        void loadSinhNhat()
        {
            lstSinhNhat.DataSource = nhanVien.getSinhNhat();
            lstSinhNhat.DisplayMember = "Ten";
            lstSinhNhat.ValueMember = "ID_NV";
        }
        void loadAutoTangLuong()
        {
            lstDieuChinhLuong.DataSource = _hopDong.getAutoLenLuong();
            lstDieuChinhLuong.DisplayMember = "TenNV";
            lstDieuChinhLuong.ValueMember = "ID_NV";
        }
        private void btnDanToc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmDanToc));
        }

        private void btnTonGiao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmTonGiao));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            nhanVien = new NhanVien();
            _hopDong = new HopDongLaoDong();
            ribbonControl1.SelectedPage = DanhMuc;
            loadSinhNhat();
            loadAutoTangLuong();
        }

        private void btnTrinhDo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmTrinhDo));
        }

        private void btnPhongBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmPhongBan));
        }

        private void btnCongTy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnBoPhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmBoPhan));
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmNhanVien));
        }

        private void btnChucVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmChucVu));
        }

        private void btnHopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmHopDong));
        }

        private void btnKhenThuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmKhenThuong_KyLuat));
        }

        private void btnKyLuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDieuChuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmDieuChuyen));
        }

        private void btnThoiViec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmThoiViec));
        }

        private void btnDieuChinhLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmThangTien));
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstSinhNhat_CustomizeItem(object sender, DevExpress.XtraEditors.CustomizeTemplatedItemEventArgs e)
        {

            if (e.TemplatedItem.Elements[1].Text.Substring(0, 2) == DateTime.Now.Date.ToString().Substring(0, 2))
            {
                e.TemplatedItem.AppearanceItem.Normal.ForeColor = Color.Red;
            }
        }

        private void lstDieuChinhLuong_CustomizeItem(object sender, DevExpress.XtraEditors.CustomizeTemplatedItemEventArgs e)
        {
            if (e.TemplatedItem.Elements[1].Text.Substring(0, 2) == DateTime.Now.Date.ToString().Substring(0, 2))
            {
                e.TemplatedItem.AppearanceItem.Normal.ForeColor = Color.Red;
            }
        }

        private void btnLoaiCa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void btnLoaiCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void btnBangCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmKyCong));
        }

        private void btnBangCongChiTiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           frmBangCongCT frm = new frmBangCongCT();
            frm.ShowDialog();
        }

        private void btnPhuCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmPhuCap));
        }

        private void btnTangCa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmTangCa));
        }

        private void btnUngLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmUngLuong));
        }

        private void btnBangLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmBangLuong));
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void btnTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmTaiKhoan));
        }
    }
}
