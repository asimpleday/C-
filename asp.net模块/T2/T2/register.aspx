<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>注册</title>
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
                <td>邮箱</td>
                <td>
                    <asp:TextBox ID="email" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>生日</td>
                <td>
                    <asp:TextBox ID="birthday" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btn" runat="server" Text="提交" OnClick="btn_Click" OnClientClick="return confirm('是否确认提交？')" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
