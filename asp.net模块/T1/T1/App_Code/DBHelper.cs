using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
 

public class DBHelper
{
    //封装了一下添加、删除、修改、查询
    private static string connStr = "server=.;uid=XLJ;pwd=123456;database=MySchool";
    /// <summary>
    /// 执行添加、删除、修改的方法
    /// </summary>
    /// <param name="sql"></param>
    /// <param name="paras"></param>
    /// <returns></returns>
    public static int ExecuteNonQuery(string sql, SqlParameter[] paras = null)
    {
        int result = 0;
        using (SqlConnection conn = new SqlConnection(connStr))
        {
            conn.Open();
            SqlCommand command = new SqlCommand(sql, conn);
            
                if (paras != null)
                    command.Parameters.AddRange(paras);

                result = command.ExecuteNonQuery();
   
        }
        return result;
    }

    /// <summary>
    /// 执行查询并返回第一行的第一列
    /// </summary>
    /// <param name="sql"></param>
    /// <param name="paras"></param>
    /// <returns></returns>
    public static object ExecuteScalar(string sql, SqlParameter[] paras = null)
    {
        object obj = 0;
        using (SqlConnection conn = new SqlConnection(connStr))
        {
            conn.Open();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                if (paras != null)
                    command.Parameters.AddRange(paras);

                obj = (object)command.ExecuteScalar();
            }
        }
        return obj;
    }

    /// <summary>
    /// 执行查询并返回SqlDataReader对象
    /// </summary>
    /// <param name="sql"></param>
    /// <param name="paras"></param>
    /// <returns></returns>
    public static SqlDataReader ExecuteReader(string sql, SqlParameter[] paras = null)
    {
        SqlDataReader reader = null;
        SqlConnection conn = new SqlConnection(connStr);
        conn.Open();
        SqlCommand command = new SqlCommand(sql, conn);
        
            if (paras != null)
                command.Parameters.AddRange(paras);

            reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        

        return reader;
    }

    public static DataTable GetDataTable(string sql, SqlParameter[] paras = null)
    {
        DataTable dt = null;
        using (SqlConnection conn = new SqlConnection(connStr))
        {
            SqlCommand command = new SqlCommand(sql, conn);
            
                if (paras != null)
                    command.Parameters.AddRange(paras);

                dt = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);
                }
            
        }
        return dt;
    }

    public static DataSet GetDataSet(string sql, SqlParameter[] paras = null)
    {
        DataSet ds = null;
        using (SqlConnection conn = new SqlConnection(connStr))
        {
            SqlCommand command = new SqlCommand(sql, conn);
            
                if (paras != null)
                    command.Parameters.AddRange(paras);

                ds = new DataSet();
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(ds);
                }
            
        }
        return ds;
    }




}
