using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PHUKIENHN.DAO;

namespace PHUKIENHN.DAO
{
    class NHAPKHODAO
    {
        private static NHAPKHODAO instance;

        public static NHAPKHODAO Instance
        {
            get { if (instance == null) instance = new NHAPKHODAO(); return instance; }

            private set { instance = value; }
        }

        private NHAPKHODAO() { }

        public DataTable dataComboNCC()
        {
            string query = string.Format("SELECT MANCC, TENNCC FROM NHACUNGCAP");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable dataComboMANV()
        {
            string query = string.Format("SELECT MANV, TENNV FROM NHANVIEN");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable dataComboMAHH()
        {
            string query = string.Format("SELECT MASP, TENSP FROM SANPHAM");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
