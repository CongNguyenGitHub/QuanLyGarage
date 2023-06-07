using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhachHangBUS
    {
        private static KhachHangBUS instance;
        public static KhachHangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangBUS();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private KhachHangBUS() { }

        // Nguyên gọi phương thức này ra, phương thức này sẽ thực hiện gọi hàm trong DAO và thực hiên insert dữ liệu vào khách hàng
        // giá trị trả về của phương thức này là 1 số nguyên cho biết số thao tác thêm, xóa, sửa thành công, ở đây là phương thức thêm
        // nên bọn kia mới gọi biến test = phương thức đó, trong cái event xác nhận á
        public int ThemKhachHangBUS(string ten, string sdt, string diachi)
        {
            return KhachHangDAO.Instance.ThemKhachHangDAO(ten, sdt, diachi);
        }

    }
}
