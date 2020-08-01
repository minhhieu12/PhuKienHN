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
            string shd = "SELECT MAX(HOADON.SOHD) AS SHD FROM HOADON";
            DataTable dt = DataProvider.Instance.ExecuteQuery(shd);
            string shd2 = dt.Rows[0]["SHD"].ToString();
            var query = "SELECT HOADON.SOHD, HOADON.NGAYTAO, HOADON.TONGTIEN, " +
                    "HOADON.TENKH, HOADON.DIACHI, HOADON.SDT, " +
                    "CTHOADON.MASP, SANPHAM.TENSP, CTHOADON.SOLUONG, CTHOADON.DONGIA, CTHOADON.CHIETKHAU, CTHOADON.THANHTIEN " +
                    "FROM CTHOADON INNER JOIN HOADON ON CTHOADON.SOHD = HOADON.SOHD INNER JOIN SANPHAM ON CTHOADON.MASP = SANPHAM.MASP " +
                    "WHERE(HOADON.SOHD = '"+ shd2 +"')";

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
