using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PHUKIENHN.DAO;

namespace PHUKIENHN
{
    public partial class frmINDSNV : Form
    {
        public frmINDSNV()
        {
            InitializeComponent();
        }

        private void frmINDSNV_Load(object sender, EventArgs e)
        {
            var query = "SELECT MANV, TENNV, GIOITINH, NGAYSINH, QUEQUAN, CMND, SDT, EMAIL, CHUCVU FROM NHANVIEN";
            SqlDataAdapter da = new SqlDataAdapter(query, DataProvider.Instance.connectionString);
            try
            {
                DataTable tbNHANVIEN = new DataTable();
                da.Fill(tbNHANVIEN);
                rptNHANVIEN rpt = new rptNHANVIEN();
                rpt.SetDataSource(tbNHANVIEN);
                crvINDSNV.ReportSource = rpt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
