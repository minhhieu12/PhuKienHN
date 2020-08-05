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
    public partial class frmTHEMSANPHAMMOI : Form
    {
        public frmTHEMSANPHAMMOI()
        {
            InitializeComponent();
        }

        int i = 0;

        private void loadCBONCC()
        {
            DataTable data = NHAPKHODAO.Instance.dataCOMBONCC();
            cboNCC.DataSource = data;
            cboNCC.DisplayMember = "TENNCC";
            cboNCC.ValueMember = "MANCC";
            cboNCC.SelectedValue = "";
        }

        
        private void frmTHEMSANPHAMMOI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pHUKIENHNDataSet1.SANPHAM' table. You can move, or remove it, as needed.
            //this.sANPHAMTableAdapter.Fill(this.pHUKIENHNDataSet1.SANPHAM);
            btnTHEMMOI.Enabled = false;
            txtMASP.Text = PHATSINHMANV.Instance.MASP().ToString();
            loadCBONCC();
            txtNCC.Text = "";

        }

        private void btnTHEMNCC_Click(object sender, EventArgs e)
        {
            frmTHEMNCC FrmTHEMNCC = new frmTHEMNCC();
            FrmTHEMNCC.ShowDialog();
        }

        private void cboNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNCC.SelectedValue != null)

                txtNCC.Text = cboNCC.SelectedValue.ToString();
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            /*
            this.dgvSANPHAM.Rows.Add("", txtMASP.Text.ToString(), txtTENSP.Text.ToString(), txtNCC.Text.ToString() ,txtDVT.Text.ToString(), txtSL.Text.ToString(), txtGIA.Text.ToString());

            foreach (DataGridViewRow r in dgvSANPHAM.Rows)
            {

                if (dgvSANPHAM.Rows.Count > r.Index + 1)
                {
                    r.Cells[0].Value = r.Index + 1;

                    i = r.Index;
                }
            }
            */

            btnTHEMMOI.Enabled = true;
            btnLUU.Enabled = false;

            string maSP = txtMASP.Text.ToString();

            string tenSP = txtTENSP.Text.ToString();

            string dvt = txtDVT.Text.ToString();

            string sl = txtSL.Text.ToString();

            string dongia = txtGIA.Text.ToString();

            string maNCC = txtNCC.Text.ToString();

            string querytoSANPHAM = string.Format("INSERT INTO SANPHAM (MASP, TENSP, DVT, SLTON, DONGIA, MANCC) VALUES ('{0}', N'{1}', N'{2}', {3}, {4}, '{5}')", maSP, tenSP, dvt, sl, dongia, maNCC);

            DataProvider.Instance.ExecuteNonQuery(querytoSANPHAM);

            MessageBox.Show("Đã lưu");
        }

        private void btnTHEMMOI_Click(object sender, EventArgs e)
        {
            txtMASP.Text = PHATSINHMANV.Instance.MASP().ToString();
            loadCBONCC();
            txtNCC.Text = "";
            txtTENSP.Text = "";
            txtDVT.Text = "";
            txtGIA.Text = "";
            txtSL.Text = "";
            btnLUU.Enabled = true;
        }
    }
}
