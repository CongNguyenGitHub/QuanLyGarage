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
        public DataTable LayTatCaQuyDinh()
        {
            string query = "LayDuLieuQuyDinh";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int CapNhatQuyDinh(string MaThamSo, int GiaTriMoi)
        {
            int result = 0;
            string query = "ThayDoiQuyDinh @MaThamSo , @GiaTriMoi";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaThamSo, GiaTriMoi });
            return result;
        }
        public DataTable LaySoXeSuaToiDa()
        {
            string query = "SELECT GiaTri FROM THAMSO WHERE MaThamSo = '3'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        
    }
}
