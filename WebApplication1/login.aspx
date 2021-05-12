<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="name">User Name:</label><br>
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            </br>
            <asp:Label ID="Label1" runat="server" Text="UserID"></asp:Label>
            <input type="text" id="user" name="user" value="alan">
            <br>
            <asp:Label ID="Label2" runat="server" Text="passwd"></asp:Label>
            <input type="password" id="passwd" name="passwd" value="123456">
    
            <asp:Label ID="loginresult" runat="server"></asp:Label>
            </br>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Page_Load" />
        </div>
    </form>
</body>
</html>
