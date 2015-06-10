<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="deleteBus.aspx.cs" Inherits="PlsCan_Run.deleteBus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



<body>
    <form id="form1">
    <div>
    
        <h1><strong>Delete Bus Details</strong></h1>
        <p>
            Bus ID:
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="BusID" DataValueField="BusID">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:routeDBConnectionString %>" SelectCommand="SELECT [BusID] FROM [Bus]"></asp:SqlDataSource>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Back" />
        </p>
    
    </div>
    </form>
</body>
</asp:Content>
