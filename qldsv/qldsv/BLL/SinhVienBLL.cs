using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace qldsv.BLL
{
    class SinhVienBLL
    {
        public static DataTable GetAll() => DAL.SinhVienDAL.GetAll();

        public static string Them(string maSV, string hoTen, string ngaySinhStr,
            string gioiTinh, string email, string sdt, string maLop, string trangThai)
        {
            string loi = Validate(
                maSV, hoTen, ngaySinhStr,
                email, sdt, maLop, trangThai, true);

            if (loi != "") return loi;

            DAL.SinhVienDAL.Them(
                maSV.Trim(),
                hoTen.Trim(),
                DateTime.Parse(ngaySinhStr),
                gioiTinh,
                email.Trim(),
                LamSachSDT(sdt),
                maLop,
                trangThai);

            return "";
        }

        public static string Sua(string maSV, string hoTen, string ngaySinhStr,
            string gioiTinh, string email, string sdt, string maLop, string trangThai)
        {
            string loi = Validate(
                maSV, hoTen, ngaySinhStr,
                email, sdt, maLop, trangThai, false);

            if (loi != "") return loi;

            DAL.SinhVienDAL.Sua(
                maSV.Trim(),
                hoTen.Trim(),
                DateTime.Parse(ngaySinhStr),
                gioiTinh,
                email.Trim(),
                LamSachSDT(sdt),
                maLop,
                trangThai);

            return "";
        }

        public static string Xoa(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV))
                return "Vui lòng chọn sinh viên cần xóa";

            if (DAL.SinhVienDAL.DangCoLienKet(maSV))
                return "Không thể xóa sinh viên đã đăng ký học phần";

            DAL.SinhVienDAL.Xoa(maSV);

            return "";
        }

        // Làm sạch SĐT từ mask "(999) 000-0000"
        private static string LamSachSDT(string sdt)
        {
            if (string.IsNullOrWhiteSpace(sdt))
                return "";

            return sdt.Replace("(", "")
                      .Replace(")", "")
                      .Replace("-", "")
                      .Replace(" ", "")
                      .Replace("_", "")
                      .Trim();
        }

        private static string Validate(
            string maSV,
            string hoTen,
            string ngaySinhStr,
            string email,
            string sdt,
            string maLop,
            string trangThai,
            bool isAdd)
        {
            // Mã sinh viên
            if (string.IsNullOrWhiteSpace(maSV))
                return "Vui lòng nhập mã sinh viên";

            if (!Regex.IsMatch(maSV.Trim(), @"^[a-zA-Z0-9]+$"))
                return "Mã sinh viên chỉ được chứa chữ cái và chữ số, không có khoảng trắng hoặc ký tự đặc biệt";

            if (isAdd && DAL.SinhVienDAL.KiemTraTrung(maSV.Trim()))
                return "Mã sinh viên đã tồn tại";

            // Họ tên
            if (string.IsNullOrWhiteSpace(hoTen))
                return "Vui lòng nhập họ tên sinh viên";

            if (hoTen.Trim().Length < 2)
                return "Họ tên phải có ít nhất 2 ký tự";

            if (Regex.IsMatch(hoTen.Trim(), @"[<>""'&0-9]"))
                return "Họ tên chứa ký tự không hợp lệ";

            // Ngày sinh
            if (!DateTime.TryParse(ngaySinhStr, out DateTime ngaySinh))
                return "Ngày sinh không hợp lệ";

            if (ngaySinh > DateTime.Now.AddYears(-15))
                return "Sinh viên phải từ 15 tuổi trở lên";

            if (ngaySinh < DateTime.Now.AddYears(-60))
                return "Ngày sinh không hợp lệ (quá 60 tuổi)";

            // Lớp
            if (string.IsNullOrWhiteSpace(maLop))
                return "Vui lòng chọn lớp";

            // Trạng thái
            if (string.IsNullOrWhiteSpace(trangThai))
                return "Vui lòng chọn trạng thái";

            // Email
            if (!string.IsNullOrWhiteSpace(email) &&
                !Regex.IsMatch(email.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return "Email không đúng định dạng";
            }

            // Số điện thoại
            string sdtClean = LamSachSDT(sdt);

            if (!string.IsNullOrEmpty(sdtClean))
            {
                // Đúng 10 số
                if (sdtClean.Length != 10)
                    return "Số điện thoại phải gồm đúng 10 chữ số";

                // Phải bắt đầu bằng 0
                if (!sdtClean.StartsWith("0"))
                    return "Số điện thoại phải bắt đầu bằng số 0";

                // Đầu số hợp lệ Việt Nam
                if (!Regex.IsMatch(sdtClean, @"^(03|05|07|08|09)\d{8}$"))
                    return "Đầu số điện thoại không hợp lệ";

                // Không cho toàn số giống nhau
                if (Regex.IsMatch(sdtClean, @"^(\d)\1{9}$"))
                    return "Số điện thoại không hợp lệ";
            }
            string maSVExclude = isAdd ? null : maSV.Trim();

            // Email trùng
            if (!string.IsNullOrWhiteSpace(email))
            {
                if (DAL.SinhVienDAL.EmailTrung(email.Trim(), maSVExclude))
                    return "Email này đã được sử dụng bởi sinh viên khác";
            }

            // SĐT trùng
            if (!string.IsNullOrEmpty(sdtClean))
            {
                if (DAL.SinhVienDAL.SDTTrung(sdtClean, maSVExclude))
                    return "Số điện thoại này đã được sử dụng bởi sinh viên khác";
            }

            return "";
        }
    }
}