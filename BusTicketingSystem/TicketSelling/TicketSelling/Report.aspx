<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="TicketSelling.Report" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <script type="text/javascript">
        function printDiv() {

            var printContents = document.getElementById("printableArea").innerHTML;
            var originalContents2 = document.body.innerHTML;
            document.body.innerHTML = printContents;
            window.print();
            document.body.innerHTML = originalContents;

        }
    </script>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Report</div>
        <asp:Button ID="Button1" runat="server" Text="Preivew Schedule Report" OnClick="Button1_Click" />
        <br />
        <br />
        <br />
        <div id="printableArea">
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="X-Large" Font-Underline="True" Text="Schedule Detailed Report" Visible="False"></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ScheduleId" DataSourceID="SqlDataSource1" Height="134px" Width="490px" Visible="False">
            <Columns>
                <asp:BoundField DataField="ScheduleId" HeaderText="ScheduleId" ReadOnly="True" SortExpression="ScheduleId" />
                <asp:BoundField DataField="Depart" HeaderText="Depart" SortExpression="Depart" />
                <asp:BoundField DataField="Destinate" HeaderText="Destinate" SortExpression="Destinate" />
                <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                <asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT Schedule.ScheduleId, Route.Depart, Route.Destinate, Schedule.Date, Schedule.Time FROM Route INNER JOIN Schedule ON Route.RouteId = Schedule.RouteId"></asp:SqlDataSource>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Printed Date :" Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Visible="False"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Printed By : Admin" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Font-Italic="True" Text="End Of Report" Visible="False"></asp:Label>
        </p>
            </div>
        <asp:Button ID="Button2" runat="server" OnClientClick="printDiv();" Text="Print" Visible="False" />
    </form>
</body>
</html>
