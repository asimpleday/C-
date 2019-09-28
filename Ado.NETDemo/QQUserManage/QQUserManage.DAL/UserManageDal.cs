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
            SqlConnection connection = SQLHelper.GetConnection();
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
            SqlConnection connection = SQLHelper.GetConnection();
            // 打开
            connection.Open();

            // 2、编写sql命令
            StringBuilder sb = new StringBuilder(@"select UserId,UserName,UserPwd,levelid,Email,OnLineDay 
from UserInfo");
            sb.Append(" where isdeleted = 0");

            // 3、创建命令对象
            SqlCommand command = new SqlCommand(sb.ToString(), connection);

            // 4、执行命令
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                UserInfo userInfo = new UserInfo();
                userInfo.UserId = (int)reader["UserId"];
                userInfo.UserName = reader["UserName"].ToString();
                userInfo.LevelId = (int)reader["levelid"];
                userInfo.OnLineDay = (int)reader["OnLineDay"];
                list.Add(userInfo);
            }

            // 5、返回结果

            // 6、关闭连接
            connection.Close();
            return list;
        }

        /// <summary>
        /// 获得等级名称
        /// </summary>
        /// <param name="levelId"></param>
        /// <returns></returns>
        public string GetLevelName(int levelId)
        {
            string levelName = string.Empty;
            // 1、建立连接
            SqlConnection connection = SQLHelper.GetConnection();
            // 打开
            connection.Open();

            // 2、编写sql命令
            StringBuilder sb = new StringBuilder(string.Format("select levelName from level where levelid = {0}", levelId));

            // 3、创建命令对象
            SqlCommand command = new SqlCommand(sb.ToString(), connection);

            // 4、执行命令
            SqlDataReader reader = command.ExecuteReader();

            // 5、返回结果
            if (reader.Read())
            {
                levelName = reader["levelName"].ToString();
            }
            // 6、关闭连接
            connection.Close();

            return levelName;
        }

        /// <summary>
        /// 更新用户在线天数
        /// </summary>
        /// <param name="userId">用户编号</param>
        /// <param name="onlineday">在线天数</param>
        public int UpdateOnlineDay(int userId, int onlineday)
        {
            return SQLHelper.Save(string.Format("update UserInfo set OnLineDay = {0} where UserId = {1}", onlineday, userId));
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="userId">用户编号</param>
        /// <returns></returns>
        public int Del(int userId)
        {
            return SQLHelper.Save(string.Format("update UserInfo set isdeleted = 1 where userId = {0}", userId));
        }
    }
}
