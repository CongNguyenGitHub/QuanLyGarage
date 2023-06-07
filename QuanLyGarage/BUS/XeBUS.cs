using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class XeBUS
    {
        private static XeBUS instance;
        public static XeBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new XeBUS();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private XeBUS() { }
        // goi phuong thuc them khach hang trước, xong mới gọi phương thức xêm xe
        // hàm này cg sẽ trả về số thao tác insert thành công như hàm themkhachhangbus
        public int ThemXeBUS(string BienSo, string HieuXe, int MaKH, DateTime now)
        {
            return XeDAO.Instance.ThemXeDAO(BienSo, HieuXe, MaKH, now);
        }
    }
}
