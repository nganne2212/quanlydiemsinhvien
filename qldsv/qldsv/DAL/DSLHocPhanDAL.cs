using qldsv.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qldsv.DAL
{
    internal class DSLHocPhanDAL
    {
        /// <summary>
        /// Lấy danh sách lớp học phần mà giảng viên đang phụ trách.
        /// Trả về: MaLHP, TenMonHoc, SoTinChi, ThuHoc, PhongHoc, SiSo, MaHocKy
        /// </summary>
        public static DataTable GetByGiangVien(string maGV)
        {
            return Functions.GetDataToTable(@"
                SELECT
                    lhp.MaLHP,
                    mh.TenMonHoc,
                    mh.SoTinChi,
                    lhp.ThuHoc,
                    lhp.PhongHoc,
                    (SELECT COUNT(*) FROM DangKyHocPhan dk WHERE dk.MaLHP = lhp.MaLHP) AS SiSo,
                    lhp.MaHocKy
                FROM LopHocPhan lhp
                INNER JOIN MonHoc mh ON mh.MaMonHoc = lhp.MaMonHoc
                WHERE lhp.MaGiangVien = @maGV
                ORDER BY lhp.MaHocKy DESC, lhp.ThuHoc",
                new { maGV });
        }

        /// <summary>
        /// Lấy danh sách học kỳ mà giảng viên có lớp (để đổ vào ComboBox).
        /// </summary>
        public static DataTable GetHocKyByGiangVien(string maGV)
        {
            return Functions.GetDataToTable(@"
                SELECT DISTINCT hk.MaHocKy, hk.TenHocKy
                FROM LopHocPhan lhp
                INNER JOIN HocKy hk ON hk.MaHocKy = lhp.MaHocKy
                WHERE lhp.MaGiangVien = @maGV
                ORDER BY hk.MaHocKy DESC",
                new { maGV });
        }
    }
}
