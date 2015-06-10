<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BusMenu.aspx.cs"  MasterPageFile="~/MasterPage.master" Inherits="PlsCan_Run.BusMenu" %>
<asp:Content ID="reserve" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
<!DOCTYPE html>

<html>
<head>
    <title></title>
</head>
<body>
    <form id="form1">
    <div>
    
        <asp:Panel ID="pnlBus" runat="server">
            <asp:Button ID="Button12" runat="server" Text="Add Bus" Height="40px" OnClick="Button12_Click" Width="200px" />
            <br />
            <br />
            <asp:Button ID="Button13" runat="server" Text="Edit Bus" Height="40px" OnClick="Button13_Click" Width="200px" />
            <br />
            <br />
            <asp:Button ID="Button14" runat="server" Text="Delete Bus" Height="40px" OnClick="Button14_Click" Width="200px" />
            <br />
            <br />
            <asp:Button ID="Button15" runat="server" Text="Show All Bus" Height="40px" OnClick="Button15_Click" Width="200px" />
            <br />
            <br />
            <br />
            <asp:Button ID="btnBack2" runat="server" Text="Back" OnClick="btnBack2_Click" />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
       </asp:Content>