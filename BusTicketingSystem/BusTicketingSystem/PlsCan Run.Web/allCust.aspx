<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="allCust.aspx.cs" Inherits="PlsCan_Run.allCust" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<body>
    <form id="form1">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Search : "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="180px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Search" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CustID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="CustID" HeaderText="CustID" ReadOnly="True" SortExpression="CustID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="icNo" HeaderText="icNo" SortExpression="icNo" />
                <asp:BoundField DataField="contact" HeaderText="contact" SortExpression="contact" />
                <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:routeDBConnectionString %>" SelectCommand="SELECT * FROM [Customer]"></asp:SqlDataSource>
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Back" />
        <br />
    
    </div>
    </form>
</body>

</asp:Content>