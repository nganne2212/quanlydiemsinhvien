using System.Data;
using System.Text.RegularExpressions;
using qldsv.DAL;

namespace qldsv.BLL
{
    internal class PhongHocBLL
    {
        private static readonly Regex _regexHopLe =
            new Regex(@"^[\p{L}0-9\s.\-]+$", RegexOptions.Compiled);

        public static DataTable GetAll()
        {
            return PhongHocDAL.GetAll();
        }

        public static DataTable Search(string keyword)
        {
            keyword = keyword?.Trim();
            if (string.IsNullOrEmpty(keyword))
                return PhongHocDAL.GetAll();
            return PhongHocDAL.Search(keyword);
        }

        private static string ValidateTenPhong(string tenPhong, int maPhong = 0)
        {
            tenPhong = tenPhong?.Trim();

            if (string.IsNullOrEmpty(tenPhong))
                return "Tên phòng không được để trống.";

            if (tenPhong.Length > 100)
                return "Tên phòng không được vượt quá 100 ký tự.";

            if (!_regexHopLe.IsMatch(tenPhong))
                return "Tên phòng chứa ký tự không hợp lệ.\n" +
                       "Chỉ cho phép: chữ cái, số, khoảng trắng, dấu chấm (.), dấu gạch ngang (-).";

            if (maPhong == 0 && PhongHocDAL.TenPhongExists(tenPhong))
                return $"Tên phòng [{tenPhong}] đã tồn tại trong hệ thống.";

            if (maPhong > 0 && PhongHocDAL.TenPhongExists(tenPhong, excludeId: maPhong))
                return $"Tên phòng [{tenPhong}] đã tồn tại trong hệ thống.";

            return "";
        }

        public static string Add(string tenPhong)
        {
            string err = ValidateTenPhong(tenPhong, maPhong: 0);
            if (!string.IsNullOrEmpty(err)) return err;
            PhongHocDAL.Add(tenPhong.Trim());
            return "";
        }

        public static string Update(int maPhong, string tenPhong)
        {
            if (maPhong <= 0) return "Vui lòng chọn phòng cần sửa.";
            string err = ValidateTenPhong(tenPhong, maPhong);
            if (!string.IsNullOrEmpty(err)) return err;
            PhongHocDAL.Update(maPhong, tenPhong.Trim());
            return "";
        }

        public static string Delete(int maPhong)
        {
            if (maPhong <= 0) return "Vui lòng chọn phòng cần xóa.";
            if (PhongHocDAL.IsInUse(maPhong))
                return "Phòng này đang được xếp trong lịch học.\nKhông thể xóa.";
            PhongHocDAL.Delete(maPhong);
            return "";
        }
    }
}