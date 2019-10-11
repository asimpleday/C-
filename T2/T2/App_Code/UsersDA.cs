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

    public List<Users> Select()
    {
        List<Users> list = new List<Users>();
        cmd.CommandText = "select * from student";
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                Users user = new Users();
                user.UserName = dr["sname"].ToString();
                user.UserNo = dr["sno"].ToString();
                list.Add(user);
            }
        }
        conn.Close();
        return list;
    }
}