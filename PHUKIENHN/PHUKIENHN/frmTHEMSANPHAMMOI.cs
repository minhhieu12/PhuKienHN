using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHUKIENHN
{
    public partial class frmTHEMSANPHAMMOI : Form
    {
        public frmTHEMSANPHAMMOI()
        {
            InitializeComponent();
        }

        private void frmTHEMSANPHAMMOI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pHUKIENHNDataSet1.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.pHUKIENHNDataSet1.SANPHAM);

        }

        private void btnTHEMNCC_Click(object sender, EventArgs e)
        {
            frmTHEMNCC FrmTHEMNCC = new frmTHEMNCC();
            FrmTHEMNCC.ShowDialog();
        }
    }
}
