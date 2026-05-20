using qldsv.DAL;
using System;
using System.Data;

namespace qldsv.BLL
{
    public class QLLichHocBLL
    {
        public static DataTable GetAll()
        {
            return QLLichHocDAL.GetAll();
        }

        public static DataTable Search(string keyword)
        {
            return QLLichHocDAL.Search(keyword ?? "");
        }

        public static DataTable GetAllLopHocPhan()
        {
            return QLLichHocDAL.GetAllLopHocPhan();
        }

        public static DataTable GetAllPhongHoc()
        {
            return QLLichHocDAL.GetAllPhongHoc();
        }

        // ── Thêm mới ────────────────────────────────────────────────────
        public static string Add(string maLHP, int maPhong, int thu, int caHoc)
        {
            if (string.IsNullOrWhiteSpace(maLHP)) return "Bạn phải chọn lớp học phần!";
            if (maPhong <= 0) return "Bạn phải chọn phòng học!";
            if (thu < 2 || thu > 7) return "Thứ không hợp lệ!";
            if (caHoc < 1 || caHoc > 4) return "Ca học không hợp lệ!";

            if (QLLichHocDAL.PhongThuCaExists(maPhong, thu, caHoc))
                return $"Phòng này đã có lịch vào Thứ {thu} Ca {caHoc}!";

            if (QLLichHocDAL.LhpThuCaExists(maLHP, thu, caHoc))
                return $"Lớp học phần [{maLHP}] đã có lịch vào Thứ {thu} Ca {caHoc}!";

            try { QLLichHocDAL.Add(maLHP, maPhong, thu, caHoc); return null; }
            catch (Exception ex) { return "Lỗi khi thêm: " + ex.Message; }
        }

        // ── Cập nhật ────────────────────────────────────────────────────
        public static string Update(string maLHP, int thuCu, int caHocCu,
                                     int maPhongMoi, int thuMoi, int caHocMoi)
        {
            if (string.IsNullOrWhiteSpace(maLHP)) return "Thiếu thông tin lịch học!";
            if (maPhongMoi <= 0) return "Bạn phải chọn phòng học!";
            if (thuMoi < 2 || thuMoi > 7) return "Thứ không hợp lệ!";
            if (caHocMoi < 1 || caHocMoi > 4) return "Ca học không hợp lệ!";

            // Kiểm tra thứ/ca mới của LHP (nếu có thay đổi)
            if ((thuMoi != thuCu || caHocMoi != caHocCu)
                && QLLichHocDAL.LhpThuCaExists(maLHP, thuMoi, caHocMoi))
                return $"Lớp học phần [{maLHP}] đã có lịch vào Thứ {thuMoi} Ca {caHocMoi}!";

            // Kiểm tra phòng mới (trừ chính nó)
            if (QLLichHocDAL.PhongThuCaExists(maPhongMoi, thuMoi, caHocMoi,
                                               maLHP, thuCu, caHocCu))
                return $"Phòng này đã có lịch vào Thứ {thuMoi} Ca {caHocMoi}!";

            try { QLLichHocDAL.Update(maLHP, thuCu, caHocCu, maPhongMoi, thuMoi, caHocMoi); return null; }
            catch (Exception ex) { return "Lỗi khi cập nhật: " + ex.Message; }
        }

        // ── Xóa ─────────────────────────────────────────────────────────
        public static string Delete(string maLHP, int thu, int caHoc)
        {
            if (string.IsNullOrWhiteSpace(maLHP)) return "Thiếu thông tin lịch học!";

            // Không cho xóa nếu đã có SV đăng ký
            int soDK = QLLichHocDAL.SoSVDangKy(maLHP);
            if (soDK > 0)
                return $"Không thể xóa! Lớp học phần [{maLHP}] đã có {soDK} sinh viên đăng ký.";

            // Không cho xóa nếu LHP đã kết thúc
            DateTime? ngayKT = QLLichHocDAL.GetNgayKetThuc(maLHP);
            if (ngayKT.HasValue && ngayKT.Value < DateTime.Today)
                return $"Không thể xóa! Lớp học phần [{maLHP}] đã kết thúc ngày {ngayKT.Value:dd/MM/yyyy}.";

            try { QLLichHocDAL.Delete(maLHP, thu, caHoc); return null; }
            catch (Exception ex) { return "Lỗi khi xóa: " + ex.Message; }
        }
    }
}