using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuSuaChuaBUS
    {
        private static PhieuSuaChuaBUS instance;
        public static PhieuSuaChuaBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuSuaChuaBUS();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private PhieuSuaChuaBUS() { }
        public DataTable LayBienSoDaTiepNhan()
        {
            return PhieuSuaChuaDAO.Instance.LayBienSoDaTiepNhan();
        }
        public DataTable LayDonGiaAndSoLuongVatTu(string ten)
        {
            return PhieuSuaChuaDAO.Instance.LayDonGiaAndSoLuongVatTu(ten);
            // dt.Rows[0][0] la don gia
            // dt.Rows[0][1] la sl hien tai trong kho
        }
        public DataTable KiemTraXeDaDuocTiepNhan(string bienso)
        {
            return PhieuSuaChuaDAO.Instance.KiemTraXeDaDuocTiepNhan(bienso);
        }
     
        public int LayTienCong(string ten)
        {
            DataTable dt = PhieuSuaChuaDAO.Instance.LayTienCong(ten);
            return int.Parse(dt.Rows[0][0].ToString());
        }
        public int ThemPhieuSuaChua(string BienSo, DateTime NgaySua, int TongTien)
        {
            return PhieuSuaChuaDAO.Instance.ThemPhieuSuaChua(BienSo, NgaySua, TongTien);
        }
        public int ThemCT_ThemPhieuSuaChua(string TenVatTu, string TenTienCong, int SoLuong)
        {
            return PhieuSuaChuaDAO.Instance.ThemCT_ThemPhieuSuaChua(TenVatTu, TenTienCong, SoLuong);
        }

    }
}
