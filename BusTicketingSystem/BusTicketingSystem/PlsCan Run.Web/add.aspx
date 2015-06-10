<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="PlsCan_Run.add" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



    <style type="text/css">
        .auto-style1 {
            width: 267px;
        }
        .auto-style2 {
            width: 166px;
        }
        .auto-style3 {
            font-size: x-large;
        }
    </style>

<body>
    <form id="form1">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Underline="True" Text="Add New Route"></asp:Label>

    
        <br />
        <br />
        <table style="width:28%;" align="center">
            <tr>
                <td class="auto-style2">Route ID :</td>
                <td class="auto-style1">
                    <asp:TextBox ID="routeID" runat="server" Enabled="False" OnTextChanged="routeID_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">From : </td>
                <td class="auto-style1">
                    <asp:TextBox ID="routeFrom" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="routeFrom" CssClass="auto-style3" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">To :</td>
                <td class="auto-style1">
                    <asp:TextBox ID="routeTo" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="routeTo" CssClass="auto-style3" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Price :</td>
                <td class="auto-style1">RM&nbsp;
                    <asp:TextBox ID="price" runat="server" Width="40px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="price" CssClass="auto-style3" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>

    
    </div>
        <p>
            <asp:Label ID="lblAdd" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Reset" />
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Back" CausesValidation="false" />
        </p>
    </form>
</body>
        </asp:Content>

