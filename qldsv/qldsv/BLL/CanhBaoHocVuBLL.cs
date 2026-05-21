using qldsv.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace qldsv.BLL
{
    public class CanhBaoHocVuBLL
    {
        public static DataTable GetByGiangVien(string maGiangVien)
        {
            return CanhBaoHocVuDAL.GetByGiangVien(maGiangVien);
        }

        public static DataTable GetLopByGiangVien(string maGiangVien)
        {
            return CanhBaoHocVuDAL.GetLopByGiangVien(maGiangVien);
        }

        public static DataTable GetHocKyByGiangVien(string maGiangVien)
        {
            return CanhBaoHocVuDAL.GetHocKyByGiangVien(maGiangVien);
        }
    }
}
