using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Sort
{
    class Student:IComparable<Student>   // 默认的排序可以不写，因为下面多个排序类可以实现
    {
        public Student()
        {

        }

        // 构造方法
        public Student(int studentId, string studentName, int sutdentAge)
        {
            this.StudentId = studentId;
            this.StudentName = studentName;
            this.StudentAge = sutdentAge;
        }

        // 学号
        public int StudentId { get; set; }
        
        // 姓名
        public string StudentName { get; set; }

        // 年龄
        public int StudentAge { get; set; }

        /// <summary>
        /// 默认的排序接口，根据学号升序排序
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Student other)
        {
            return this.StudentId.CompareTo(other.StudentId);
        }
    }

    #region 排序
    /// <summary>
    /// 根据姓名升序排序
    /// </summary>
    class StudentNameASC : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.StudentName.CompareTo(y.StudentName);
        }
    }

    /// <summary>
    /// 根据学号的降序排序
    /// </summary>
    class StudentNameDESC : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return y.StudentName.CompareTo(x.StudentName);
        }
    }

    /// <summary>
    /// 根据年龄的升序进行排序
    /// </summary>
    class StudentAgeASC : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.StudentAge.CompareTo(y.StudentAge);
        }
    }

    /// <summary>
    /// 根据年龄的降序进行排序
    /// </summary>
    class StudentAgeDESC : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return y.StudentAge.CompareTo(x.StudentAge);
        }
    }
    #endregion

}
