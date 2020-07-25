﻿using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHUKIENHN.Class;

namespace PHUKIENHN
{
    public partial class frmMain : Form
    {
        string LTK, UserName, PassWord;
        public frmMain(string _LTK, string _UserName, string _PassWord)
        {
            InitializeComponent();
            this.LTK = _LTK;
            this.PassWord = _PassWord;
            this.UserName = _UserName;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnTaoHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabform.TabPages.IndexOfKey("TaoHoaDon");
            if (index >= 0)
                tabform.SelectedIndex = index;
            else
            {
                frmTaoHD f = new frmTaoHD();
                f.Text = "Tạo hóa đơn";
                f.MdiParent = this;
                TabPage p = new TabPage(f.Text);
                p.Name = "TaoHoaDon";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabform.TabPages.Add(p);
                f.Show();
            }
        }

        

        public void enableControl()
        {
            switch (this.LTK.Trim())
            {
                
                case "Bán hàng":
                    btnTaoHD.Enabled = true;
                    btnCapNhatHD.Enabled = false;
                    btnPhieuNK.Enabled = false;
                    btnDSNV.Enabled = false;
                    btnTinhLuong.Enabled = false;
                    btnDoanhThu.Enabled = false;
                    btnTonKho.Enabled = false;
                    btnTTDonHang.Enabled = false;
                    btnTTPM.Enabled = true;
                    btnDoiMK.Enabled = true;
                    btnThoat.Enabled = true;
                    break;

                case "Kho":
                    btnTaoHD.Enabled = false;
                    btnCapNhatHD.Enabled = false;
                    btnPhieuNK.Enabled = true;
                    btnDSNV.Enabled = false;
                    btnTinhLuong.Enabled = false;
                    btnDoanhThu.Enabled = false;
                    btnTonKho.Enabled = true;
                    btnTTDonHang.Enabled = false;
                    btnTTPM.Enabled = true;
                    btnDoiMK.Enabled = true;
                    btnThoat.Enabled = true;
                    break;

                case "Giao hàng":
                    btnTaoHD.Enabled = false;
                    btnCapNhatHD.Enabled = false;
                    btnPhieuNK.Enabled = false;
                    btnDSNV.Enabled = false;
                    btnTinhLuong.Enabled = false;
                    btnDoanhThu.Enabled = false;
                    btnTonKho.Enabled = false;
                    btnTTDonHang.Enabled = true;
                    btnTTPM.Enabled = true;
                    btnDoiMK.Enabled = true;
                    btnThoat.Enabled = true;
                    break;

                case "Admin":
                    btnTaoHD.Enabled = true;
                    btnCapNhatHD.Enabled = true;
                    btnPhieuNK.Enabled = true;
                    btnDSNV.Enabled = true;
                    btnTinhLuong.Enabled = true;
                    btnDoanhThu.Enabled = true;
                    btnTonKho.Enabled = true;
                    btnTTDonHang.Enabled = true;
                    btnTTPM.Enabled = true;
                    btnDoiMK.Enabled = true;
                    btnThoat.Enabled = true;
                    break;

                default:
                    btnTaoHD.Enabled = false;
                    btnCapNhatHD.Enabled = false;
                    btnPhieuNK.Enabled = false;
                    btnDSNV.Enabled = false;
                    btnTinhLuong.Enabled = false;
                    btnDoanhThu.Enabled = false;
                    btnTonKho.Enabled = false;
                    btnTTDonHang.Enabled = false;
                    btnTTPM.Enabled = false;
                    btnDoiMK.Enabled = false;
                    btnThoat.Enabled = false;
                    break;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            enableControl();
            this.IsMdiContainer = true;
            
        }

        private void btnTTPM_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTTPM FrmTTPM = new frmTTPM();
            FrmTTPM.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            tabform.TabPages.Remove(tabform.SelectedTab);
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmDangNhap FrmDangNhap = new frmDangNhap();
                FrmDangNhap.ShowDialog();
                this.Close();
            }    
        }

        private void btnDoiMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoiMK FrmDoiMK = new frmDoiMK(UserName ,PassWord);
            FrmDoiMK.ShowDialog();
        }
    }
}
