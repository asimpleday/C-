using BLL;
using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
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
            StudentBusiness buiness = new StudentBusiness();
            string msg = string.Empty;

            if (dao.ValidataUser(userName, userPwd, ref msg))
            {
                string email = dao.Login(userName, userPwd);
                Console.WriteLine("恭喜{0},{1}", email, msg);

                // 选择
                Console.WriteLine("请选择");
                // 1、统计学生人数
                // 2、查询学生名单
                // 3、新增年级
                Console.WriteLine("1、统计学生人数");
                Console.WriteLine("2、查询学生名单");
                Console.WriteLine("3、新增年级");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("统计学生人数");
                        break;
                    case 2:
                        Console.WriteLine("查询学生名单");

                        List<Student> students = buiness.GetStudentList();
                        foreach (var student in students)
                        {
                            Console.WriteLine(student.StudentName + "————" + student.StudentNo);
                        }
                        break;
                    case 3:
                        Console.WriteLine("请输入年级id");
                        string gradeId = Console.ReadLine();
                        Console.WriteLine("请输入年级名称");
                        string gradeName = Console.ReadLine();
                        int count = buiness.AddGrade(gradeId, gradeName);
                        if (count > 0)
                        {
                            Console.WriteLine("增加成功");
                        }
                        else
                        {
                            Console.WriteLine("增加失败");
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
