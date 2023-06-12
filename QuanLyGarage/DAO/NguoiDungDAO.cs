using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NguoiDungDAO
    {
        private static NguoiDungDAO instance;
        public static NguoiDungDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NguoiDungDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private NguoiDungDAO() { }

        public int ThemNguoiDung(string ten, string ngaysinh, int gioitinh, string sdt, string diachi)
        {
            string query = "ThemNguoiDung @TenND , @NgaySinh , @GioiTinh , @DienThoai , @DiaChi";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, ngaysinh, gioitinh, sdt, diachi });
        }
    }
}
