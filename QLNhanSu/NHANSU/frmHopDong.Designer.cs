namespace QLNhanSu
{
    partial class frmHopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHopDong));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtLuongCoBan = new DevExpress.XtraEditors.TextEdit();
            this.cboThoiHan = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoiDung = new DevExpress.XtraRichEdit.RichEditControl();
            this.slkNhanVien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_ID_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.spLanKi = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayKi = new System.Windows.Forms.DateTimePicker();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoHD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SoHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LanKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LuongCoBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThoiHan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spHeSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.HeSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuongCoBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLanKi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoHD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHeSoLuong.Properties)).BeginInit();
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
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.barButtonItem4,
            this.btnHuy,
            this.btnLuu,
            this.btnDong,
            this.btnIn});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 5;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuu.ImageOptions.SvgImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Id = 7;
            this.btnIn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIn.ImageOptions.SvgImage")));
            this.btnIn.Name = "btnIn";
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // btnDong
            // 
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlTop.Size = new System.Drawing.Size(2009, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 820);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlBottom.Size = new System.Drawing.Size(2009, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 790);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(2009, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 790);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Lưu";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.spHeSoLuong);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl9);
            this.splitContainer1.Panel1.Controls.Add(this.txtLuongCoBan);
            this.splitContainer1.Panel1.Controls.Add(this.cboThoiHan);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl8);
            this.splitContainer1.Panel1.Controls.Add(this.txtNoiDung);
            this.splitContainer1.Panel1.Controls.Add(this.slkNhanVien);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.spLanKi);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayKi);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayKetThuc);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayBatDau);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.txtSoHD);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(2009, 790);
            this.splitContainer1.SplitterDistance = 892;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 5;
            // 
            // txtLuongCoBan
            // 
            this.txtLuongCoBan.Location = new System.Drawing.Point(409, 74);
            this.txtLuongCoBan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLuongCoBan.MenuManager = this.barManager1;
            this.txtLuongCoBan.Name = "txtLuongCoBan";
            this.txtLuongCoBan.Size = new System.Drawing.Size(166, 22);
            this.txtLuongCoBan.TabIndex = 18;
            // 
            // cboThoiHan
            // 
            this.cboThoiHan.FormattingEnabled = true;
            this.cboThoiHan.Items.AddRange(new object[] {
            "3 Tháng",
            "6 Tháng",
            "12 Tháng"});
            this.cboThoiHan.Location = new System.Drawing.Point(409, 102);
            this.cboThoiHan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboThoiHan.Name = "cboThoiHan";
            this.cboThoiHan.Size = new System.Drawing.Size(167, 24);
            this.cboThoiHan.TabIndex = 17;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(354, 102);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(51, 16);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Thời Hạn";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(9, 141);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNoiDung.MenuManager = this.barManager1;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(854, 640);
            this.txtNoiDung.TabIndex = 15;
            // 
            // slkNhanVien
            // 
            this.slkNhanVien.Location = new System.Drawing.Point(409, 18);
            this.slkNhanVien.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.slkNhanVien.MenuManager = this.barManager1;
            this.slkNhanVien.Name = "slkNhanVien";
            this.slkNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkNhanVien.Properties.PopupView = this.searchLookUpEdit1View;
            this.slkNhanVien.Size = new System.Drawing.Size(166, 22);
            this.slkNhanVien.TabIndex = 13;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_ID_NV,
            this.HoTenNV});
            this.searchLookUpEdit1View.DetailHeight = 295;
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Col_ID_NV
            // 
            this.Col_ID_NV.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.Col_ID_NV.AppearanceHeader.Options.UseFont = true;
            this.Col_ID_NV.Caption = "ID";
            this.Col_ID_NV.FieldName = "ID_NV";
            this.Col_ID_NV.MinWidth = 16;
            this.Col_ID_NV.Name = "Col_ID_NV";
            this.Col_ID_NV.Visible = true;
            this.Col_ID_NV.VisibleIndex = 0;
            this.Col_ID_NV.Width = 58;
            // 
            // HoTenNV
            // 
            this.HoTenNV.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.HoTenNV.AppearanceHeader.Options.UseFont = true;
            this.HoTenNV.Caption = "Họ Tên";
            this.HoTenNV.FieldName = "Ten";
            this.HoTenNV.MinWidth = 16;
            this.HoTenNV.Name = "HoTenNV";
            this.HoTenNV.Visible = true;
            this.HoTenNV.VisibleIndex = 1;
            this.HoTenNV.Width = 58;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(348, 21);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(58, 16);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Nhân Viên";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(327, 74);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(79, 16);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Lương Cơ Bản";
            // 
            // spLanKi
            // 
            this.spLanKi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spLanKi.Location = new System.Drawing.Point(409, 44);
            this.spLanKi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.spLanKi.MenuManager = this.barManager1;
            this.spLanKi.Name = "spLanKi";
            this.spLanKi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spLanKi.Properties.IsFloatValue = false;
            this.spLanKi.Properties.MaskSettings.Set("mask", "N00");
            this.spLanKi.Size = new System.Drawing.Size(166, 24);
            this.spLanKi.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(371, 48);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(34, 16);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Lần Kí";
            // 
            // dtNgayKi
            // 
            this.dtNgayKi.CustomFormat = "dd/mm/yyyy";
            this.dtNgayKi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayKi.Location = new System.Drawing.Point(138, 102);
            this.dtNgayKi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtNgayKi.Name = "dtNgayKi";
            this.dtNgayKi.Size = new System.Drawing.Size(142, 23);
            this.dtNgayKi.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(87, 105);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 16);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Ngày Kí";
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.CustomFormat = "dd/mm/yyyy";
            this.dtNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayKetThuc.Location = new System.Drawing.Point(137, 74);
            this.dtNgayKetThuc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.Size = new System.Drawing.Size(142, 23);
            this.dtNgayKetThuc.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(53, 80);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Ngày Kết Thúc";
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.CustomFormat = "dd/mm/yyyy";
            this.dtNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBatDau.Location = new System.Drawing.Point(138, 45);
            this.dtNgayBatDau.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.Size = new System.Drawing.Size(142, 23);
            this.dtNgayBatDau.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(58, 48);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ngày Bắt Đầu";
            // 
            // txtSoHD
            // 
            this.txtSoHD.Location = new System.Drawing.Point(137, 20);
            this.txtSoHD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSoHD.MenuManager = this.barManager1;
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Properties.ReadOnly = true;
            this.txtSoHD.Size = new System.Drawing.Size(142, 22);
            this.txtSoHD.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(97, 24);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Số HĐ";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1114, 790);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SoHD,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.NgayKy,
            this.LanKy,
            this.HeSoLuong,
            this.LuongCoBan,
            this.ThoiHan,
            this.ID_NV,
            this.TenNV});
            this.gvDanhSach.DetailHeight = 295;
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            // 
            // SoHD
            // 
            this.SoHD.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.SoHD.AppearanceHeader.Options.UseFont = true;
            this.SoHD.Caption = "Số Hợp Đồng";
            this.SoHD.FieldName = "SoHD";
            this.SoHD.MaxWidth = 156;
            this.SoHD.MinWidth = 156;
            this.SoHD.Name = "SoHD";
            this.SoHD.Visible = true;
            this.SoHD.VisibleIndex = 0;
            this.SoHD.Width = 156;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.NgayBatDau.AppearanceHeader.Options.UseFont = true;
            this.NgayBatDau.Caption = "Ngày Bắt Đầu";
            this.NgayBatDau.FieldName = "NgayBatDau";
            this.NgayBatDau.MaxWidth = 156;
            this.NgayBatDau.MinWidth = 156;
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.Visible = true;
            this.NgayBatDau.VisibleIndex = 2;
            this.NgayBatDau.Width = 156;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.NgayKetThuc.AppearanceHeader.Options.UseFont = true;
            this.NgayKetThuc.Caption = "Ngày Kết Thúc";
            this.NgayKetThuc.FieldName = "NgayKetThuc";
            this.NgayKetThuc.MinWidth = 23;
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.Visible = true;
            this.NgayKetThuc.VisibleIndex = 3;
            this.NgayKetThuc.Width = 87;
            // 
            // NgayKy
            // 
            this.NgayKy.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.NgayKy.AppearanceHeader.Options.UseFont = true;
            this.NgayKy.Caption = "Ngày Ký";
            this.NgayKy.FieldName = "NgayKy";
            this.NgayKy.MinWidth = 23;
            this.NgayKy.Name = "NgayKy";
            this.NgayKy.Visible = true;
            this.NgayKy.VisibleIndex = 4;
            this.NgayKy.Width = 87;
            // 
            // LanKy
            // 
            this.LanKy.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.LanKy.AppearanceHeader.Options.UseFont = true;
            this.LanKy.Caption = "Lần Ký";
            this.LanKy.FieldName = "LanKy";
            this.LanKy.MinWidth = 23;
            this.LanKy.Name = "LanKy";
            this.LanKy.Visible = true;
            this.LanKy.VisibleIndex = 5;
            this.LanKy.Width = 87;
            // 
            // LuongCoBan
            // 
            this.LuongCoBan.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.LuongCoBan.AppearanceHeader.Options.UseFont = true;
            this.LuongCoBan.Caption = "Lương Cơ Bản";
            this.LuongCoBan.FieldName = "LuongCoBan";
            this.LuongCoBan.MinWidth = 23;
            this.LuongCoBan.Name = "LuongCoBan";
            this.LuongCoBan.Visible = true;
            this.LuongCoBan.VisibleIndex = 6;
            this.LuongCoBan.Width = 87;
            // 
            // ThoiHan
            // 
            this.ThoiHan.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ThoiHan.AppearanceHeader.Options.UseFont = true;
            this.ThoiHan.Caption = "Thời Hạn";
            this.ThoiHan.FieldName = "ThoiHan";
            this.ThoiHan.MinWidth = 23;
            this.ThoiHan.Name = "ThoiHan";
            this.ThoiHan.Visible = true;
            this.ThoiHan.VisibleIndex = 8;
            this.ThoiHan.Width = 87;
            // 
            // ID_NV
            // 
            this.ID_NV.Caption = "ID_NV";
            this.ID_NV.FieldName = "ID_NV";
            this.ID_NV.MinWidth = 23;
            this.ID_NV.Name = "ID_NV";
            this.ID_NV.Width = 87;
            // 
            // TenNV
            // 
            this.TenNV.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.TenNV.AppearanceHeader.Options.UseFont = true;
            this.TenNV.Caption = "Họ Tên";
            this.TenNV.FieldName = "TenNV";
            this.TenNV.MinWidth = 23;
            this.TenNV.Name = "TenNV";
            this.TenNV.Visible = true;
            this.TenNV.VisibleIndex = 1;
            this.TenNV.Width = 87;
            // 
            // spHeSoLuong
            // 
            this.spHeSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spHeSoLuong.Location = new System.Drawing.Point(673, 19);
            this.spHeSoLuong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.spHeSoLuong.MenuManager = this.barManager1;
            this.spHeSoLuong.Name = "spHeSoLuong";
            this.spHeSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spHeSoLuong.Properties.IsFloatValue = false;
            this.spHeSoLuong.Properties.MaskSettings.Set("mask", "N00");
            this.spHeSoLuong.Size = new System.Drawing.Size(166, 24);
            this.spHeSoLuong.TabIndex = 20;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(596, 22);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(73, 16);
            this.labelControl9.TabIndex = 19;
            this.labelControl9.Text = "Hệ Số Lương";
            // 
            // HeSoLuong
            // 
            this.HeSoLuong.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.HeSoLuong.AppearanceHeader.Options.UseFont = true;
            this.HeSoLuong.Caption = "Hệ Số Lương";
            this.HeSoLuong.FieldName = "HeSoLuong";
            this.HeSoLuong.MinWidth = 25;
            this.HeSoLuong.Name = "HeSoLuong";
            this.HeSoLuong.Visible = true;
            this.HeSoLuong.VisibleIndex = 7;
            this.HeSoLuong.Width = 94;
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2009, 840);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::QLNhanSu.Properties.Resources.logoCellPhoneS;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmHopDong";
            this.Text = "Hợp Đồng";
            this.Load += new System.EventHandler(this.frmHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtLuongCoBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLanKi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoHD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHeSoLuong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn SoHD;
        private DevExpress.XtraGrid.Columns.GridColumn NgayBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn NgayKetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn NgayKy;
        private DevExpress.XtraGrid.Columns.GridColumn LanKy;
        private DevExpress.XtraGrid.Columns.GridColumn LuongCoBan;
        private DevExpress.XtraGrid.Columns.GridColumn ThoiHan;
        private DevExpress.XtraGrid.Columns.GridColumn ID_NV;
        private DevExpress.XtraGrid.Columns.GridColumn TenNV;
        private DevExpress.XtraEditors.TextEdit txtSoHD;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.DateTimePicker dtNgayKi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.DateTimePicker dtNgayKetThuc;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DateTimePicker dtNgayBatDau;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit spLanKi;
        private DevExpress.XtraEditors.SearchLookUpEdit slkNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraRichEdit.RichEditControl txtNoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn Col_ID_NV;
        private DevExpress.XtraGrid.Columns.GridColumn HoTenNV;
        private System.Windows.Forms.ComboBox cboThoiHan;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtLuongCoBan;
        private DevExpress.XtraEditors.SpinEdit spHeSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraGrid.Columns.GridColumn HeSoLuong;
    }
}