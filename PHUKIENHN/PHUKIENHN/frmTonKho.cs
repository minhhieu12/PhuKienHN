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
using System.Data.SqlClient;

namespace PHUKIENHN
{
    public partial class frmTonKho : Form
    {
        public frmTonKho()
        {
            InitializeComponent();
        }

        XLBANG_SANPHAM tblSANPHAM;
        BindingManagerBase DSTK;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage p = (TabPage)this.Parent;
            TabControl tabMain = (TabControl)p.Parent;
            tabMain.TabPages.Remove(p);
        }

        private void frmTonKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pHUKIENHNDataSet1.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.pHUKIENHNDataSet1.SANPHAM);
            // TODO: This line of code loads data into the 'pHUKIENHNDataSet1.CTHOADON' table. You can move, or remove it, as needed.
            this.cTHOADONTableAdapter.Fill(this.pHUKIENHNDataSet1.CTHOADON);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvTonKho.Rows)
            {
                if (dgvTonKho.Rows.Count > r.Index + 1)
                    r.Cells[0].Value = r.Index + 1;
            }
        }

        private void btnXUATEXCEL_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "DANH SÁCH TỒN KHO";
            for (int i = 1; i < dgvTonKho.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvTonKho.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvTonKho.Rows.Count - 1; i++)
            {
                for (int j = 1; j < dgvTonKho.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvTonKho.Rows[i].Cells[j].Value.ToString();
                }
            }
        }

        private void txtTIMKIEM_TextChanged(object sender, EventArgs e)
        {
            string TENHH = txtTIMKIEM.Text.ToString();
            string query = string.Format("SELECT * FROM SANPHAM WHERE TENSP LIKE N{0}%'", TENHH);
            DataTable sanpham = DataProvider.Instance.ExecuteQuery(query);
            dgvTonKho.DataSource = sanpham;
        }
    }
}
