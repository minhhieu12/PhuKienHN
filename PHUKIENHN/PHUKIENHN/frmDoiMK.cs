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

        private void frmDoiMK_Load(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            tblNhanVien = new XLBANG_NHANVIEN();

            string oldPassword = txtMKCu.Text.Trim();
            string newPassword = txtMKMoi.Text.Trim();
            string confirmNewPassword = txtNLMKMoi.Text.Trim();

            string strErr = ChangePasswordDAO.Instance.CheckError(PassWord, oldPassword, newPassword, confirmNewPassword);

            if (strErr != string.Empty)
            {
                MessageBox.Show(strErr);
                return;
            }
                
            if (ChangePasswordDAO.Instance.checkChangePassword(UserName, newPassword))
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Close();
            }
                    
            else MessageBox.Show("Failed!");
            
        }
    }
}
