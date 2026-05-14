using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using qldsv.Class;

namespace qldsv.DAL
{
    internal class PhongHocDAL
    {
        public static DataTable GetAll()
        {
            return Functions.GetDataToTable(
                @"SELECT ROW_NUMBER() OVER (ORDER BY MaPhong) AS STT,
                         MaPhong, TenPhong
                  FROM PhongHoc");
        }

        public static bool TenPhongExists(string tenPhong, int? excludeId = null)
        {
            if (excludeId.HasValue)
            {
                int count = Functions.QuerySingle<int>(
                    "SELECT COUNT(*) FROM PhongHoc WHERE TenPhong = @ten AND MaPhong <> @id",
                    new { ten = tenPhong, id = excludeId.Value });
                return count > 0;
            }
            int c = Functions.QuerySingle<int>(
                "SELECT COUNT(*) FROM PhongHoc WHERE TenPhong = @ten",
                new { ten = tenPhong });
            return c > 0;
        }

        public static bool IsInUse(int maPhong)
        {
            int count = Functions.QuerySingle<int>(
                "SELECT COUNT(*) FROM LichHoc WHERE MaPhong = @ma",
                new { ma = maPhong });
            return count > 0;
        }

        public static void Add(string tenPhong)
        {
            Functions.Execute(
                "INSERT INTO PhongHoc (TenPhong) VALUES (@ten)",
                new { ten = tenPhong });
        }

        public static void Update(int maPhong, string tenPhong)
        {
            Functions.Execute(
                "UPDATE PhongHoc SET TenPhong = @ten WHERE MaPhong = @ma",
                new { ten = tenPhong, ma = maPhong });
        }

        public static void Delete(int maPhong)
        {
            Functions.Execute(
                "DELETE FROM PhongHoc WHERE MaPhong = @ma",
                new { ma = maPhong });
        }
    }
}