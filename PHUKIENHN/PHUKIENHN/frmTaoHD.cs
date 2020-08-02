using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors.Filtering.Templates;
using PHUKIENHN.DAO;

namespace PHUKIENHN
{
    public partial class frmTaoHD : Form
    {
        int i = 0, tongTien = 0;
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

            clearData();
            /*
            txtSOHD.Enabled = false;

            txtMANV.Enabled = false;

            txtMAHH.Enabled = false;

            txtTENKH.Enabled = false;

            txtDONGIA.Enabled = false;
            */
            btnIN.Enabled = false;
            btnTHEMHD.Enabled = false;
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
            clearData();
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

                txtSL.Text = "1";

                txtTHANHTIEN.Text = tinhTien().ToString();
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
            btnIN.Enabled = false;
            btnTHEMHD.Enabled = false;
            btnLUU.Enabled = true;
            btnHUY.Enabled = true;
            btnTHEMMH.Enabled = true;
            clearData();
        }

        private void clearData()
        {
            cbTENNV.SelectedValue = "";
            cboTENHH.SelectedValue = "";
            txtTENKH.Text = "";
            txtDIACHI.Text = "";
            txtSDT.Text = "";
            txtSOHD.Text = "";
            txtMANV.Text = "";
            txtMAHH.Text = "";
            txtDONGIA.Text = "0";
            txtTHANHTIEN.Text = "0";
            txtGIAMGIA.Text = "0";
            txtSL.Text = "0";
            dgvHOADONBANHANG.Rows.Clear();
            dgvHOADONBANHANG.Refresh();
            tongTien = 0;
            txtTONGCONG.Text = "";
        }

        private void txtMANV_TextChanged(object sender, EventArgs e)
        {
            txtSOHD.Text = CreateInvoicesDAO.Instance.maHoaDon();
        }

        private void dgvHOADONBANHANG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 9 && e.RowIndex < dgvHOADONBANHANG.Rows.Count - 1)
            {
                string str = dgvHOADONBANHANG.Rows[e.RowIndex].Cells[7].Value.ToString();

                int value = int.Parse(str);

                tongTien -= value;

                txtTONGCONG.Text = tongTien.ToString() + " VND";

                dgvHOADONBANHANG.Rows.RemoveAt(e.RowIndex);

                foreach (DataGridViewRow r in dgvHOADONBANHANG.Rows)
                {
                    if (dgvHOADONBANHANG.Rows.Count > r.Index + 1)
                    {
                        r.Cells[0].Value = r.Index + 1;
                    }
                    i = r.Index;
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == 8 && e.RowIndex < dgvHOADONBANHANG.Rows.Count - 1)
            {
                cboTENHH.SelectedValue = dgvHOADONBANHANG.Rows[e.RowIndex].Cells[2].Value.ToString();

                txtSL.Text = dgvHOADONBANHANG.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            if (dgvHOADONBANHANG.Rows.Count == 1)
            {
                MessageBox.Show("Chưa có mặt hàng nào được thêm vào hóa đơn!");
            }
            else if (txtMANV.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn tên nhân viên bán hàng!");
            } 
            else if (txtTENKH.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
            }
            else if (txtSDT.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại của khách hàng!");
            }
            else
            {
                string soHD = txtSOHD.Text.ToString();

                string dt = dateNGAY.Value.ToString("yyyy-MM-dd");

                string tenKhachHang = txtTENKH.Text.ToString();

                string diaChi = txtDIACHI.Text.ToString();

                string sdt = txtSDT.Text.ToString();

                string queryToHoaDon = string.Format("INSERT INTO HOADON (SOHD, NGAYTAO, TONGTIEN, TENKH, DIACHI, SDT) VALUES ('{0}', '{1}', {2}, N'{3}', N'{4}', '{5}')", soHD, dt, tongTien, tenKhachHang, diaChi, sdt);

                DataProvider.Instance.ExecuteNonQuery(queryToHoaDon);


                foreach (DataGridViewRow r in dgvHOADONBANHANG.Rows)
                {
                    if (r.Cells[1].Value != null)
                    {
                        string maHangHoa = r.Cells[1].Value.ToString();

                        int soLuong = Convert.ToInt32(r.Cells[4].Value);

                        int donGia = Convert.ToInt32(r.Cells[5].Value);

                        int chietKhau = Convert.ToInt32(r.Cells[6].Value);

                        int tongTien = Convert.ToInt32(r.Cells[7].Value);

                        string queryToChiTietHoaDon = string.Format("INSERT INTO CTHOADON (SOHD, MASP, SOLUONG, DONGIA, CHIETKHAU, THANHTIEN) VALUES ('{0}', '{1}', {2}, {3}, {4}, {5})", soHD, maHangHoa, soLuong, donGia, chietKhau, tongTien);

                        DataProvider.Instance.ExecuteNonQuery(queryToChiTietHoaDon);
                    }
                }
                MessageBox.Show("Đã thêm hóa đơn!!!");
            }
            //disable button
            btnLUU.Enabled = false;
            btnHUY.Enabled = false;
            btnTHEMMH.Enabled = false;
            btnTHEMHD.Enabled = true;
            btnIN.Enabled = true;
        }

        
        private void gbTTHoaDon_Enter(object sender, EventArgs e)
        {

        }

        private void btnTHEMMH_Click(object sender, EventArgs e)
        {
            if (txtMAHH.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn tên một loại hàng hóa!");
            }
            else if (kiemTraLoiThemMatHang(txtMAHH.Text) == false)
            {
                MessageBox.Show("Mặt hàng đã tồn tại trong hóa đơn!");
            } 
            else
            {
                tongTien += tinhTien();

                this.dgvHOADONBANHANG.Rows.Add("", txtMAHH.Text.ToString(), cboTENHH.SelectedValue.ToString(), "Cái", txtSL.Text.ToString(), txtDONGIA.Text.ToString(), txtGIAMGIA.Text.ToString(), txtTHANHTIEN.Text.ToString());

                txtTONGCONG.Text = tongTien.ToString() + " VND";

                foreach (DataGridViewRow r in dgvHOADONBANHANG.Rows)
                {

                    if (dgvHOADONBANHANG.Rows.Count > r.Index + 1)
                    {
                        r.Cells[0].Value = r.Index + 1;
                    }
                }
            }
        }

        private bool kiemTraLoiThemMatHang(string maHangHoa)
        {
            foreach(DataGridViewRow r in dgvHOADONBANHANG.Rows)
            {
                if(r.Cells[1].Value != null)
                {
                    if (maHangHoa == r.Cells[1].Value.ToString()) 
                    {
                        return false;
                    }
                }
                
            }
            return true;
        }
    }
}
