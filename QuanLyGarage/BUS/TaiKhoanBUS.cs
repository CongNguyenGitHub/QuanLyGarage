using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;
        public static TaiKhoanBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanBUS();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private TaiKhoanBUS() { }
        public DataTable LayToanBoThongTinTaiKhoan(string TaiKhoan, string MatKhau)
        {
            return DAO.TaiKhoanDAO.Instance.LayToanBoThongTinTaiKhoan(TaiKhoan, MatKhau);
        }
        // huong dan dung
        // datatable dt = DAO.Instance.LayToanBoThongTinTaiKhoan
        // dt.Rows[0][0].toString() = họ tên
        // dt.Rows[0][1].toString() = ngày sinh
        // dt.Rows[0][2].toString() = giới tính 0 la trai,  1 la gai
        // dt.Rows[0][3].toString()= sodt
        //dt.Rows[0][4].toString() = diachi
        //dt.Rows[0][5].toString() = tendangnhap
        //dt.Rows[0][6].toString() = matkhau
        //dt.Rows[0][7].toString() = quyenhan
        public int CapNhatMatKhau(string User, string Pass, string newPass) // tra ve so hanh updaate thanh conng >0 là thành công
        {
            return DAO.TaiKhoanDAO.Instance.CapNhatMatKhau(User, Pass, newPass);
        }
        public bool checkDangNhapBUS(string TaiKhoan, string MatKhau)
        {
            DataTable result = TaiKhoanDAO.Instance.DangNhapDAO(TaiKhoan, MatKhau);
            if (result.Rows.Count > 0) return true;
            else return false;
        }
        public int ThemTaiKhoan(string User, string Pass, string QuyenHan)  // trẩ về số hàng insert thành công, >0 là thành công
        {
            return DAO.TaiKhoanDAO.Instance.ThemTaiKhoan(User, Pass, int.Parse(QuyenHan));
        }
        public bool KiemTraTenDNTonTai(string User) // true thi chua tồn tại, mà false thì đã có trong database rồi
        {
            DataTable result = TaiKhoanDAO.Instance.KiemTraTenDNTonTai(User);
            if (result.Rows.Count > 0) return false;
            else return true;
        }
        public string LayQuyenHan(string User, string Pass)
        {
            return TaiKhoanDAO.Instance.LayQuyenHan(User, Pass);
        }



    }
}
