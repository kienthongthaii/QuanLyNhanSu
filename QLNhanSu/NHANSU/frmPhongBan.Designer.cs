namespace QLNhanSu
{
    partial class frmPhongBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhongBan));
            this.BarManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtSoLuongNV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.ckbConHoatDong = new DevExpress.XtraEditors.CheckEdit();
            this.txtNgayThanhLap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtID_PB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMoTa = new System.Windows.Forms.RichTextBox();
            this.txtTenTruongPB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenPB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_PB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenPB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_TruongPB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTruongPB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoThanhVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Delete_By = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbConHoatDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayThanhLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID_PB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTruongPB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenPB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // BarManager1
            // 
            this.BarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.BarManager1.DockControls.Add(this.barDockControlTop);
            this.BarManager1.DockControls.Add(this.barDockControlBottom);
            this.BarManager1.DockControls.Add(this.barDockControlLeft);
            this.BarManager1.DockControls.Add(this.barDockControlRight);
            this.BarManager1.Form = this;
            this.BarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.barButtonItem4,
            this.btnHuy,
            this.btnLuu,
            this.btnDong,
            this.btnIn,
            this.btnPhucHoi});
            this.BarManager1.MainMenu = this.bar2;
            this.BarManager1.MaxItemId = 9;
            this.BarManager1.StatusBar = this.bar3;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi, true),
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
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục Hồi";
            this.btnPhucHoi.Id = 8;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
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
            this.barDockControlTop.Manager = this.BarManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1826, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 932);
            this.barDockControlBottom.Manager = this.BarManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1826, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.BarManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 898);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1826, 34);
            this.barDockControlRight.Manager = this.BarManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 898);
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
            this.splitContainer1.Panel1.Controls.Add(this.txtID_PB);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.txtMoTa);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenTruongPB);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenPB);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(1826, 898);
            this.splitContainer1.SplitterDistance = 543;
            this.splitContainer1.TabIndex = 5;
            // 
            // txtSoLuongNV
            // 
            this.txtSoLuongNV.Location = new System.Drawing.Point(236, 562);
            this.txtSoLuongNV.MenuManager = this.BarManager1;
            this.txtSoLuongNV.Name = "txtSoLuongNV";
            this.txtSoLuongNV.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongNV.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuongNV.Properties.ReadOnly = true;
            this.txtSoLuongNV.Size = new System.Drawing.Size(275, 30);
            this.txtSoLuongNV.TabIndex = 33;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(36, 565);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(177, 24);
            this.labelControl6.TabIndex = 32;
            this.labelControl6.Text = "Số lượng nhân viên : ";
            // 
            // ckbConHoatDong
            // 
            this.ckbConHoatDong.Location = new System.Drawing.Point(236, 610);
            this.ckbConHoatDong.MenuManager = this.BarManager1;
            this.ckbConHoatDong.Name = "ckbConHoatDong";
            this.ckbConHoatDong.Properties.Caption = "Đang hoạt động";
            this.ckbConHoatDong.Properties.ReadOnly = true;
            this.ckbConHoatDong.Size = new System.Drawing.Size(225, 27);
            this.ckbConHoatDong.TabIndex = 31;
            // 
            // txtNgayThanhLap
            // 
            this.txtNgayThanhLap.Location = new System.Drawing.Point(237, 519);
            this.txtNgayThanhLap.MenuManager = this.BarManager1;
            this.txtNgayThanhLap.Name = "txtNgayThanhLap";
            this.txtNgayThanhLap.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayThanhLap.Properties.Appearance.Options.UseFont = true;
            this.txtNgayThanhLap.Properties.ReadOnly = true;
            this.txtNgayThanhLap.Size = new System.Drawing.Size(275, 30);
            this.txtNgayThanhLap.TabIndex = 30;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(71, 519);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(142, 24);
            this.labelControl4.TabIndex = 29;
            this.labelControl4.Text = "Ngày thành lập : ";
            // 
            // txtID_PB
            // 
            this.txtID_PB.Location = new System.Drawing.Point(235, 35);
            this.txtID_PB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID_PB.Name = "txtID_PB";
            this.txtID_PB.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtID_PB.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_PB.Properties.Appearance.Options.UseBackColor = true;
            this.txtID_PB.Properties.Appearance.Options.UseFont = true;
            this.txtID_PB.Size = new System.Drawing.Size(275, 30);
            this.txtID_PB.TabIndex = 26;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(90, 38);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(136, 24);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "Mã Phòng Ban : ";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(236, 182);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(276, 313);
            this.txtMoTa.TabIndex = 25;
            this.txtMoTa.Text = "";
            // 
            // txtTenTruongPB
            // 
            this.txtTenTruongPB.Location = new System.Drawing.Point(237, 130);
            this.txtTenTruongPB.MenuManager = this.BarManager1;
            this.txtTenTruongPB.Name = "txtTenTruongPB";
            this.txtTenTruongPB.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTruongPB.Properties.Appearance.Options.UseFont = true;
            this.txtTenTruongPB.Properties.ReadOnly = true;
            this.txtTenTruongPB.Size = new System.Drawing.Size(275, 30);
            this.txtTenTruongPB.TabIndex = 24;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(94, 133);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(132, 24);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Trưởng Phòng : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(155, 182);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 24);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Mô Tả : ";
            // 
            // txtTenPB
            // 
            this.txtTenPB.Location = new System.Drawing.Point(236, 82);
            this.txtTenPB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPB.Properties.Appearance.Options.UseFont = true;
            this.txtTenPB.Size = new System.Drawing.Size(276, 30);
            this.txtTenPB.TabIndex = 18;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(90, 85);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(140, 24);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Tên Phòng Ban : ";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcDanhSach.MenuManager = this.BarManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1279, 898);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_PB,
            this.TenPB,
            this.ID_TruongPB,
            this.TenTruongPB,
            this.SoThanhVien,
            this.Delete_By,
            this.MoTa});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            this.gvDanhSach.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvDanhSach_CustomDrawCell);
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            // 
            // ID_PB
            // 
            this.ID_PB.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ID_PB.AppearanceHeader.Options.UseFont = true;
            this.ID_PB.Caption = "ID";
            this.ID_PB.FieldName = "ID_PB";
            this.ID_PB.MaxWidth = 150;
            this.ID_PB.MinWidth = 150;
            this.ID_PB.Name = "ID_PB";
            this.ID_PB.Visible = true;
            this.ID_PB.VisibleIndex = 1;
            this.ID_PB.Width = 150;
            // 
            // TenPB
            // 
            this.TenPB.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.TenPB.AppearanceHeader.Options.UseFont = true;
            this.TenPB.Caption = "Tên Phòng Ban";
            this.TenPB.FieldName = "TenPB";
            this.TenPB.MaxWidth = 201;
            this.TenPB.MinWidth = 201;
            this.TenPB.Name = "TenPB";
            this.TenPB.Visible = true;
            this.TenPB.VisibleIndex = 2;
            this.TenPB.Width = 201;
            // 
            // ID_TruongPB
            // 
            this.ID_TruongPB.Caption = "ID_TruongPB";
            this.ID_TruongPB.FieldName = "ID_TruongPB";
            this.ID_TruongPB.MinWidth = 30;
            this.ID_TruongPB.Name = "ID_TruongPB";
            this.ID_TruongPB.Width = 96;
            // 
            // TenTruongPB
            // 
            this.TenTruongPB.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.TenTruongPB.AppearanceHeader.Options.UseFont = true;
            this.TenTruongPB.Caption = "Tên Trưởng Phòng";
            this.TenTruongPB.FieldName = "TenTruongPB";
            this.TenTruongPB.MinWidth = 30;
            this.TenTruongPB.Name = "TenTruongPB";
            this.TenTruongPB.Visible = true;
            this.TenTruongPB.VisibleIndex = 3;
            this.TenTruongPB.Width = 174;
            // 
            // SoThanhVien
            // 
            this.SoThanhVien.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.SoThanhVien.AppearanceHeader.Options.UseFont = true;
            this.SoThanhVien.Caption = "Số Lượng Nhân Viên";
            this.SoThanhVien.FieldName = "SoThanhVien";
            this.SoThanhVien.MinWidth = 30;
            this.SoThanhVien.Name = "SoThanhVien";
            this.SoThanhVien.Visible = true;
            this.SoThanhVien.VisibleIndex = 4;
            this.SoThanhVien.Width = 238;
            // 
            // Delete_By
            // 
            this.Delete_By.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.Delete_By.AppearanceHeader.Options.UseFont = true;
            this.Delete_By.Caption = "Delete_By";
            this.Delete_By.FieldName = "Delete_By";
            this.Delete_By.MaxWidth = 30;
            this.Delete_By.MinWidth = 30;
            this.Delete_By.Name = "Delete_By";
            this.Delete_By.Visible = true;
            this.Delete_By.VisibleIndex = 0;
            this.Delete_By.Width = 30;
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
            this.MoTa.VisibleIndex = 5;
            this.MoTa.Width = 450;
            // 
            // frmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1826, 952);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::QLNhanSu.Properties.Resources.logoCellPhoneS;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhongBan";
            this.Text = "Phòng Ban";
            this.Load += new System.EventHandler(this.frmPhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbConHoatDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayThanhLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID_PB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTruongPB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenPB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager BarManager1;
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
        private DevExpress.XtraGrid.Columns.GridColumn ID_PB;
        private DevExpress.XtraGrid.Columns.GridColumn TenPB;
        private DevExpress.XtraGrid.Columns.GridColumn ID_TruongPB;
        private DevExpress.XtraGrid.Columns.GridColumn TenTruongPB;
        private DevExpress.XtraGrid.Columns.GridColumn SoThanhVien;
        private DevExpress.XtraEditors.TextEdit txtSoLuongNV;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.CheckEdit ckbConHoatDong;
        private DevExpress.XtraEditors.TextEdit txtNgayThanhLap;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtID_PB;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.RichTextBox txtMoTa;
        private DevExpress.XtraEditors.TextEdit txtTenTruongPB;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenPB;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Columns.GridColumn Delete_By;
        private DevExpress.XtraGrid.Columns.GridColumn MoTa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
    }
}