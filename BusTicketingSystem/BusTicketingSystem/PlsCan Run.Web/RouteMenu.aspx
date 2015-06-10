<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RouteMenu.aspx.cs"  MasterPageFile="~/MasterPage.master" Inherits="PlsCan_Run.RouteMenu" %>
<asp:Content ID="reserve" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
<!DOCTYPE html>

<html>
<head>
    <title></title>
</head>
<body>
    <form id="form1" >
        <asp:Panel ID="pnlRoute" runat="server">
            <asp:Button ID="Button20" runat="server" Text="Add Route" Height="40px" OnClick="Button20_Click" Width="200px" />
            <br />
            <br />
            <asp:Button ID="Button21" runat="server" Text="Edit Route" Height="40px" OnClick="Button21_Click" Width="200px" />
            <br />
            <br />
            <asp:Button ID="Button22" runat="server" Text="Delete Route" Height="40px" OnClick="Button22_Click" Width="200px" />
            <br />
            <br />
            <asp:Button ID="Button23" runat="server" Text="Show All Route" Height="40px" OnClick="Button23_Click" Width="200px" />
            <br />
            <br />
            <br />
            <asp:Button ID="btnBack4" runat="server" Text="Back" OnClick="btnBack4_Click" />
        </asp:Panel>
    <div>
    
    </div>
    </form>
</body>
</html>
       </asp:Content>