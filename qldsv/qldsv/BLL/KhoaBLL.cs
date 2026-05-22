using System;
using System.Data;
using System.Text.RegularExpressions;

namespace qldsv.BLL
{
    class KhoaBLL
    {
        public static DataTable GetAll() => DAL.KhoaDAL.GetAll();

        public static DataTable Search(string keyword)
        {
            keyword = keyword?.Trim();
            if (string.IsNullOrEmpty(keyword))
                return DAL.KhoaDAL.GetAll();
            return DAL.KhoaDAL.Search(keyword);
        }

        public static string Them(string maKhoa, string tenKhoa)
        {
            string loi = Validate(maKhoa, tenKhoa, true);

            if (loi != "") return loi;

            DAL.KhoaDAL.Them(maKhoa.Trim(), tenKhoa.Trim());

            return "";
        }

        public static string Sua(string maKhoa, string tenKhoa)
        {
            string loi = Validate(maKhoa, tenKhoa, false);

            if (loi != "") return loi;

            DAL.KhoaDAL.Sua(maKhoa.Trim(), tenKhoa.Trim());

            return "";
        }

        public static string Xoa(string maKhoa)
        {
            if (string.IsNullOrWhiteSpace(maKhoa))
                return "Vui lòng chọn khoa cần xóa";

            if (DAL.KhoaDAL.DangCoLienKet(maKhoa))
                return "Không thể xóa khoa đã có giảng viên";

            DAL.KhoaDAL.Xoa(maKhoa);

            return "";
        }

        private static string Validate(string maKhoa, string tenKhoa, bool isAdd)
        {
            // Mã khoa
            if (string.IsNullOrWhiteSpace(maKhoa))
                return "Vui lòng nhập mã khoa";

            if (!Regex.IsMatch(maKhoa.Trim(), @"^[a-zA-Z0-9]+$"))
                return "Mã khoa chỉ được chứa chữ cái và chữ số, không có khoảng trắng hoặc ký tự đặc biệt";

            if (isAdd && DAL.KhoaDAL.KiemTraTrung(maKhoa.Trim()))
                return "Mã khoa đã tồn tại";

            // Tên khoa
            if (string.IsNullOrWhiteSpace(tenKhoa))
                return "Vui lòng nhập tên khoa";

            if (tenKhoa.Trim().Length < 2)
                return "Tên khoa phải có ít nhất 2 ký tự";

            if (Regex.IsMatch(tenKhoa.Trim(), @"[<>""'&]"))
                return "Tên khoa chứa ký tự không hợp lệ";

            if (DAL.KhoaDAL.TenKhoaExists(tenKhoa.Trim(), isAdd ? null : maKhoa.Trim()))
                return "Tên khoa đã tồn tại";

            return "";
        }
    }
}
