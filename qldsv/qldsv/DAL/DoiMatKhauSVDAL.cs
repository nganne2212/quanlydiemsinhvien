using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qldsv.Class;

namespace qldsv.DAL
{
    internal class DoiMatKhauDAL
    {
        public static string GetMatKhau(string tenDangNhap)
        {
            return Functions.QuerySingle<string>(
                "SELECT MatKhau FROM NguoiDung WHERE TenDangNhap = @u",
                new { u = tenDangNhap });
        }

        public static void CapNhatMatKhau(string tenDangNhap, string matKhauMoiHash)
        {
            Functions.Execute(
                "UPDATE NguoiDung SET MatKhau = @mk WHERE TenDangNhap = @u",
                new { mk = matKhauMoiHash, u = tenDangNhap });
        }
    }
}