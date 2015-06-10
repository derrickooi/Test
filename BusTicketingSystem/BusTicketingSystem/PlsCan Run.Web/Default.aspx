<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PlsCan_Run.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <h2>Comfort4U Express Bus Sdn. Bhd.</h2>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Username : " CssClass="auto-style1"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Height="26px" Width="133px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password :" CssClass="auto-style1"></asp:Label>
&nbsp;
&nbsp;<asp:TextBox ID="TextBox2" runat="server" Height="26px" Width="133px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
    
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
