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
using System.IO;

namespace PHUKIENHN.DAO
{
    public partial class frmINHOADON : Form
    {
        public frmINHOADON()
        {
            InitializeComponent();
        }

        private void frmINHOADON_Load(object sender, EventArgs e)
        {
            var query = "";
            SqlDataAdapter da = new SqlDataAdapter(query, DataProvider.Instance.connectionString);
            try
            {
                DataTable tbHoaDon = new DataTable();
                da.Fill(tbHoaDon);
                rptHOADON rpt = new rptHOADON();
                rpt.SetDataSource(tbHoaDon);
                crvINHOADON.ReportSource = rpt;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
