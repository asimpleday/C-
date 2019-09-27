using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQUserManage.Entity
{
    /// <summary>
    /// 用户信息类
    /// </summary>
    public class UserInfo
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string UserPwd { get; set; }

        public int LevelId { get; set; }

        public string Email { get; set; }

        public int OnLineDay { get; set; }

        public string LevelName { get; set; }
    }
}
