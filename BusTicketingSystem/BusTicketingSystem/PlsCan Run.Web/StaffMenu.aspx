<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffMenu.aspx.cs"  MasterPageFile="~/MasterPage.master" Inherits="PlsCan_Run.StaffMenu" %>
<asp:Content ID="reserve" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
<!DOCTYPE html>

<html>
<head >
    <title></title>
</head>
<body>
    <form id="form1">
    <div>
    
        <asp:Panel ID="pnlStaff" runat="server">
            <asp:Button ID="Button6" runat="server" Text="Add Staff" OnClick="Button6_Click" Height="40px" Width="200px" />
            <br />
            <br />
            <asp:Button ID="Button7" runat="server" Text="Edit Staff" OnClick="Button7_Click" Height="40px" Width="200px" />
            <br />
            <br />
            <asp:Button ID="Button8" runat="server" Text="Show All Staff" OnClick="Button8_Click" Height="40px" Width="200px" />
            <br />
            <br />
            <br />
            <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
       </asp:Content>