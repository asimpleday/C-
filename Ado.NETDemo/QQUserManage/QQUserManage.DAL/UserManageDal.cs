using QQUserManage.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQUserManage.DAL
{
    public class UserManageDal
    {
        /// <summary>
        /// 管理员登陆
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="userPass">密码</param>
        public int Login(string userName, string userPass)
        {
            // 1、建立连接
            // 得到连接字符串
            string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
            // 真正的连接
            SqlConnection connection = new SqlConnection(connString);
            // 打开
            connection.Open();

            // 2、编写sql命令
            StringBuilder sb = new StringBuilder(string.Format("select count(*) from admin where LoginId = '{0}' and LoginPwd = '{1}'", userName, userPass));

            // 3、创建命令对象
            SqlCommand command = new SqlCommand(sb.ToString(), connection);

            // 4、执行命令
            int result = (int)command.ExecuteScalar();

            // 5、返回结果

            // 6、关闭连接
            connection.Close();

            return result;
        }

        /// <summary>
        /// 获得所有用户
        /// </summary>
        /// <returns></returns>
        public List<UserInfo> GetUserList()
        {
            var list = new List<UserInfo>();
            // 1、建立连接
            // 得到连接字符串
            string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
            // 真正的连接
            SqlConnection connection = new SqlConnection(connString);
            // 打开
            connection.Open();

            // 2、编写sql命令
            StringBuilder sb = new StringBuilder(@"select UserId,UserName,UserPwd,l.LevelName,Email,OnLineDay 
from UserInfo u
left
join Level l on u.LevelId = l.LevelId; ");

            // 3、创建命令对象
            SqlCommand command = new SqlCommand(sb.ToString(), connection);

            // 4、执行命令
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                UserInfo userInfo = new UserInfo();
                userInfo.UserId = (int)reader["UserId"];
                userInfo.UserName = reader["UserName"].ToString();
                userInfo.LevelName = reader["LevelName"].ToString();
                list.Add(userInfo);
            }

            // 5、返回结果

            // 6、关闭连接
            connection.Close();
            return list;
        }
    }
}
