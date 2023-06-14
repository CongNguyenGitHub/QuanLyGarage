using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuNhapVatTuBUS
    {
        private static PhieuNhapVatTuBUS instance;
        public static PhieuNhapVatTuBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuNhapVatTuBUS();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private PhieuNhapVatTuBUS() { }
        public int ThemPhieuNhapVatTu(string ten, string soluong, DateTime now)
        {
            return PhieuNhapVatTuDAO.Instance.ThemPhieuNhapVatTu(ten, int.Parse(soluong), now);
        }
    }
}
