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
            return list;
        }
    }
}
