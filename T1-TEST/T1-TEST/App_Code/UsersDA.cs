using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// UsersDA 的摘要说明
/// </summary>
public class UsersDA
{
    SqlConnection conn = null;
    SqlCommand cmd = null;
    public UsersDA()
    {
        conn = new SqlConnection("server=.;user=sa;pwd=123456;database=Test");
        cmd = conn.CreateCommand();
    }

    /// <summary>
    /// 用户验证
    /// </summary>
    /// <param name="userName">用户名</param>
    /// <param name="password">密码</param>
    /// <returns></returns>
    public bool Select(string userName, string password)
    {
        bool result = false;
        cmd.CommandText = $"select * from student where sname = '{userName}' and sno = '{password}'";
        cmd.Parameters.Clear();
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            result = true;
        }
        conn.Close();
        return result;
    }
}