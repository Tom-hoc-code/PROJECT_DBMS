using Microsoft.Data.SqlClient;
using PROJECT_DBMS.connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PROJECT_DBMS.SQL
{
    public class NhanvienQuery
    {
        public static DataTable GetAllNhanVien()
        {
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 10 * FROM NhanVien", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ ERROR: {ex.Message}");
                throw;
            }
        }

        public static DataTable SearchNhanVien(string keyword)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = @"
            SELECT * 
            FROM NhanVien
            WHERE MANV LIKE '%' + @keyword + '%' 
                OR HONV LIKE '%' + @keyword + '%'
               OR TENNV LIKE '%' + @keyword + '%'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@keyword", keyword);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable ApplySort(string orderBy = "")
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM NhanVien";

                    if (!string.IsNullOrEmpty(orderBy))
                    {
                        query += " ORDER BY " + orderBy;
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu nhân viên: " + ex.Message);
            }
            return dt;
        }
    }
}
