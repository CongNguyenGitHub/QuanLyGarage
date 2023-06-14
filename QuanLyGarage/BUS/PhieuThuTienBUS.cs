using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuThuTienBUS
    {
        private static PhieuThuTienBUS instance;
        public static PhieuThuTienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuThuTienBUS();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private PhieuThuTienBUS() { }
        public int LayTienNoKH(string BienSo)  // so tien thu phai <= TienNo nhé nguyên
        {
            DataTable dt = PhieuThuTienDAO.Instance.LayTienNoKH(BienSo);
            return int.Parse(dt.Rows[0][0].ToString());
        }

        public int ThemPhieuThuTien(string BienSo, string SoTienThu, DateTime NgayThu)
        {
            return PhieuThuTienDAO.Instance.ThemPhieuThuTien(BienSo, int.Parse(SoTienThu), NgayThu);
        }

        public DataTable LayThongTinKhachHang(string BienSo) // cai nay vua dung để lấy in4 tự động khi nhập biển số, vừa để dùng để check xem bienso da có trong table phieusauchua hay chua, bang cach gọi va ss if(dt.Rows.Count >0) thi la da lap phieu sua chua roi
        {
            return PhieuThuTienDAO.Instance.LayThongTinKhachHang(BienSo);
            // dt.Rows[0][0]  la hoten
            // 01 la sdt
            // 02 la diachi
        }
    }
}
