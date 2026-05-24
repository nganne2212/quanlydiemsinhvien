using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qldsv.Utils
{


    public class ImportResult
    {
        public int STT { get; set; }
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public bool HopLe { get; set; }
        public string LyDoLoi { get; set; }

        // Thêm cho nhập điểm
        public string CC { get; set; }
        public string KT1 { get; set; }
        public string KT2 { get; set; }
        public string CK { get; set; }
    }
}


