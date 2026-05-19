using qldsv.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qldsv.BLL
{
    internal class MonHocBLL
    {
        public static DataTable GetAll()
        {
            return MonHocDAL.GetAll();
        }

        public static DataTable Search(string keyword)
        {
            return MonHocDAL.Search(keyword);
        }

        public static string Them(string maMonHoc, string tenMon, string soTinChiStr,
            string ccStr, string kt1Str, string kt2Str, string ckStr)
        {
            if (string.IsNullOrWhiteSpace(maMonHoc))
                return "Bạn phải nhập mã môn học";

            if (string.IsNullOrWhiteSpace(tenMon))
                return "Bạn phải nhập tên môn học";

            if (!int.TryParse(soTinChiStr.Trim(), out int soTinChi) || soTinChi < 1 || soTinChi > 10)
                return "Số tín chỉ phải là số nguyên từ 1 đến 10";

            string errHeSo = ValidateHeSo(ccStr, kt1Str, kt2Str, ckStr,
                out double cc, out double kt1, out double kt2, out double ck);
            if (!string.IsNullOrEmpty(errHeSo))
                return errHeSo;

            if (MonHocDAL.CheckTrungMa(maMonHoc.Trim()))
                return "Mã môn học đã tồn tại";

            MonHocDAL.Insert(maMonHoc.Trim(), tenMon.Trim(), soTinChi, cc, kt1, kt2, ck);
            return "";
        }

        public static string Sua(string maMonHoc, string tenMon, string soTinChiStr,
            string ccStr, string kt1Str, string kt2Str, string ckStr)
        {
            if (string.IsNullOrWhiteSpace(maMonHoc))
                return "Chưa chọn bản ghi nào";

            if (string.IsNullOrWhiteSpace(tenMon))
                return "Bạn phải nhập tên môn học";

            if (!int.TryParse(soTinChiStr.Trim(), out int soTinChi) || soTinChi < 1 || soTinChi > 10)
                return "Số tín chỉ phải là số nguyên từ 1 đến 10";

            string errHeSo = ValidateHeSo(ccStr, kt1Str, kt2Str, ckStr,
                out double cc, out double kt1, out double kt2, out double ck);
            if (!string.IsNullOrEmpty(errHeSo))
                return errHeSo;

            MonHocDAL.Update(maMonHoc.Trim(), tenMon.Trim(), soTinChi, cc, kt1, kt2, ck);
            return "";
        }

        public static string KiemTraXoa(string maMonHoc)
        {
            if (string.IsNullOrWhiteSpace(maMonHoc))
                return "Chưa chọn bản ghi nào";

            if (MonHocDAL.CheckDangDung(maMonHoc.Trim()))
                return "Không thể xóa: môn học đang được dùng trong lớp học phần";

            return "";
        }

        public static void Xoa(string maMonHoc)
        {
            MonHocDAL.Delete(maMonHoc.Trim());
        }

        private static string ValidateHeSo(
            string ccStr, string kt1Str, string kt2Str, string ckStr,
            out double cc, out double kt1, out double kt2, out double ck)
        {
            cc = kt1 = kt2 = ck = 0;
            var cult = CultureInfo.InvariantCulture;

            if (!double.TryParse(ccStr.Trim().Replace(',', '.'), NumberStyles.Any, cult, out cc) || cc < 0 || cc > 1)
                return "Hệ số chuyên cần không hợp lệ (nhập số từ 0 đến 1, ví dụ: 0.1)";

            if (!double.TryParse(kt1Str.Trim().Replace(',', '.'), NumberStyles.Any, cult, out kt1) || kt1 < 0 || kt1 > 1)
                return "Hệ số kiểm tra 1 không hợp lệ (nhập số từ 0 đến 1)";

            if (!double.TryParse(kt2Str.Trim().Replace(',', '.'), NumberStyles.Any, cult, out kt2) || kt2 < 0 || kt2 > 1)
                return "Hệ số kiểm tra 2 không hợp lệ (nhập số từ 0 đến 1)";

            if (!double.TryParse(ckStr.Trim().Replace(',', '.'), NumberStyles.Any, cult, out ck) || ck < 0 || ck > 1)
                return "Hệ số cuối kỳ không hợp lệ (nhập số từ 0 đến 1)";

            double tong = Math.Round(cc + kt1 + kt2 + ck, 10);
            if (Math.Abs(tong - 1.0) > 1e-9)
                return $"Tổng 4 hệ số phải bằng 1 (hiện tại: {tong:0.####})";

            return "";
        }
    }
}
