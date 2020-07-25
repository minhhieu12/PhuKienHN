using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHUKIENHN.Class
{
    class XLBANG_KHACHHANG: XULYBANG
    {
        public XLBANG_KHACHHANG() : base("KHACHHANG"){}
        public XLBANG_KHACHHANG(string pQuery): base ("KHACHHANG", pQuery) { }
    }
}
