using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.NETDemo2
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

                // 选择
                Console.WriteLine("请选择");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("统计学生人数");
                        break;
                    case 2:
                        Console.WriteLine("查询学生名单");
                        StudentBusiness buiness = new StudentBusiness();
                        List<Student> students = buiness.GetStudentList();
                        foreach (var student in students)
                        {
                            Console.WriteLine(student.StudentName + "————" + student.StudentNo);
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine(msg);
            }
        }
    }
}
