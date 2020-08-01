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
            DataTable data = NHAPKHODAO.Instance.dataComboNCC();
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
        }

        private void clearData()
        {
            cboNCC.SelectedValue = "";
            cboNVNHAP.SelectedValue = "";
            txtSOPHIEU.Text = "";
            txtGHICHU.Text = "";
            txtMAHH.Text = "";
            txtDVT.Text = "";
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
            btnIN.Enabled = false;
            btnLUU.Enabled = true;
            btnHUY.Enabled = true;
            btnThem.Enabled = true;
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
            btnIN.Enabled = false;
            btnLUU.Enabled = true;
            btnHUY.Enabled = true;
            btnThem.Enabled = true;
        }

        private void cboNVNHAP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = string.Format("SELECT * FROM NHANVIEN WHERE TENNV = N'{0}'", cboNVNHAP.SelectedValue);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
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

            this.dgvPHIEUNHAPKHO.Rows.Add("", cboTENHH.SelectedValue.ToString(), "Cái", txtSOLUONG.Text.ToString(), txtDONGIA.Text.ToString(), txtGIAMGIA.Text.ToString(), txtTHANHTIEN.Text.ToString());

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
            string query = string.Format("SELECT * FROM SANPHAM WHERE TENSP = N'{0}'", cboTENHH.SelectedValue.ToString().Trim());

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            
            txtMAHH.Text = data.Rows[0]["MASP"].ToString();
            */

            MessageBox.Show(cboTENHH.SelectedValue.ToString());
        }
    }
}
