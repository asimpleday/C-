using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.NETDemo
{
    public class StudentDao
    {
        /// <summary>
        /// 验证用户是否存在
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool ValidataUser(string userName, string password, ref string message)
        {
            // 1、编写连接字符串
            //string connectionString = "server=.;uid=XLJ;pwd=123456;database=Mydata;";
            //string connectionString = "Data Source=.;Initial Catalog=Mydata;Persist Security Info=True;User ID=XLJ;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;Password=123456;";
            string connectionString = ConfigurationManager.ConnectionStrings["MyschoolConnectionString"].ToString();

            // 2、建立连接
            SqlConnection connection = new SqlConnection(connectionString);
            // connection.ConnectionString = connectionString;

            bool result = false;
            try
            {
                // 3、打开连接
                connection.Open();
                // Console.WriteLine("连接打开成功");

                // 4、实现登陆功能
                SqlCommand command = new SqlCommand();
                //command.CommandText = string.Format("select count(*) from Student where StudentName='{0}' and LoginPwd='{1}'", userName, userPwd);
                //command.CommandText = $"select count(*) from Student where StudentName='{userName}' and LoginPwd='{password}'";
                StringBuilder sb = new StringBuilder("select count(*) from Student");
                sb.AppendFormat(" where StudentName='{0}' and LoginPwd='{1}'", userName, password);
                command.CommandText = sb.ToString();
                command.Connection = connection;

                // 5、执行命令
                int num = (int)command.ExecuteScalar();
                if (num > 0)
                {
                    result = true;
                    message = "登陆成功";
                }
                else
                {
                    message = "用户名或者密码有误";
                }
                
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine("数据库访问异常~" + sqlException.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("程序出现问题，请联系管理员。" + ex.Message);
            }
            finally
            {
                // 6、关闭连接
                connection.Close();
                //Console.WriteLine("连接关闭成功");
            }

            return result;
        }

        /// <summary>
        /// 实现登陆获取邮箱
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string Login(string userName, string password)
        {
            // 1、编写连接字符串
            //string connectionString = "server=.;uid=XLJ;pwd=123456;database=Mydata;";
            //string connectionString = "Data Source=.;Initial Catalog=Mydata;Persist Security Info=True;User ID=XLJ;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;Password=123456;";
            string connectionString = ConfigurationManager.ConnectionStrings["MyschoolConnectionString"].ToString();

            // 2、建立连接
            SqlConnection connection = new SqlConnection(connectionString);
            // connection.ConnectionString = connectionString;

            string result = string.Empty;
            try
            {
                // 3、打开连接
                connection.Open();
                // Console.WriteLine("连接打开成功");

                // 4、实现登陆功能
                SqlCommand command = new SqlCommand();
                //command.CommandText = string.Format("select count(*) from Student where StudentName='{0}' and LoginPwd='{1}'", userName, userPwd);
                command.CommandText = $"select * from Student where StudentName='{userName}' and LoginPwd='{password}'";
                command.Connection = connection;

                // 5、执行命令
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                result = reader["email"].ToString();
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine("数据库访问异常~" + sqlException.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("程序出现问题，请联系管理员。" + ex.Message);
            }
            finally
            {
                // 6、关闭连接
                connection.Close();
                //Console.WriteLine("连接关闭成功");
            }

            return result;
        }
    }
}
