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
    public partial class frmTHEMNCC : Form
    {
        public frmTHEMNCC()
        {
            InitializeComponent();
        }

        private void frmTHEMNCC_Load(object sender, EventArgs e)
        {
            txtMANCC.Text = PHATSINHMANV.Instance.MANCC();
            btnTHEMMOI.Enabled = false;
        }

        private void btnTHEMMOI_Click(object sender, EventArgs e)
        {
            txtMANCC.Text = PHATSINHMANV.Instance.MANCC();
            txtDIACHI.Text = "";
            txtEMAIL.Text = "";
            txtSDT.Text = "";
            txtTENNCC.Text = "";

            btnLUU.Enabled = true;
            btnLUU.Enabled = false;
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            string maNCC = txtMANCC.Text.ToString();

            string tenNCC = txtTENNCC.Text.ToString();

            string diachi = txtDIACHI.Text.ToString();

            string sdt = txtSDT.Text.ToString();

            string email = txtEMAIL.Text.ToString();

            string querytoNCC = string.Format("INSERT INTO NHACUNGCAP (MANCC, TENNCC, DIACHI, SDT, EMAIL) VALUES ('{0}', N'{1}', N'{2}', '{3}', '{4}')", maNCC, tenNCC, diachi, sdt, email);

            DataProvider.Instance.ExecuteNonQuery(querytoNCC);

            MessageBox.Show("Đã lưu");
            btnTHEMMOI.Enabled = true;
            btnLUU.Enabled = false;
        }
    }
}
