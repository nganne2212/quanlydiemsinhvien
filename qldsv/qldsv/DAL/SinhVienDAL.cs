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

        class SinhVienDAL
        {
            public static DataTable GetAll()
            {
                return Functions.GetDataToTable(@"
                SELECT sv.MaSinhVien, sv.HoTen, sv.NgaySinh, sv.GioiTinh,
                       sv.Email, sv.SoDienThoai, sv.Trangthai, l.TenLop, l.MaLop
                FROM SinhVien sv
                JOIN Lop l ON sv.MaLop = l.MaLop");
            }

            public static bool KiemTraTrung(string maSV)
            {
                return Functions.QuerySingle<int>(
                    "SELECT COUNT(*) FROM SinhVien WHERE MaSinhVien = @ma",
                    new { ma = maSV }) > 0;
            }

            public static bool DangCoLienKet(string maSV)
            {
                return Functions.QuerySingle<int>(
                    "SELECT COUNT(*) FROM DangKyHP WHERE MaSinhVien = @ma",
                    new { ma = maSV }) > 0;
            }

            public static void Them(string maSV, string hoTen, System.DateTime ngaySinh,
                string gioiTinh, string email, string sdt, string maLop, string trangThai)
            {
                using (var tran = Functions.Conn.BeginTransaction())
                {
                    try
                    {
                        // Gộp INSERT + lấy ID vào 1 câu
                        string matKhau = SecurityHelper.HashPassword("hvnh1961");

                        int maNguoiDung = Functions.Conn.QueryFirstOrDefault<int>(@"
                        INSERT INTO NguoiDung (TenDangNhap, MatKhau, VaiTro, TrangThai)
                        VALUES (@u, @p, 'SinhVien', 'Active');
                        SELECT CAST(SCOPE_IDENTITY() AS INT)",
                            new { u = maSV, p = matKhau }, tran);

                        if (maNguoiDung == 0)
                            throw new System.Exception("Khong the tao tai khoan");

                        Functions.Conn.Execute(@"
                        INSERT INTO SinhVien
                            (MaSinhVien, HoTen, NgaySinh, GioiTinh, Email, SoDienThoai, Trangthai, MaLop, MaNguoiDung)
                        VALUES
                            (@ma, @ten, @ns, @gt, @email, @sdt, @tt, @lop, @mand)",
                            new
                            {
                                ma = maSV,
                                ten = hoTen,
                                ns = ngaySinh,
                                gt = gioiTinh,
                                email,
                                sdt,
                                tt = trangThai,
                                lop = maLop,
                                mand = maNguoiDung
                            },
                            tran);

                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }

            public static void Sua(string maSV, string hoTen, System.DateTime ngaySinh,
                string gioiTinh, string email, string sdt, string maLop, string trangThai)
            {
                Functions.Execute(@"
                UPDATE SinhVien
                SET HoTen=@ten, NgaySinh=@ns, GioiTinh=@gt,
                    Email=@email, SoDienThoai=@sdt, Trangthai=@tt, MaLop=@lop
                WHERE MaSinhVien=@ma",
                    new
                    {
                        ma = maSV,
                        ten = hoTen,
                        ns = ngaySinh,
                        gt = gioiTinh,
                        email,
                        sdt,
                        tt = trangThai,
                        lop = maLop
                    });
            }
        public static bool EmailTrung(string email, string excludeMaSV = null)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            if (!string.IsNullOrEmpty(excludeMaSV))
                return Functions.QuerySingle<int>(
                    "SELECT COUNT(*) FROM SinhVien WHERE Email = @email AND MaSinhVien <> @ma",
                    new { email, ma = excludeMaSV }) > 0;
            return Functions.QuerySingle<int>(
                "SELECT COUNT(*) FROM SinhVien WHERE Email = @email",
                new { email }) > 0;
        }

        public static bool SDTTrung(string sdt, string excludeMaSV = null)
        {
            if (string.IsNullOrWhiteSpace(sdt)) return false;
            if (!string.IsNullOrEmpty(excludeMaSV))
                return Functions.QuerySingle<int>(
                    "SELECT COUNT(*) FROM SinhVien WHERE SoDienThoai = @sdt AND MaSinhVien <> @ma",
                    new { sdt, ma = excludeMaSV }) > 0;
            return Functions.QuerySingle<int>(
                "SELECT COUNT(*) FROM SinhVien WHERE SoDienThoai = @sdt",
                new { sdt }) > 0;
        }

        public static void Xoa(string maSV)
            {
                using (var tran = Functions.Conn.BeginTransaction())
                {
                    try
                    {
                        int maNguoiDung = Functions.Conn.QueryFirstOrDefault<int>(
                            "SELECT MaNguoiDung FROM SinhVien WHERE MaSinhVien = @ma",
                            new { ma = maSV }, tran);

                        // Xóa SinhVien trước (do FK)
                        Functions.Conn.Execute(
                            "DELETE FROM SinhVien WHERE MaSinhVien = @ma",
                            new { ma = maSV }, tran);

                        // Xóa NguoiDung sau
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

