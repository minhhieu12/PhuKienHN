using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PHUKIENHN.DAO
{
    class THEMSPMOI
    {
        private static THEMSPMOI instance;

        public static THEMSPMOI Instance
        {
            get { if (instance == null) instance = new THEMSPMOI(); return instance; }

            private set { instance = value; }
        }

        private THEMSPMOI() { }

        public DataTable dataComboBoxSP()
        {
            string query = string.Format("SELECT MASP, TENSP FROM SANPHAM");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
