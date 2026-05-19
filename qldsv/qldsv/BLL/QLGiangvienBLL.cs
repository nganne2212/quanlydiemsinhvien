using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace qldsv.BLL
{
    class QLGiangvienBLL
    {
        public static DataTable GetAll() => DAL.QLGiangvienDAL.GetAll();

        public static string Them(string maGV, string hoTen, string email, string maKhoa)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(maGV))
                return "Vui lòng nhập mã giảng viên";

            if (string.IsNullOrWhiteSpace(hoTen))
                return "Vui lòng nhập họ tên giảng viên";

            if (string.IsNullOrWhiteSpace(email))
                return "Vui lòng nhập email";

            if (string.IsNullOrWhiteSpace(maKhoa))
                return "Vui lòng chọn khoa";

            // Kiểm tra độ dài
            if (maGV.Trim().Length > 20)
                return "Mã giảng viên không được vượt quá 20 ký tự";

            if (hoTen.Trim().Length > 100)
                return "Họ tên không được vượt quá 100 ký tự";

            if (email.Trim().Length > 100)
                return "Email không được vượt quá 100 ký tự";

            // Kiểm tra mã
            if (!Regex.IsMatch(maGV.Trim(), @"^[a-zA-Z0-9]+$"))
                return "Mã giảng viên chỉ được chứa chữ cái và chữ số, không chứa ký tự đặc biệt";

            // Kiểm tra họ tên
            if (!Regex.IsMatch(hoTen.Trim(), @"^[\p{L}\s]+$"))
                return "Họ tên không hợp lệ, không được chứa số hoặc ký tự đặc biệt";

            // Kiểm tra email
            if (!Regex.IsMatch(email.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return "Email không đúng định dạng";

            // Kiểm tra trùng mã
            if (DAL.QLGiangvienDAL.KiemTraTrung(maGV.Trim()))
                return "Mã giảng viên đã tồn tại";

            DAL.QLGiangvienDAL.Them(
                maGV.Trim(),
                hoTen.Trim(),
                email.Trim(),
                maKhoa);

            return "";
        }

        public static string Sua(string maGV, string hoTen, string email, string maKhoa)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(hoTen))
                return "Vui lòng nhập họ tên giảng viên";

            if (string.IsNullOrWhiteSpace(email))
                return "Vui lòng nhập email";

            if (string.IsNullOrWhiteSpace(maKhoa))
                return "Vui lòng chọn khoa";

            // Kiểm tra độ dài
            if (hoTen.Trim().Length > 100)
                return "Họ tên không được vượt quá 100 ký tự";

            if (email.Trim().Length > 100)
                return "Email không được vượt quá 100 ký tự";

            // Kiểm tra họ tên
            if (!Regex.IsMatch(hoTen.Trim(), @"^[\p{L}\s]+$"))
                return "Họ tên không hợp lệ, không được chứa số hoặc ký tự đặc biệt";

            // Kiểm tra email
            if (!Regex.IsMatch(email.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return "Email không đúng định dạng";

            DAL.QLGiangvienDAL.Sua(
                maGV.Trim(),
                hoTen.Trim(),
                email.Trim(),
                maKhoa);

            return "";
        }

        public static string Xoa(string maGV)
        {
            if (string.IsNullOrWhiteSpace(maGV))
                return "Vui lòng chọn giảng viên cần xóa";

            if (DAL.QLGiangvienDAL.DangChuNhiemLop(maGV))
                return "Giảng viên đang là cố vấn học tập của lớp nên không thể xóa";

            if (DAL.QLGiangvienDAL.DangDayHocPhan(maGV))
                return "Giảng viên đang phụ trách học phần nên không thể xóa";

            if (DAL.QLGiangvienDAL.DangXuLyPhucKhao(maGV))
                return "Giảng viên đang xử lý phúc khảo nên không thể xóa";

            DAL.QLGiangvienDAL.Xoa(maGV);

            return "";
        }
    }
}