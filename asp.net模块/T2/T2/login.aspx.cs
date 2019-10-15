using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    public UserInfo userInfo = new UserInfo();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["userInfo"] != null)
        {
            string uI = Request.Cookies["userInfo"].Value;
            userInfo.UserName = uI.Split(',')[0];
            userInfo.Email = uI.Split(',')[1];
        }
    }

    protected void btn_Click(object sender, EventArgs e)
    {
        // 获取界面信息
        string userName = this.userName.Text.Trim();
        string password = this.passWord.Text.Trim();

        // session 记住登陆状态

        string sql = @"select UserName, UserPwd, Email, birthday from UserInfo where UserName=@UserName and UserPwd=@UserPwd";
        SqlParameter[] paras =
        {
            new SqlParameter("@UserName", userName),
            new SqlParameter("@UserPwd", password)
        };
        DataTable dt = DBHelper.GetDataTable(sql, paras);
        if (dt != null && dt.Rows.Count > 0)
        {
            //dt.Rows[0][""]
            UserInfo userInfo = new UserInfo();

            userInfo.UserName = dt.Rows[0]["UserName"].ToString();
            userInfo.UserPwd = dt.Rows[0]["UserPwd"].ToString();
            userInfo.Email = dt.Rows[0]["Email"].ToString();
            userInfo.Birthday = dt.Rows[0]["Birthday"].ToString();
            if (this.rememberPassword.Checked)
            {
                HttpCookie cookie = new HttpCookie("userInfo", userInfo.UserName + "," + userInfo.Email);
                cookie.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(cookie);
            }
            Session["userInfo"] = userInfo;
            Response.Redirect("index.aspx");
        }
    }
}