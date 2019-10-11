using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string UserName = this.UserName.Text;
        string Password = this.Password.Text;
        bool result = new UsersDA().Select(UserName, Password);
        if (result)
        {
            this.Literal1.Text = "登录成功";
        }
        else
        {
            this.Literal1.Text = "登录名或者密码错误";
        }
    }
}