<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>登陆</title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>账号</td>
                <td>
                    <asp:TextBox ID="userName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>密码</td>
                <td>
                    <asp:TextBox ID="passWord" runat="server" TextMode="Password"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btn" runat="server" Text="登陆" OnClick="btn_Click" />
                    <asp:CheckBox ID="rememberPassword" runat="server" Text="记住密码" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
