using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class productlist : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // 获取 url 传递过来的参数
        string id = Request["id"].ToString();
        string name = Request["name"].ToString();
        ViewState["name"] = name;
    }
}