using DevExpress.XtraBars;
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
using PHUKIENHN.DAO;

namespace PHUKIENHN
{
    public partial class frmMain : Form
    {
        string UserName, PassWord;
        public frmMain(string _UserName, string _PassWord)
        {
            InitializeComponent();
            this.PassWord = _PassWord;
            this.UserName = _UserName;
        }

        public frmMain()
        {
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

        public void enableControl(string userName)
        {
            string rankAccount = RankDAO.Instace.RankAccount(userName);

            switch (rankAccount.Trim())
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
            enableControl(UserName);
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

        private void btnCapNhatHD_ItemClick(object sender, ItemClickEventArgs e)
        {
            int index = tabform.TabPages.IndexOfKey("CapNhatHoaDon");
            if (index >= 0)
                tabform.SelectedIndex = index;
            else
            {
                frmCapNhatHD f = new frmCapNhatHD();
                f.Text = "Cập nhật hóa đơn";
                f.MdiParent = this;
                TabPage p = new TabPage(f.Text);
                p.Name = "CapNhatHoaDon";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabform.TabPages.Add(p);
                f.Show();
            }
        }

        private void btnPhieuNK_ItemClick(object sender, ItemClickEventArgs e)
        {
            int index = tabform.TabPages.IndexOfKey("TaoPhieuNhapKho");
            if (index >= 0)
                tabform.SelectedIndex = index;
            else
            {
                frmTaoPNK f = new frmTaoPNK();
                f.Text = "Tạo phiếu nhập kho";
                f.MdiParent = this;
                TabPage p = new TabPage(f.Text);
                p.Name = "TaoPhieuNhapKho";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabform.TabPages.Add(p);
                f.Show();
            }
        }

        private void btnDSNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            int index = tabform.TabPages.IndexOfKey("QuanLyNhanVien");
            if (index >= 0)
                tabform.SelectedIndex = index;
            else
            {
                frmDSNV f = new frmDSNV();
                f.Text = "Quản lý nhân viên";
                f.MdiParent = this;
                TabPage p = new TabPage(f.Text);
                p.Name = "QuanLyNhanVien";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabform.TabPages.Add(p);
                f.Show();
            }
        }

        private void btnTinhLuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            int index = tabform.TabPages.IndexOfKey("TinhLuong");
            if (index >= 0)
                tabform.SelectedIndex = index;
            else
            {
                frmTinhLuong f = new frmTinhLuong();
                f.Text = "Tính lương";
                f.MdiParent = this;
                TabPage p = new TabPage(f.Text);
                p.Name = "TinhLuong";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabform.TabPages.Add(p);
                f.Show();
            }
        }

        private void btnDoanhThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            int index = tabform.TabPages.IndexOfKey("DoanhThu");
            if (index >= 0)
                tabform.SelectedIndex = index;
            else
            {
                frmDoanhThu f = new frmDoanhThu();
                f.Text = "Doanh thu";
                f.MdiParent = this;
                TabPage p = new TabPage(f.Text);
                p.Name = "DoanhThu";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabform.TabPages.Add(p);
                f.Show();
            }
        }

        private void btnTonKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            int index = tabform.TabPages.IndexOfKey("TonKho");
            if (index >= 0)
                tabform.SelectedIndex = index;
            else
            {
                frmTonKho f = new frmTonKho();
                f.Text = "Tồn Kho";
                f.MdiParent = this;
                TabPage p = new TabPage(f.Text);
                p.Name = "TonKho";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabform.TabPages.Add(p);
                f.Show();
            }
        }

        private void btnTTDonHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            int index = tabform.TabPages.IndexOfKey("CapNhatTTDonHang");
            if (index >= 0)
                tabform.SelectedIndex = index;
            else
            {
                frmCapNhatTTDH f = new frmCapNhatTTDH();
                f.Text = "Cập nhật tình trạng đơn hàng";
                f.MdiParent = this;
                TabPage p = new TabPage(f.Text);
                p.Name = "CapNhatTTDonHang";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabform.TabPages.Add(p);
                f.Show();
            }
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
