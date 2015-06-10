<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="addCustomer.aspx.cs" Inherits="PlsCan_Run.addCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


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
        </style>

<body>
        <form id="form1">
    <div>
    
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Underline="True" Text="Add New Customer"></asp:Label>

    
    </div>
        <table style="width:37%;" align="center">
            <tr>
                <td class="auto-style1">Customer ID :</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
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
                <td class="auto-style1">IC number :</td>
                <td>
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
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
&nbsp;&nbsp;&nbsp;

        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Reset" />

            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Back" CausesValidation="false" />

    </form>
</body>

</asp:Content>
