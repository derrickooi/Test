<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStaff.aspx.cs" Inherits="PaymentModule.AddStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 140px;
        }
        #TextArea1 {
            width: 197px;
        }
        .auto-style2 {
            width: 140px;
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1><strong>Add Staff Details</strong></h1>
    
    </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">StaffID:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
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
                <td class="auto-style2">Position:</td>
                <td class="auto-style3">
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
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Reset" />
    </form>
</body>
</html>
