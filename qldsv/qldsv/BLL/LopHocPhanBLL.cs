using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace qldsv.BLL
{

        class LopHocPhanBLL
        {
            public static DataTable GetAll() => DAL.LopHocPhanDAL.GetAll();

            public static DataTable GetSVTrongLHP(string maLHP) =>
                DAL.LopHocPhanDAL.GetSVTrongLHP(maLHP);

            public static DataTable GetSVChuaDangKy(string maLHP) =>
                DAL.LopHocPhanDAL.GetSVChuaDangKy(maLHP);


            public static string Them(string maLHP, string maMonHoc, string maGV,
                string maHocKyStr, DateTime ngayBD, DateTime ngayKT)
            {
                string loi = Validate(maLHP, maMonHoc, maGV, maHocKyStr, ngayBD, ngayKT, true);
                if (loi != "") return loi;

                DAL.LopHocPhanDAL.Them(maLHP.Trim(), maMonHoc, maGV,
                    int.Parse(maHocKyStr), ngayBD, ngayKT);
                return "";
            }

            public static string Sua(string maLHP, string maMonHoc, string maGV,
                string maHocKyStr, DateTime ngayBD, DateTime ngayKT)
            {
                string loi = Validate(maLHP, maMonHoc, maGV, maHocKyStr, ngayBD, ngayKT, false);
                if (loi != "") return loi;

                DAL.LopHocPhanDAL.Sua(maLHP.Trim(), maMonHoc, maGV,
                    int.Parse(maHocKyStr), ngayBD, ngayKT);
                return "";
            }

            public static string Xoa(string maLHP)
            {
                if (string.IsNullOrWhiteSpace(maLHP))
                    return "Vui lòng chọn lớp học phần cần xóa";

                DAL.LopHocPhanDAL.Xoa(maLHP);
                return "";
            }



        public static string ThemSVVaoLHP(string maSV, string maLHP)
        {
            if (string.IsNullOrWhiteSpace(maSV))
                return "Vui lòng chọn sinh viên";

            if (DAL.LopHocPhanDAL.DaSVTrongLHP(maSV, maLHP))
                return "Sinh viên đã có trong lớp học phần này";
            if (DAL.LopHocPhanDAL.DaDangKyCungMon(maSV, maLHP))
                return "Sinh viên đã đăng ký môn này trong học kỳ";
            if (DAL.LopHocPhanDAL.TrungLichHoc(maSV, maLHP))
                return "Sinh viên bị trùng lịch học với lớp học phần khác";
            if (DAL.LopHocPhanDAL.DaXacNhanDiem(maLHP))
                return "Không thể thêm sinh viên vào lớp học phần đã xác nhận điểm";

            // Kiểm tra điểm cao nhất môn này
            double diemCao = DAL.LopHocPhanDAL.GetDiemCaoNhatMonHoc(maSV, maLHP);
            if (diemCao >= 8.5)
                return $"Sinh viên đã đạt {diemCao} điểm, không cần cải thiện!";

            DAL.LopHocPhanDAL.ThemSVVaoLHP(maSV, maLHP);
            return "";
        }

        public static string XoaSVKhoiLHP(string maSV, string maLHP)
            {
                if (string.IsNullOrWhiteSpace(maSV))
                    return "Vui lòng chọn sinh viên cần xóa";

                if (DAL.LopHocPhanDAL.DangCoDiem(maSV, maLHP))
                    return "Không thể xóa sinh viên đã có điểm trong lớp học phần này";

                DAL.LopHocPhanDAL.XoaSVKhoiLHP(maSV, maLHP);
                return "";
            }


            public static List<Utils.ImportResult> ValidateImportExcel(string filePath, string maLHP)
            {
                return DAL.LopHocPhanDAL.ValidateImportExcel(filePath, maLHP);
            }

            public static string ThemNhieuSVVaoLHP(List<string> dsMaSV, string maLHP)
            {
                if (dsMaSV == null || dsMaSV.Count == 0)
                    return "Không có sinh viên hợp lệ để thêm";

                DAL.LopHocPhanDAL.ThemNhieuSVVaoLHP(dsMaSV, maLHP);
                return "";
            }


            private static string Validate(string maLHP, string maMonHoc, string maGV,
                string maHocKyStr, DateTime ngayBD, DateTime ngayKT, bool isAdd)
            {
                if (string.IsNullOrWhiteSpace(maLHP))
                    return "Vui lòng nhập mã lớp học phần";

                if (!System.Text.RegularExpressions.Regex.IsMatch(maLHP.Trim(), @"^[a-zA-Z0-9_\-]+$"))
                    return "Mã lớp học phần chỉ được chứa chữ cái, số, dấu gạch ngang và gạch dưới";

                if (isAdd && DAL.LopHocPhanDAL.KiemTraTrung(maLHP.Trim()))
                    return "Mã lớp học phần đã tồn tại";

                if (string.IsNullOrWhiteSpace(maMonHoc))
                    return "Vui lòng chọn môn học";

                if (string.IsNullOrWhiteSpace(maGV))
                    return "Vui lòng chọn giảng viên";

                if (string.IsNullOrWhiteSpace(maHocKyStr) || !int.TryParse(maHocKyStr, out _))
                    return "Vui lòng chọn học kỳ";

                if (ngayKT <= ngayBD)
                    return "Ngày kết thúc phải sau ngày bắt đầu";

                return "";
            }
        }
 }

