using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QuyDinhDAO
    {
        private static QuyDinhDAO instance;
        public static QuyDinhDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new QuyDinhDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private QuyDinhDAO() { }
        
        public DataTable LaySoXeSuaToiDa()
        {
            string query = "SELECT GiaTri FROM THAMSO WHERE MaThamSo = '3'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        
    }
}
