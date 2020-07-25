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
    public partial class frmDoiMK : Form
    {

        string UserName ,PassWord;
        public frmDoiMK(string _UserName, string _PassWord)
        {
            this.UserName = _UserName;
            this.PassWord = _PassWord;
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        XLBANG_NHANVIEN tblNhanVien;
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            tblNhanVien = new XLBANG_NHANVIEN();
            string strErr = string.Empty;
            string strMatKhauCu = txtMKCu.Text.Trim();
            string strMatKhauMoi = txtMKMoi.Text.Trim();
            string strNhapLaiMatKhauMoi = txtNLMKMoi.Text.Trim();

            if (strMatKhauCu == string.Empty || strMatKhauMoi == string.Empty || strNhapLaiMatKhauMoi == string.Empty)
                strErr = "Mật khẩu vui lòng không được bỏ trống!";
            else if (strMatKhauMoi != strNhapLaiMatKhauMoi)
                strErr = "Mật khẩu mới đã nhập không trùng nhau!";
            else if (PassWord != strMatKhauCu)
                strErr = "Mật khẩu cũ sai!";

            if (strErr != string.Empty)
            {
                MessageBox.Show(strErr);
                return;
            } else
            {
                int count = XULYBANG.TruyVan("UPDATE NHANVIEN SET MATKHAU = '" + strMatKhauMoi + "' WHERE TENDN = '" + UserName + "'");
                
                if (count > 0)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    this.Close();
                }
                    
                else MessageBox.Show("Failed!");
            }
        }
    }
}
