using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.NETDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入用户名^_^");
            string userName = Console.ReadLine();
            Console.WriteLine("请输入密码o(*￣︶￣*)o");
            string userPwd = Console.ReadLine();

            StudentDao dao = new StudentDao();
            string msg = string.Empty;

            if (dao.ValidataUser(userName, userPwd, ref msg))
            {
                string email = dao.Login(userName, userPwd);
                Console.WriteLine("恭喜{0},{1}", email, msg);
            }
            else
            {
                Console.WriteLine(msg);
            }



        }
    }
}
