using System;

namespace qldsv.BLL
{
    internal class DoiMatKhauGVBLL
    {
        public static string DoiMatKhau(string tenDangNhap, string matKhauCu, string matKhauMoi)
        {
            if (string.IsNullOrWhiteSpace(matKhauCu))
                return "Vui lòng nhập mật khẩu cũ!";

            if (string.IsNullOrWhiteSpace(matKhauMoi))
                return "Vui lòng nhập mật khẩu mới!";

            if (matKhauMoi.Length < 6)
                return "Mật khẩu mới phải có ít nhất 6 ký tự!";

            if (matKhauMoi == matKhauCu)
                return "Mật khẩu mới không được trùng mật khẩu cũ!";

            string hashHienTai = DAL.DoiMatKhauGVDAL.GetMatKhau(tenDangNhap);

            if (!Utils.SecurityHelper.VerifyPassword(matKhauCu, hashHienTai))
                return "Mật khẩu cũ không đúng!";

            DAL.DoiMatKhauGVDAL.DoiMatKhau(tenDangNhap, matKhauMoi);
            return "";
        }
    }
}