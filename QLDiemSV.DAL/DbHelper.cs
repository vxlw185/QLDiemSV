using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QLDiemSV.DAL
{
    public static class DbHelper
    {
        // Thêm <connectionStrings name="QLDiemSV"> vào App.config của GUI
        private static string ConnStr
        {
            get { return ConfigurationManager.ConnectionStrings["QLDiemSV"].ConnectionString; }
        }

        public static DataTable ExecuteQuery(string sql, params SqlParameter[] ps)
        {
            using (var conn = new SqlConnection(ConnStr))
            using (var cmd = new SqlCommand(sql, conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                if (ps != null) cmd.Parameters.AddRange(ps);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static int ExecuteNonQuery(string sql, params SqlParameter[] ps)
        {
            using (var conn = new SqlConnection(ConnStr))
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (ps != null) cmd.Parameters.AddRange(ps);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static object ExecuteScalar(string sql, params SqlParameter[] ps)
        {
            using (var conn = new SqlConnection(ConnStr))
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (ps != null) cmd.Parameters.AddRange(ps);
                conn.Open();
                return cmd.ExecuteScalar();
            }
        }
    }
}
