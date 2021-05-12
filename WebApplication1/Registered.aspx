<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registered.aspx.cs" Inherits="WebApplication1.Registered" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="exampleInputEmail1">帳號</label>
            </br>
            <input type="text"  id="user" name="user" placeholder="輸入帳號" value="">
            </br>
            <label for="exampleInputPassword1">新的密碼</label>
            </br>
            <input type="password"  id="passwd" name="passwd" placeholder="輸入密碼" value="">
            </br>
            <label for="exampleInputPassword1">姓名</label>
            </br>
            <input type="password"  id="name" name="name" placeholder="輸入密碼" value="">
            <asp:Label ID="loginresult" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="登入畫面" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="SUBMIT" />
        </div>
    </form>
</body>
</html>
