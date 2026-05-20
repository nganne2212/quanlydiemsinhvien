using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qldsv.BLL
{
    internal class DSLHocPhanBLL
    {
        /// <summary>
        /// Lấy toàn bộ lớp học phần của giảng viên.
        /// </summary>
        public static DataTable GetByGiangVien(string maGV)
            => DAL.DSLHocPhanDAL.GetByGiangVien(maGV);

        /// <summary>
        /// Lấy danh sách học kỳ để hiển thị lên ComboBox lọc.
        /// </summary>
        public static DataTable GetHocKyByGiangVien(string maGV)
            => DAL.DSLHocPhanDAL.GetHocKyByGiangVien(maGV);
    }
}
