using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Click(object sender, EventArgs e)
    {
        // 获取所有信息并去空格
        string userName = this.userName.Text;
        string password = this.passWord.Text;
        string email = this.email.Text;
        string birthday = this.birthday.Text;
        string sql = @"insert into UserInfo(UserName, UserPwd, Email, birthday) values(@UserName, @UserPwd, @Email, @birthday)";

        // 数字、日期、字符串
        SqlParameter[] paras =
        {
            new SqlParameter("@UserName", userName),
            new SqlParameter("@UserPwd", password),
            new SqlParameter("@Email", email),
            new SqlParameter("@birthday", birthday)
        };

        int result = DBHelper.ExecuteNonQuery(sql, paras);

        if (result > 0)
        {
            // Response 输出对象 Request 请求信息
            //Response.Write("<script>alert('注册成功');location.href='login.aspx'</script>");
            Response.Redirect("login.aspx");   // 重定向
        }
        else
        {
            Response.Write("<script>alert('注册失败')</script>");
        }
    }
}