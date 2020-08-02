using PHUKIENHN.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Office_12 = Microsoft.Office.Core;
using Excel_12 = Microsoft.Office.Interop.Excel;

namespace PHUKIENHN
{
    public partial class frmTinhLuong : Form
    {
        public frmTinhLuong()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage p = (TabPage)this.Parent;
            TabControl tabMain = (TabControl)p.Parent;
            tabMain.TabPages.Remove(p);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmTinhLuong_Load(object sender, EventArgs e)
        {
            loadCBONhanVien();
        }

        private void loadCBONhanVien()
        {
            DataTable dt = PayrollDAO.Instace.TenNhanVien();

            cboTenNhanVien.DataSource = dt;

            cboTenNhanVien.DisplayMember = "TENNV";

            cboTenNhanVien.ValueMember = "MANV";

            cboTenNhanVien.SelectedValue = "";
        }

        private void cboTenNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtThuong.Text = "0";
            txtPhat.Text = "0";
            txtNgayNghi.Text = "0";
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            if (cboTenNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhân viên cần tính lương!");
                return;
            }

            string chucVu = PayrollDAO.Instace.chucVu(cboTenNhanVien.SelectedValue.ToString()).Trim();

            string maNhanVien = cboTenNhanVien.SelectedValue.ToString();

            string tenNhanVien = PayrollDAO.Instace.TENNV(cboTenNhanVien.SelectedValue.ToString());

            string ngayCham = dateNgayCham.Value.ToString("yyyy-MM-dd");

            int ngayNghi = Convert.ToInt32(txtNgayNghi.Text.ToString());

            int soGioLam = PayrollDAO.Instace.soGioLam(chucVu, ngayNghi);

            int luongTheoGio = PayrollDAO.Instace.luongTheoChucVu(chucVu);

            int tongLuong = PayrollDAO.Instace.tinhLuong(chucVu, ngayNghi);

            int luongThuong = Convert.ToInt32(txtThuong.Text);

            int luongPhat = Convert.ToInt32(txtPhat.Text);

            txtTongLuong.Text = Convert.ToString(tongLuong + luongThuong - luongPhat);

            foreach (DataGridViewRow r in dgvChamCong.Rows)
            {
                if (r.Cells[1].Value != null)
                {
                    if (maNhanVien == r.Cells[1].Value.ToString())
                    {
                        MessageBox.Show("Nhân viên này đã được tính lương rồi!");
                        return;
                    }
                }
            }
            dgvChamCong.Rows.Add("", maNhanVien, tenNhanVien, ngayCham, soGioLam, luongTheoGio, luongThuong, luongPhat, tongLuong + luongThuong - luongPhat);

            foreach (DataGridViewRow r in dgvChamCong.Rows)
            {
                if (dgvChamCong.Rows.Count > r.Index + 1)
                {
                    r.Cells[0].Value = r.Index + 1;
                }
            }
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {

        }

        private void btnXuatBaoCao_Click_1(object sender, EventArgs e)
        {
            if (dgvChamCong.Rows.Count == 1)
            {
                MessageBox.Show("Chưa có nhân viên nào được chấm công!");
                return;
            }

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "BẢNG CHẤM CÔNG!";
            for (int i = 1; i < dgvChamCong.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvChamCong.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvChamCong.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvChamCong.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvChamCong.Rows[i].Cells[j].Value.ToString();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvChamCong.Rows)
            {
                if (!row.IsNewRow) dgvChamCong.Rows.Remove(row); 
            }

            foreach (DataGridViewRow r in dgvChamCong.Rows)
            {
                if (dgvChamCong.Rows.Count > r.Index + 1)
                {
                    r.Cells[0].Value = r.Index + 1;
                }
            }
        }
    }
}
