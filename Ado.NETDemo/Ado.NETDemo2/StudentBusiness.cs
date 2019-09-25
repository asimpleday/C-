using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.NETDemo2
{
    /// <summary>
    /// 学生管理系统业务类
    /// </summary>
    public class StudentBusiness
    {
        StudentDao dao = new StudentDao();
        /// <summary>
        /// 获取所有学生
        /// </summary>
        /// <returns></returns>
        public List<Student> GetStudentList()
        {
            List<Student> students = new List<Student>();



            
            SqlDataReader reader = dao.GetDataReader("select StudentNo,StudentName from Student");
            while (reader.Read())
            {
                Student student = new Student();
                student.StudentNo = reader["StudentNo"].ToString();
                student.StudentName = reader["StudentName"].ToString();
                // 组装到学生集合列表中
                students.Add(student);
            }
            // 关闭读取器
            reader.Close();

            // 关闭连接
            dao.connection.Close();
            return students;
        }

        /// <summary>
        /// 增加年级
        /// </summary>
        /// <param name="gradeId"></param>
        /// <param name="gradeName"></param>
        /// <returns></returns>
        public int AddGrade(string gradeId, string gradeName)
        {
            string sql = string.Format("insert into grade([GradeId], [GradeName]) values('{0}', '{1}')", gradeId, gradeName);
            return dao.Save(sql);
        }
    }
}
