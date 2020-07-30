using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHUKIENHN.DAO;

namespace PHUKIENHN
{
    public partial class frmTaoHD : Form
    {
        public frmTaoHD()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            TabPage p = (TabPage)this.Parent;
            TabControl tabMain = (TabControl)p.Parent;
            tabMain.TabPages.Remove(p);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage p = (TabPage)this.Parent;
            TabControl tabMain = (TabControl)p.Parent;
            tabMain.TabPages.Remove(p);
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            frmINHOADON FrmINHD = new frmINHOADON();
            FrmINHD.ShowDialog();
        }
    }
}
