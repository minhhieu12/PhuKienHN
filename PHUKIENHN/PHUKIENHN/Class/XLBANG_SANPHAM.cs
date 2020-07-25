using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHUKIENHN.Class
{
    class XLBANG_SANPHAM: XULYBANG
    {
        public XLBANG_SANPHAM() : base("SANPHAM"){}
        public XLBANG_SANPHAM(string pQuery): base ("SANPHAM", pQuery) { }
    }
}
