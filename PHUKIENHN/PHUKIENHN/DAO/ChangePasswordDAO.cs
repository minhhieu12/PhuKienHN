using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHUKIENHN.DAO
{
    class ChangePasswordDAO
    {
        private static ChangePasswordDAO instance;

        public static ChangePasswordDAO Instance
        {
            get { if (instance == null) instance = new ChangePasswordDAO(); return instance; }
            private set { instance = value; }
        }

        private ChangePasswordDAO() { }

        public string CheckError(string password, string oldPassword, string newPassword, string confirmNewPassword)
        {
            string strErr = string.Empty; 

            if (oldPassword == string.Empty || newPassword == string.Empty || confirmNewPassword == string.Empty)
            {
                strErr = "Mật khẩu vui lòng không được bỏ trống!";
            }
            else if(newPassword != confirmNewPassword)
            {
                strErr = "Mật khẩu mới đã nhập không trùng nhau!";
            } else if (password != oldPassword)
            {
                strErr = "Mật khẩu cũ sai!";
            }

            return strErr;
        }

        public bool checkChangePassword(string userName, string newPassword)
        {
            string query = string.Format("UPDATE NHANVIEN SET MATKHAU = '{0}' WHERE TENDN = '{1}'", newPassword, userName);

            int count = DataProvider.Instance.ExecuteNonQuery(query);

            return count != 0;
        }
    }
}
