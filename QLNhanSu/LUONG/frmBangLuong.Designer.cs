namespace QLNhanSu.LUONG
{
    partial class frmBangLuong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBangLuong));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTinhLuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoc = new DevExpress.XtraBars.BarButtonItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnXemBangLuong = new DevExpress.XtraEditors.SimpleButton();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Delete_By = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaKyCong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayCong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayPhep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayKhongPhep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayLe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayChuNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TangCa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhuCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UngLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThucLanh = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTinhLuong,
            this.btnSua,
            this.btnXoa,
            this.barButtonItem4,
            this.btnHuy,
            this.btnLuu,
            this.btnDong,
            this.btnIn,
            this.btnLoc,
            this.btnPrint});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(330, 178);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTinhLuong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrint, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Caption = "Tính Lương";
            this.btnTinhLuong.Id = 0;
            this.btnTinhLuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTinhLuong.ImageOptions.SvgImage")));
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnTinhLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTinhLuong_ItemClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "In";
            this.btnPrint.Id = 9;
            this.btnPrint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrint.ImageOptions.SvgImage")));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 6;
            this.btnDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDong.ImageOptions.SvgImage")));
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1932, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 867);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1932, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 833);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1932, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 833);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Lưu";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 5;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuu.ImageOptions.SvgImage")));
            this.btnLuu.Name = "btnLuu";
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Id = 7;
            this.btnIn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIn.ImageOptions.SvgImage")));
            this.btnIn.Name = "btnIn";
            // 
            // btnLoc
            // 
            this.btnLoc.Caption = "Lọc";
            this.btnLoc.Id = 8;
            this.btnLoc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoc.ImageOptions.SvgImage")));
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 34);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnXemBangLuong);
            this.splitContainer1.Panel1.Controls.Add(this.cboThang);
            this.splitContainer1.Panel1.Controls.Add(this.cboNam);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(1932, 833);
            this.splitContainer1.SplitterDistance = 135;
            this.splitContainer1.TabIndex = 8;
            // 
            // btnXemBangLuong
            // 
            this.btnXemBangLuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXemBangLuong.ImageOptions.SvgImage")));
            this.btnXemBangLuong.Location = new System.Drawing.Point(783, 42);
            this.btnXemBangLuong.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemBangLuong.Name = "btnXemBangLuong";
            this.btnXemBangLuong.Size = new System.Drawing.Size(210, 53);
            this.btnXemBangLuong.TabIndex = 8;
            this.btnXemBangLuong.Text = "Xem Bảng Lương";
            this.btnXemBangLuong.Click += new System.EventHandler(this.btnXemBangLuong_Click);
            // 
            // cboThang
            // 
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(504, 56);
            this.cboThang.Margin = new System.Windows.Forms.Padding(4);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(242, 27);
            this.cboThang.TabIndex = 7;
            // 
            // cboNam
            // 
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Location = new System.Drawing.Point(152, 56);
            this.cboNam.Margin = new System.Windows.Forms.Padding(4);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(238, 27);
            this.cboNam.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(418, 58);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 24);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Tháng : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(75, 58);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 24);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Năm :  ";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1932, 694);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Delete_By,
            this.ID,
            this.ID_NV,
            this.HoTen,
            this.MaKyCong,
            this.NgayCong,
            this.NgayPhep,
            this.NgayKhongPhep,
            this.NgayLe,
            this.NgayChuNhat,
            this.NgayThuong,
            this.TangCa,
            this.PhuCap,
            this.UngLuong,
            this.ThucLanh});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            // 
            // Delete_By
            // 
            this.Delete_By.FieldName = "Delete_By";
            this.Delete_By.MaxWidth = 30;
            this.Delete_By.MinWidth = 30;
            this.Delete_By.Name = "Delete_By";
            this.Delete_By.Visible = true;
            this.Delete_By.VisibleIndex = 0;
            this.Delete_By.Width = 30;
            // 
            // ID
            // 
            this.ID.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ID.AppearanceHeader.Options.UseFont = true;
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.MinWidth = 30;
            this.ID.Name = "ID";
            this.ID.Width = 112;
            // 
            // ID_NV
            // 
            this.ID_NV.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ID_NV.AppearanceHeader.Options.UseFont = true;
            this.ID_NV.Caption = "ID_NV";
            this.ID_NV.FieldName = "ID_NV";
            this.ID_NV.MaxWidth = 50;
            this.ID_NV.MinWidth = 50;
            this.ID_NV.Name = "ID_NV";
            this.ID_NV.Width = 50;
            // 
            // HoTen
            // 
            this.HoTen.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.HoTen.AppearanceHeader.Options.UseFont = true;
            this.HoTen.Caption = "Tên Nhân Viên";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.MaxWidth = 201;
            this.HoTen.MinWidth = 201;
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 2;
            this.HoTen.Width = 201;
            // 
            // MaKyCong
            // 
            this.MaKyCong.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.MaKyCong.AppearanceHeader.Options.UseFont = true;
            this.MaKyCong.Caption = "Kỳ Công";
            this.MaKyCong.FieldName = "MaKyCong";
            this.MaKyCong.MinWidth = 30;
            this.MaKyCong.Name = "MaKyCong";
            this.MaKyCong.Visible = true;
            this.MaKyCong.VisibleIndex = 1;
            this.MaKyCong.Width = 112;
            // 
            // NgayCong
            // 
            this.NgayCong.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.NgayCong.AppearanceHeader.Options.UseFont = true;
            this.NgayCong.Caption = "Ngày Công";
            this.NgayCong.DisplayFormat.FormatString = "n0";
            this.NgayCong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NgayCong.FieldName = "NgayCong";
            this.NgayCong.MinWidth = 30;
            this.NgayCong.Name = "NgayCong";
            this.NgayCong.Visible = true;
            this.NgayCong.VisibleIndex = 3;
            this.NgayCong.Width = 112;
            // 
            // NgayPhep
            // 
            this.NgayPhep.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.NgayPhep.AppearanceHeader.Options.UseFont = true;
            this.NgayPhep.Caption = "Ngày Phép";
            this.NgayPhep.DisplayFormat.FormatString = "n0";
            this.NgayPhep.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NgayPhep.FieldName = "NgayPhep";
            this.NgayPhep.MinWidth = 30;
            this.NgayPhep.Name = "NgayPhep";
            this.NgayPhep.Visible = true;
            this.NgayPhep.VisibleIndex = 5;
            this.NgayPhep.Width = 112;
            // 
            // NgayKhongPhep
            // 
            this.NgayKhongPhep.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.NgayKhongPhep.AppearanceHeader.Options.UseFont = true;
            this.NgayKhongPhep.Caption = "Ngày Không Phép";
            this.NgayKhongPhep.DisplayFormat.FormatString = "n0";
            this.NgayKhongPhep.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NgayKhongPhep.FieldName = "NgayKhongPhep";
            this.NgayKhongPhep.MinWidth = 32;
            this.NgayKhongPhep.Name = "NgayKhongPhep";
            this.NgayKhongPhep.Visible = true;
            this.NgayKhongPhep.VisibleIndex = 6;
            this.NgayKhongPhep.Width = 121;
            // 
            // NgayLe
            // 
            this.NgayLe.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.NgayLe.AppearanceHeader.Options.UseFont = true;
            this.NgayLe.Caption = "Ngày Lễ";
            this.NgayLe.DisplayFormat.FormatString = "n0";
            this.NgayLe.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NgayLe.FieldName = "NgayLe";
            this.NgayLe.MinWidth = 32;
            this.NgayLe.Name = "NgayLe";
            this.NgayLe.Visible = true;
            this.NgayLe.VisibleIndex = 7;
            this.NgayLe.Width = 121;
            // 
            // NgayChuNhat
            // 
            this.NgayChuNhat.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.NgayChuNhat.AppearanceHeader.Options.UseFont = true;
            this.NgayChuNhat.Caption = "Ngày Chủ Nhật";
            this.NgayChuNhat.DisplayFormat.FormatString = "n0";
            this.NgayChuNhat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NgayChuNhat.FieldName = "NgayChuNhat";
            this.NgayChuNhat.MinWidth = 32;
            this.NgayChuNhat.Name = "NgayChuNhat";
            this.NgayChuNhat.Visible = true;
            this.NgayChuNhat.VisibleIndex = 8;
            this.NgayChuNhat.Width = 121;
            // 
            // NgayThuong
            // 
            this.NgayThuong.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.NgayThuong.AppearanceHeader.Options.UseFont = true;
            this.NgayThuong.Caption = "Ngày Thường";
            this.NgayThuong.DisplayFormat.FormatString = "n0";
            this.NgayThuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NgayThuong.FieldName = "NgayThuong";
            this.NgayThuong.MinWidth = 32;
            this.NgayThuong.Name = "NgayThuong";
            this.NgayThuong.Visible = true;
            this.NgayThuong.VisibleIndex = 4;
            this.NgayThuong.Width = 121;
            // 
            // TangCa
            // 
            this.TangCa.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.TangCa.AppearanceHeader.Options.UseFont = true;
            this.TangCa.Caption = "Tăng Ca";
            this.TangCa.DisplayFormat.FormatString = "n0";
            this.TangCa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TangCa.FieldName = "TangCa";
            this.TangCa.MinWidth = 32;
            this.TangCa.Name = "TangCa";
            this.TangCa.Visible = true;
            this.TangCa.VisibleIndex = 9;
            this.TangCa.Width = 121;
            // 
            // PhuCap
            // 
            this.PhuCap.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.PhuCap.AppearanceHeader.Options.UseFont = true;
            this.PhuCap.Caption = "Phụ Cấp";
            this.PhuCap.DisplayFormat.FormatString = "n0";
            this.PhuCap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PhuCap.FieldName = "PhuCap";
            this.PhuCap.MinWidth = 32;
            this.PhuCap.Name = "PhuCap";
            this.PhuCap.Visible = true;
            this.PhuCap.VisibleIndex = 10;
            this.PhuCap.Width = 121;
            // 
            // UngLuong
            // 
            this.UngLuong.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.UngLuong.AppearanceHeader.Options.UseFont = true;
            this.UngLuong.Caption = "Ứng Lương";
            this.UngLuong.DisplayFormat.FormatString = "n0";
            this.UngLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.UngLuong.FieldName = "UngLuong";
            this.UngLuong.MinWidth = 32;
            this.UngLuong.Name = "UngLuong";
            this.UngLuong.Visible = true;
            this.UngLuong.VisibleIndex = 11;
            this.UngLuong.Width = 121;
            // 
            // ThucLanh
            // 
            this.ThucLanh.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ThucLanh.AppearanceHeader.Options.UseFont = true;
            this.ThucLanh.Caption = "Thực Lãnh";
            this.ThucLanh.DisplayFormat.FormatString = "n0";
            this.ThucLanh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ThucLanh.FieldName = "ThucLanh";
            this.ThucLanh.MinWidth = 32;
            this.ThucLanh.Name = "ThucLanh";
            this.ThucLanh.Visible = true;
            this.ThucLanh.VisibleIndex = 12;
            this.ThucLanh.Width = 121;
            // 
            // frmBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1932, 887);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBangLuong";
            this.Text = "Bảng Lương";
            this.Load += new System.EventHandler(this.frmBangLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnTinhLuong;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnLoc;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn Delete_By;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn ID_NV;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn MaKyCong;
        private DevExpress.XtraGrid.Columns.GridColumn NgayCong;
        private DevExpress.XtraGrid.Columns.GridColumn NgayPhep;
        private DevExpress.XtraEditors.SimpleButton btnXemBangLuong;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.ComboBox cboNam;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraGrid.Columns.GridColumn NgayKhongPhep;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLe;
        private DevExpress.XtraGrid.Columns.GridColumn NgayChuNhat;
        private DevExpress.XtraGrid.Columns.GridColumn NgayThuong;
        private DevExpress.XtraGrid.Columns.GridColumn ThucLanh;
        private DevExpress.XtraGrid.Columns.GridColumn TangCa;
        private DevExpress.XtraGrid.Columns.GridColumn PhuCap;
        private DevExpress.XtraGrid.Columns.GridColumn UngLuong;
    }
}