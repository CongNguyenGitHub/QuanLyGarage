using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NguoiDungBUS
    {
        private static NguoiDungBUS instance;
        public static NguoiDungBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new NguoiDungBUS();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private NguoiDungBUS() { }
        public bool KiemTraNguoiDungDaTonTai(string ten, string ngaysinh, int gioitinh, string sdt, string diachi) //true neu chua ton tai nguoi dung
        {
            DataTable result = NguoiDungDAO.Instance.KiemTraNguoiDungDaTonTai( ten, ngaysinh, gioitinh, sdt, diachi);
            if (result.Rows.Count > 0) return true;
            else return false;
        }
        public int ThemNguoiDung(string ten,string ngaysinh, string gioitinh, string sdt, string diachi)  // tương tự như thêm xe, mình phải thêm người dùng trước rồi ms gọi thêm tài khoản, chú ý giới tính trong database la int  0 là con trai, 1 là con gái
        {
            return NguoiDungDAO.Instance.ThemNguoiDung(ten, ngaysinh, int.Parse(gioitinh), sdt, diachi);
        }

    }
}
