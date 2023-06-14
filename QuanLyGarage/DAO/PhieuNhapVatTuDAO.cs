using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuNhapVatTuDAO
    {
        private static PhieuNhapVatTuDAO instance;
        public static PhieuNhapVatTuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuNhapVatTuDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private PhieuNhapVatTuDAO() { }
        
        public int ThemPhieuNhapVatTu(string ten, int soluong, DateTime now)
        {
            string query = "ThemPhieuNhapVatTu @TenVatTu , @SoLuong , @ThoiDiem";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, soluong, now });
        }

    }
}
