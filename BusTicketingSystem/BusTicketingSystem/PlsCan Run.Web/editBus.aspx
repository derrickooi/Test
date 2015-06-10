<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="editBus.aspx.cs" Inherits="PlsCan_Run.editBus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



<style type="text/css">
    .auto-style1 {
        width: 230px;
    }
</style>
    
<body>
    <form id="form1">
    <h1>
        <strong>Edit Bus Details</strong></h1>
    <table style="width:37%;" align="center">
        <tr>
            <td class="auto-style1">Bus ID:</td>

            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="BusID" DataValueField="BusID" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:routeDBConnectionString %>" SelectCommand="SELECT [BusID] FROM [Bus]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Bus Car Plate Number:
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Total number of seat:
                </td><td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Car Registratation Number:</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox4" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
     

       
    </table>
        <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
     
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Clear" />
     
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Back" CausesValidation="false" />
     
    </form>
</body>

</asp:Content>