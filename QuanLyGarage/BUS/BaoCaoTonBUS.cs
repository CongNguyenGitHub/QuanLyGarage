using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BaoCaoTonBUS
    {
        private static BaoCaoTonBUS instance;
        public static BaoCaoTonBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BaoCaoTonBUS();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private BaoCaoTonBUS() { }
        public DataTable BaoCaoTon(string Thang, string Nam)
        {
            return BaoCaoTonDAO.Instance.BaoCaoTon(int.Parse(Thang), int.Parse(Nam));
        }
    }
}
