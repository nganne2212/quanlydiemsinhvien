using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qldsv.Class;

namespace qldsv.DAL
{
    internal class LichHocDAL
    {
        // Lấy danh sách học kỳ để đổ vào ComboBox
        public static DataTable GetAllHocKy()
        {
            return Functions.GetDataToTable(
                "SELECT MaHocKy, TenHocKy + ' - ' + NamHoc AS TenHienThi FROM HocKy ORDER BY MaHocKy DESC");
        }

        // Lấy lịch học của sinh viên theo học kỳ
        // JOIN: LichHoc → LopHocPhan → MonHoc, GiangVien, PhongHoc, DangKyHP
        public static DataTable GetLichHocSinhVien(string maSinhVien, int maHocKy)
        {
            string sql = $@"
        SELECT 
            lh.Thu,
            lh.CaHoc,
            lhp.MaLHP       AS [Mã HP],
            mh.TenMon       AS [Tên môn học],
            ph.TenPhong     AS [Phòng],
            gv.HoTen        AS [Giảng viên],
            lhp.NgayBatDau  AS [Ngày bắt đầu],
            lhp.NgayKetThuc AS [Ngày kết thúc]
        FROM LichHoc lh
        JOIN LopHocPhan lhp  ON lh.MaLHP = lhp.MaLHP
        JOIN MonHoc mh       ON lhp.MaMonHoc = mh.MaMonHoc
        JOIN GiangVien gv    ON lhp.MaGiangVien = gv.MaGiangVien
        JOIN PhongHoc ph     ON lh.MaPhong = ph.MaPhong
        JOIN DangKyHP dk     ON dk.MaLHP = lhp.MaLHP
        WHERE dk.MaSinhVien = '{maSinhVien}'
          AND lhp.MaHocKy = {maHocKy}
        ORDER BY lh.Thu, lh.CaHoc";

            return Functions.GetDataToTable(sql);
        }

        // Lấy thông tin sinh viên để hiển thị header
        public static DataTable GetThongTinSinhVien(string maSinhVien)
        {
            string sql = $@"
        SELECT sv.MaSinhVien, sv.HoTen, l.TenLop
        FROM SinhVien sv
        JOIN Lop l ON sv.MaLop = l.MaLop
        WHERE sv.MaSinhVien = '{maSinhVien}'";

            return Functions.GetDataToTable(sql);
        }
    }
}