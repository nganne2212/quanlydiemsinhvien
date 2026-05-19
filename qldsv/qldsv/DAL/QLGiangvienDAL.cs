using qldsv.Class;
using qldsv.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace qldsv.DAL
{
    class QLGiangvienDAL
    {
        public static DataTable GetAll()
        {
            return Functions.GetDataToTable(@"
                SELECT gv.MaGiangVien, gv.HoTen, gv.Email, gv.MaKhoa
                FROM GiangVien gv");
        }

        public static bool KiemTraTrung(string maGV)
        {
            return Functions.QuerySingle<int>(
                "SELECT COUNT(*) FROM GiangVien WHERE MaGiangVien = @ma",
                new { ma = maGV }) > 0;
        }

        public static bool DangChuNhiemLop(string maGV)
        {
            return Functions.QuerySingle<int>(
                "SELECT COUNT(*) FROM Lop WHERE MaGiangVien = @ma",
                new { ma = maGV }) > 0;
        }

        public static bool DangDayHocPhan(string maGV)
        {
            return Functions.QuerySingle<int>(
                "SELECT COUNT(*) FROM LopHocPhan WHERE MaGiangVien = @ma",
                new { ma = maGV }) > 0;
        }

        public static bool DangXuLyPhucKhao(string maGV)
        {
            return Functions.QuerySingle<int>(
                "SELECT COUNT(*) FROM KetQuaPhucKhao WHERE MaGiangVien = @ma",
                new { ma = maGV }) > 0;
        }

        public static void Them(string maGV, string hoTen, string email, string maKhoa)
        {
            using (var tran = Functions.Conn.BeginTransaction())
            {
                try
                {
                    string matKhau = SecurityHelper.HashPassword("hvnh1961");

                    // Gộp INSERT + lấy ID vào 1 câu
                    int maNguoiDung = Functions.Conn.QueryFirstOrDefault<int>(@"
                INSERT INTO NguoiDung (TenDangNhap, MatKhau, VaiTro, TrangThai)
                VALUES (@u, @p, 'GiangVien', 'Active');
                SELECT CAST(SCOPE_IDENTITY() AS INT)",
                        new { u = maGV, p = matKhau }, tran);

                    // Kiểm tra lấy được ID chưa
                    if (maNguoiDung == 0)
                        throw new Exception("Khong the tao tai khoan");

                    Functions.Conn.Execute(@"
                        INSERT INTO GiangVien (MaGiangVien, HoTen, Email, MaKhoa, MaNguoiDung)
                        VALUES (@ma, @ten, @email, @khoa, @mand)",
                        new
                        {
                            ma = maGV,
                            ten = hoTen,
                            email,
                            khoa = maKhoa,
                            mand = maNguoiDung
                        }, tran);

                    tran.Commit();
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
        }

        public static void Sua(string maGV, string hoTen, string email, string maKhoa)
        {
            Functions.Execute(@"
                UPDATE GiangVien SET HoTen=@ten, Email=@email, MaKhoa=@khoa
                WHERE MaGiangVien=@ma",
                new { ma = maGV, ten = hoTen, email, khoa = maKhoa });
        }

        public static void Xoa(string maGV)
        {
            using (var tran = Functions.Conn.BeginTransaction())
            {
                try
                {
                    int maNguoiDung = Functions.Conn.QueryFirstOrDefault<int>(
                        "SELECT MaNguoiDung FROM GiangVien WHERE MaGiangVien = @ma",
                        new { ma = maGV }, tran);

                    Functions.Conn.Execute(
                        "DELETE FROM GiangVien WHERE MaGiangVien = @ma",
                        new { ma = maGV }, tran);

                    Functions.Conn.Execute(
                        "DELETE FROM NguoiDung WHERE MaNguoiDung = @id",
                        new { id = maNguoiDung }, tran);

                    tran.Commit();
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }

        }
    }
}
