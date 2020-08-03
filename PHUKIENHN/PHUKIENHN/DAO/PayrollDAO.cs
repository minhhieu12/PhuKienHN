using System;
using System.Data.Sql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace PHUKIENHN.DAO
{
    class PayrollDAO
    {
        private static PayrollDAO instance;

        public static PayrollDAO Instace
        {
            get { if (instance == null) instance = new PayrollDAO(); return instance; }
            private set { instance = value; }
        }

        private PayrollDAO() { }

        public DataTable TenNhanVien()
        {
            string query = string.Format("SELECT TENNV, MANV FROM NHANVIEN");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        } 

        public string TENNV(string maNhanVien)
        {
            string query = string.Format("SELECT TENNV FROM NHANVIEN WHERE MANV  = '{0}'", maNhanVien);

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt.Rows[0]["TENNV"].ToString();
        }

        public int tinhLuong(string chucVu, int ngayNghi)
        {
            int luong = 0;
            switch (chucVu)
            {
                case "Bán hàng":
                    luong = 150000 * (30 - ngayNghi);
                    break;

                case "Kho":
                    luong = 200000 * (12 - ngayNghi);
                    break;

                case "Admin":
                    luong = 10000000;
                    break;
            }
            return luong;
        }

        public int soGioLam(string chucVu, int ngayNghi)
        {
            int gio = 0;
            switch (chucVu)
            {
                case "Bán hàng":
                    gio = (30 - ngayNghi) * 6;
                    break;

                case "Kho":
                    gio = (12 - ngayNghi) * 6;
                    break;

                case "Admin":
                    gio = 30 * 6;
                    break;
            }
            return gio;
        }

        public int luongTheoChucVu(string chucVu)
        {
            int luong = 0;
            switch (chucVu)
            {
                case "Bán hàng":
                    luong = 150000;
                    break;

                case "Kho":
                    luong = 200000;
                    break;

                case "Admin":
                    luong = 333333;
                    break;
            }
            return luong;
        }

        public string chucVu(string maNhanVien)
        {
            string query = string.Format("SELECT CHUCVU FROM NHANVIEN WHERE MANV = '{0}'", maNhanVien);

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt.Rows[0]["CHUCVU"].ToString();
        }

        public int soNgayNghi(string chucVu, int soGioLam)
        {
            int gio = 0;
            switch (chucVu)
            {
                case "Bán hàng":
                    gio = (180 - soGioLam) / 6;
                    break;

                case "Kho":
                    gio = (72 - soGioLam) / 6;
                    break;

                case "Admin":
                    gio = 0;
                    break;
            }
            return gio;
        }
    }
}
