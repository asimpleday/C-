<%@ Page Language="C#" AutoEventWireup="true" CodeFile="oderInfo.aspx.cs" Inherits="oderInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <% 
        if (userInfo != null)
        { 
    %>
    欢迎 <%=userInfo.UserName %> 登陆了

    <%} %>
</body>
</html>
