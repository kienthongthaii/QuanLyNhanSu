namespace QLNhanSu
{
    partial class frmBoPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoPhan));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Delete_By = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_BP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenBP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_TruongBP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTruongBP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoThanhVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_PB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenPB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtSoLuongNV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.ckbConHoatDong = new DevExpress.XtraEditors.CheckEdit();
            this.txtNgayThanhLap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtKiHieuPB = new DevExpress.XtraEditors.TextEdit();
            this.txtID_BP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMoTa = new System.Windows.Forms.RichTextBox();
            this.txtTenTruongBP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbPhongBan = new System.Windows.Forms.ComboBox();
            this.txtPhongBan = new DevExpress.XtraEditors.LabelControl();
            this.txtTenBP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbConHoatDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayThanhLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKiHieuPB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID_BP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTruongBP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenBP.Properties)).BeginInit();
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
            this.btnIn,
            this.btnPhucHoi});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi, true),
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
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục Hồi";
            this.btnPhucHoi.Id = 8;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(2462, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 804);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(2462, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 770);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(2462, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 770);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Lưu";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
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
            this.gcDanhSach.Size = new System.Drawing.Size(1736, 770);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach,
            this.gridView1});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Delete_By,
            this.ID_BP,
            this.TenBP,
            this.ID_TruongBP,
            this.TenTruongBP,
            this.SoThanhVien,
            this.ID_PB,
            this.TenPB,
            this.MoTa});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            this.gvDanhSach.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvDanhSach_CustomDrawCell);
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            // 
            // Delete_By
            // 
            this.Delete_By.Caption = "Delete_By";
            this.Delete_By.FieldName = "Delete_By";
            this.Delete_By.MaxWidth = 50;
            this.Delete_By.MinWidth = 50;
            this.Delete_By.Name = "Delete_By";
            this.Delete_By.Visible = true;
            this.Delete_By.VisibleIndex = 0;
            this.Delete_By.Width = 50;
            // 
            // ID_BP
            // 
            this.ID_BP.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ID_BP.AppearanceHeader.Options.UseFont = true;
            this.ID_BP.Caption = "ID";
            this.ID_BP.FieldName = "ID_BP";
            this.ID_BP.MaxWidth = 150;
            this.ID_BP.MinWidth = 150;
            this.ID_BP.Name = "ID_BP";
            this.ID_BP.Visible = true;
            this.ID_BP.VisibleIndex = 1;
            this.ID_BP.Width = 150;
            // 
            // TenBP
            // 
            this.TenBP.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.TenBP.AppearanceHeader.Options.UseFont = true;
            this.TenBP.Caption = "Tên Bộ Phận";
            this.TenBP.FieldName = "TenBP";
            this.TenBP.MaxWidth = 201;
            this.TenBP.MinWidth = 201;
            this.TenBP.Name = "TenBP";
            this.TenBP.Visible = true;
            this.TenBP.VisibleIndex = 2;
            this.TenBP.Width = 201;
            // 
            // ID_TruongBP
            // 
            this.ID_TruongBP.Caption = "ID_TruongBP";
            this.ID_TruongBP.FieldName = "ID_TruongBP";
            this.ID_TruongBP.MinWidth = 30;
            this.ID_TruongBP.Name = "ID_TruongBP";
            this.ID_TruongBP.Width = 112;
            // 
            // TenTruongBP
            // 
            this.TenTruongBP.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.TenTruongBP.AppearanceHeader.Options.UseFont = true;
            this.TenTruongBP.Caption = "Trưởng Bộ Phận";
            this.TenTruongBP.FieldName = "TenTruongBP";
            this.TenTruongBP.MinWidth = 30;
            this.TenTruongBP.Name = "TenTruongBP";
            this.TenTruongBP.Visible = true;
            this.TenTruongBP.VisibleIndex = 5;
            this.TenTruongBP.Width = 112;
            // 
            // SoThanhVien
            // 
            this.SoThanhVien.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.SoThanhVien.AppearanceHeader.Options.UseFont = true;
            this.SoThanhVien.Caption = "Số Thành Viên";
            this.SoThanhVien.FieldName = "SoThanhVien";
            this.SoThanhVien.MinWidth = 30;
            this.SoThanhVien.Name = "SoThanhVien";
            this.SoThanhVien.Visible = true;
            this.SoThanhVien.VisibleIndex = 4;
            this.SoThanhVien.Width = 112;
            // 
            // ID_PB
            // 
            this.ID_PB.Caption = "ID_PB";
            this.ID_PB.FieldName = "ID_PB";
            this.ID_PB.MinWidth = 30;
            this.ID_PB.Name = "ID_PB";
            this.ID_PB.Width = 112;
            // 
            // TenPB
            // 
            this.TenPB.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.TenPB.AppearanceHeader.Options.UseFont = true;
            this.TenPB.Caption = "Phòng Ban Trực Thuộc";
            this.TenPB.FieldName = "TenPB";
            this.TenPB.MinWidth = 30;
            this.TenPB.Name = "TenPB";
            this.TenPB.Visible = true;
            this.TenPB.VisibleIndex = 3;
            this.TenPB.Width = 112;
            // 
            // MoTa
            // 
            this.MoTa.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.MoTa.AppearanceHeader.Options.UseFont = true;
            this.MoTa.Caption = "Mô Tả";
            this.MoTa.FieldName = "MoTa";
            this.MoTa.MinWidth = 30;
            this.MoTa.Name = "MoTa";
            this.MoTa.Visible = true;
            this.MoTa.VisibleIndex = 6;
            this.MoTa.Width = 112;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcDanhSach;
            this.gridView1.Name = "gridView1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 34);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtSoLuongNV);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.ckbConHoatDong);
            this.splitContainer1.Panel1.Controls.Add(this.txtNgayThanhLap);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.txtKiHieuPB);
            this.splitContainer1.Panel1.Controls.Add(this.txtID_BP);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.txtMoTa);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenTruongBP);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.cbPhongBan);
            this.splitContainer1.Panel1.Controls.Add(this.txtPhongBan);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenBP);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(2462, 770);
            this.splitContainer1.SplitterDistance = 722;
            this.splitContainer1.TabIndex = 4;
            // 
            // txtSoLuongNV
            // 
            this.txtSoLuongNV.Location = new System.Drawing.Point(239, 631);
            this.txtSoLuongNV.MenuManager = this.barManager1;
            this.txtSoLuongNV.Name = "txtSoLuongNV";
            this.txtSoLuongNV.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongNV.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuongNV.Properties.ReadOnly = true;
            this.txtSoLuongNV.Size = new System.Drawing.Size(275, 30);
            this.txtSoLuongNV.TabIndex = 17;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(39, 634);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(177, 24);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Số lượng nhân viên : ";
            // 
            // ckbConHoatDong
            // 
            this.ckbConHoatDong.Location = new System.Drawing.Point(239, 679);
            this.ckbConHoatDong.MenuManager = this.barManager1;
            this.ckbConHoatDong.Name = "ckbConHoatDong";
            this.ckbConHoatDong.Properties.Caption = "Đang hoạt động";
            this.ckbConHoatDong.Properties.ReadOnly = true;
            this.ckbConHoatDong.Size = new System.Drawing.Size(225, 27);
            this.ckbConHoatDong.TabIndex = 15;
            // 
            // txtNgayThanhLap
            // 
            this.txtNgayThanhLap.Location = new System.Drawing.Point(240, 588);
            this.txtNgayThanhLap.MenuManager = this.barManager1;
            this.txtNgayThanhLap.Name = "txtNgayThanhLap";
            this.txtNgayThanhLap.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayThanhLap.Properties.Appearance.Options.UseFont = true;
            this.txtNgayThanhLap.Properties.ReadOnly = true;
            this.txtNgayThanhLap.Size = new System.Drawing.Size(275, 30);
            this.txtNgayThanhLap.TabIndex = 14;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(74, 588);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(142, 24);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Ngày thành lập : ";
            // 
            // txtKiHieuPB
            // 
            this.txtKiHieuPB.Location = new System.Drawing.Point(240, 54);
            this.txtKiHieuPB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKiHieuPB.Name = "txtKiHieuPB";
            this.txtKiHieuPB.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKiHieuPB.Properties.Appearance.Options.UseFont = true;
            this.txtKiHieuPB.Properties.ReadOnly = true;
            this.txtKiHieuPB.Size = new System.Drawing.Size(80, 30);
            this.txtKiHieuPB.TabIndex = 12;
            // 
            // txtID_BP
            // 
            this.txtID_BP.Location = new System.Drawing.Point(326, 54);
            this.txtID_BP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID_BP.Name = "txtID_BP";
            this.txtID_BP.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtID_BP.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_BP.Properties.Appearance.Options.UseBackColor = true;
            this.txtID_BP.Properties.Appearance.Options.UseFont = true;
            this.txtID_BP.Size = new System.Drawing.Size(189, 30);
            this.txtID_BP.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(108, 54);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(116, 24);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Mã Bộ Phận : ";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(239, 251);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(276, 313);
            this.txtMoTa.TabIndex = 7;
            this.txtMoTa.Text = "";
            // 
            // txtTenTruongBP
            // 
            this.txtTenTruongBP.Location = new System.Drawing.Point(240, 199);
            this.txtTenTruongBP.MenuManager = this.barManager1;
            this.txtTenTruongBP.Name = "txtTenTruongBP";
            this.txtTenTruongBP.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTruongBP.Properties.Appearance.Options.UseFont = true;
            this.txtTenTruongBP.Properties.ReadOnly = true;
            this.txtTenTruongBP.Size = new System.Drawing.Size(275, 30);
            this.txtTenTruongBP.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(74, 199);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(150, 24);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Trưởng bộ phận : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(158, 251);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 24);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Mô Tả : ";
            // 
            // cbPhongBan
            // 
            this.cbPhongBan.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhongBan.FormattingEnabled = true;
            this.cbPhongBan.Location = new System.Drawing.Point(240, 144);
            this.cbPhongBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPhongBan.Name = "cbPhongBan";
            this.cbPhongBan.Size = new System.Drawing.Size(275, 32);
            this.cbPhongBan.TabIndex = 2;
            this.cbPhongBan.SelectedValueChanged += new System.EventHandler(this.cbPhongBan_SelectedValueChanged);
            // 
            // txtPhongBan
            // 
            this.txtPhongBan.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhongBan.Appearance.Options.UseFont = true;
            this.txtPhongBan.Location = new System.Drawing.Point(23, 147);
            this.txtPhongBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhongBan.Name = "txtPhongBan";
            this.txtPhongBan.Size = new System.Drawing.Size(201, 24);
            this.txtPhongBan.TabIndex = 1;
            this.txtPhongBan.Text = "Phòng Ban Trực Thuộc : ";
            // 
            // txtTenBP
            // 
            this.txtTenBP.Location = new System.Drawing.Point(240, 96);
            this.txtTenBP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenBP.Name = "txtTenBP";
            this.txtTenBP.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBP.Properties.Appearance.Options.UseFont = true;
            this.txtTenBP.Size = new System.Drawing.Size(276, 30);
            this.txtTenBP.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(106, 96);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(118, 24);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tên Bộ Phận : ";
            // 
            // frmBoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2462, 824);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::QLNhanSu.Properties.Resources.logoCellPhoneS;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBoPhan";
            this.Text = "Bộ Phận";
            this.Load += new System.EventHandler(this.frmBoPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbConHoatDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayThanhLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKiHieuPB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID_BP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTruongBP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenBP.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn ID_BP;
        private DevExpress.XtraGrid.Columns.GridColumn TenBP;
        private DevExpress.XtraGrid.Columns.GridColumn ID_TruongBP;
        private DevExpress.XtraGrid.Columns.GridColumn TenTruongBP;
        private DevExpress.XtraGrid.Columns.GridColumn SoThanhVien;
        private DevExpress.XtraGrid.Columns.GridColumn ID_PB;
        private DevExpress.XtraGrid.Columns.GridColumn TenPB;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Delete_By;
        private DevExpress.XtraGrid.Columns.GridColumn MoTa;
        private System.Windows.Forms.RichTextBox txtMoTa;
        private DevExpress.XtraEditors.TextEdit txtTenTruongBP;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbPhongBan;
        private DevExpress.XtraEditors.LabelControl txtPhongBan;
        private DevExpress.XtraEditors.TextEdit txtTenBP;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtKiHieuPB;
        private DevExpress.XtraEditors.TextEdit txtID_BP;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtSoLuongNV;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.CheckEdit ckbConHoatDong;
        private DevExpress.XtraEditors.TextEdit txtNgayThanhLap;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}