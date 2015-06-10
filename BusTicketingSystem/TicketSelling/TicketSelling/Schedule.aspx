<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Schedule.aspx.cs" Inherits="TicketSelling.Schedule" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<style type="text/css">
    .modalBackground {

        background-color: black;
        filter: alpha(opacity=90);
        opacity: 0.8;

    }
    .modalPopup {
        background-color: #FFFFFF;
        border-width: 3px;
        border-style: solid;
        border-color: black;
        padding-top: 10px;
        padding-left: 10px;
        width: 300px;
        height: 140px;
    
    }
    </style>

<!DOCTYPE html>

  

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="ScheduleId" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="ScheduleId" HeaderText="ScheduleId" ReadOnly="True" SortExpression="ScheduleId" />
                <asp:BoundField DataField="RouteId" HeaderText="RouteId" SortExpression="RouteId" />
                <asp:BoundField DataField="Depart" HeaderText="Depart" SortExpression="Depart" />
                <asp:BoundField DataField="Destinate" HeaderText="Destinate" SortExpression="Destinate" />
                <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                <asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT Schedule.ScheduleId, Schedule.RouteId, Route.Depart, Route.Destinate, Schedule.Date, Schedule.Time FROM Route INNER JOIN Schedule ON Route.RouteId = Schedule.RouteId"></asp:SqlDataSource>

    </div>
    </form>
</body>
</html>
