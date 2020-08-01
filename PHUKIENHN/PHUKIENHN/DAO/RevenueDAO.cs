using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PHUKIENHN.DAO
{
    class RevenueDAO
    {
        private static RevenueDAO instance;

        public static RevenueDAO Instace
        {
            get { if (instance == null) instance = new RevenueDAO(); return instance; }
            private set { instance = value; }
        }

        private RevenueDAO() { }

        //string dt = dateNGAY.Value.ToString("yyyy-MM-dd");

        public DataTable bangDoanhThu(string dateStart, string dateEnd)
        {
            string query = String.Format("SELECT SOHD, NGAYTAO, TENKH, TONGTIEN FROM HOADON WHERE NGAYTAO BETWEEN '{0}' AND '{1}'", dateStart, dateEnd);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable bangChiTietHoaDon(string soHoaDon)
        {
            string query = string.Format("SELECT SANPHAM.TENSP AS N'Tên sản phẩm', CTHOADON.SOLUONG AS N'Số lượng', CTHOADON.DONGIA AS N'Đơn giá', CTHOADON.CHIETKHAU AS N'Chiết khẩu', CTHOADON.THANHTIEN AS N'Thành tiền' FROM CTHOADON INNER JOIN SANPHAM ON CTHOADON.MASP = SANPHAM.MASP WHERE SOHD = '{0}'", soHoaDon);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
