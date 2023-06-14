using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BaoCaoTonDAO
    {
        private static BaoCaoTonDAO instance;
        public static BaoCaoTonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BaoCaoTonDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private BaoCaoTonDAO() { }
        public DataTable BaoCaoTon(int Thang, int Nam)
        {
            string query = "BaoCaoTonKho45 @Thang , @Nam";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { Thang, Nam });
        }
    }
}
