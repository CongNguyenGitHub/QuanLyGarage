using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public int SoXeTiepNhanTrongNgay(DateTime now)
        {
            DataTable dt = XeDAO.Instance.SoXeTiepNhanTrongNgay(now);
            return int.Parse(dt.Rows[0][0].ToString());
        }
        public int ThemXeBUS(string BienSo, string HieuXe, DateTime now)
        {
            return XeDAO.Instance.ThemXeDAO(BienSo, HieuXe, now);
        }
        public bool TiepNhanXe(string HoTen, string BienSo, string DiaChi, string HieuXe, string SDT, DateTime NgayTiepNhan)
        {
            int SoXeTrongNgay = SoXeTiepNhanTrongNgay(NgayTiepNhan);
            int SoXeToiDa = QuyDinhBUS.Instance.LaySoXeSuaToiDa();
            if (SoXeTrongNgay < SoXeToiDa)
            {
                ThemXeBUS(BienSo, HieuXe, NgayTiepNhan);
                KhachHangBUS.Instance.ThemKhachHangBUS(HoTen, SDT, DiaChi);
                return true;
            }            
            return false;
        }

    }
}
