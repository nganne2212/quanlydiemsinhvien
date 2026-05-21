using System.Data;
using System.Text.RegularExpressions;
using qldsv.DAL;

namespace qldsv.BLL
{
    internal class LopBLL
    {
        // Mã lớp: chỉ chữ và số, không khoảng trắng
        private static readonly Regex _regexMaLop =
            new Regex(@"^[a-zA-Z0-9]+$", RegexOptions.Compiled);

        // Tên lớp: không chứa ký tự đặc biệt
        private static readonly Regex _regexKyTuLa =
            new Regex(@"[<>""'&!@#$%^*()+=\[\]{}|\\;:,/?`~]",
                      RegexOptions.Compiled);

        public static DataTable GetAll() => LopDAL.GetAll();
        public static DataTable GetAllKhoa() => LopDAL.GetAllKhoa();

        public static DataTable GetGiangVienByKhoa(string maKhoa)
            => LopDAL.GetGiangVienByKhoa(maKhoa);

        public static DataTable Search(string keyword, string maKhoa = "")
        {
            keyword = keyword?.Trim() ?? "";
            if (!string.IsNullOrEmpty(maKhoa))
                return LopDAL.SearchByKhoa(keyword, maKhoa);
            return string.IsNullOrEmpty(keyword)
                ? LopDAL.GetAll()
                : LopDAL.Search(keyword);
        }

        private static string Validate(string maLop, string tenLop,
                                       string maKhoa, string maGV, bool isAdd)
        {
            maLop = maLop?.Trim();
            tenLop = tenLop?.Trim();

            if (string.IsNullOrEmpty(maLop))
                return "Vui lòng nhập mã lớp.";

            if (!_regexMaLop.IsMatch(maLop))
                return "Mã lớp chỉ được chứa chữ và số,\nkhông có khoảng trắng hoặc ký tự đặc biệt.";

            if (maLop.Length > 20)
                return "Mã lớp không được vượt quá 20 ký tự.";

            if (isAdd && LopDAL.KiemTraTrung(maLop))
                return $"Mã lớp [{maLop}] đã tồn tại trong hệ thống.";

            if (string.IsNullOrEmpty(tenLop))
                return "Vui lòng nhập tên lớp.";

            if (_regexKyTuLa.IsMatch(tenLop))
                return "Tên lớp chứa ký tự không hợp lệ!\n" +
                       "Không được dùng các ký tự đặc biệt như: < > \" ' & ! @ # ...";

            if (tenLop.Length > 100)
                return "Tên lớp không được vượt quá 100 ký tự.";

            if (string.IsNullOrEmpty(maKhoa))
                return "Vui lòng chọn khoa.";

            if (string.IsNullOrEmpty(maGV))
                return "Vui lòng chọn cố vấn học tập.";

            return "";
        }

        public static string Add(string maLop, string tenLop,
                                 string maKhoa, string maGV)
        {
            string err = Validate(maLop, tenLop, maKhoa, maGV, isAdd: true);
            if (!string.IsNullOrEmpty(err)) return err;
            LopDAL.Add(maLop.Trim(), tenLop.Trim(), maKhoa, maGV);
            return "";
        }

        public static string Update(string maLop, string tenLop,
                                    string maKhoa, string maGV)
        {
            if (string.IsNullOrWhiteSpace(maLop))
                return "Vui lòng chọn lớp cần sửa.";
            string err = Validate(maLop, tenLop, maKhoa, maGV, isAdd: false);
            if (!string.IsNullOrEmpty(err)) return err;
            LopDAL.Update(maLop.Trim(), tenLop.Trim(), maKhoa, maGV);
            return "";
        }

        public static string Delete(string maLop)
        {
            if (string.IsNullOrWhiteSpace(maLop))
                return "Vui lòng chọn lớp cần xóa.";
            if (LopDAL.DangCoDanhSinhVien(maLop))
                return $"Lớp [{maLop}] đang có sinh viên.\nKhông thể xóa.";
            LopDAL.Delete(maLop);
            return "";
        }
    }
}