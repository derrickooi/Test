<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="editStaff.aspx.cs" Inherits="PlsCan_Run.editStaff" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<style type="text/css">
    .auto-style1 {
        width: 230px;
    }
</style>


<body>
    <form id="form1">
    <div>
    
        <h1><strong>Edit Staff Details</strong></h1>
    
    </div>
        <table style="width:37%;" align="center">
            <tr>
                <td class="auto-style1">StaffID:</td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1" DataTextField="StaffID" DataValueField="StaffID" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:routeDBConnectionString %>" SelectCommand="SELECT [StaffID] FROM [Staff]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Name:</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">IC number:</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Address:</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox4" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Position:</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Driver</asp:ListItem>
                        <asp:ListItem>Admin</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DropDownList1" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Salary:</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Contact Number:</td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox6" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Login ID:</td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox7" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Login Password:</td>
                <td>
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox8" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>

            <tr>
                <td class="auto-style1">Status : </td>
                <td>
                    <asp:DropDownList ID="DropDownList3" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Active</asp:ListItem>
                        <asp:ListItem>Resigned</asp:ListItem>
                        <asp:ListItem>Retired</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="DropDownList3" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
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