using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PHUKIENHN.DAO
{
    class PHATSINHMANV
    {
        private static PHATSINHMANV instance;

        public static PHATSINHMANV Instance
        {
            get { if (instance == null) instance = new PHATSINHMANV(); return PHATSINHMANV.instance; }
            private set { PHATSINHMANV.instance = value; }
        }

        private PHATSINHMANV() { }

        public string MANHANVIEN()
        {
            string query = "SELECT MAX(MANV) AS MANHANVIEN FROM NHANVIEN";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            String str = data.Rows[0]["MANHANVIEN"].ToString();

            str = str.Substring(str.Length - 3, 3);

            int MANHANVIEN = Convert.ToInt32(str);

            MANHANVIEN++;

            if (MANHANVIEN < 10)
            {
                str = "NV00" + MANHANVIEN.ToString();
            }
            else if (MANHANVIEN < 100)
            {
                str = "NV0" + MANHANVIEN.ToString();
            }
            else
            {
                str = "NV" + MANHANVIEN.ToString();
            }

            return str;
        }
    }
}
