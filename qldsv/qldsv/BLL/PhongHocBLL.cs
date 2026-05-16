using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using qldsv.DAL;

namespace qldsv.BLL
{
    internal class PhongHocBLL
    {
        public static DataTable GetAll()
        {
            return PhongHocDAL.GetAll();
        }

        public static string Add(string tenPhong)
        {
            tenPhong = tenPhong?.Trim();
            if (string.IsNullOrEmpty(tenPhong))
                return "Vui lòng nhập tên phòng";
            if (tenPhong.Length > 100)
                return "Tên phòng không được vượt quá 100 ký tự";
            if (PhongHocDAL.TenPhongExists(tenPhong))
                return $"Tên phòng [{tenPhong}] đã tồn tại";
            PhongHocDAL.Add(tenPhong);
            return "";
        }

        public static string Update(int maPhong, string tenPhong)
        {
            tenPhong = tenPhong?.Trim();
            if (maPhong <= 0)
                return "Vui lòng chọn phòng cần sửa";
            if (string.IsNullOrEmpty(tenPhong))
                return "Vui lòng nhập tên phòng";
            if (tenPhong.Length > 100)
                return "Tên phòng không được vượt quá 100 ký tự";
            if (PhongHocDAL.TenPhongExists(tenPhong, excludeId: maPhong))
                return $"Tên phòng [{tenPhong}] đã tồn tại";
            PhongHocDAL.Update(maPhong, tenPhong);
            return "";
        }

        public static string Delete(int maPhong)
        {
            if (maPhong <= 0)
                return "Vui lòng chọn phòng cần xóa";
            if (PhongHocDAL.IsInUse(maPhong))
                return "Phòng này đang có lịch học, không thể xóa";
            PhongHocDAL.Delete(maPhong);
            return "";
        }
    }
}