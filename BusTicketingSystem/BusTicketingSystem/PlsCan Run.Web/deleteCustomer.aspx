<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="deleteCustomer.aspx.cs" Inherits="PlsCan_Run.deleteCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">



<body>
    <form id="form1">
    <div>
    
        <h1><strong>Delete Customer Details</strong></h1>
        <p>
            Customer ID:
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="CustID" DataValueField="CustID">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:routeDBConnectionString %>" SelectCommand="SELECT [CustID] FROM [Customer]"></asp:SqlDataSource>
            </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete" />
        </p>
    
    </div>
    </form>
</body>
</asp:Content>
