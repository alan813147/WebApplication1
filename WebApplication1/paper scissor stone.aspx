<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="paper scissor stone.aspx.cs" Inherits="WebApplication1.paper_scissor_stone" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:Button ID="logout" runat="server" OnClick="logout_Click" Text="logout" />
        </br>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/pics/scissors.png" OnClick="Button_Click" />
        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/pics/stone.png" OnClick="Button_Click" />
        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/pics/paper.png" OnClick="Button_Click" />
        </br>
        <asp:Label ID="userResult" runat="server" Text="userResult"></asp:Label>
        </br>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        
        <asp:Image ID="comppic" runat="server" />
        </br>
        <asp:Label ID="compResult" runat="server" Text="compResult"></asp:Label>
        </br>
        <asp:Label ID="final" runat="server" Text="Final" BorderColor="Yellow"></asp:Label>
        </br>
        <asp:Label ID="countpeoplelabe" runat="server" Text="countpeoplelabe"></asp:Label>
        </br>
        <asp:Label ID="chatname" runat="server" Text="Label"></asp:Label>
        
        <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
        </asp:Timer> 

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                 <asp:Label ID="timelabel" runat="server"></asp:Label>
                 <br>
                </br>
                 <asp:Label ID="chatlabel" runat="server"></asp:Label>

             </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
            </Triggers>
         </asp:UpdatePanel>
        <asp:TextBox ID="input_chat" runat="server"></asp:TextBox>
        
        <asp:Button ID="sendbtn" runat="server" Text="Send" OnClick="sendbtn_Click" />

        
        
    </form>
</body>
</html>
