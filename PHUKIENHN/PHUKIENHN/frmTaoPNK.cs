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
    public partial class frmTaoPNK : Form
    {
        int i = 0;
        int tongtien = 0;

        public frmTaoPNK()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage p = (TabPage)this.Parent;
            TabControl tabMain = (TabControl)p.Parent;
            tabMain.TabPages.Remove(p);
        }

        private void loadCBOTENNV()
        {
            DataTable data = CreateInvoicesDAO.Instance.dataComboBoxMaNV();
            cboNVNHAP.DataSource = data;
            cboNVNHAP.DisplayMember = "TENNV";
            cboNVNHAP.ValueMember = "MANV";
            cboNVNHAP.SelectedValue = "";
        }

        private void loadCBONCC()
        {
            DataTable data = NHAPKHODAO.Instance.dataCOMBONCC();
            cboNCC.DataSource = data;
            cboNCC.DisplayMember = "TENNCC";
            cboNCC.ValueMember = "MANCC";
            cboNCC.SelectedValue = "";
        }

        private void loadCBOSP()
        {
            DataTable data = NHAPKHODAO.Instance.dataComboMAHH();
            cboTENHH.DataSource = data;
            cboTENHH.DisplayMember = "TENSP";
            cboTENHH.ValueMember = "MASP";
            cboTENHH.SelectedValue = "";
        }

        private void frmTaoPNK_Load(object sender, EventArgs e)
        {
            this.loadCBOTENNV();
            this.loadCBOSP();
            this.loadCBONCC();
            clearData();
            disableButton();
            btnLUU.Enabled = false;
            btnHUY.Enabled = false;
            btnCAPNHAT.Enabled = false;
            btnXUATEXCEL.Enabled = false;
            btnThem.Enabled = false;
            btnTHEMHANGMOI.Enabled = false;
            btnXOADONG.Enabled = false;
        }

        private void disableButton()
        {
            dateNGAY.Enabled = false;
            txtGHICHU.Enabled = false;
            txtSOLUONG.Enabled = false;
            cboNVNHAP.Enabled = false;
            txtDVT.Enabled = false;
            txtDONGIA.Enabled = false;
            txtGIAMGIA.Enabled = false;
            cboTENHH.Enabled = false;
            cboNCC.Enabled = false;
        }

        private void enableButton()
        {
            dateNGAY.Enabled = true;
            txtGHICHU.Enabled = true;
            txtSOLUONG.Enabled = true;
            cboNVNHAP.Enabled = true;
            txtDVT.Enabled = true;
            txtDONGIA.Enabled = true;
            txtGIAMGIA.Enabled = true;
            cboTENHH.Enabled = true;
            cboNCC.Enabled = true;
        }

        private void clearData()
        {
            cboNCC.SelectedValue = "";
            cboNVNHAP.SelectedValue = "";
            cboTENHH.SelectedValue = "";          
            txtSOPHIEU.Text = "";
            txtGHICHU.Text = "";
            txtMAHH.Text = "";
            txtDVT.Text = "Cái";
            txtMANV.Text = "";
            txtMANCC.Text = "";
            txtDONGIA.Text = "0";
            txtTHANHTIEN.Text = "0";
            txtGIAMGIA.Text = "0";
            txtSOLUONG.Text = "0";
            dgvPHIEUNHAPKHO.Rows.Clear();
            dgvPHIEUNHAPKHO.Refresh();
            tongtien = 0;
            txtTONGCONG.Text = "";
        }

        private void btnTHEMMOI_Click(object sender, EventArgs e)
        {
            enableButton();
            btnXUATEXCEL.Enabled = false;
            btnCAPNHAT.Enabled = false;
            btnLUU.Enabled = true;
            btnHUY.Enabled = true;
            btnThem.Enabled = true;
            btnTHEMHANGMOI.Enabled = true;
            btnXOADONG.Enabled = true;
            clearData();
            txtSOPHIEU.Text = PHATSINHMANV.Instance.MAPN().ToString();
        }

        private void txtTENHH_TextChanged(object sender, EventArgs e)
        {

        }

        private int tinhTien()
        {
            int soLuong = 0, giamGia = 0;

            int donGia = Convert.ToInt32(txtDONGIA.Text);


            if (txtSOLUONG.Text != string.Empty)
            {
                soLuong = Convert.ToInt32(txtSOLUONG.Text);
            }

            if (txtGIAMGIA.Text != string.Empty)
            {
                giamGia = Convert.ToInt32(txtGIAMGIA.Text);
            }

            int thanhTien = donGia * soLuong - giamGia;

            return thanhTien;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            clearData();
            btnXUATEXCEL.Enabled = false;
            btnCAPNHAT.Enabled = false;
            btnLUU.Enabled = false;
            btnTHEMMOI.Enabled = true;
            btnThem.Enabled = false;
            btnTHEMHANGMOI.Enabled = false;
            btnXOADONG.Enabled = false;
        }

        private void cboNVNHAP_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            string query = string.Format("SELECT * FROM NHANVIEN WHERE TENNV = N'{0}'", cboNVNHAP.SelectedValue);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                txtMANV.Text = data.Rows[0]["MANV"].ToString();
            }
            */
            if (cboNVNHAP.SelectedValue != null)

                txtMANV.Text = cboNVNHAP.SelectedValue.ToString();
        }

        private void txtSOLUONG_TextChanged(object sender, EventArgs e)
        {
            txtTHANHTIEN.Text = tinhTien().ToString();
        }

        private void txtGIAMGIA_TextChanged(object sender, EventArgs e)
        {
            txtTHANHTIEN.Text = tinhTien().ToString();
        }

        private void txtDONGIA_TextChanged(object sender, EventArgs e)
        {
            txtTHANHTIEN.Text = tinhTien().ToString();
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            if(txtSOPHIEU.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Chưa có mã phiếu nhập! Nhấn Thêm mới!");
            }
            else if (dgvPHIEUNHAPKHO.Rows.Count == 1)
            {
                MessageBox.Show("Chưa thêm mặt hàng!");
            }
            else if (txtMANV.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!");
            }
            else
            {
                string soPN = txtSOPHIEU.Text.ToString();

                string date = dateNGAY.Value.ToString("yyyy-MM-dd");

                string maNV = txtMANV.Text.ToString();

                string ghiCHU = txtGHICHU.Text.ToString();

                string querytoPHIEUNHAP = string.Format("INSERT INTO PHIEUNHAP (SOPHIEUNHAP, NGAYNHAP, NVNHAP, GHICHU) VALUES ('{0}', '{1}', '{2}', N'{3}')", soPN, date, maNV, ghiCHU);

                DataProvider.Instance.ExecuteNonQuery(querytoPHIEUNHAP);

                foreach (DataGridViewRow r in dgvPHIEUNHAPKHO.Rows)
                {
                    if (r.Cells[1].Value != null)
                    {
                        string maSP = r.Cells[1].Value.ToString();

                        string maNCC = r.Cells[3].Value.ToString();

                        string dvt = r.Cells[5].Value.ToString();

                        int sl = Convert.ToInt32(r.Cells[6].Value);

                        int dongia = Convert.ToInt32(r.Cells[7].Value);

                        int giamgia = Convert.ToInt32(r.Cells[8].Value);

                        int thanhtien = Convert.ToInt32(r.Cells[9].Value);

                        string queryToPHIEUNHAP = string.Format("INSERT INTO CTPHIEUNHAP (SOPHIEUNHAP, MASP, DVT, SL, DONGIA, MANCC, CHIETKHAU, THANHTIEN) VALUES ('{0}', '{1}', '{2}', {3}, {4}, '{5}', {6}, {7})", soPN, maSP, dvt, sl, dongia, maNCC, giamgia, tongtien);

                        DataProvider.Instance.ExecuteNonQuery(queryToPHIEUNHAP);
                    }
                }
                MessageBox.Show("Đã lưu!");
            }            
            btnXUATEXCEL.Enabled = true;

        }

        private bool kiemTraLoiThemMatHang(string maHangHoa)
        {
            foreach (DataGridViewRow r in dgvPHIEUNHAPKHO.Rows)
            {
                if (r.Cells[1].Value != null)
                {
                    if (maHangHoa == r.Cells[1].Value.ToString())
                    {
                        return false;
                    }
                }

            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            tongtien += tinhTien();

            string queryTENHH = string.Format("SELECT TENSP FROM SANPHAM WHERE MASP = '{0}'", cboTENHH.SelectedValue.ToString());

            DataTable dt = DataProvider.Instance.ExecuteQuery(queryTENHH);

            string TENHH = dt.Rows[0]["TENSP"].ToString();

            string queryTENNCC = string.Format("SELECT TENNCC FROM NHACUNGCAP WHERE MANCC = '{0}'", cboNCC.SelectedValue.ToString());

            DataTable dt2 = DataProvider.Instance.ExecuteQuery(queryTENNCC);

            string TENNCC = dt2.Rows[0]["TENNCC"].ToString();

            foreach (DataGridViewRow r in dgvPHIEUNHAPKHO.Rows)
            {
                if (r.Cells[1].Value != null)
                {
                    if (txtMAHH.Text.ToString() == r.Cells[1].Value.ToString())
                    {
                        MessageBox.Show("Hàng hoá đã tồn tại!");
                        return;
                    }
                }
            }

            this.dgvPHIEUNHAPKHO.Rows.Add("",txtMAHH.Text.ToString(), TENHH, txtMANCC.Text.ToString(), TENNCC, txtDVT.Text.ToString(), txtSOLUONG.Text.ToString(), txtDONGIA.Text.ToString(), txtGIAMGIA.Text.ToString(), txtTHANHTIEN.Text.ToString());

            txtTONGCONG.Text = tongtien.ToString() + " VND";

            foreach (DataGridViewRow r in dgvPHIEUNHAPKHO.Rows)
            {

                if (dgvPHIEUNHAPKHO.Rows.Count > r.Index + 1)
                {
                    r.Cells[0].Value = r.Index + 1;

                    i = r.Index;
                }
            }
        }

        private void cboTENHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            string query = string.Format("SELECT * FROM SANPHAM WHERE TENSP = N'{0}'", cboTENHH.SelectedValue);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                txtMAHH.Text = data.Rows[0]["MASP"].ToString();
            }
            */

            if(cboTENHH.SelectedValue != null)

                txtMAHH.Text = cboTENHH.SelectedValue.ToString();

            cboNCC.SelectedValue = "";
            txtMANCC.Text = "";
            txtDONGIA.Text = "0";
            txtTHANHTIEN.Text = "0";
            txtGIAMGIA.Text = "0";
            txtSOLUONG.Text = "0";
        }

        private void cboNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            string query = string.Format("SELECT * FROM NHACUNGCAP WHERE TENNCC = N'{0}'", cboNCC.SelectedValue);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                txtMANCC.Text = data.Rows[0]["MANCC"].ToString();
            }
            */
            if (cboNCC.SelectedValue != null)

                txtMANCC.Text = cboNCC.SelectedValue.ToString();
        }

        private void txtMANV_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnXUATEXCEL_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "PHIẾU NHẬP KHO";
            worksheet.Cells[1, 1] = string.Format("Mã phiếu nhập");
            worksheet.Cells[1, 2] = txtSOPHIEU.Text.ToString();
            worksheet.Cells[2, 1] = string.Format("Ngày nhập");
            worksheet.Cells[2, 2] = dateNGAY.Value.ToString("dd-MM-yyyy");
            worksheet.Cells[3, 1] = string.Format("Nhân viên nhập");
            string queryTENNV = string.Format("SELECT TENNV FROM NHANVIEN WHERE MANV = '{0}'", cboNVNHAP.SelectedValue.ToString());

            DataTable dt = DataProvider.Instance.ExecuteQuery(queryTENNV);

            string TENNV = dt.Rows[0]["TENNV"].ToString();

            worksheet.Cells[3, 2] = TENNV;
            worksheet.Cells[4, 1] = string.Format("Ghi chú");
            worksheet.Cells[4, 2] = txtGHICHU.Text.ToString();
            
            worksheet.Cells[5, 1] = string.Format("TỔNG DOANH THU");
            worksheet.Cells[5, 2] = txtTONGCONG.Text.ToString();

            worksheet.Cells[6, 1] = string.Format("Danh sách hàng hoá");
            for (int i = 1; i < dgvPHIEUNHAPKHO.Columns.Count + 1; i++)
            {
                worksheet.Cells[7, i] = dgvPHIEUNHAPKHO.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvPHIEUNHAPKHO.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvPHIEUNHAPKHO.Columns.Count; j++)
                {
                    worksheet.Cells[i + 8, j + 1] = dgvPHIEUNHAPKHO.Rows[i].Cells[j].Value.ToString();
                }
            }
            
        }

        private void btnSUADONG_Click(object sender, EventArgs e)
        {

        }

        private void btnXOADONG_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgvPHIEUNHAPKHO.SelectedCells)
            {
                if (oneCell.Selected)
                    dgvPHIEUNHAPKHO.Rows.RemoveAt(oneCell.RowIndex);
            }
        }

        public void dgvPHIEUNHAPKHO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = this.dgvPHIEUNHAPKHO.Rows[e.RowIndex];
                indexRow = row;

                txtMAHH.Text = row.Cells[1].Value.ToString();
                cboTENHH.Text = row.Cells[2].Value.ToString();
                txtMANCC.Text = row.Cells[3].Value.ToString();
                cboNCC.Text = row.Cells[4].Value.ToString();
                txtDVT.Text = row.Cells[5].Value.ToString();
                txtSOLUONG.Text = row.Cells[6].Value.ToString();
                txtDONGIA.Text = row.Cells[7].Value.ToString();
                txtGIAMGIA.Text = row.Cells[8].Value.ToString();
                txtTHANHTIEN.Text = row.Cells[9].Value.ToString();
            }
            btnCAPNHAT.Enabled = true;
        }

        DataGridViewRow indexRow;
        
        private void btnCAPNHAT_Click(object sender, EventArgs e)
        {
            int tienbd = Convert.ToInt32(indexRow.Cells[9].Value);

            //indexRow = dgvPHIEUNHAPKHO.SelectedRows[0].Index;

            //DataGridViewRow dr = dgvPHIEUNHAPKHO.SelectedRows[indexRow];

            //dgvPHIEUNHAPKHO.Rows[indexRow].SetValues("", txtMAHH.Text.ToString(), cboTENHH.Text.ToString(), txtMANCC.Text.ToString(), cboNCC.Text.ToString(), txtDVT.Text.ToString(), txtSOLUONG.Text.ToString(), txtDONGIA.Text.ToString(), txtGIAMGIA.Text.ToString(), txtTHANHTIEN.Text.ToString());

            indexRow.Cells[3].Value = txtMANCC.Text.ToString();

            indexRow.Cells[4].Value = cboNCC.Text.ToString();

            indexRow.Cells[5].Value = txtDVT.Text.ToString();

            indexRow.Cells[6].Value = txtSOLUONG.Text.ToString();

            indexRow.Cells[7].Value = txtDONGIA.Text.ToString();

            indexRow.Cells[8].Value = txtGIAMGIA.Text.ToString();

            indexRow.Cells[9].Value = txtTHANHTIEN.Text.ToString();

            //txtTONGCONG.Text = tongtien.ToString() + " VND";

            tongtien += tinhTien() - tienbd;

            txtTONGCONG.Text = tongtien.ToString() + " VND";
        }

        private void btnTHEMHANGMOI_Click(object sender, EventArgs e)
        {
            frmTHEMSANPHAMMOI FrmTHEMSPMOI = new frmTHEMSANPHAMMOI();
            FrmTHEMSPMOI.ShowDialog();
        }
    }
}
