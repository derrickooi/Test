<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateStaff.aspx.cs" Inherits="PaymentModule.UpdateStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1><strong>Update Staff Details</strong></h1>
    
    </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">StaffID:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                &nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Search" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Name:</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">IC number:</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Address:</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Position:</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Admin</asp:ListItem>
                        <asp:ListItem>Driver</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Salary:</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Contact Number:</td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Login ID:</td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Login Password:</td>
                <td>
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Status:</td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem>Resigned</asp:ListItem>
                        <asp:ListItem>Retired</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" Width="50px" />
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Height="26px" OnClick="Button3_Click" Text="Clear" />
        <br />
    </form>
</body>
</html>
