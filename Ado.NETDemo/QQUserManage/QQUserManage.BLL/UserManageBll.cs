using QQUserManage.DAL;
using QQUserManage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQUserManage.BLL
{
    /// <summary>
    /// BLL层的用户管理业务类
    /// </summary>
    public class UserManageBll
    {
        /// <summary>
        /// 管理员登陆
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="userPass">密码</param>
        public int Login(string userName, string userPass)
        {
            var dal = new UserManageDal();
            return dal.Login(userName, userPass);
        }

        /// <summary>
        /// 拿到所有用户
        /// </summary>
        /// <returns></returns>
        public List<UserInfo> GetUserList()
        {
            var list = new List<UserInfo>();
            var dal = new UserManageDal();
            list = dal.GetUserList();
            foreach (var userInfo in list)
            {
                userInfo.LevelName = dal.GetLevelName(userInfo.LevelId);
            }
            return list;
        }

        /// <summary>
        /// 更新用户在线天数
        /// </summary>
        /// <param name="userId">用户编号</param>
        /// <param name="onlineday">在线天数</param>
        /// <returns></returns>
        public int UpdateOnlineDay(int userId, int onlineday)
        {
            int result = 0;
            var dal = new UserManageDal();
            result = dal.UpdateOnlineDay(onlineday, userId);
            return result;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="userId">用户编号</param>
        /// <returns></returns>
        public int Del(int userId)
        {
            var dal = new UserManageDal();
            return dal.Del(userId);
        }
    }
}
