using QQUserManage.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQUserManage
{
    public class UserManage
    {
        /// <summary>
        /// 开始
        /// </summary>
        public void Start()
        {
            bool isLogin = false;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("请输入用户名(#^.^#)：");
                string userName = Console.ReadLine();
                Console.WriteLine("请输入密码o(*￣︶￣*)o：");
                string userPass = Console.ReadLine();
                string message = string.Empty;
                
                // 登陆
                int result = Login(userName, userPass, ref message);
                // 提示
                Console.WriteLine(message);
                if (result > 0)
                {
                    isLogin = true;
                    break;
                }
            }

            if (isLogin)
            {
                // 显示菜单
                ShowMenu();
            }
            else
            {
                Console.WriteLine("您今天输入次数已经达到3次，请明天再试。");
            }

        }

        /// <summary>
        /// 管理员登陆
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="userPass">用户密码</param>
        public int Login(string userName, string userPass, ref string msg)
        {
            var bll = new UserManageBll();
            int result = bll.Login(userName, userPass);
            if (result == 0)
            {
                //Console.WriteLine("用户名或者密码错误");
                msg = "用户名或者密码错误";
            }
            else
            {
                // Console.WriteLine("用户登陆成功");
                msg = "用户登陆成功";
            }
            return result;
        }


        public void ShowMenu()
        {
            Console.WriteLine("-------------------------欢迎登陆QQ用户信息管理系统--------------------------");
            Console.WriteLine("------------------------------------请选择操作键----------------------------");
            Console.WriteLine("1、显示用户信息");
            Console.WriteLine("2、更新在线天数");
            Console.WriteLine("3、添加用户");
            Console.WriteLine("4、更新用户等级");
            Console.WriteLine("5、删除用户");
            Console.WriteLine("6、退出");

            Console.WriteLine("--------------------------------------------------------------------------");
            int num = int.Parse(Console.ReadLine());
            Choice(num);
        }

        /// <summary>
        /// 菜单选择
        /// </summary>
        /// <param name="num"></param>
        public void Choice(int num)
        {
            switch (num)
            {
                case 1:
                    // 显示用户信息
                    GetUserList();
                    break;

                case 2:
                    // 更新在线天数
                    break;

                case 3:
                    // 添加用户
                    break;

                case 4:
                    // 更新用户等级
                    break;

                case 5:
                    // 删除用户
                    break;

                case 6:
                    // 退出
                    break;

                default:
                    break;
            }
        }

        public void GetUserList()
        {
            var bll = new UserManageBll();

            var list = bll.GetUserList();

            foreach (var userInfo in list)
            {
                Console.WriteLine("用户ID:" + userInfo.UserId + ";用户名:" + userInfo.UserName + ";用户等级：" + userInfo.LevelName);
            }
        }


    }
}
