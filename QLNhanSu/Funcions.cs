using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DataAccess.Web;
using DataLayer;

namespace QLNhanSu
{
    public class Funcions
    {
        //Đếm số ngày làm việc trong tháng
        public static int demSoNgayLamViecTrongThang(int thang, int nam)
        {
            int dem = 0;
            DateTime f = new DateTime(nam, thang, 01);
            int x = f.Month + 1;
            while (f.Month < x)
            {
                dem = dem + 1;
                if (f.DayOfWeek == DayOfWeek.Sunday)
                {
                    dem = dem - 1;
                }
                f = f.AddDays(1);
            }
            return dem;
        }
        public static int laySoNgayCuaThang(int thang, int nam)
        {
            return DateTime.DaysInMonth(nam, thang);
        }
        public static string layThuTrongTuan(int nam, int thang, int ngay)
        {
            string thu = "";
            DateTime newDate = new DateTime(nam, thang, ngay);

            // Tạo từ điển để ánh xạ các ngày trong tuần sang tiếng Việt
            Dictionary<string, string> daysOfWeek = new Dictionary<string, string>
            {
                { "Monday", "Thứ hai" },
                { "Tuesday", "Thứ ba" },
                { "Wednesday", "Thứ tư" },
                { "Thursday", "Thứ năm" },
                { "Friday", "Thứ sáu" },
                { "Saturday", "Thứ bảy" },
                { "Sunday", "Chủ nhật" }
            };

            // Lấy tên ngày trong tuần bằng tiếng Anh
            string englishDay = newDate.DayOfWeek.ToString();

            // Kiểm tra và ánh xạ sang tiếng Việt
            if (daysOfWeek.TryGetValue(englishDay, out thu))
            {
                return thu;
            }
            else
            {
                return "Không xác định";
            }
            
        }
        //Khai báo 1 biến SqlConnection
        static SqlConnection con = new SqlConnection();

        //Hàm tạo kết nối
        public static void taoKetNoi()
        {
            //Cấu trúc chuỗi kết nối đến CSDL SQLServer
            con.ConnectionString = "Data Source=.;Initial Catalog=QuanLyNhanSu_Master;User ID=sa;Password=123456789;TrustServerCertificate=True";
            try
            {
                con.Open();//Mở kết nối đến CSDL
            }
            catch (Exception)
            {
                throw;
            }
        }

        //hàm đóng kết nối
        public static void dongKetNoi()
        {
            con.Close();
        }

        //hàm đỗ dữ liệu vào datatable
        public static DataTable getData(string query)
        {
            taoKetNoi();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(tb);
            dongKetNoi();
            return tb;
        }

        //hàm lấy dữ liệu bằng Dataset
        public static DataSet getDataSet(string query)
        {
            taoKetNoi();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        //hàm insert/update dữ liệu
        public static void execQuery(string qr)
        {
            taoKetNoi();
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dongKetNoi();
        }
        

        public class AutoCodeGenerator
        {
            private string connectionString = "Data Source=.;Initial Catalog=QuanLyNhanSu_Master;User ID=sa;Password=123456789;TrustServerCertificate=True";

            public string CreateAutoCode(string KH, string table, string columnName)
            {
                string maxCode = GetMaxCodeFromDatabase(table, columnName, KH);

                if (maxCode == null)
                {
                    return $"{KH}00001";
                }
                else
                {
                    int currentNumber = int.Parse(maxCode.Substring(KH.Length));
                    int newNumber = currentNumber + 1;
                    return $"{KH}{newNumber:00000}";
                }
            }

            private string GetMaxCodeFromDatabase(string table, string columnName, string KH)
            {
                string query = $"SELECT MAX({columnName}) FROM {table} WHERE {columnName} LIKE '{KH}%'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    object result = command.ExecuteScalar();

                    return result != DBNull.Value ? result.ToString() : null;
                }
            }

            
        }
    }
}
