using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using qldsv.Class;
using System.Data;

namespace qldsv.DAL
{
    public class PhucKhaoDAL
    {
        /// <summary>Lấy danh sách đơn phúc khảo, lọc theo HK và trạng thái.</summary>
        public static DataTable GetAll(int maHocKy = 0, string trangThai = "")
        {
            string sql = @"SELECT pk.MaPhucKhao,
                          dk.MaDangKy,
                          dk.MaDangKy AS MaDangKyRef,
                          sv.MaSinhVien + ' - ' + sv.HoTen AS TenSinhVien,
                          mh.TenMon,
                          pk.NgayGui,
                          pk.TrangThai,
                          pk.LyDo,
                          d.CuoiKy AS DiemCu,
                          lhp.MaGiangVien,
                          gv.HoTen AS TenGiangVien
                   FROM PhucKhao pk
                   JOIN DangKyHP   dk  ON pk.MaDangKy  = dk.MaDangKy
                   JOIN SinhVien   sv  ON dk.MaSinhVien = sv.MaSinhVien
                   JOIN LopHocPhan lhp ON dk.MaLHP      = lhp.MaLHP
                   JOIN MonHoc     mh  ON lhp.MaMonHoc  = mh.MaMonHoc
                   JOIN GiangVien  gv  ON lhp.MaGiangVien = gv.MaGiangVien
                   LEFT JOIN Diem  d   ON dk.MaDangKy   = d.MaDangKy
                                      AND d.TrangThai   = N'DaXacNhan'
                   WHERE 1=1";

            if (maHocKy > 0)
                sql += " AND lhp.MaHocKy = " + maHocKy;

            if (!string.IsNullOrEmpty(trangThai))
                sql += $" AND pk.TrangThai = N'{trangThai}'";

            sql += " ORDER BY pk.NgayGui DESC";

            return Functions.GetDataToTable(sql);
        }

        /// <summary>Lấy danh sách HK có đơn phúc khảo để fill ComboBox.</summary>
        public static DataTable GetHocKyCoDon()
        {
            return Functions.GetDataToTable(
                @"SELECT DISTINCT hk.MaHocKy,
                         hk.TenHocKy + ' (' + hk.NamHoc + ')' AS TenHocKy
                  FROM PhucKhao pk
                  JOIN DangKyHP   dk  ON pk.MaDangKy = dk.MaDangKy
                  JOIN LopHocPhan lhp ON dk.MaLHP    = lhp.MaLHP
                  JOIN HocKy      hk  ON lhp.MaHocKy = hk.MaHocKy
                  ORDER BY hk.MaHocKy DESC");
        }

        /// <summary>INSERT kết quả xử lý vào KetQuaPhucKhao, UPDATE trạng thái PhucKhao.</summary>
        public static void XuLy(int maPhucKhao, int maDangKy, string maGiangVien,
                                double diemCu, double diemMoi,
                                string nhanXet, string ketLuan, string ngayXuLy)
        {
            // INSERT KetQuaPhucKhao
            Functions.Execute(
                @"INSERT INTO KetQuaPhucKhao
                    (MaPhucKhao, MaGiangVien, DiemCu, DiemMoi, NhanXet, NgayXuLy, KetLuan)
                  VALUES
                    (@MaPhucKhao, @MaGiangVien, @DiemCu, @DiemMoi, @NhanXet, @NgayXuLy, @KetLuan)",
                new
                {
                    MaPhucKhao = maPhucKhao,
                    MaGiangVien = maGiangVien,
                    DiemCu = diemCu,
                    DiemMoi = diemMoi,
                    NhanXet = nhanXet,
                    NgayXuLy = ngayXuLy,
                    KetLuan = ketLuan
                });

            // UPDATE trạng thái đơn
            Functions.Execute(
                "UPDATE PhucKhao SET TrangThai = N'DaXuLy' WHERE MaPhucKhao = @MaPhucKhao",
                new { MaPhucKhao = maPhucKhao });

            // Nếu kết luận Thay Đổi → cập nhật TongKet trong Diem
            // Nếu kết luận Thay Đổi → cập nhật CuoiKy rồi tính lại TongKet
            if (ketLuan == "Thay Đổi")
            {
                // Lấy hệ số của môn
                Functions.Execute(
                    @"UPDATE d
          SET d.CuoiKy  = @DiemMoi,
              d.TongKet = ROUND(
                  d.ChuyenCan * mh.HeSoChuyenCan +
                  d.Kiemtra1  * mh.HeSoKT1 +
                  d.Kiemtra2  * mh.HeSoKT2 +
                  @DiemMoi    * mh.HeSoCuoiKy
              , 2)
          FROM Diem d
          JOIN DangKyHP   dk  ON d.MaDangKy  = dk.MaDangKy
          JOIN LopHocPhan lhp ON dk.MaLHP    = lhp.MaLHP
          JOIN MonHoc     mh  ON lhp.MaMonHoc = mh.MaMonHoc
          WHERE d.MaDangKy = @MaDangKy
            AND d.TrangThai = N'DaXacNhan'",
                    new { DiemMoi = diemMoi, MaDangKy = maDangKy });
            }
        }
    }
}
