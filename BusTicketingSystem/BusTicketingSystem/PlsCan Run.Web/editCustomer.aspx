<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="editCustomer.aspx.cs" Inherits="PlsCan_Run.editCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <body>
        <form id="form1">
            <div>
    
                <h1><strong>Edit Customer Details</strong></h1>
    
    </div>
        <table style="width:38%;" align="center">
            <tr>
                <td class="auto-style1">Customer ID:</td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1" DataTextField="CustID" DataValueField="CustID" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:routeDBConnectionString %>" SelectCommand="SELECT [CustID] FROM [Customer]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Name :</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">IC number :</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Contact Number:</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox4" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            
           
            <tr>
                <td class="auto-style1">Address :</td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox6" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">E-mail</td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox7" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>

        </table>
        <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" Width="50px" />
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Height="26px" OnClick="Button3_Click" Text="Clear" />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Back" CausesValidation="false" />
    </form>
</body>

</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style5 {
            width: 230px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
    </style>
</asp:Content>

