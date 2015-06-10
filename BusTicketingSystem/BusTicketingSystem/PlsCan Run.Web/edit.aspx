<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="PlsCan_Run.edit" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <style type="text/css">
        .auto-style1 {
            width: 484px;
        }
        .auto-style2 {
            width: 164px;
        }
    </style>
 

<body>
    <form id="form1">
    <div>
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Underline="True" Text="Edit Route"></asp:Label>

    
        <br />

    
        <br />
        <br />
        <table style="width:31%;" align="center">
            <tr>
                <td class="auto-style2">Route ID :</td>
                <td class="auto-style1">
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="routeID" DataValueField="routeID" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:routeDBConnectionString %>" SelectCommand="SELECT [routeID] FROM [Route]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">From : </td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">To :</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox4" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Price :</td>
                <td class="auto-style1">RM&nbsp;
                    <asp:TextBox ID="TextBox2" runat="server" Width="40px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>

    
    </div>
        <p>
            <asp:Label ID="lblEdit" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Edit" OnClick="Button1_Click" />

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Reset"/>
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Back" CausesValidation="false" />
        </p>
    </form>
</body>
</asp:Content>
