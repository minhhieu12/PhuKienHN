using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHUKIENHN.Class
{
    class XLBANG_HOADON: XULYBANG
    {
        public XLBANG_HOADON() : base("HOADON"){}
        public XLBANG_HOADON(string pQuery): base ("HOADON", pQuery) { }
    }
}
