namespace USER_MANAGERMENT
{
    partial class frmQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnGroup = new DevExpress.XtraBars.BarButtonItem();
            this.btnUser = new DevExpress.XtraBars.BarButtonItem();
            this.btnCapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnChucNang = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gcUser = new DevExpress.XtraGrid.GridControl();
            this.gvUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Disable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_CT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_CV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnGroup,
            this.btnUser,
            this.btnCapNhat,
            this.btnChucNang,
            this.btnExit});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1541, 219);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Chức Năng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGroup);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUser, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCapNhat, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tài Khoản";
            // 
            // btnGroup
            // 
            this.btnGroup.Caption = "Nhóm Người Dùng";
            this.btnGroup.Id = 1;
            this.btnGroup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhomNguoiDung.ImageOptions.Image")));
            this.btnGroup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhomNguoiDung.ImageOptions.LargeImage")));
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGroup_ItemClick);
            // 
            // btnUser
            // 
            this.btnUser.Caption = "Người Dùng";
            this.btnUser.Id = 2;
            this.btnUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.ImageOptions.Image")));
            this.btnUser.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUser.ImageOptions.LargeImage")));
            this.btnUser.Name = "btnUser";
            this.btnUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUser_ItemClick);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Caption = "Cập Nhật Thông Tin";
            this.btnCapNhat.Id = 3;
            this.btnCapNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.ImageOptions.Image")));
            this.btnCapNhat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.ImageOptions.LargeImage")));
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCapNhat_ItemClick);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnChucNang);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Phân Quyền";
            // 
            // btnChucNang
            // 
            this.btnChucNang.Caption = "Chức Năng";
            this.btnChucNang.Id = 4;
            this.btnChucNang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChucNang.ImageOptions.Image")));
            this.btnChucNang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChucNang.ImageOptions.LargeImage")));
            this.btnChucNang.Name = "btnChucNang";
            this.btnChucNang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChucNang_ItemClick);
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnExit);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Hệ Thống";
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 5;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.LargeImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panelNhom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1541, 100);
            this.panel1.TabIndex = 1;
            // 
            // gcUser
            // 
            this.gcUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUser.Location = new System.Drawing.Point(0, 319);
            this.gcUser.MainView = this.gvUser;
            this.gcUser.MenuManager = this.ribbonControl1;
            this.gcUser.Name = "gcUser";
            this.gcUser.Size = new System.Drawing.Size(1541, 457);
            this.gcUser.TabIndex = 2;
            this.gcUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUser});
            // 
            // gvUser
            // 
            this.gvUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Disable,
            this.ID_NV,
            this.UserName,
            this.FullName,
            this.ID_CT,
            this.ID_CV,
            this.IsGroup});
            this.gvUser.GridControl = this.gcUser;
            this.gvUser.Name = "gvUser";
            // 
            // Disable
            // 
            this.Disable.Caption = "Del";
            this.Disable.FieldName = "Disable";
            this.Disable.MaxWidth = 30;
            this.Disable.MinWidth = 30;
            this.Disable.Name = "Disable";
            this.Disable.Visible = true;
            this.Disable.VisibleIndex = 0;
            this.Disable.Width = 30;
            // 
            // ID_NV
            // 
            this.ID_NV.Caption = "ID";
            this.ID_NV.FieldName = "ID_NV";
            this.ID_NV.MinWidth = 30;
            this.ID_NV.Name = "ID_NV";
            this.ID_NV.Width = 112;
            // 
            // UserName
            // 
            this.UserName.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.UserName.AppearanceHeader.Options.UseFont = true;
            this.UserName.Caption = "UserName";
            this.UserName.FieldName = "UserName";
            this.UserName.MinWidth = 30;
            this.UserName.Name = "UserName";
            this.UserName.Visible = true;
            this.UserName.VisibleIndex = 1;
            this.UserName.Width = 112;
            // 
            // FullName
            // 
            this.FullName.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.FullName.AppearanceHeader.Options.UseFont = true;
            this.FullName.Caption = "FullName";
            this.FullName.FieldName = "FullName";
            this.FullName.MinWidth = 30;
            this.FullName.Name = "FullName";
            this.FullName.Visible = true;
            this.FullName.VisibleIndex = 2;
            this.FullName.Width = 112;
            // 
            // ID_CT
            // 
            this.ID_CT.Caption = "ID_CT";
            this.ID_CT.FieldName = "ID_CT";
            this.ID_CT.MinWidth = 30;
            this.ID_CT.Name = "ID_CT";
            this.ID_CT.Width = 112;
            // 
            // ID_CV
            // 
            this.ID_CV.Caption = "ID_CV";
            this.ID_CV.FieldName = "ID_CV";
            this.ID_CV.MinWidth = 30;
            this.ID_CV.Name = "ID_CV";
            this.ID_CV.Width = 112;
            // 
            // IsGroup
            // 
            this.IsGroup.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.IsGroup.AppearanceHeader.Options.UseFont = true;
            this.IsGroup.Caption = "Group";
            this.IsGroup.FieldName = "IsGroup";
            this.IsGroup.MinWidth = 30;
            this.IsGroup.Name = "IsGroup";
            this.IsGroup.Visible = true;
            this.IsGroup.VisibleIndex = 3;
            this.IsGroup.Width = 112;
            // 
            // panelNhom
            // 
            this.panelNhom.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNhom.Location = new System.Drawing.Point(1124, 0);
            this.panelNhom.Name = "panelNhom";
            this.panelNhom.Size = new System.Drawing.Size(417, 100);
            this.panelNhom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1012, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐƠN VỊ";
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 776);
            this.Controls.Add(this.gcUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmQuanLy";
            this.Text = "Quản Lý Người Dùng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnGroup;
        private DevExpress.XtraBars.BarButtonItem btnUser;
        private DevExpress.XtraBars.BarButtonItem btnCapNhat;
        private DevExpress.XtraBars.BarButtonItem btnChucNang;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gcUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUser;
        private DevExpress.XtraGrid.Columns.GridColumn Disable;
        private DevExpress.XtraGrid.Columns.GridColumn ID_NV;
        private DevExpress.XtraGrid.Columns.GridColumn UserName;
        private DevExpress.XtraGrid.Columns.GridColumn FullName;
        private DevExpress.XtraGrid.Columns.GridColumn ID_CT;
        private DevExpress.XtraGrid.Columns.GridColumn ID_CV;
        private DevExpress.XtraGrid.Columns.GridColumn IsGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelNhom;
    }
}