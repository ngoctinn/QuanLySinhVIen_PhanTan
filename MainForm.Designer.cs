﻿
namespace QLNV1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.NhanVienbarButton = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnLapPhieuNX = new DevExpress.XtraBars.BarButtonItem();
            this.LopHocbarButton = new DevExpress.XtraBars.BarButtonItem();
            this.MonHocButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.DiemButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.LopTinChibarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.HocPhibarButton = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.LopTinChibarButton = new DevExpress.XtraBars.BarButtonItem();
            this.DangKibarButton = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTK = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.rpQuanTri = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpCauHinh = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MANV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(39, 36, 39, 36);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.NhanVienbarButton,
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnSinhVien,
            this.btnLapPhieuNX,
            this.LopHocbarButton,
            this.MonHocButtonItem,
            this.DiemButtonItem,
            this.LopTinChibarButtonItem,
            this.HocPhibarButton,
            this.barButtonItem1,
            this.LopTinChibarButton,
            this.DangKibarButton,
            this.btnTaoTK,
            this.barButtonItem3,
            this.barButtonItem2,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.btnLogout,
            this.barButtonItem8});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ribbonControl1.MaxItemId = 24;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 495;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpQuanTri,
            this.rpBaoCao,
            this.rpCauHinh});
            this.ribbonControl1.Size = new System.Drawing.Size(1584, 244);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // NhanVienbarButton
            // 
            this.NhanVienbarButton.Caption = "Nhân Viên";
            this.NhanVienbarButton.Id = 1;
            this.NhanVienbarButton.Name = "NhanVienbarButton";
            this.NhanVienbarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NhanVienbarButton_ItemClick);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Id = 2;
            this.btnDangNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangNhap.ImageOptions.SvgImage")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 4;
            this.btnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.Image")));
            this.btnDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.LargeImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Caption = "SINH VIÊN";
            this.btnSinhVien.Id = 5;
            this.btnSinhVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSinhVien.ImageOptions.SvgImage")));
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnLapPhieuNX
            // 
            this.btnLapPhieuNX.Caption = "In DSSV  ĐKLTC";
            this.btnLapPhieuNX.Id = 6;
            this.btnLapPhieuNX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLapPhieuNX.ImageOptions.SvgImage")));
            this.btnLapPhieuNX.Name = "btnLapPhieuNX";
            this.btnLapPhieuNX.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLapPhieuNX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLapPhieuNX_ItemClick);
            // 
            // LopHocbarButton
            // 
            this.LopHocbarButton.Caption = "BỘ MÔN";
            this.LopHocbarButton.Id = 7;
            this.LopHocbarButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("LopHocbarButton.ImageOptions.SvgImage")));
            this.LopHocbarButton.Name = "LopHocbarButton";
            this.LopHocbarButton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.LopHocbarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.LopHocbarButton_ItemClick);
            // 
            // MonHocButtonItem
            // 
            this.MonHocButtonItem.Caption = "MÔN HỌC";
            this.MonHocButtonItem.Id = 8;
            this.MonHocButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("MonHocButtonItem.ImageOptions.SvgImage")));
            this.MonHocButtonItem.Name = "MonHocButtonItem";
            this.MonHocButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MonHocButtonItem_ItemClick);
            // 
            // DiemButtonItem
            // 
            this.DiemButtonItem.Caption = "ĐIỂM";
            this.DiemButtonItem.Id = 9;
            this.DiemButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("DiemButtonItem.ImageOptions.SvgImage")));
            this.DiemButtonItem.Name = "DiemButtonItem";
            this.DiemButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DiemButtonItem_ItemClick);
            // 
            // LopTinChibarButtonItem
            // 
            this.LopTinChibarButtonItem.Caption = "LỚP TÍN CHỈ";
            this.LopTinChibarButtonItem.Id = 10;
            this.LopTinChibarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("LopTinChibarButtonItem.ImageOptions.Image")));
            this.LopTinChibarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("LopTinChibarButtonItem.ImageOptions.LargeImage")));
            this.LopTinChibarButtonItem.Name = "LopTinChibarButtonItem";
            // 
            // HocPhibarButton
            // 
            this.HocPhibarButton.Caption = "HỌC PHÍ";
            this.HocPhibarButton.Id = 11;
            this.HocPhibarButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("HocPhibarButton.ImageOptions.SvgImage")));
            this.HocPhibarButton.Name = "HocPhibarButton";
            this.HocPhibarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.HocPhibarButton_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 12;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // LopTinChibarButton
            // 
            this.LopTinChibarButton.Caption = "HỌC PHẦN";
            this.LopTinChibarButton.Id = 13;
            this.LopTinChibarButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("LopTinChibarButton.ImageOptions.SvgImage")));
            this.LopTinChibarButton.Name = "LopTinChibarButton";
            this.LopTinChibarButton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.LopTinChibarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.LopTinChibarButton_ItemClick);
            // 
            // DangKibarButton
            // 
            this.DangKibarButton.Caption = "ĐĂNG KÍ";
            this.DangKibarButton.Id = 14;
            this.DangKibarButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("DangKibarButton.ImageOptions.SvgImage")));
            this.DangKibarButton.Name = "DangKibarButton";
            this.DangKibarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DangKibarButton_ItemClick);
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Caption = "Tạo tài khoản";
            this.btnTaoTK.Id = 15;
            this.btnTaoTK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaoTK.ImageOptions.SvgImage")));
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTaoTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTK_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Đổi mật khẩu";
            this.barButtonItem3.Id = 16;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "In DSLTC";
            this.barButtonItem2.Id = 17;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "In DSLTC";
            this.barButtonItem4.Id = 18;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "In BDHM";
            this.barButtonItem5.Id = 19;
            this.barButtonItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "In Phiếu Điểm SV";
            this.barButtonItem6.Id = 20;
            this.barButtonItem6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem6.ImageOptions.SvgImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "In Danh Sách HP của Lớp";
            this.barButtonItem7.Id = 21;
            this.barButtonItem7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem7.ImageOptions.SvgImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng xuất";
            this.btnLogout.Id = 22;
            this.btnLogout.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLogout.ImageOptions.SvgImage")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "In Bảng điểm TK";
            this.barButtonItem8.Id = 23;
            this.barButtonItem8.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem8.ImageOptions.SvgImage")));
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // rpQuanTri
            // 
            this.rpQuanTri.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rpQuanTri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rpQuanTri.ImageOptions.Image")));
            this.rpQuanTri.Name = "rpQuanTri";
            this.rpQuanTri.Text = "QUẢN TRỊ";
            this.rpQuanTri.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSinhVien);
            this.ribbonPageGroup2.ItemLinks.Add(this.LopHocbarButton);
            this.ribbonPageGroup2.ItemLinks.Add(this.MonHocButtonItem);
            this.ribbonPageGroup2.ItemLinks.Add(this.LopTinChibarButton);
            this.ribbonPageGroup2.ItemLinks.Add(this.DiemButtonItem);
            this.ribbonPageGroup2.ItemLinks.Add(this.HocPhibarButton);
            this.ribbonPageGroup2.ItemLinks.Add(this.DangKibarButton);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "QUẢN LÝ DỮ LIỆU";
            // 
            // rpBaoCao
            // 
            this.rpBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rpBaoCao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rpBaoCao.ImageOptions.Image")));
            this.rpBaoCao.Name = "rpBaoCao";
            this.rpBaoCao.Text = "BÁO CÁO";
            this.rpBaoCao.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnLapPhieuNX);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // rpCauHinh
            // 
            this.rpCauHinh.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.rpCauHinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rpCauHinh.ImageOptions.Image")));
            this.rpCauHinh.Name = "rpCauHinh";
            this.rpCauHinh.Text = "CẤU HÌNH";
            this.rpCauHinh.Visible = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnTaoTK);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Chức năng";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 709);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1584, 39);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MANV
            // 
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(84, 32);
            this.MANV.Text = "MANV";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(91, 32);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(89, 32);
            this.NHOM.Text = "NHOM";
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Caption = "Tạo tài khoản";
            this.btnTaoTaiKhoan.Id = 3;
            this.btnTaoTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.Image")));
            this.btnTaoTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.LargeImage")));
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 748);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản Lý";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem NhanVienbarButton;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpQuanTri;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnSinhVien;
        private DevExpress.XtraBars.BarButtonItem btnLapPhieuNX;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MANV;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.BarButtonItem LopHocbarButton;
        private DevExpress.XtraBars.BarButtonItem MonHocButtonItem;
        private DevExpress.XtraBars.BarButtonItem DiemButtonItem;
        private DevExpress.XtraBars.BarButtonItem LopTinChibarButtonItem;
        private DevExpress.XtraBars.BarButtonItem HocPhibarButton;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem LopTinChibarButton;
        private DevExpress.XtraBars.BarButtonItem DangKibarButton;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpCauHinh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnTaoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnTaoTK;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
    }
}

