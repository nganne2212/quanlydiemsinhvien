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
            // Lấy danh sách SV có đăng ký trong kỳ
            DataTable dsSV = Functions.GetDataToTable(
                @"SELECT DISTINCT dk.MaSinhVien
                  FROM DangKyHP dk
                  JOIN LopHocPhan lhp ON dk.MaLHP = lhp.MaLHP
                  WHERE lhp.MaHocKy = @MaHocKy",
                new { MaHocKy = maHocKy });

            // Bước 3: Xét từng SV
            foreach (DataRow row in dsSV.Rows)
            {
                string maSV = row["MaSinhVien"].ToString();
                KiemTraVaCanhBao(maSV, maHocKy);
            }

            return "";
        }

        // ════════════════════════════════════════════════════════
        //  KIỂM TRA PHÚC KHẢO — Form có thể gọi độc lập
        // ════════════════════════════════════════════════════════

        /// <summary>
        /// Trả về "" nếu không còn đơn phúc khảo chưa xử lý,
        /// trả về string lỗi nếu còn.
        /// </summary>
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

        // ════════════════════════════════════════════════════════
        //  XÉT TỪNG SINH VIÊN
        // ════════════════════════════════════════════════════════

        private static void KiemTraVaCanhBao(string maSV, int maHocKy)
        {
            // ── 1. TC đăng ký trong kỳ ──────────────────────────
            int tcDangKy = Functions.QuerySingle<int>(
                @"SELECT ISNULL(SUM(mh.SoTinChi), 0)
                  FROM DangKyHP dk
                  JOIN LopHocPhan lhp ON dk.MaLHP     = lhp.MaLHP
                  JOIN MonHoc     mh  ON lhp.MaMonHoc = mh.MaMonHoc
                  WHERE dk.MaSinhVien = @MaSV
                    AND lhp.MaHocKy  = @MaHocKy",
                new { MaSV = maSV, MaHocKy = maHocKy });

            // ── 2. TC không đạt trong kỳ (TongKet < 4.0) ────────
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

            // ── 3. TC tích lũy đạt (TongKet >= 4.0, lần học đầu) 
            //       Đây là TCTL thực sự: tổng TC đã qua, dùng để báo cáo
            int tctl = Functions.QuerySingle<int>(
                @"SELECT ISNULL(SUM(mh.SoTinChi), 0)
                  FROM DangKyHP dk
                  JOIN LopHocPhan lhp ON dk.MaLHP     = lhp.MaLHP
                  JOIN MonHoc     mh  ON lhp.MaMonHoc = mh.MaMonHoc
                  JOIN Diem       d   ON dk.MaDangKy  = d.MaDangKy
                  WHERE dk.MaSinhVien = @MaSV
                    AND d.TrangThai   = N'DaXacNhan'
                    AND d.Loaihoc     = N'LanDau'
                    AND d.TongKet    >= 4.0",
                new { MaSV = maSV });

            // ── 4. Nợ tích lũy (TC lần đầu chưa đạt toàn lịch sử)
            int noTichLuy = Functions.QuerySingle<int>(
                @"SELECT ISNULL(SUM(mh.SoTinChi), 0)
                  FROM DangKyHP dk
                  JOIN LopHocPhan lhp ON dk.MaLHP     = lhp.MaLHP
                  JOIN MonHoc     mh  ON lhp.MaMonHoc = mh.MaMonHoc
                  JOIN Diem       d   ON dk.MaDangKy  = d.MaDangKy
                  WHERE dk.MaSinhVien = @MaSV
                    AND d.TrangThai   = N'DaXacNhan'
                    AND d.Loaihoc     = N'LanDau'
                    AND d.TongKet     < 4.0",
                new { MaSV = maSV });

            // ── 5. ĐTBHK — trung bình có trọng số trong kỳ này ──
            double dtbhk = Functions.QuerySingle<double>(
                @"SELECT ISNULL(
                    SUM(d.TongKet * mh.SoTinChi) / NULLIF(SUM(mh.SoTinChi), 0)
                  , 0)
                  FROM DangKyHP dk
                  JOIN LopHocPhan lhp ON dk.MaLHP     = lhp.MaLHP
                  JOIN MonHoc     mh  ON lhp.MaMonHoc = mh.MaMonHoc
                  JOIN Diem       d   ON dk.MaDangKy  = d.MaDangKy
                  WHERE dk.MaSinhVien = @MaSV
                    AND lhp.MaHocKy  = @MaHocKy
                    AND d.TrangThai  = N'DaXacNhan'",
                new { MaSV = maSV, MaHocKy = maHocKy });

            // ── 6. ĐTBTL — trung bình tích lũy lần học đầu ──────
            double dtbtl = Functions.QuerySingle<double>(
                @"SELECT ISNULL(
                    SUM(d.TongKet * mh.SoTinChi) / NULLIF(SUM(mh.SoTinChi), 0)
                  , 0)
                  FROM DangKyHP dk
                  JOIN LopHocPhan lhp ON dk.MaLHP     = lhp.MaLHP
                  JOIN MonHoc     mh  ON lhp.MaMonHoc = mh.MaMonHoc
                  JOIN Diem       d   ON dk.MaDangKy  = d.MaDangKy
                  WHERE dk.MaSinhVien = @MaSV
                    AND d.TrangThai   = N'DaXacNhan'
                    AND d.Loaihoc     = N'LanDau'",
                new { MaSV = maSV });

            // ── 7. Xác định năm học của SV (đếm số kỳ đã học) ───
            int soKyDaHoc = Functions.QuerySingle<int>(
                @"SELECT COUNT(DISTINCT lhp.MaHocKy)
                  FROM DangKyHP dk
                  JOIN LopHocPhan lhp ON dk.MaLHP = lhp.MaLHP
                  WHERE dk.MaSinhVien = @MaSV",
                new { MaSV = maSV });

            // Kỳ hiện tại đang đóng tính là kỳ cuối của năm học đó
            int namHoc = soKyDaHoc <= 2 ? 1
                       : soKyDaHoc <= 4 ? 2
                       : soKyDaHoc <= 6 ? 3 : 4;

            // ── 8. Ngưỡng theo năm học ───────────────────────────
            double nguongDTBHK = namHoc == 1 ? 0.8 : 1.0;
            double nguongDTBTL = namHoc == 1 ? 1.2
                               : namHoc == 2 ? 1.4
                               : namHoc == 3 ? 1.6 : 1.8;

            // ── 9. Kiểm tra điều kiện cảnh báo ───────────────────
            //       Ưu tiên theo mức độ nghiêm trọng giảm dần
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
                lyDo = $"TC không đạt trong kỳ ({tcKhongDatTrongKy}/{tcDangKy} TC) "
                       + "vượt quá 50% TC đăng ký";
                biBao = true;
            }
            else if (dtbhk < nguongDTBHK)
            {
                lyDo = $"ĐTBHK ({dtbhk:F2}) thấp hơn ngưỡng {nguongDTBHK:F1} "
                       + $"(Năm {namHoc})";
                biBao = true;
            }
            else if (dtbtl < nguongDTBTL)
            {
                lyDo = $"ĐTBTL ({dtbtl:F2}) thấp hơn ngưỡng {nguongDTBTL:F1} "
                       + $"(Năm {namHoc})";
                biBao = true;
            }

            if (!biBao) return;

            // ── 10. Đếm số lần đã bị cảnh báo trước đó ──────────
            int soLanCuBao = Functions.QuerySingle<int>(
                @"SELECT COUNT(*)
                  FROM CanhBaoHocVu
                  WHERE MaSinhVien = @MaSV",
                new { MaSV = maSV });

            int soKyDaBiCB = soLanCuBao + 1; // kỳ này là lần thứ mấy
            string mucCanhBao = soLanCuBao == 0 ? "CanhBao1"
                              : soLanCuBao == 1 ? "CanhBao2"
                              : "BuocThoiHoc";

            // ── 11. INSERT CanhBaoHocVu ───────────────────────────
            Functions.Execute(
                @"INSERT INTO CanhBaoHocVu
                    (MaSinhVien, MaHocKy, SoKyDaBiCB, DiemHK, TBTL,  TCTL,
                     LyDo,      MucCanhBao, TrangThai)
                  VALUES
                    (@MaSV, @MaHocKy, @SoKyDaBiCB, @DiemHK, @TBTL, @TCTL,
                     @LyDo, @MucCanhBao, N'ChuaXuLy')",
                new
                {
                    MaSV = maSV,
                    MaHocKy = maHocKy,
                    SoKyDaBiCB = soKyDaBiCB,
                    DiemHK = Math.Round(dtbhk, 2),
                    TBTL = Math.Round(dtbtl, 2),
                    TCTL = tctl,
                    LyDo = lyDo,
                    MucCanhBao = mucCanhBao
                });

            // ── 12. Buộc thôi học ở lần cảnh báo thứ 3 ──────────
            if (mucCanhBao == "BuocThoiHoc")
            {
                Functions.Execute(
                    @"UPDATE SinhVien
                      SET Trangthai = N'ThoiHoc'
                      WHERE MaSinhVien = @MaSV",
                    new { MaSV = maSV });
            }
        }
    }
}
