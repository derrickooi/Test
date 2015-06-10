<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminMenu.aspx.cs" MasterPageFile="~/MasterPage.master" Inherits="PlsCan_Run.AdminMenu" %>
<asp:Content ID="reserve" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <!DOCTYPE html>

<html>
<head >
    <title></title>
</head>
<body>
    <form id="form1">
    <div>
    
        <asp:Panel ID="pnlMenu" runat="server">
            <asp:Button ID="Button1" runat="server" Text="Staff Maintenance" OnClick="Button1_Click" Width="200px" Height="40px" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Customer Maintenence" Height="40px" Width="200px" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Bus Maintenence" Width="200px" Height="40px" />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Schedule Maintenence" Height="40px" Width="200px" />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Route Maintenence" Width="200px" Height="40px" />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
    </asp:Content>