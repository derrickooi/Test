<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="allStaff.aspx.cs" Inherits="PlsCan_Run.allStaff" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<body>
    <form id="form1">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Search :  "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="180px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Search" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="StaffID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="StaffID" HeaderText="StaffID" ReadOnly="True" SortExpression="StaffID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="icNumber" HeaderText="icNumber" SortExpression="icNumber" />
                <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                <asp:BoundField DataField="position" HeaderText="position" SortExpression="position" />
                <asp:BoundField DataField="salary" HeaderText="salary" SortExpression="salary" />
                <asp:BoundField DataField="contactNo" HeaderText="contactNo" SortExpression="contactNo" />
                <asp:BoundField DataField="loginID" HeaderText="loginID" SortExpression="loginID" />
                <asp:BoundField DataField="loginPSW" HeaderText="loginPSW" SortExpression="loginPSW" />
                <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:routeDBConnectionString %>" SelectCommand="SELECT * FROM [Staff]"></asp:SqlDataSource>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" />
        <br />
    
    </div>
    </form>
</body>

</asp:Content>