using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Connection
    {
        private static SqlConnection conn;

        public static void connect()
        {
            // Đăng nhập của Phong
            //string s = "Data Source=PHONYY\\DANGMINHPHONG; Initial Catalog=database_v1; Integrated Security=True;";
            // Đăng nhập của Hưng
            string s = "Data Source=MSI\\SQLEXPRESS; Initial Catalog=database_v1; Integrated Security=True;";
            conn = new SqlConnection(s);
            conn.Open();

        }

        public static bool actionQuery(string sql)
        {
            try
            {
                connect();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in actionQuery: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public static DataTable selectQuery(string sql)
        {
            connect();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

    }
}