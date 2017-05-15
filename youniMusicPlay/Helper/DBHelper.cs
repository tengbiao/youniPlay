using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace youni.Helper
{
    public class DBHelper
    {
        /// <summary>
        /// 连接字符串 从app.config读取
        /// //"Data Source=.;Initial Catalog=youni;Integrated Security=True";
        /// </summary>
        public static string Connstring = ConfigurationManager.ConnectionStrings["DataBaseConnection"].ToString();
        //连接对象
        private static SqlConnection conn = null;
        private static void InitConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(Connstring);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            if (conn.State == ConnectionState.Broken)
            {
                conn.Close();
                conn.Open();
            }
        }
        public static SqlDataReader GDR(string sqlStr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public static DataTable GDT(string sqlStr)
        {
            InitConnection();
            DataTable table = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sqlStr, conn);
            dap.Fill(table);
            conn.Close();
            return table;
        }
        public static bool ENQ(string sqlStr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }
    }
}