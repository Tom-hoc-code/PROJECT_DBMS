using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJECT_DBMS.connection;


namespace PROJECT_DBMS.SQL
{
    public class NhanvienQuery
    {
        public static DataTable GetAllNhanVien()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM NhanVien";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(dt);
                    MessageBox.Show("được gọi!");
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi lấy dữ liệu nhân viên: " + ex.Message);
                }
            }

            return dt;
        }
    }
}
