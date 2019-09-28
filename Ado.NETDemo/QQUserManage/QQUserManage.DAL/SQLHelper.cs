using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQUserManage.DAL
{
    /// <summary>
    /// 数据库帮助类
    /// </summary>
    public class SQLHelper
    {
        // 得到连接字符串
        public static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        /// <summary>
        /// 创建连接对象
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connString);
            return connection;
        }

        /// <summary>
        /// 增加、修改、删除
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Save(string sql)
        {
            // 1、建立连接
            SqlConnection connection = SQLHelper.GetConnection();

            // 2、打开
            connection.Open();

            // 3、编写sql语句
            // StringBuilder sql = new StringBuilder(string.Format("update UserInfo set OnLineDay = {0} where UserId = {1}", onlineday, userId));
            // 4、创建命令对象
            SqlCommand command = new SqlCommand(sql, connection);

            // 5、 执行命令
            int result = (int)command.ExecuteNonQuery();

            // 6、 关闭连接
            connection.Close();

            return result;
        }
    }

   
}
