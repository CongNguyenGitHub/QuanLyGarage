using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class XeDAO
    {
        private static XeDAO instance;
        public static XeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new XeDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private XeDAO() { }
        public DataTable TimKiemMotDoiSo(string DL)
        {
            string query = "TimKiemMotDoiSo @DuLieu";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { DL });
        }

        public DataTable TimKiemHaiDoiSo(string BienSo, string HieuXe)
        {
            string query = "TimKiemHaiDoiSo @BienSo , @HieuXe";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { BienSo, HieuXe });
        }

        public DataTable CacXeDaTiepNhan()
        {
            string query = "XemDanhSachXe";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SoXeTiepNhanTrongNgay(DateTime now)
        {
            string query = "SELECT COUNT(BienSo) FROM XE WHERE day(NgayTiepNhan) = " + now.Day + " and month(NgayTiepNhan) = " + now.Month + " and year(NgayTiepNhan) = " + now.Year;
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int ThemXeDAO(string BienSo, string HieuXe, DateTime now) // now nguyên lấy thời gian của hiện tại nha
        {
            string query = "ThemXe @BienSo , @HieuXe , @NgayTiepNhan";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { BienSo, HieuXe, now });
        }


    }
}

