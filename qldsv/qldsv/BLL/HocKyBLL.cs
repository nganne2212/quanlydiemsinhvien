using qldsv.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace qldsv.BLL
{
    public class HocKyBLL
    {
        // ── Validate riêng lẻ — Form dùng khi rời ô ────────────
        // Trả về "" nếu hợp lệ, string lỗi nếu sai
        public static string ValidateTenHocKy(string tenHocKy)
        {
            if (string.IsNullOrWhiteSpace(tenHocKy))
                return "Tên học kỳ không được để trống.";
            if (tenHocKy.Trim().Length < 3)
                return "Tên học kỳ phải có ít nhất 3 ký tự.";
            if (tenHocKy.Trim().Length > 100)
                return "Tên học kỳ không được vượt quá 100 ký tự.";
            if (Regex.IsMatch(tenHocKy, @"[!@#$%^&*()_+={}\[\]|\\:;""'<>?/~`]"))
                return "Tên học kỳ không được chứa ký tự đặc biệt.";
            return "";
        }

        public static string ValidateNamHoc(string namHoc)
        {
            if (string.IsNullOrWhiteSpace(namHoc))
                return "Năm học không được để trống.";
            if (!Regex.IsMatch(namHoc.Trim(), @"^\d{4}-\d{4}$"))
                return "Năm học phải đúng định dạng YYYY-YYYY (VD: 2024-2025).";

            string[] parts = namHoc.Trim().Split('-');
            int namBD = int.Parse(parts[0]);
            int namKT = int.Parse(parts[1]);
            if (namKT != namBD + 1)
                return "Năm kết thúc phải bằng năm bắt đầu + 1 (VD: 2024-2025).";
            if (namBD < 2000 || namBD > DateTime.Now.Year + 5)
                return $"Năm học phải nằm trong khoảng 2000 đến {DateTime.Now.Year + 5}.";

            return "";
        }

        // ── GetAll — Form gọi qua BLL, không gọi DAL trực tiếp ─
        public static DataTable GetAll()
        {
            return HocKyDAL.GetAll();
        }

        // ── Nghiệp vụ — trả về "" nếu thành công ───────────────
        public static string Them(string tenHocKy, string namHoc)
        {
            string loi = ValidateTenHocKy(tenHocKy);
            if (loi != "") return loi;

            loi = ValidateNamHoc(namHoc);
            if (loi != "") return loi;

            if (HocKyDAL.KiemTraTrung(tenHocKy.Trim(), namHoc.Trim()))
                return "Học kỳ đã tồn tại!";

            HocKyDAL.Them(tenHocKy.Trim(), namHoc.Trim());
            return "";
        }

        public static string Sua(int maHocKy, string tenHocKy, string namHoc)
        {
            string loi = ValidateTenHocKy(tenHocKy);
            if (loi != "") return loi;

            loi = ValidateNamHoc(namHoc);
            if (loi != "") return loi;

            if (HocKyDAL.KiemTraTrung(tenHocKy.Trim(), namHoc.Trim(), maHocKy))
                return "Học kỳ đã tồn tại!";

            HocKyDAL.Sua(maHocKy, tenHocKy.Trim(), namHoc.Trim());
            return "";
        }

        public static string Xoa(int maHocKy)
        {
            string trangThai = HocKyDAL.GetTrangThai(maHocKy);
            if (trangThai == "DangDienRa")
                return "Không thể xóa học kỳ đang diễn ra!";
            if (HocKyDAL.DangDuocDung(maHocKy))
                return "Học kỳ đang được sử dụng, không thể xóa!";

            HocKyDAL.Xoa(maHocKy);
            return "";
        }

        public static string MoHocKy(int maHocKy)
        {
            string trangThai = HocKyDAL.GetTrangThai(maHocKy);
            if (trangThai == "DangDienRa")
                return "Học kỳ này đã đang diễn ra!";
            if (trangThai == "DaKetThuc")
                return "Không thể mở lại học kỳ đã kết thúc!";

            HocKyDAL.MoHocKy(maHocKy);
            return "";
        }

        public static string DongHocKy(int maHocKy)
        {
            string trangThai = HocKyDAL.GetTrangThai(maHocKy);
            if (trangThai != "DangDienRa")
                return "Chỉ có thể đóng học kỳ đang diễn ra!";

            HocKyDAL.DongHocKy(maHocKy);
            return "";
        }
    }
}

