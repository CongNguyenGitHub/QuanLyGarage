using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QuyDinhBUS
    {
        private static QuyDinhBUS instance;
        public static QuyDinhBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new QuyDinhBUS();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private QuyDinhBUS() { }
        public DataTable LayTatCaQuyDinh()
        {
            return DAO.QuyDinhDAO.Instance.LayTatCaQuyDinh();
        }
        public int CapNhatQuyDinh(string MaThamSo, int GiaTriMoi) // truoc khi truyen gia tri moi vao ngyen nho chuyen qua int nha, kiểu như này int gtm = int.Parse(GiaTriMoi);
        {

            return DAO.QuyDinhDAO.Instance.CapNhatQuyDinh(MaThamSo, GiaTriMoi);
            //trả về số hàng update thành công
        }
        public int LaySoXeSuaToiDa()
        {
            DataTable dt = QuyDinhDAO.Instance.LaySoXeSuaToiDa();
            return int.Parse(dt.Rows[0][0].ToString());
        }
    }
}
