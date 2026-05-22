using qldsv.Class;
using System;

namespace qldsv.DAL
{
    internal class DoiMatKhauGVDAL
    {
        public static string GetMatKhau(string tenDangNhap)
        {
            return Functions.QuerySingle<string>(
                "SELECT MatKhau FROM NguoiDung WHERE TenDangNhap = @u",
                new { u = tenDangNhap });
        }

        public static void DoiMatKhau(string tenDangNhap, string matKhauMoi)
        {
            string hash = Utils.SecurityHelper.HashPassword(matKhauMoi);
            Functions.Execute(
                "UPDATE NguoiDung SET MatKhau = @p WHERE TenDangNhap = @u",
                new { p = hash, u = tenDangNhap });
        }
    }
}