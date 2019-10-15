using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    // 成员变量
    public string aaa = "啦啦啦";
    protected void Page_Load(object sender, EventArgs e)
    {
        // C#代码
        //if (!IsPostBack)
        //{
        //    DataTable dt = DBHelper.GetDataTable("select * from Student;");
        //}

        // 根据相对路径获取磁盘的绝对路径
        string path = Request.MapPath("/images");
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        //foreach (var item in this.form1.Controls)
        //{
            
        //}
    }
}