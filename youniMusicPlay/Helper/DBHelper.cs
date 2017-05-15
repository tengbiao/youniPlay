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

        public static DataTable GDT(string sqlStr)
        {
            //using 自动销毁关闭 SqlConnection
            using (SqlConnection conn = new SqlConnection(Connstring))
            {
                DataTable table = new DataTable();
                SqlDataAdapter dap = new SqlDataAdapter(sqlStr, conn);
                dap.Fill(table);
                return table;
            }
        }

        public static bool ENQ(string sqlStr)
        {
            using (SqlConnection conn = new SqlConnection(Connstring))
            {
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}