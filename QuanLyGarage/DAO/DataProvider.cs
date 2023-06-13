using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        //Design patern Singleton để chỉ duy nhất 1 dataprovider tồn tại trong chương trình, tránh việc khởi tạo lại nhiều dataprovider
        private static DataProvider instance;//tạo 1 đối tượng static tên instance kiểu dataprovider 
        private DataProvider() { }
        private string connectionSTR = @"Data Source=MSI\HDT;Initial Catalog=QuanLyGarage;Integrated Security=True";
        //private string connectionSTR = @"Data Source =LAPTOP-4CPH3R26;Initial Catalog = QuanLyGarage; Integrated Security = True"; // cái này đợi tùng làm xong mới có 
        //private string connectionSTR = @"Data Source=DESKTOP-9MK74VM;Initial Catalog=QuanLyGarage;Integrated Security=True";
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { DataProvider.instance = value; } //private để chỉ nội bộ trong class ms được thay đổi dlieu
        }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable(); // khởi tạo data

            using (SqlConnection connection = new SqlConnection(connectionSTR)) // ket thuc khoi lenh trong using thì nó se tự giải phóng
            {
                connection.Open(); //mo ket nối

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data); // đẩy dữ liệu truy vấn được vào data

                connection.Close(); //đóng kết nối
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null) // số dòng thành công khi insert, update, detele
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null) // đếm số lượng COUNT, trả về sl đó  
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }

        public void UpdateDatabase(string query, object[] parameter = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
