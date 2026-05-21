using System;
using System.Collections.Generic;
using System.Data;
using qldsv.DAL;

namespace qldsv.BLL
{
    internal class KhoaBLL
    {
        public static DataTable GetAllKhoa()
        {
            return KhoaDAL.GetAll();
        }

        public static DataTable SearchKhoa(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return GetAllKhoa();
            
            return KhoaDAL.Search(keyword);
        }

        public static bool ThemKhoa(string maKhoa, string tenKhoa)
        {
            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrWhiteSpace(maKhoa) || string.IsNullOrWhiteSpace(tenKhoa))
                return false;

            // Kiểm tra mã khoa tồn tại
            if (KhoaDAL.KhoaExists(maKhoa))
                return false;

            return KhoaDAL.ThemKhoa(maKhoa, tenKhoa);
        }

        public static bool SuaKhoa(string maKhoa, string tenKhoa)
        {
            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrWhiteSpace(maKhoa) || string.IsNullOrWhiteSpace(tenKhoa))
                return false;

            return KhoaDAL.SuaKhoa(maKhoa, tenKhoa);
        }

        public static bool XoaKhoa(string maKhoa)
        {
            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrWhiteSpace(maKhoa))
                return false;

            return KhoaDAL.XoaKhoa(maKhoa);
        }
    }
}
