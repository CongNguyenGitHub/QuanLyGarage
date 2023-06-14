using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuThuTienDAO
    {
        private static PhieuThuTienDAO instance;
        public static PhieuThuTienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuThuTienDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private PhieuThuTienDAO() { }
        public DataTable LayTienNoKH(string BienSo)
        {
            string query = "SELECT TienNo from KHACHHANG as KH, XE WHERE XE.BienSo = '" + BienSo + "' and XE.MaKH = KH.MaKH";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int ThemPhieuThuTien(string BienSo, int SoTienThu, DateTime NgayThu)
        {
            string query = " ThemPhieuThuTien @BienSo , @TienThu , @NgayThuTien";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { BienSo, SoTienThu, NgayThu });
        }

        public DataTable LayThongTinKhachHang(string BienSo)
        {
            string query = " LayThongTinKhachHang @BienSo";
            return DataProvider.Instance.ExecuteQuery(query, new object[] {BienSo});
        }
    }
}
