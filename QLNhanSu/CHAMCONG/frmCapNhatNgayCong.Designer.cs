namespace QLNhanSu.CHAMCONG
{
    partial class frmCapNhatNgayCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapNhatNgayCong));
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.cldNgayCong = new System.Windows.Forms.MonthCalendar();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rdgChamCong = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.rdgLoaiNghi = new DevExpress.XtraEditors.RadioGroup();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgChamCong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgLoaiNghi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCapNhat.ImageOptions.SvgImage")));
            this.btnCapNhat.Location = new System.Drawing.Point(221, 422);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(137, 66);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // cldNgayCong
            // 
            this.cldNgayCong.Location = new System.Drawing.Point(16, 10);
            this.cldNgayCong.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.cldNgayCong.Name = "cldNgayCong";
            this.cldNgayCong.TabIndex = 1;
            this.cldNgayCong.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cldNgayCong_DateSelected);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.rdgChamCong);
            this.groupControl1.Location = new System.Drawing.Point(219, 10);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(281, 213);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Chấm Công";
            // 
            // rdgChamCong
            // 
            this.rdgChamCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdgChamCong.EditValue = "P";
            this.rdgChamCong.Location = new System.Drawing.Point(2, 28);
            this.rdgChamCong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdgChamCong.Name = "rdgChamCong";
            this.rdgChamCong.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Nghỉ Có Phép"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("V", "Nghỉ Không Phép"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("CT", "Công Tác")});
            this.rdgChamCong.Size = new System.Drawing.Size(277, 183);
            this.rdgChamCong.TabIndex = 0;
            this.rdgChamCong.SelectedIndexChanged += new System.EventHandler(this.rdgChamCong_SelectedIndexChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.rdgLoaiNghi);
            this.groupControl2.Location = new System.Drawing.Point(221, 233);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(281, 184);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Thời Gian Nghỉ";
            // 
            // rdgLoaiNghi
            // 
            this.rdgLoaiNghi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdgLoaiNghi.EditValue = "CN";
            this.rdgLoaiNghi.Location = new System.Drawing.Point(2, 28);
            this.rdgLoaiNghi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdgLoaiNghi.Name = "rdgLoaiNghi";
            this.rdgLoaiNghi.Properties.Columns = 2;
            this.rdgLoaiNghi.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Sáng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("C", "Chiều"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("CN", "Cả Ngày")});
            this.rdgLoaiNghi.Size = new System.Drawing.Size(277, 154);
            this.rdgLoaiNghi.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Location = new System.Drawing.Point(376, 422);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(121, 66);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.lblHoTen);
            this.groupControl3.Controls.Add(this.lblID);
            this.groupControl3.Controls.Add(this.label1);
            this.groupControl3.Controls.Add(this.lblThongTin);
            this.groupControl3.Location = new System.Drawing.Point(16, 233);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(194, 254);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "Thông Tin";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(65, 60);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(44, 16);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "HoTen";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(30, 32);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 16);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(5, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ Tên: ";
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblThongTin.Location = new System.Drawing.Point(5, 32);
            this.lblThongTin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(34, 17);
            this.lblThongTin.TabIndex = 0;
            this.lblThongTin.Text = "ID: ";
            // 
            // frmCapNhatNgayCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 498);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.cldNgayCong);
            this.Controls.Add(this.btnCapNhat);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCapNhatNgayCong";
            this.Text = "Cập Nhật Ngày Công";
            this.Load += new System.EventHandler(this.frmCapNhatNgayCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdgChamCong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdgLoaiNghi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private System.Windows.Forms.MonthCalendar cldNgayCong;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.RadioGroup rdgChamCong;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.RadioGroup rdgLoaiNghi;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblThongTin;
    }
}