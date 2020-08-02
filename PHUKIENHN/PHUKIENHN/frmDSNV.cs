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
using PHUKIENHN.Class;
using PHUKIENHN.DAO;
using Office_12 = Microsoft.Office.Core;
using Excel_12 = Microsoft.Office.Interop.Excel;
using System.IO;

namespace PHUKIENHN
{
    public partial class frmDSNV : Form
    {
        public frmDSNV()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage p = (TabPage)this.Parent;
            TabControl tabMain = (TabControl)p.Parent;
            tabMain.TabPages.Remove(p);

        }

        XLBANG_NHANVIEN tblNHANVIEN;
        SqlDataAdapter daNHANVIEN;
        BindingManagerBase DSNV;
        bool capnhat = false;

        public void enablebutton()
        {
            btnTHEMNV.Enabled = !capnhat;
            btnXOANV.Enabled = !capnhat;
            btnSUANV.Enabled = !capnhat;
            btnLUU.Enabled = capnhat;
            btnINDSNV.Enabled = !capnhat;
            btnXUATEXCEL.Enabled = !capnhat;
            btnThoat.Enabled = true;
        }

        private void frmDSNV_Load(object sender, EventArgs e)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM NHANVIEN");

            dgvDSNV.DataSource = dt;

            tblNHANVIEN = new XLBANG_NHANVIEN();
            daNHANVIEN = new SqlDataAdapter("SELECT * FROM NHANVIEN", DataProvider.Instance.connectionString);
            try
            {
                daNHANVIEN.Fill(tblNHANVIEN);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb = new SqlCommandBuilder(daNHANVIEN);
            loadcboCHUCVU();
            loaddgvNHANVIEN();

            txtMANV.DataBindings.Add("text", tblNHANVIEN, "MANV", true);
            txtHOTEN.DataBindings.Add("text", tblNHANVIEN, "TENNV", true);
            dateNGAYSINH.DataBindings.Add("text", tblNHANVIEN, "NGAYSINH", true);
            txtQUEQUAN.DataBindings.Add("text", tblNHANVIEN, "QUEQUAN", true);
            radNam.DataBindings.Add("checked", tblNHANVIEN, "GIOITINH", true);
            txtCMND.DataBindings.Add("text", tblNHANVIEN, "CMND", true);
            txtDIENTHOAI.DataBindings.Add("text", tblNHANVIEN, "SDT", true);
            txtEMAIL.DataBindings.Add("text", tblNHANVIEN, "EMAIL", true);
            cboCHUCVU.DataBindings.Add("SelectedValue", tblNHANVIEN, "CHUCVU", true);
            txtTENDN.DataBindings.Add("text", tblNHANVIEN, "TENDN", true);
            txtMK.DataBindings.Add("text", tblNHANVIEN, "MATKHAU", true);

            DSNV = this.BindingContext[tblNHANVIEN];
            enablebutton();
        }

        private void loaddgvNHANVIEN()
        {
            dgvDSNV.AutoGenerateColumns = false;
            dgvDSNV.DataSource = tblNHANVIEN;
        }

        private void loadcboCHUCVU()
        {
            string query = string.Format("SELECT CHUCVU FROM NHANVIEN GROUP BY CHUCVU");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            cboCHUCVU.SelectedValue = "";
            cboCHUCVU.DataSource = data;
            cboCHUCVU.DisplayMember = "CHUCVU";
            cboCHUCVU.ValueMember = "CHUCVU";
        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {
            radNu.Checked = !radNam.Checked;
        }

        private void btnTHEMNV_Click(object sender, EventArgs e)
        {
            DSNV.AddNew();
            txtMANV.Text = PHATSINHMANV.Instance.MANHANVIEN().ToString();
            capnhat = true;
            enablebutton();
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            try
            {
                DSNV.EndCurrentEdit();
                daNHANVIEN.Update(tblNHANVIEN);
                tblNHANVIEN.AcceptChanges();
                capnhat = false;
                enablebutton();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXOANV_Click(object sender, EventArgs e)
        {
            try
            {
                DSNV.RemoveAt(DSNV.Position);
                daNHANVIEN.Update(tblNHANVIEN);
                tblNHANVIEN.AcceptChanges();
            }
            catch(Exception ex)
            {
                tblNHANVIEN.RejectChanges();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSUANV_Click(object sender, EventArgs e)
        {
            capnhat = true;
            enablebutton();
        }


        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing); 
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "DANH SÁCH NHÂN VIÊN";
            for (int i = 1; i < dgvDSNV.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvDSNV.Columns[i - 1].HeaderText;
            } 
            for (int i = 0; i < dgvDSNV.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvDSNV.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvDSNV.Rows[i].Cells[j].Value.ToString();
                }
            }
            
        }

        private void btnINDSNV_Click(object sender, EventArgs e)
        {
            frmINDSNV FrmINNV = new frmINDSNV();
            FrmINNV.ShowDialog();
        }

        private void dgvDSNV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewRow r in dgvDSNV.Rows)
            {
                if (dgvDSNV.Rows.Count > r.Index + 1)
                    r.Cells[0].Value = r.Index + 1;
            }
        }
    }
}
