﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="buttontest.aspx.cs" Inherits="WebApplication1.buttontest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>
            </br>

            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <asp:Label ID="Message" runat="server" Text=""></asp:Label>
            </br>
            <asp:Image ID="Image1" runat="server" />
        </div>
 
    </form>
</body>
</html>
