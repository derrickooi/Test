<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addBus.aspx.cs" MasterPageFile="~/MasterPage.master" Inherits="PlsCan_Run.addBus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<!DOCTYPE html>

<html>
<head>
    <title></title>
</head>
<body>
    <form id="form1">
    <h1>
        <strong>Add Bus Details</strong></h1>
    <table style="width:37%;" align="center">
        <tr>
            <td class="auto-style1">Bus ID:</td>

            <td>
                <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
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
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
     
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Clear" />
     
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Back" CausesValidation="false" />
     
    </form>

</body>
</html>
    </asp:Content>