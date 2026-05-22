using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qldsv.DAL;
using qldsv.Utils;

namespace qldsv.BLL
{
    public class DoiMatKhauSVBLL
    {
        // Trả về "" nếu thành công, string lỗi nếu sai
        public static string DoiMatKhau(string tenDangNhap, string matKhauCu, string matKhauMoi)
        {
            // 1. Lấy mật khẩu hiện tại từ DB
            string hashHienTai = DoiMatKhauDAL.GetMatKhau(tenDangNhap);
            if (hashHienTai == null)
                return "Không tìm thấy tài khoản. Vui lòng đăng nhập lại.";

            // 2. Xác thực mật khẩu cũ bằng BCrypt
            if (!SecurityHelper.VerifyPassword(matKhauCu, hashHienTai))
                return "Mật khẩu hiện tại không đúng!";

            // 3. Không cho đặt trùng mật khẩu cũ
            if (matKhauMoi == matKhauCu)
                return "Mật khẩu mới không được trùng mật khẩu hiện tại!";

            // 4. Hash mật khẩu mới và lưu
            string hashMoi = SecurityHelper.HashPassword(matKhauMoi);
            DoiMatKhauDAL.CapNhatMatKhau(tenDangNhap, hashMoi);

            return "";
        }
    }
}