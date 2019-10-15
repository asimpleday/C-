using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student(1005, "tom", 26);
            Student stu2 = new Student(1003, "jack", 18);
            Student stu3 = new Student(1001, "alice", 9);
            Student stu4 = new Student(1002, "david", 36);
            Student stu5 = new Student(1004, "jane", 19);

            List<Student> stuList = new List<Student>()
            {
                stu1,
                stu2,
                stu3,
                stu4,
                stu5
            };

            Console.WriteLine("--------默认排序前--------");
            foreach (Student student in stuList)
            {
                Console.WriteLine(student.StudentId + "\t" + student.StudentName + "\t" + student.StudentAge);
            }

            Console.WriteLine("--------默认排序后--------");
            stuList.Sort();
            foreach (Student student in stuList)
            {
                Console.WriteLine(student.StudentId + "\t" + student.StudentName + "\t" + student.StudentAge);
            }

            Console.WriteLine("--------姓名升序后--------");
            stuList.Sort(new StudentNameASC());
            foreach (Student student in stuList)
            {
                Console.WriteLine(student.StudentId + "\t" + student.StudentName + "\t" + student.StudentAge);
            }

            Console.WriteLine("--------姓名降序后--------");
            stuList.Sort(new StudentNameDESC());
            foreach (Student student in stuList)
            {
                Console.WriteLine(student.StudentId + "\t" + student.StudentName + "\t" + student.StudentAge);
            }

            Console.WriteLine("--------年龄升序后--------");
            stuList.Sort(new StudentAgeASC());
            foreach (Student student in stuList)
            {
                Console.WriteLine(student.StudentId + "\t" + student.StudentName + "\t" + student.StudentAge);
            }

            Console.WriteLine("--------年龄降序后--------");
            stuList.Sort(new StudentAgeDESC());
            foreach (Student student in stuList)
            {
                Console.WriteLine(student.StudentId + "\t" + student.StudentName + "\t" + student.StudentAge);
            }
        }
    }
}
