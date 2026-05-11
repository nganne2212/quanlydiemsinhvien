using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using qldsv.Class;

namespace qldsv.DAL
{
    internal class TaiKhoanDAL
    {
        public static DataTable GetAll()
        {
            return Functions.GetDataToTable("SELECT * FROM NguoiDung");
        }

        public static void KhoaTaiKhoan(string tenDangNhap)
        {
            Functions.Execute(
                "UPDATE NguoiDung SET TrangThai = 'BiKhoa' WHERE TenDangNhap = @u",
                new { u = tenDangNhap });
        }

        public static void MoKhoaTaiKhoan(string tenDangNhap)
        {
            Functions.Execute(
                "UPDATE NguoiDung SET TrangThai = 'Active' WHERE TenDangNhap = @u",
                new { u = tenDangNhap });
        }

        public static void ResetMatKhau(string tenDangNhap)
        {
            string matKhauMacDinh = Utils.SecurityHelper.HashPassword(tenDangNhap);
            Functions.Execute(
                "UPDATE NguoiDung SET MatKhau = @p WHERE TenDangNhap = @u",
                new { p = matKhauMacDinh, u = tenDangNhap });
        }
        public static string GetTrangThai(string tenDangNhap)
        {
            return Functions.QuerySingle<string>(
                "SELECT TrangThai FROM NguoiDung WHERE TenDangNhap = @u",
                new { u = tenDangNhap });
        }
    }
}
