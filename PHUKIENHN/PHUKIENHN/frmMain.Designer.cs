namespace PHUKIENHN
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnTaoHD = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnTinhLuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuNK = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuXK = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMK = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoanhThu = new DevExpress.XtraBars.BarButtonItem();
            this.btnTonKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnTTPM = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnCaLV = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSSP = new DevExpress.XtraBars.BarButtonItem();
            this.tabform = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.SystemColors.Control;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnTaoHD,
            this.btnThoat,
            this.btnDSNV,
            this.btnTinhLuong,
            this.btnPhieuNK,
            this.btnPhieuXK,
            this.barButtonItem3,
            this.btnDoiMK,
            this.btnDoanhThu,
            this.btnTonKho,
            this.btnTTPM,
            this.btnDangXuat,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 20;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1019, 160);
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.Caption = "Tạo hoá đơn";
            this.btnTaoHD.Id = 1;
            this.btnTaoHD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoHD.ImageOptions.Image")));
            this.btnTaoHD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaoHD.ImageOptions.LargeImage")));
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoHD_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát ứng dụng";
            this.btnThoat.Id = 2;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnDSNV
            // 
            this.btnDSNV.Caption = "Danh sách nhân viên";
            this.btnDSNV.Id = 3;
            this.btnDSNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSNV.ImageOptions.Image")));
            this.btnDSNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDSNV.ImageOptions.LargeImage")));
            this.btnDSNV.Name = "btnDSNV";
            this.btnDSNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSNV_ItemClick);
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Caption = "Tính lương";
            this.btnTinhLuong.Id = 5;
            this.btnTinhLuong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTinhLuong.ImageOptions.Image")));
            this.btnTinhLuong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTinhLuong.ImageOptions.LargeImage")));
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTinhLuong_ItemClick);
            // 
            // btnPhieuNK
            // 
            this.btnPhieuNK.Caption = "Tạo phiếu nhập kho";
            this.btnPhieuNK.Id = 8;
            this.btnPhieuNK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuNK.ImageOptions.Image")));
            this.btnPhieuNK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhieuNK.ImageOptions.LargeImage")));
            this.btnPhieuNK.Name = "btnPhieuNK";
            this.btnPhieuNK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuNK_ItemClick);
            // 
            // btnPhieuXK
            // 
            this.btnPhieuXK.Caption = "Tạp phiếu xuất kho";
            this.btnPhieuXK.Id = 9;
            this.btnPhieuXK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuXK.ImageOptions.Image")));
            this.btnPhieuXK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhieuXK.ImageOptions.LargeImage")));
            this.btnPhieuXK.Name = "btnPhieuXK";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Thống kê";
            this.barButtonItem3.Id = 10;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Caption = "Đổi mật khẩu";
            this.btnDoiMK.Id = 11;
            this.btnDoiMK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMK.ImageOptions.Image")));
            this.btnDoiMK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDoiMK.ImageOptions.LargeImage")));
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiMK_ItemClick);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Caption = "Doanh thu";
            this.btnDoanhThu.Id = 12;
            this.btnDoanhThu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoanhThu.ImageOptions.Image")));
            this.btnDoanhThu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDoanhThu.ImageOptions.LargeImage")));
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoanhThu_ItemClick);
            // 
            // btnTonKho
            // 
            this.btnTonKho.Caption = "Tồn kho";
            this.btnTonKho.Id = 14;
            this.btnTonKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTonKho.ImageOptions.Image")));
            this.btnTonKho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTonKho.ImageOptions.LargeImage")));
            this.btnTonKho.Name = "btnTonKho";
            this.btnTonKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTonKho_ItemClick);
            // 
            // btnTTPM
            // 
            this.btnTTPM.Caption = "Thông tin phần mềm";
            this.btnTTPM.Id = 16;
            this.btnTTPM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTTPM.ImageOptions.Image")));
            this.btnTTPM.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTTPM.ImageOptions.LargeImage")));
            this.btnTTPM.Name = "btnTTPM";
            this.btnTTPM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTTPM_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 18;
            this.btnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.Image")));
            this.btnDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.LargeImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "e";
            this.barButtonItem1.Id = 19;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup5,
            this.ribbonPageGroup2,
            this.ribbonPageGroup6,
            this.ribbonPageGroup8,
            this.ribbonPageGroup4});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Sử dụng phần mềm";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTaoHD);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản lý hoá đơn";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnPhieuNK);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Sản phẩm";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDSNV);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTinhLuong);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Quản lý nhân sự";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnDoanhThu);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnTonKho);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Thống kê";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnTTPM);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Trợ giúp";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDoiMK);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnThoat);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Chức năng khác";
            // 
            // btnCaLV
            // 
            this.btnCaLV.Caption = "Ca làm việc";
            this.btnCaLV.Id = 4;
            this.btnCaLV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCaLV.ImageOptions.Image")));
            this.btnCaLV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCaLV.ImageOptions.LargeImage")));
            this.btnCaLV.Name = "btnCaLV";
            // 
            // btnDSSP
            // 
            this.btnDSSP.Caption = "Danh sách sản phẩm";
            this.btnDSSP.Id = 7;
            this.btnDSSP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSSP.ImageOptions.Image")));
            this.btnDSSP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDSSP.ImageOptions.LargeImage")));
            this.btnDSSP.Name = "btnDSSP";
            // 
            // tabform
            // 
            this.tabform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabform.Location = new System.Drawing.Point(0, 160);
            this.tabform.Name = "tabform";
            this.tabform.SelectedIndex = 0;
            this.tabform.Size = new System.Drawing.Size(1019, 363);
            this.tabform.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 523);
            this.Controls.Add(this.tabform);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "PHẦN MỀM QUẢN LÝ CỬA HÀNG PHỤ KIỆN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnTaoHD;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnDSNV;
        private DevExpress.XtraBars.BarButtonItem btnTinhLuong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnPhieuNK;
        private DevExpress.XtraBars.BarButtonItem btnPhieuXK;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnDoiMK;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnDoanhThu;
        private DevExpress.XtraBars.BarButtonItem btnTonKho;
        private DevExpress.XtraBars.BarButtonItem btnTTPM;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem btnCaLV;
        private DevExpress.XtraBars.BarButtonItem btnDSSP;
        private System.Windows.Forms.TabControl tabform;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}

