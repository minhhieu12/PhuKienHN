using PHUKIENHN.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHUKIENHN
{
    public partial class frmDangNhap : Form
    {

        public frmDangNhap()
        {
            InitializeComponent();
        }

        XLBANG_NHANVIEN tblNhanVien;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string strUserName = txtTenDN.Text.Trim();
            string strPassWord = txtMK.Text.Trim();
            string strErr = string.Empty;

            if (strUserName == string.Empty && strPassWord == string.Empty)
            {
                strErr = "Bạn chưa nhập tài khoản và mật khẩu!";
            } 
            else if (strUserName == string.Empty)
            {
                strErr = "Tài khoản vui lòng không được bỏ trống";
            }
            else if (strPassWord == string.Empty)
            {
                strErr = "Mật khẩu vui lòng không được bỏ trống";
            }

            if(strErr != string.Empty)
            {
                MessageBox.Show(strErr);
                return;
            }

            tblNhanVien = new XLBANG_NHANVIEN();
            var r = tblNhanVien.Select("TENDN='" + txtTenDN.Text + "' AND MATKHAU='" + txtMK.Text + "'");
            if (r.Count() > 0)
            {
                this.Hide();
                frmMain FrmMain = new frmMain(r[0]["CHUCVU"].ToString().Trim(), r[0]["TENDN"].ToString().Trim(), r[0]["MATKHAU"].ToString().Trim());
                FrmMain.Text = "Cửa hàng phụ kiện H&N - Chào " + r[0]["TENNV"].ToString().Trim() + " (" + r[0]["CHUCVU"].ToString().Trim() + ")";
                FrmMain.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!");
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        
    }
}
