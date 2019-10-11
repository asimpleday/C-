using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //// 数据源指向
        //DropDownList1.DataSource = new UsersDA().Select();

        //// 显示字段绑定
        //DropDownList1.DataTextField = "UserName";

        //// 隐藏字段绑定
        //DropDownList1.DataValueField = "UserNo";

        //DropDownList1.DataBind();



        // 设置默认选中
        //if (!IsPostBack)
        //{
        //    List<Users> list = new List<Users>();
        //    list = new UsersDA().Select();

        //    foreach (var item in list)
        //    {
        //        ListItem li = new ListItem(item.UserName, item.UserNo);
        //        if (li.Value == "1002")
        //        {
        //            li.Selected = true;
        //        }
        //        DropDownList1.Items.Add(li);
        //    }
        //}

        // 多选
        if (!IsPostBack)
        {
            List<Users> list = new List<Users>();
            list = new UsersDA().Select();

            foreach (var item in list)
            {
                ListItem li = new ListItem(item.UserName, item.UserNo);
                if (li.Value == "1002")
                {
                    li.Selected = true;
                }
                ListBox1.Items.Add(li);
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Label1.Text = DropDownList1.SelectedItem.Text + "---" + DropDownList1.SelectedItem.Value;

        string end = "";
        foreach (ListItem item in ListBox1.Items)
        {
            if (item.Selected)
            {
                end += item.Text + "----" + item.Value + ",";
            }
        }
        Label1.Text = end;
    }
}