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

namespace PHUKIENHN
{
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage p = (TabPage)this.Parent;
            TabControl tabMain = (TabControl)p.Parent;
            tabMain.TabPages.Remove(p);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            string ngayBatDau = dtStart.Value.ToString("yyyy-MM-dd");

            string ngayKetThuc = dtEnd.Value.ToString("yyyy-MM-dd");

            DataTable dt = RevenueDAO.Instace.bangDoanhThu(ngayBatDau, ngayKetThuc);

            int tongTien = 0;

            dgvDoanhThu.Rows.Clear();

            dgvDoanhThu.Refresh();

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                this.dgvDoanhThu.Rows.Add(i + 1, dt.Rows[i]["SOHD"].ToString(), dt.Rows[i]["NGAYTAO"].ToString(), dt.Rows[i]["TENKH"].ToString(), dt.Rows[i]["TONGTIEN"].ToString());

                tongTien += Convert.ToInt32(dt.Rows[i]["TONGTIEN"]);
            }

            txtTongDoanhThu.Text = tongTien.ToString() + " VND";

        }

        private void dgvDoanhThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex < dgvDoanhThu.Rows.Count - 1)
            {
                //dgvChiTietDoanhThu.CurrentRow.Selected = true;

                string soHoaDon = dgvDoanhThu.Rows[e.RowIndex].Cells[1].Value.ToString();

                dgvChiTietDoanhThu.DataSource = RevenueDAO.Instace.bangChiTietHoaDon(soHoaDon);

            }
        }
    }
}
