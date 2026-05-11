using qldsv.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            // Không cho khóa chính mình
            if (tenDangNhap == CurrentUser.TenDangNhap)
                return "Không thể khóa tài khoản đang đăng nhập";

            // Kiểm tra đã bị khóa chưa
            string trangThai = DAL.TaiKhoanDAL.GetTrangThai(tenDangNhap);
            if (trangThai == "BiKhoa")
                return "Tài khoản này đã bị khóa rồi";

            DAL.TaiKhoanDAL.KhoaTaiKhoan(tenDangNhap);
            return "";

        }

        public static string MoKhoaTaiKhoan(string tenDangNhap)
        {
            if (string.IsNullOrWhiteSpace(tenDangNhap))
                return "Vui lòng chọn tài khoản";

            string trangThai = DAL.TaiKhoanDAL.GetTrangThai(tenDangNhap);
            if (trangThai == "Active")
                return "Tài khoản này đang hoạt động rồi";

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
