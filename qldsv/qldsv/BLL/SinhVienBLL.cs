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
            string loi = Validate(maSV, hoTen, ngaySinhStr, email, sdt, maLop, trangThai, true);
            if (loi != "") return loi;

            DAL.SinhVienDAL.Them(
                maSV.Trim(), hoTen.Trim(),
                DateTime.Parse(ngaySinhStr),
                gioiTinh, email.Trim(), LamSachSDT(sdt),
                maLop, trangThai);
            return "";
        }

        public static string Sua(string maSV, string hoTen, string ngaySinhStr,
            string gioiTinh, string email, string sdt, string maLop, string trangThai)
        {
            string loi = Validate(maSV, hoTen, ngaySinhStr, email, sdt, maLop, trangThai, false);
            if (loi != "") return loi;

            DAL.SinhVienDAL.Sua(
                maSV.Trim(), hoTen.Trim(),
                DateTime.Parse(ngaySinhStr),
                gioiTinh, email.Trim(), LamSachSDT(sdt),
                maLop, trangThai);
            return "";
        }

        public static string Xoa(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV))
                return "Vui long chon sinh vien can xoa";
            if (DAL.SinhVienDAL.DangCoLienKet(maSV))
                return "Khong the xoa sinh vien da co dang ky hoc phan!";
            DAL.SinhVienDAL.Xoa(maSV);
            return "";
        }

        // Làm sạch SĐT từ mask "(999) 000-0000" → chỉ còn số
        private static string LamSachSDT(string sdt)
        {
            if (string.IsNullOrWhiteSpace(sdt)) return "";
            return sdt.Replace("(", "").Replace(")", "")
                      .Replace("-", "").Replace(" ", "")
                      .Replace("_", "").Trim();
        }

        private static string Validate(string maSV, string hoTen, string ngaySinhStr,
            string email, string sdt, string maLop, string trangThai, bool isAdd)
        {
            // Mã SV
            if (string.IsNullOrWhiteSpace(maSV))
                return "Vui long nhap ma sinh vien";
            if (!Regex.IsMatch(maSV.Trim(), @"^[a-zA-Z0-9]+$"))
                return "Ma sinh vien chi duoc chua chu va so, khong co khoang trang";
            if (isAdd && DAL.SinhVienDAL.KiemTraTrung(maSV.Trim()))
                return "Ma sinh vien da ton tai";

            // Họ tên
            if (string.IsNullOrWhiteSpace(hoTen))
                return "Vui long nhap ho ten";
            if (hoTen.Trim().Length < 2)
                return "Ho ten phai co it nhat 2 ky tu";
            if (Regex.IsMatch(hoTen.Trim(), @"[<>""'&0-9]"))
                return "Ho ten chua ky tu khong hop le";

            // Ngày sinh
            if (!DateTime.TryParse(ngaySinhStr, out DateTime ngaySinh))
                return "Ngay sinh khong hop le";
            if (ngaySinh > DateTime.Now)
                return "Ngay sinh khong the lon hon ngay hien tai";
            if (ngaySinh.Year < 1900)
                return "Ngay sinh khong hop le";

            // Lớp
            if (string.IsNullOrWhiteSpace(maLop))
                return "Vui long chon lop";

            // Trạng thái
            if (string.IsNullOrWhiteSpace(trangThai))
                return "Vui long chon trang thai";

            // Email — không bắt buộc
            if (!string.IsNullOrWhiteSpace(email) &&
                !Regex.IsMatch(email.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return "Email khong hop le";

            // SĐT — không bắt buộc, mask "(999) 000-0000"
            string sdtClean = LamSachSDT(sdt);
            if (!string.IsNullOrEmpty(sdtClean) && sdtClean.Length != 10)
                return "So dien thoai phai du 10 so";

            return "";
        }
    }
}
