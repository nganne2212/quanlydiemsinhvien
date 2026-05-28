using qldsv.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace qldsv.Utils
{
    internal class CanhBaoService
    {
        public static string XuLyCanhBaoSauDongHK(int maHocKy)
        {
            DataTable dsSV = Functions.GetDataToTable(
                @"SELECT DISTINCT dk.MaSinhVien
                  FROM DangKyHP dk
                  JOIN LopHocPhan lhp ON dk.MaLHP = lhp.MaLHP
                  WHERE lhp.MaHocKy = @MaHocKy",
                new { MaHocKy = maHocKy });

            foreach (DataRow row in dsSV.Rows)
            {
                string maSV = row["MaSinhVien"].ToString();
                KiemTraVaCanhBao(maSV, maHocKy);
            }

            return "";
        }
        public static string KiemTraDiemChuaXacNhan(int maHocKy)
        {
            int so = Functions.QuerySingle<int>(
                @"SELECT COUNT(DISTINCT dk.MaLHP)
          FROM DangKyHP dk
          JOIN LopHocPhan lhp ON dk.MaLHP = lhp.MaLHP
          LEFT JOIN Diem d ON dk.MaDangKy = d.MaDangKy
          WHERE lhp.MaHocKy = @MaHocKy
            AND (d.MaDiem IS NULL OR d.TrangThai = N'ChuaXacNhan')",
                new { MaHocKy = maHocKy });

            return so > 0
                ? $"Còn {so} lớp học phần chưa xác nhận điểm. Vui lòng xác nhận hết trước khi đóng học kỳ!"
                : "";
        }

        public static string KiemTraPhucKhaoChuaXuLy(int maHocKy)
        {
            int so = Functions.QuerySingle<int>(
                @"SELECT COUNT(*)
                  FROM PhucKhao pk
                  JOIN DangKyHP   dk  ON pk.MaDangKy  = dk.MaDangKy
                  JOIN LopHocPhan lhp ON dk.MaLHP     = lhp.MaLHP
                  WHERE lhp.MaHocKy  = @MaHocKy
                    AND pk.TrangThai = N'ChuaXuLy'",
                new { MaHocKy = maHocKy });

            return so > 0
                ? $"Còn {so} đơn phúc khảo chưa xử lý. Vui lòng xử lý hết trước khi đóng học kỳ!"
                : "";
        }

        private static void KiemTraVaCanhBao(string maSV, int maHocKy)
        {
            // 1. TC dang ky trong ky
            int tcDangKy = Functions.QuerySingle<int>(
                @"SELECT ISNULL(SUM(mh.SoTinChi), 0)
                  FROM DangKyHP dk
                  JOIN LopHocPhan lhp ON dk.MaLHP     = lhp.MaLHP
                  JOIN MonHoc     mh  ON lhp.MaMonHoc = mh.MaMonHoc
                  WHERE dk.MaSinhVien = @MaSV
                    AND lhp.MaHocKy  = @MaHocKy",
                new { MaSV = maSV, MaHocKy = maHocKy });

            // 2. TC khong dat trong ky
            int tcKhongDatTrongKy = Functions.QuerySingle<int>(
                @"SELECT ISNULL(SUM(mh.SoTinChi), 0)
                  FROM DangKyHP dk
                  JOIN LopHocPhan lhp ON dk.MaLHP     = lhp.MaLHP
                  JOIN MonHoc     mh  ON lhp.MaMonHoc = mh.MaMonHoc
                  JOIN Diem       d   ON dk.MaDangKy  = d.MaDangKy
                  WHERE dk.MaSinhVien = @MaSV
                    AND lhp.MaHocKy  = @MaHocKy
                    AND d.TrangThai  = N'DaXacNhan'
                    AND d.TongKet    < 4.0",
                new { MaSV = maSV, MaHocKy = maHocKy });

            // 3. TC tich luy dat
            int tctl = Functions.QuerySingle<int>(
                @"SELECT ISNULL(SUM(SoTinChi), 0)
                  FROM (
                      SELECT lhp.MaMonHoc, mh.SoTinChi, MAX(d.TongKet) AS DiemTot
                      FROM DangKyHP dk
                      JOIN LopHocPhan lhp ON dk.MaLHP     = lhp.MaLHP
                      JOIN MonHoc     mh  ON lhp.MaMonHoc = mh.MaMonHoc
                      JOIN Diem       d   ON dk.MaDangKy  = d.MaDangKy
                      WHERE dk.MaSinhVien = @MaSV
                        AND d.TrangThai   = N'DaXacNhan'
                      GROUP BY lhp.MaMonHoc, mh.SoTinChi
                      HAVING MAX(d.TongKet) >= 4.0
                  ) t",
                new { MaSV = maSV });

            // 4. No tich luy
            int noTichLuy = Functions.QuerySingle<int>(
                @"SELECT ISNULL(SUM(SoTinChi), 0)
                  FROM (
                      SELECT lhp.MaMonHoc, mh.SoTinChi, MAX(d.TongKet) AS DiemTot
                      FROM DangKyHP dk
                      JOIN LopHocPhan lhp ON dk.MaLHP     = lhp.MaLHP
                      JOIN MonHoc     mh  ON lhp.MaMonHoc = mh.MaMonHoc
                      JOIN Diem       d   ON dk.MaDangKy  = d.MaDangKy
                      WHERE dk.MaSinhVien = @MaSV
                        AND d.TrangThai   = N'DaXacNhan'
                      GROUP BY lhp.MaMonHoc, mh.SoTinChi
                      HAVING MAX(d.TongKet) < 4.0
                  ) t",
                new { MaSV = maSV });

            // 5. DTBHK he 4 — lay diem tung mon ve C# roi quy doi
            DataTable dsDiemHK = Functions.GetDataToTable(
                @"SELECT d.TongKet, mh.SoTinChi
                  FROM DangKyHP dk
                  JOIN LopHocPhan lhp ON dk.MaLHP     = lhp.MaLHP
                  JOIN MonHoc     mh  ON lhp.MaMonHoc = mh.MaMonHoc
                  JOIN Diem       d   ON dk.MaDangKy  = d.MaDangKy
                  WHERE dk.MaSinhVien = @MaSV
                    AND lhp.MaHocKy  = @MaHocKy
                    AND d.TrangThai  = N'DaXacNhan'",
                new { MaSV = maSV, MaHocKy = maHocKy });

            double tongHK = 0, tongTCHK = 0;
            foreach (DataRow r in dsDiemHK.Rows)
            {
                double diem4 = QuyDoiHe4(Convert.ToDouble(r["TongKet"]));
                int tc = Convert.ToInt32(r["SoTinChi"]);
                tongHK += diem4 * tc;
                tongTCHK += tc;
            }
            double dtbhk = tongTCHK > 0 ? Math.Round(tongHK / tongTCHK, 1) : 0;

            // 6. DTBTL he 4 — lay diem cao nhat moi mon roi quy doi
            DataTable dsDiemTL = Functions.GetDataToTable(
                @"SELECT mh.SoTinChi, MAX(d.TongKet) AS DiemTot
                  FROM DangKyHP dk
                  JOIN LopHocPhan lhp ON dk.MaLHP     = lhp.MaLHP
                  JOIN MonHoc     mh  ON lhp.MaMonHoc = mh.MaMonHoc
                  JOIN Diem       d   ON dk.MaDangKy  = d.MaDangKy
                  WHERE dk.MaSinhVien = @MaSV
                    AND d.TrangThai   = N'DaXacNhan'
                  GROUP BY lhp.MaMonHoc, mh.SoTinChi",
                new { MaSV = maSV });

            double tongTL = 0, tongTCTL = 0;
            foreach (DataRow r in dsDiemTL.Rows)
            {
                double diem4 = QuyDoiHe4(Convert.ToDouble(r["DiemTot"]));
                int tc = Convert.ToInt32(r["SoTinChi"]);
                tongTL += diem4 * tc;
                tongTCTL += tc;
            }
            double dtbtl = tongTCTL > 0 ? Math.Round(tongTL / tongTCTL, 1) : 0;

            // 7. Xac dinh nam hoc cua SV
            int soKyDaHoc = Functions.QuerySingle<int>(
                @"SELECT COUNT(DISTINCT lhp.MaHocKy)
                  FROM DangKyHP dk
                  JOIN LopHocPhan lhp ON dk.MaLHP = lhp.MaLHP
                  WHERE dk.MaSinhVien = @MaSV",
                new { MaSV = maSV });

            int namHoc = soKyDaHoc <= 2 ? 1
                       : soKyDaHoc <= 4 ? 2
                       : soKyDaHoc <= 6 ? 3 : 4;

            // 8. Nguong theo nam hoc
            double nguongDTBHK = namHoc == 1 ? 0.8 : 1.0;
            double nguongDTBTL = namHoc == 1 ? 1.2
                               : namHoc == 2 ? 1.4
                               : namHoc == 3 ? 1.6 : 1.8;

            // 9. Kiem tra dieu kien canh bao
            string lyDo = "";
            bool biBao = false;

            if (tcDangKy == 0)
            {
                lyDo = "Không đăng ký môn học trong kỳ";
                biBao = true;
            }
            else if (noTichLuy > 24)
            {
                lyDo = $"Nợ tích lũy {noTichLuy} TC vượt quá 24 TC cho phép";
                biBao = true;
            }
            else if (tcDangKy > 0 && tcKhongDatTrongKy > tcDangKy * 0.5)
            {
                lyDo = $"TC không đạt trong kỳ ({tcKhongDatTrongKy}/{tcDangKy} TC) vượt quá 50% TC đăng ký";
                biBao = true;
            }
            else if (dtbhk < nguongDTBHK)
            {
                lyDo = $"ĐTBHK ({dtbhk:F1}) thấp hơn ngưỡng {nguongDTBHK:F1} (Năm {namHoc})";
                biBao = true;
            }
            else if (dtbtl < nguongDTBTL)
            {
                lyDo = $"ĐTBTL ({dtbtl:F1}) thấp hơn ngưỡng {nguongDTBTL:F1} (Năm {namHoc})";
                biBao = true;
            }

            if (!biBao) return;

            // 10. Dem so lan da bi canh bao truoc do
            int soLanCuBao = Functions.QuerySingle<int>(
                @"SELECT COUNT(*)
                  FROM CanhBaoHocVu
                  WHERE MaSinhVien = @MaSV",
                new { MaSV = maSV });

            int soKyDaBiCB = soLanCuBao + 1;
            string mucCanhBao = soLanCuBao == 0 ? "CanhBao1"
                              : soLanCuBao == 1 ? "CanhBao2"
                              : "BuocThoiHoc";

            // 11. INSERT CanhBaoHocVu
            Functions.Execute(
                @"INSERT INTO CanhBaoHocVu
                    (MaSinhVien, MaHocKy, SoKyDaBiCB, DiemHK, TBTL, TCTL,
                     LyDo, MucCanhBao, TrangThai)
                  VALUES
                    (@MaSV, @MaHocKy, @SoKyDaBiCB, @DiemHK, @TBTL, @TCTL,
                     @LyDo, @MucCanhBao, N'ChuaXuLy')",
                new
                {
                    MaSV = maSV,
                    MaHocKy = maHocKy,
                    SoKyDaBiCB = soKyDaBiCB,
                    DiemHK = dtbhk,
                    TBTL = dtbtl,
                    TCTL = tctl,
                    LyDo = lyDo,
                    MucCanhBao = mucCanhBao
                });

            // 12. Buoc thoi hoc o lan canh bao thu 3
            if (mucCanhBao == "BuocThoiHoc")
            {
                Functions.Execute(
                    @"UPDATE SinhVien
                      SET Trangthai = N'ThoiHoc'
                      WHERE MaSinhVien = @MaSV",
                    new { MaSV = maSV });
            }
        }

        // Quy doi he 10 sang he 4 (thang chuan Bo GD&DT)
        private static double QuyDoiHe4(double diem10)
        {
            if (diem10 >= 8.5) return 4.0;
            if (diem10 >= 8.0) return 3.5;
            if (diem10 >= 7.0) return 3.0;
            if (diem10 >= 6.5) return 2.5;
            if (diem10 >= 5.5) return 2.0;
            if (diem10 >= 5.0) return 1.5;
            if (diem10 >= 4.0) return 1.0;
            return 0.0;
        }
    }
}