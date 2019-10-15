using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class oderInfo : System.Web.UI.Page
{
    public UserInfo userInfo;   // 定义一个成员变量
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userInfo"] != null)
        {
            userInfo = Session["userInfo"] as UserInfo;
        }
    }
}