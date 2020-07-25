using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHUKIENHN.Class
{
    class XLBANG_NHANVIEN: XULYBANG
    {
        public XLBANG_NHANVIEN() : base("NHANVIEN"){}
        public XLBANG_NHANVIEN(string pQuery): base ("NHANVIEN", pQuery) { }
    }
}
