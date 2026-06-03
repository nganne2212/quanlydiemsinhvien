using qldsv.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qldsv.DAL
{
    internal class KQHocTapDAL
    {

        public static DataTable GetNamHoc()
        {
            return Functions.GetDataToTable(@"
                SELECT DISTINCT NamHoc
                FROM HocKy
                ORDER BY NamHoc DESC");
        }


        public static DataTable GetHocKyByNam(string namHoc)
        {
            return Functions.GetDataToTable(@"
                SELECT MaHocKy, TenHocKy + ' - ' + NamHoc AS TenHK
                FROM HocKy
                WHERE NamHoc = @namHoc
                ORDER BY MaHocKy DESC",
                new { namHoc });
        }


        public static DataRow GetThongTinSinhVien(string maSV)
        {
            DataTable dt = Functions.GetDataToTable(@"
                SELECT sv.MaSinhVien, sv.HoTen, l.TenLop, k.TenKhoa
                FROM SinhVien sv
                JOIN Lop l ON sv.MaLop = l.MaLop
                JOIN Khoa k ON l.MaKhoa = k.MaKhoa
                WHERE sv.MaSinhVien = @maSV",
                new { maSV });
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }


        public static DataTable GetKetQuaHocTap(string maSV, int maHocKy)
        {
            return Functions.GetDataToTable(@"
                SELECT 
                    lhp.MaLHP,
                    mh.TenMon,
                    mh.SoTinChi,
                    mh.HeSoChuyenCan,
                    mh.HeSoKT1,
                    mh.HeSoKT2,
                    mh.HeSoCuoiKy,
                    ISNULL(d.ChuyenCan, 0) AS ChuyenCan,
                    ISNULL(d.Kiemtra1, 0) AS Kiemtra1,
                    ISNULL(d.Kiemtra2, 0) AS Kiemtra2,
                    ISNULL(d.CuoiKy, 0) AS CuoiKy,
                    ISNULL(d.TongKet, 0) AS TongKet
                FROM DangKyHP dk
                INNER JOIN LopHocPhan lhp ON dk.MaLHP = lhp.MaLHP
                INNER JOIN MonHoc mh ON lhp.MaMonHoc = mh.MaMonHoc
                LEFT JOIN Diem d ON dk.MaDangKy = d.MaDangKy AND d.TrangThai = N'DaXacNhan'
                WHERE dk.MaSinhVien = @maSV
                AND lhp.MaHocKy = @maHocKy
                ORDER BY mh.TenMon",
                new { maSV, maHocKy });
        }


        public static double TinhTrungBinhHocKy(string maSV, int maHocKy)
        {
            double? result = Functions.QuerySingle<double?>(
                @"SELECT 
                    CASE WHEN SUM(mh.SoTinChi) = 0 THEN 0
                    ELSE ROUND(SUM(d.TongKet * mh.SoTinChi) / SUM(mh.SoTinChi), 2)
                    END
                FROM DangKyHP dk
                INNER JOIN LopHocPhan lhp ON dk.MaLHP = lhp.MaLHP
                INNER JOIN MonHoc mh ON lhp.MaMonHoc = mh.MaMonHoc
                LEFT JOIN Diem d ON dk.MaDangKy = d.MaDangKy
                WHERE dk.MaSinhVien = @maSV
                AND lhp.MaHocKy = @maHocKy
                AND d.TongKet IS NOT NULL",
                new { maSV, maHocKy });
            return result ?? 0;
        }

  
        public static double TinhGPA4HocKy(string maSV, int maHocKy)
        {
            double? result = Functions.QuerySingle<double?>(
                @"SELECT 
                    CASE WHEN SUM(mh.SoTinChi) = 0 THEN 0
                    ELSE ROUND(SUM(CASE 
                        WHEN d.TongKet >= 8.5 THEN 4.0 * mh.SoTinChi
                        WHEN d.TongKet >= 8.0 THEN 3.5 * mh.SoTinChi
                        WHEN d.TongKet >= 7.0 THEN 3.0 * mh.SoTinChi
                        WHEN d.TongKet >= 6.5 THEN 2.5 * mh.SoTinChi
                        WHEN d.TongKet >= 5.5 THEN 2.0 * mh.SoTinChi
                        WHEN d.TongKet >= 5.0 THEN 1.5 * mh.SoTinChi
                        WHEN d.TongKet >= 4.0 THEN 1.0 * mh.SoTinChi
                        ELSE 0 END) / SUM(mh.SoTinChi), 2)
                    END
                FROM DangKyHP dk
                INNER JOIN LopHocPhan lhp ON dk.MaLHP = lhp.MaLHP
                INNER JOIN MonHoc mh ON lhp.MaMonHoc = mh.MaMonHoc
                LEFT JOIN Diem d ON dk.MaDangKy = d.MaDangKy
                WHERE dk.MaSinhVien = @maSV
                AND lhp.MaHocKy = @maHocKy
                AND d.TongKet IS NOT NULL",
                new { maSV, maHocKy });
            return result ?? 0;
        }


        public static double TinhTrungBinhTichLuy(string maSV, int maHocKy)
        {
            double? result = Functions.QuerySingle<double?>(
                @"SELECT 
            CASE WHEN SUM(mh.SoTinChi) = 0 THEN 0
            ELSE ROUND(SUM(d.TongKet * mh.SoTinChi) / SUM(mh.SoTinChi), 2)
            END
        FROM DangKyHP dk
        INNER JOIN LopHocPhan lhp ON dk.MaLHP = lhp.MaLHP
        INNER JOIN MonHoc mh ON lhp.MaMonHoc = mh.MaMonHoc
        LEFT JOIN Diem d ON dk.MaDangKy = d.MaDangKy
        WHERE dk.MaSinhVien = @maSV
          AND lhp.MaHocKy <= @maHocKy
          AND d.TongKet IS NOT NULL
          AND d.TrangThai = N'DaXacNhan'",
                new { maSV, maHocKy });
            return result ?? 0;
        }

        public static double TinhGPA4TichLuy(string maSV, int maHocKy)
        {
            double? result = Functions.QuerySingle<double?>(
                @"SELECT 
            CASE WHEN SUM(mh.SoTinChi) = 0 THEN 0
            ELSE ROUND(SUM(CASE 
                WHEN d.TongKet >= 8.5 THEN 4.0 * mh.SoTinChi
                WHEN d.TongKet >= 8.0 THEN 3.5 * mh.SoTinChi
                WHEN d.TongKet >= 7.0 THEN 3.0 * mh.SoTinChi
                WHEN d.TongKet >= 6.5 THEN 2.5 * mh.SoTinChi
                WHEN d.TongKet >= 5.5 THEN 2.0 * mh.SoTinChi
                WHEN d.TongKet >= 5.0 THEN 1.5 * mh.SoTinChi
                WHEN d.TongKet >= 4.0 THEN 1.0 * mh.SoTinChi
                ELSE 0 END) / SUM(mh.SoTinChi), 2)
            END
        FROM DangKyHP dk
        INNER JOIN LopHocPhan lhp ON dk.MaLHP = lhp.MaLHP
        INNER JOIN MonHoc mh ON lhp.MaMonHoc = mh.MaMonHoc
        LEFT JOIN Diem d ON dk.MaDangKy = d.MaDangKy
        WHERE dk.MaSinhVien = @maSV
          AND lhp.MaHocKy <= @maHocKy
          AND d.TongKet IS NOT NULL
          AND d.TrangThai = N'DaXacNhan'",
                new { maSV, maHocKy });
            return result ?? 0;
        }

        public static int TinhTongTinChiTichLuy(string maSV, int maHocKy)
        {
            return Functions.QuerySingle<int>(
                @"SELECT ISNULL(SUM(mh.SoTinChi), 0)
          FROM DangKyHP dk
          INNER JOIN LopHocPhan lhp ON dk.MaLHP = lhp.MaLHP
          INNER JOIN MonHoc mh ON lhp.MaMonHoc = mh.MaMonHoc
          LEFT JOIN Diem d ON dk.MaDangKy = d.MaDangKy
          WHERE dk.MaSinhVien = @maSV
            AND lhp.MaHocKy <= @maHocKy
            AND d.TongKet >= 4.0
            AND d.TrangThai = N'DaXacNhan'",
                new { maSV, maHocKy });
        }


        public static int TinhTongTinChiHocKy(string maSV, int maHocKy)
        {
            return Functions.QuerySingle<int>(
                @"SELECT ISNULL(SUM(mh.SoTinChi), 0)
                FROM DangKyHP dk
                INNER JOIN LopHocPhan lhp ON dk.MaLHP = lhp.MaLHP
                INNER JOIN MonHoc mh ON lhp.MaMonHoc = mh.MaMonHoc
                WHERE dk.MaSinhVien = @maSV
                AND lhp.MaHocKy = @maHocKy",
                new { maSV, maHocKy });
        }


       
    }
}
