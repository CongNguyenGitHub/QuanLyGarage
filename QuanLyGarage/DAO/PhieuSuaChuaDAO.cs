using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuSuaChuaDAO
    {
        private static PhieuSuaChuaDAO instance;
        public static PhieuSuaChuaDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuSuaChuaDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private PhieuSuaChuaDAO() { }
        public DataTable LayBienSoDaTiepNhan()
        {
            string query = "LayBienSoDaTiepNhan";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable LayDonGiaAndSoLuongVatTu(string ten)
        {
            string query = "LayDonGiaAndSoLuongVatTu @TenVatTu";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { ten });
        }
        public DataTable KiemTraXeDaDuocTiepNhan(string bienso)
        {
            string query = "KiemTraXeDaDuocTiepNhan @BienSo";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { bienso });
        }

        public DataTable LayTienCong(string ten)
        {
            string query = "LayTienCong @TenTienCong";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { ten });
        }
        public int ThemPhieuSuaChua(string BienSo, DateTime NgaySua, int TongTien)
        {
            string query = "ThemPhieuSuaChua @Bienso , @NgaySuaChua , @TongTien";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { BienSo, NgaySua, TongTien });
        }
        public int ThemCT_ThemPhieuSuaChua(string TenVatTu, string TenTienCong, int SoLuong)
        {
            string query = "ThemCT_PhieuSuaChua @TenVatTu , @TenTienCong , @SoLuong";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { TenVatTu, TenTienCong, SoLuong });
        }

    }
}
