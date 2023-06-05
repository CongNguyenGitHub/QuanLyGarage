using DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DangNhapBUS
    {
        private static DangNhapBUS instance;
        public static DangNhapBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DangNhapBUS();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private DangNhapBUS() { }
        public bool checkDangNhapBUS(string TaiKhoan, string MatKhau)
        {
            DataTable result = TaiKhoanDAO.Instance.DangNhapDAO(TaiKhoan , MatKhau);
            if (result.Rows.Count > 0) return true;
            else return false;
        }
    }
}
