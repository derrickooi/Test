<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Report.aspx.cs" MasterPageFile="~/MasterPage.master" Inherits="BusTicketingSystem.Report" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!DOCTYPE html>

<html>
    <script type="text/javascript">
        function printDiv() {

            var printContents = document.getElementById("printableArea").innerHTML;
            var originalContents2 = document.body.innerHTML;
            document.body.innerHTML = printContents;
            window.print();
            document.body.innerHTML = originalContents;

        }
    </script>
<head>
    <title></title>
</head>
<body>
    <form id="form1">
    <div class="auto-style2">
    
        Report</div>
        <div class="auto-style2">
        <asp:Button ID="Button1" runat="server" Text="Preivew Schedule Report" OnClick="Button1_Click" />
        <br />
        <br />
        <br />
        </div>
        <div id="printableArea" class="auto-style1">
            <div class="auto-style2">
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="X-Large" Font-Underline="True" Text="Schedule Detailed Report" Visible="False"></asp:Label>
        <br />
            </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ScheduleId" DataSourceID="SqlDataSource2" Height="134px" Width="490px" Visible="False">
            <Columns>
                <asp:BoundField DataField="ScheduleId" HeaderText="ScheduleId" SortExpression="ScheduleId" ReadOnly="True" />
                <asp:BoundField DataField="routeFrom" HeaderText="routeFrom" SortExpression="routeFrom" />
                <asp:BoundField DataField="routeTo" HeaderText="routeTo" SortExpression="routeTo" />
                <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                <asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" />
            </Columns>
        </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BTSDBConn %>" SelectCommand="SELECT * FROM [Schedule]"></asp:SqlDataSource>
        <p class="auto-style2">
            <asp:Label ID="Label2" runat="server" Text="Printed Date :" Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Visible="False"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Printed By : Admin" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Font-Italic="True" Text="End Of Report" Visible="False"></asp:Label>
        </p>
            </div>
        <asp:Button ID="Button2" runat="server" OnClientClick="printDiv();" Text="Print" Visible="False" />



        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />



        <asp:Button ID="Button3" runat="server" Text="Back" OnClick="Button3_Click" />
    </form>
</body>
</html>
    </asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="Head">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            text-align: left;
        }
    </style>
</asp:Content>
