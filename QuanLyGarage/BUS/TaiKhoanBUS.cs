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
        public bool checkDangNhapBUS(string TaiKhoan, string MatKhau)
        {
            DataTable result = TaiKhoanDAO.Instance.DangNhapDAO(TaiKhoan, MatKhau);
            if (result.Rows.Count > 0) return true;
            else return false;
        }
        public string LayQuyenHan(string User, string Pass)
        {
            return TaiKhoanDAO.Instance.LayQuyenHan(User, Pass);
        }



    }
}
