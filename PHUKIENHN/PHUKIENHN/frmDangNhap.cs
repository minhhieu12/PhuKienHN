using PHUKIENHN.Class;
using PHUKIENHN.DAO;
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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = txtTenDN.Text.Trim();
            string passWord = txtMK.Text.Trim();
            
            if (LoginDAO.Instance.checkError(userName, passWord) != string.Empty)
            {
                MessageBox.Show(LoginDAO.Instance.checkError(userName, passWord));
            }    

            if (LoginDAO.Instance.isLogin(userName, passWord))
            {
                this.Hide();
                frmMain f = new frmMain(userName, passWord);
                f.ShowDialog();
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

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            //txtTenDN.Text = "minhnghia";
            //txtMK.Text = "123";
        }
    }
}
