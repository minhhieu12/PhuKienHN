using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHUKIENHN.DAO
{
    class CreateInvoicesDAO
    {
        private static CreateInvoicesDAO instance;

        public static CreateInvoicesDAO Instance
        {
            get { if (instance == null) instance = new CreateInvoicesDAO(); return instance; }

            private set { instance = value; }
        }

        private CreateInvoicesDAO() { }

        public DataTable dataComboBoxMaNV()
        {
            string query = string.Format("SELECT MANV, TENNV FROM NHANVIEN");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }



        public DataTable dataComboTenNV()
        {
            string query = "SELECT MASP, TENSP, DONGIA FROM SANPHAM";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        

        public string maHoaDon()
        {
            string query = "SELECT MAX(SOHD) AS MAHD FROM HOADON";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            String str = data.Rows[0]["MAHD"].ToString();

            str = str.Substring(str.Length - 3, 3);

            int maHoaDon = Convert.ToInt32(str);

            maHoaDon++;

            if (maHoaDon < 10)
            {
                str = "HD00" + maHoaDon.ToString();
            }
            else if (maHoaDon < 100)
            {
                str = "HD0" + maHoaDon.ToString();
            }
            else
            {
                str = "HD" + maHoaDon.ToString();
            }

            return str;
        }

        
    }
}
