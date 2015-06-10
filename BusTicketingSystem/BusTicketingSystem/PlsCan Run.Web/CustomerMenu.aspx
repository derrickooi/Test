<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerMenu.aspx.cs" MasterPageFile="~/MasterPage.master"  Inherits="PlsCan_Run.CustomerMenu" %>
<asp:Content ID="reserve" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <!DOCTYPE html>

<html>
<head >
    <title></title>
</head>
<body>
    <form id="form1">
    <div>
    
        <asp:Panel ID="pnlCustomer" runat="server">
            <asp:Button ID="Button9" runat="server" Text="Add Customer" Height="40px" OnClick="Button9_Click" Width="200px" />
            <br />
            <br />
            <asp:Button ID="Button10" runat="server" Text="Edit Customer" Height="40px" OnClick="Button10_Click" Width="200px" />
            <br />
            <br />
            <asp:Button ID="Button11" runat="server" Text="Show All Customer" Height="40px" OnClick="Button11_Click" Width="200px" />
            <br />
            <br />
            <br />
            <asp:Button ID="btnBack1" runat="server" Text="Back" OnClick="btnBack1_Click" />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
       </asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="Head">
    <style type="text/css">
    .auto-style1 {
        text-align: center;
    }
</style>
</asp:Content>
