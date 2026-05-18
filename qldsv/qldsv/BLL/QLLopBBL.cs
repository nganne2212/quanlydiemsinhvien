using System;
using System.Text.RegularExpressions;
using qldsv.DAL;

namespace qldsv.BLL
{
    public static class QLLopBLL
    {
        public static string Validate(LopDTO lop, bool isAdd)
        {
            if (string.IsNullOrWhiteSpace(lop.MaLop))
                return "Vui lòng nhập mã lớp.";
            if (!Regex.IsMatch(lop.MaLop.Trim(), @"^[a-zA-Z0-9]+$"))
                return "Mã lớp chỉ được chứa chữ và số, không có khoảng trắng.";
            if (isAdd && QLLopDAL.KiemTraTrung(lop.MaLop.Trim()))
                return "Mã lớp đã tồn tại. Vui lòng chọn mã khác.";
            if (string.IsNullOrWhiteSpace(lop.TenLop))
                return "Vui lòng nhập tên lớp.";
            if (Regex.IsMatch(lop.TenLop.Trim(), @"[<>""'&]"))
                return "Tên lớp chứa ký tự không hợp lệ.";
            if (string.IsNullOrEmpty(lop.MaKhoa))
                return "Vui lòng chọn khoa.";
            if (string.IsNullOrEmpty(lop.MaGiangVien))
                return "Vui lòng chọn cố vấn học tập.";
            return string.Empty;
        }

        public static string Them(LopDTO lop)
        {
            lop.MaLop = lop.MaLop?.Trim().ToUpper();
            lop.TenLop = lop.TenLop?.Trim();
            string loi = Validate(lop, isAdd: true);
            if (!string.IsNullOrEmpty(loi)) return loi;
            try { QLLopDAL.Them(lop); return string.Empty; }
            catch (Exception ex) { return "Lỗi khi thêm lớp: " + ex.Message; }
        }

        public static string Sua(LopDTO lop)
        {
            lop.TenLop = lop.TenLop?.Trim();
            string loi = Validate(lop, isAdd: false);
            if (!string.IsNullOrEmpty(loi)) return loi;
            try { QLLopDAL.Sua(lop); return string.Empty; }
            catch (Exception ex) { return "Lỗi khi sửa lớp: " + ex.Message; }
        }

        public static string Xoa(string maLop)
        {
            if (string.IsNullOrWhiteSpace(maLop))
                return "Vui lòng chọn lớp cần xóa.";
            if (QLLopDAL.DangCoDanhSinhVien(maLop))
                return "Không thể xóa lớp đang có sinh viên.";
            try { QLLopDAL.Xoa(maLop); return string.Empty; }
            catch (Exception ex) { return "Lỗi khi xóa lớp: " + ex.Message; }
        }
    }
}