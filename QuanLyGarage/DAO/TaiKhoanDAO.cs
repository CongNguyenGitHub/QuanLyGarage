using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAO
{
    public class TaiKhoanDAO
    {
        //Design patern Singleton
        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private TaiKhoanDAO() { }
        public DataTable DangNhapDAO(string TaiKhoan, string MatKhau)
        {
            string query = "usp_dangnhap @TenDN , @MatKhau"; // gọi procedure, chú ý trước sau dấu , phải có cách

            return DataProvider.Instance.ExecuteQuery(query, new object[] { TaiKhoan, MatKhau }); // truyền parameter la taikhoan va matkhau
            // DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { TaiKhoan, MatKhau });
            // return result.Rows.Count > 0;
            // nguyệt gọi hàm này của t và kiểm tra số hàng của data trả về nếu hơn 1 hàng thì return true, else false
            // lm tương tự như file bọn kia á nguyệt
        }
        public string LayQuyenHan(string User, string Pass)
        {
            string query = "usp_dangnhap @TenDN , @MatKhau";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { User, Pass });

            string qh = result.Rows[0][4].ToString();
            return qh;
        }

        public DataTable LayToanBoThongTinTaiKhoan(string User, string Pass) 
        {
            string query = "LayToanBoThongTinTaiKhoan @TenDN , @MatKhau";
        
            return DataProvider.Instance.ExecuteQuery(query, new object[] { User, Pass });
        }

        public int CapNhatMatKhau(string User, string Pass, string newPass) 
        {
            int result = 0;
            string query = "CapNhatMatKhau @TenDN , @MatKhau , @MatKhauMoi";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { User, Pass, newPass });
            return result;
        }
        public DataTable KiemTraTenDNTonTai(string User)
        {
            string query = "KiemTraTenDNTonTai @TenDN";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { User }); 
        }
        public int ThemTaiKhoan(string User, string Pass, int QuyenHan)
        {
          
            string query = "ThemTaiKhoan @TenDN , @MatKhau , @QuyenHan";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { User, Pass, QuyenHan });
        }
    }
}
