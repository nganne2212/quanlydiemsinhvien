using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qldsv.Class
{
    public static class CurrentUser
    {
        public static int MaNguoiDung { get; set; }
        public static string TenDangNhap { get; set; }
        public static string VaiTro { get; set; }
        public static string MaDoiTuong { get; set; }
        // MaSinhVien hoặc MaGiangVien tuỳ VaiTro
        public static void Reset()
        {
            MaNguoiDung = 0;
            TenDangNhap = null;
            VaiTro = null;
            MaDoiTuong = null;
        }
    }
}