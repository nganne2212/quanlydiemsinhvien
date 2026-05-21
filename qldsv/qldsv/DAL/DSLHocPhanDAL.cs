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
       
        public static DataTable GetByGiangVien(string maGV)
        {
            return Functions.GetDataToTable(@"
        SELECT
            lhp.MaLHP,
            mh.TenMon        AS TenMonHoc,
            mh.SoTinChi,
            lh.Thu           AS ThuHoc,
            ph.TenPhong      AS PhongHoc,
            (SELECT COUNT(*) FROM DangKyHP dk WHERE dk.MaLHP = lhp.MaLHP) AS SiSo,
            lhp.MaHocKy
        FROM LopHocPhan lhp
        INNER JOIN MonHoc mh   ON mh.MaMonHoc  = lhp.MaMonHoc
        LEFT  JOIN LichHoc lh  ON lh.MaLHP     = lhp.MaLHP
        LEFT  JOIN PhongHoc ph ON ph.MaPhong   = lh.MaPhong
        WHERE lhp.MaGiangVien = @maGV
        ORDER BY lhp.MaHocKy DESC, lh.Thu",
        new { maGV });
        }

        
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
