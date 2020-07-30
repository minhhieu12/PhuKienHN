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
            var query = "SELECT KHACHHANG.MAKH, KHACHHANG.TENKH, KHACHHANG.DIACHI, KHACHHANG.SDT, HOADON.SOHD, HOADON.NGAYTAO, CTHOADON.MASP, CTHOADON.DONGIA, CTHOADON.SOLUONG, CTHOADON.CHIETKHAU," +
                        "CTHOADON.THANHTIEN, SANPHAM.TENSP, dbo.fu_TINHTONGHOADON(CTHOADON.SOHD) AS TONGTIEN" +
                        "FROM CTHOADON INNER JOIN" +
                        "HOADON ON CTHOADON.SOHD = HOADON.SOHD INNER JOIN" +
                        "KHACHHANG ON HOADON.MAKH = KHACHHANG.MAKH INNER JOIN" +
                        "SANPHAM ON CTHOADON.MASP = SANPHAM.MASP";
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
