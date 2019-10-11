<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <%--<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList><br />--%>

        <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple"></asp:ListBox>
        <asp:Button ID="Button1" runat="server" Text="click me" OnClick="Button1_Click" /><br />
        <asp:Label ID="Label1" runat="server" Text="..."></asp:Label>
    </form>
</body>
</html>
