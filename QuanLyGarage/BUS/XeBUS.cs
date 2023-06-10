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
        public DataTable TimKiemMotDoiSo(string DuLieu)  // cái này là nhập 1 trong 2 ô rồi bấm tìm kiếm
        {
            return XeDAO.Instance.TimKiemMotDoiSo(DuLieu);
        }

        public DataTable TimKiemHaiDoiSo(string BienSo, string HieuXe) // cái này là 2 ô đều được nhập rồi ms bấm tìm kiếm
        {
            return XeDAO.Instance.TimKiemHaiDoiSo(BienSo, HieuXe);
        }
        public DataTable CacXeDaTiepNhan()
        {
            return XeDAO.Instance.CacXeDaTiepNhan();
        }
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
                KhachHangBUS.Instance.ThemKhachHangBUS(HoTen, SDT, DiaChi);
                ThemXeBUS(BienSo, HieuXe, NgayTiepNhan);
                return true;
            }            
            return false;
        }

    }
}
