using BusinessLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.CHAMCONG_BL;
using DataLayer;
using QLNhanSu.Reports;
using DevExpress.XtraReports.UI;

namespace QLNhanSu.CHAMCONG
{
    public partial class frmBangCongChiTiet : DevExpress.XtraEditors.XtraForm
    {
        public frmBangCongChiTiet()
        {
            InitializeComponent();
        }
        KyCong _kyCong;
        KyCongChiTiet _kcct;
        NhanVien _nhanVien;
        BangCong_NV_CT _bangCongCT;
        public string _makycong;
        public int _thang;
        public int _nam;
        public void loadBangCong()
        {
            _kcct = new KyCongChiTiet();
            gcBangCongChiTiet.DataSource = _kcct.getList(_makycong);    
            CustomView(int.Parse(cbThang.Text), int.Parse(cbNam.Text));
            gvBangCongChiTiet.OptionsBehavior.Editable = false;
        }

        private void frmBangCongChiTiet_Load(object sender, EventArgs e)
        {
            gcBangCongChiTiet.ContextMenuStrip = contextMenuStrip1;
            _kyCong = new KyCong();
            _kcct = new KyCongChiTiet();
            _nhanVien = new NhanVien();
            _bangCongCT = new BangCong_NV_CT();
            gcBangCongChiTiet.DataSource = _kcct.getList(_makycong);
            gvBangCongChiTiet.OptionsBehavior.Editable=false;
            cbThang.Text = _thang.ToString();
            cbNam.Text = _nam.ToString();
            CustomView(_thang, _nam);

        }
        private void btnPhatSinhKyCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmWaiting),true,true);
            if (_kyCong.checkTrangThai(cbNam.Text+cbThang.Text))
            {
                MessageBox.Show("Kỳ công đã được phát sinh không thể phát sinh lại!", "Thông Báo", MessageBoxButtons.OK);
                SplashScreenManager.CloseForm();
                return;
            }
            
            List<tb_NhanVien> lstNhanVien = _nhanVien.getlist();
            _kcct.phatSinhKyCongChiTiet(int.Parse(cbThang.Text),int.Parse(cbNam.Text));
            foreach (var item in lstNhanVien)
            {
                for (int i = 1; i <= GetDayNumber(int.Parse(cbThang.Text), int.Parse(cbNam.Text)); i++)
                {
                    tb_BangCong_NV_CT bcnvct = new tb_BangCong_NV_CT();
                    bcnvct.ID_NV = item.ID_NV;
                    bcnvct.TenNV = item.TenNV;
                    bcnvct.GioVao = "08:00";
                    bcnvct.GioRa = "17:00";
                    bcnvct.Ngay = DateTime.Parse(cbNam.Text+"-"+cbThang.Text+"-"+i.ToString());
                    bcnvct.Thu = Funcions.layThuTrongTuan(int.Parse(cbNam.Text),int.Parse(cbThang.Text),i);
                    bcnvct.NgayPhep = 0;
                    bcnvct.NgayKhongPhep = 0;
                    bcnvct.NgayLe = 0;
                    bcnvct.NgayChuNhat = 0;
                    if (bcnvct.Thu =="Chủ nhật")
                    {
                        bcnvct.KyHieu = "CN";
                        bcnvct.NgayThuong = 0;
                    }
                    else
                    {
                        bcnvct.KyHieu = "-";
                        bcnvct.NgayThuong = 1;
                    }
                    bcnvct.MaKyCong = _makycong;
                    bcnvct.Create_By = "1";
                    bcnvct.Create_Time =DateTime.Now;
                    _bangCongCT.Add(bcnvct);
                }
            }
            
            SplashScreenManager.CloseForm();
            var kc = _kyCong.getItem(cbNam.Text + cbThang.Text);
            kc.TrangThai = true;
            _kyCong.Update(kc);
            loadBangCong();
        }
        private void btnXemBangCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadBangCong();
        }
        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadBangCong();
        }
        private void btnInBangCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<tb_KyCongChiTiet> lst = _kcct.getList(_makycong);
            rptBangCongTongHop rpt = new rptBangCongTongHop(lst,_makycong.ToString());
            
            rpt.ShowPreviewDialog();
        }
        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        //Định dạng view chấm công
        private void CustomView(int thang, int nam)
        {
            //Gán layout
            gvBangCongChiTiet.RestoreLayoutFromXml(Application.StartupPath + @"\BangCong_Layout.xml");
            int i;
            gvBangCongChiTiet.OptionsView.ColumnAutoWidth = true;
            gvBangCongChiTiet.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;

            foreach (GridColumn gridColumn in gvBangCongChiTiet.Columns)
            {
                if (gridColumn.FieldName == "HoTen") continue;

                RepositoryItemTextEdit textEdit = new RepositoryItemTextEdit();
                textEdit.Mask.MaskType = MaskType.RegEx;
                textEdit.Mask.EditMask = @"\p{Lu}+";
                gridColumn.ColumnEdit = textEdit;
            }
            //Load Tên các Colum (các thứ, ngày)
            for (i = 1; i <= GetDayNumber(thang, nam); i++)
            {
                DateTime newDate = new DateTime(nam, thang, i);
                GridColumn column = new GridColumn();
                column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                string fieldName = "D" + i;
                switch (newDate.DayOfWeek.ToString())
                {
                    case "Monday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T.Hai " + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        column.Width = 100;
                        column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        break;

                    case "Tuesday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T.Ba " + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        column.Width = 100;
                        break;

                    case "Wednesday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T.Tư " + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        column.Width = 100;
                        break;
                    case "Thursday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T.Năm " + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        column.Width = 100;
                        break;
                    case "Friday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T.Sáu " + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        column.Width = 100;
                        break;

                    case "Saturday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T.Bảy " + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Red;
                        column.AppearanceHeader.BackColor = Color.Violet;
                        column.AppearanceHeader.BackColor2 = Color.Violet;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Khaki;
                        column.OptionsColumn.AllowFocus = true;
                        column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        column.Width = 100;
                        break;

                    case "Sunday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "CN " + Environment.NewLine + i;
                        column.OptionsColumn.AllowEdit = false;
                        column.AppearanceHeader.ForeColor = Color.Red;
                        column.AppearanceHeader.BackColor = Color.GreenYellow;
                        column.AppearanceHeader.BackColor2 = Color.GreenYellow;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Orange;
                        column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        column.Width = 100;
                        column.OptionsColumn.AllowFocus = false;
                        break;
                }
            }
            while (i <= 31)
            {
                gvBangCongChiTiet.Columns[i + 1].Visible = false;
                i++;
            }

        }
        //Lấy số ngày theo tháng
        private int GetDayNumber(int thang, int nam)
        {
            int dayNumber = 0;
            switch (thang)
            {
                case 2:
                    dayNumber = (nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0 ? 29 : 28;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    dayNumber = 30;
                    break;

                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dayNumber = 31;
                    break;
            }
            return dayNumber;
        }
        //Truyền dữ liệu qua frmCapNhatNgayCong
        private void mnCapNhatNgayCong_Click_1(object sender, EventArgs e)
        {
            frmCapNhatNgayCong frm = new frmCapNhatNgayCong();
            frm.makycong = _makycong;
            frm.id_nv = gvBangCongChiTiet.GetFocusedRowCellValue("ID_NV").ToString();
            frm.name_nv = gvBangCongChiTiet.GetFocusedRowCellValue("HoTen").ToString();
            frm._ngay = gvBangCongChiTiet.FocusedColumn.FieldName.ToString();
            frm.ShowDialog();
        }
        //Đổi màu cell khi có lịch nghỉ
        private void gvBangCongChiTiet_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.CellValue==null)
            {

            }
            else
            {
                if (e.CellValue.ToString()=="CT")
                {
                    e.Appearance.BackColor = Color.Yellow;
                    e.Appearance.ForeColor = Color.White;
                }
                if (e.CellValue.ToString() == "V")
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.ForeColor = Color.White;
                }
                if (e.CellValue.ToString() == "P")
                {
                    e.Appearance.BackColor = Color.DarkGreen;
                    e.Appearance.ForeColor = Color.White;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}
