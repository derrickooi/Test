<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScheduleMenu.aspx.cs" MasterPageFile="~/MasterPage.master"  Inherits="PlsCan_Run.ScheduleMenu" %>
<asp:Content ID="reserve" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <!DOCTYPE html>

<html>
<head>
    <title></title>
</head>
<body>
    <form id="form1">
    <div>
    
        <asp:Panel ID="pnlSchedule" runat="server">
            <asp:Button ID="Button16" runat="server" Text="Add Schedule" Height="40px" OnClick="Button16_Click" Width="200px" />
            <br />
            <br />
            <asp:Button ID="Button17" runat="server" Text="Edit/Delete Schedule" Height="40px" OnClick="Button17_Click" Width="200px" />
            <br />
            <br />
            <asp:Button ID="Button18" runat="server" Text="Show All Schedule" Height="40px" Width="200px" OnClick="Button18_Click" />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button20" runat="server" Height="40px" OnClick="Button20_Click" Text="Report" Width="200px" />
            <br />
            <br />
            <asp:Button ID="btnBack3" runat="server" Text="Back" OnClick="btnBack3_Click" />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
       </asp:Content>