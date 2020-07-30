using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHUKIENHN.DAO
{
    class RankDAO
    {
        private static RankDAO instance;

        public static RankDAO Instace
        {
            get { if (instance == null) instance = new RankDAO(); return instance; }
            private set { instance = value; }
        }

        private RankDAO() { }

        public string RankAccount(string userName)
        {
            string query = string.Format("SELECT * FROM NHANVIEN WHERE TENDN = '{0}'", userName);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data.Rows[0]["CHUCVU"].ToString();
        }
    }
}
