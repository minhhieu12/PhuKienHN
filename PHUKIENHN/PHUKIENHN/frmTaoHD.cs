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
    public partial class frmTaoHD : Form
    {
        public frmTaoHD()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            TabPage p = (TabPage)this.Parent;
            TabControl tabMain = (TabControl)p.Parent;
            tabMain.TabPages.Remove(p);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage p = (TabPage)this.Parent;
            TabControl tabMain = (TabControl)p.Parent;
            tabMain.TabPages.Remove(p);
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            frmINHOADON FrmINHD = new frmINHOADON();
            FrmINHD.ShowDialog();
        }

        private void frmTaoHD_Load(object sender, EventArgs e)
        {
            this.loadCBTENNV();
            this.loadCBTENHH();
        }

        private void loadCBTENNV()
        {
            DataTable data = CreateInvoicesDAO.Instance.dataComboBoxMaNV();

            cbTENNV.DataSource = data;

            cbTENNV.DisplayMember = "TENNV";

            cbTENNV.ValueMember = "TENNV";

            cbTENNV.SelectedValue = "";
        }

        private void loadCBTENHH()
        {
            DataTable data = CreateInvoicesDAO.Instance.dataComboTenNV();

            cboTENHH.DataSource = data;

            cboTENHH.DisplayMember = "TENSP";

            cboTENHH.ValueMember = "TENSP";

            cboTENHH.SelectedValue = "";
        }

        private void btnHUY_Click(object sender, EventArgs e)
        {
            
        }

        private void cbTENNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string query = string.Format("SELECT * FROM NHANVIEN WHERE TENNV = N'{0}'", cbTENNV.SelectedValue);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                txtMANV.Text = data.Rows[0]["MANV"].ToString();
            }
            
        }

        private void cboTENHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = string.Format("SELECT * FROM SANPHAM WHERE TENSP = N'{0}'", cboTENHH.SelectedValue);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                txtMAHH.Text = data.Rows[0]["MASP"].ToString();

                

                txtDONGIA.Text = data.Rows[0]["DONGIA"].ToString();

                txtGIAMGIA.Text = "0";
            }
        }

        private int tinhTien()
        {
            int soLuong = 0, giamGia = 0;

            int donGia = Convert.ToInt32(txtDONGIA.Text);


            if (txtSL.Text != string.Empty)
            {
                soLuong = Convert.ToInt32(txtSL.Text);
            }

            if (txtGIAMGIA.Text != string.Empty)
            {
                giamGia = Convert.ToInt32(txtGIAMGIA.Text);
            }

            int thanhTien = donGia * soLuong - giamGia;

            return thanhTien;
        }

        private void txtTHANHTIEN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            txtTHANHTIEN.Text = tinhTien().ToString();
        }

        private void txtGIAMGIA_TextChanged(object sender, EventArgs e)
        {
            txtTHANHTIEN.Text = tinhTien().ToString();
        }

        private void btnTHEMHD_Click(object sender, EventArgs e)
        {
            
        }

        private void txtMANV_TextChanged(object sender, EventArgs e)
        {
            txtSOHD.Text = CreateInvoicesDAO.Instance.maHoaDon();
        }

        
    }
}
