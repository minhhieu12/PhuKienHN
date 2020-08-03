using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PHUKIENHN.DAO
{
    class THEMNCCMOI
    {
        private static THEMNCCMOI instance;

        public static THEMNCCMOI Instance
        {
            get { if (instance == null) instance = new THEMNCCMOI(); return instance; }

            private set { instance = value; }
        }

        private THEMNCCMOI() { }

        
    }
}
