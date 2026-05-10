using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace qldsv.BLL
{
    internal class TaiKhoanBLL
    {
        public static DataTable GetAll()
        {
            return DAL.TaiKhoanDAL.GetAll();
        }

        public static string KhoaTaiKhoan(string tenDangNhap)
        {
            if (string.IsNullOrWhiteSpace(tenDangNhap))
                return "Vui lòng chọn tài khoản";
            DAL.TaiKhoanDAL.KhoaTaiKhoan(tenDangNhap);
            return "";
        }

        public static string MoKhoaTaiKhoan(string tenDangNhap)
        {
            if (string.IsNullOrWhiteSpace(tenDangNhap))
                return "Vui lòng chọn tài khoản";
            DAL.TaiKhoanDAL.MoKhoaTaiKhoan(tenDangNhap);
            return "";
        }

        public static string ResetMatKhau(string tenDangNhap)
        {
            if (string.IsNullOrWhiteSpace(tenDangNhap))
                return "Vui lòng chọn tài khoản";
            DAL.TaiKhoanDAL.ResetMatKhau(tenDangNhap);
            return "";
        }
    }
}
