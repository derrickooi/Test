<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="allBus.aspx.cs" Inherits="PlsCan_Run.allBus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<body>
    <form id="form1">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Search : "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="180px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Search" />
        <br />
        <div class="auto-style1">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="BusID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="BusID" HeaderText="BusID" ReadOnly="True" SortExpression="BusID" />
                <asp:BoundField DataField="carPlateNo" HeaderText="carPlateNo" SortExpression="carPlateNo" />
                <asp:BoundField DataField="noOfSeat" HeaderText="noOfSeat" SortExpression="noOfSeat" />
                <asp:BoundField DataField="carRegistrationNumber" HeaderText="carRegistrationNumber" SortExpression="carRegistrationNumber" />
            </Columns>
        </asp:GridView>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:routeDBConnectionString %>" SelectCommand="SELECT * FROM [Bus]"></asp:SqlDataSource>
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Back" />
        <br />
    
    </div>
    </form>
</body>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="Head">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</asp:Content>
