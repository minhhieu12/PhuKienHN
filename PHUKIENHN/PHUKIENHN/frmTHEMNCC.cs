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
    public partial class frmTHEMNCC : Form
    {
        public frmTHEMNCC()
        {
            InitializeComponent();
        }

        private void frmTHEMNCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pHUKIENHNDataSet3.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.pHUKIENHNDataSet3.NHACUNGCAP);

        }
    }
}
