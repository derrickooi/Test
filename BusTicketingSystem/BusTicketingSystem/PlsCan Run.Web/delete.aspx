<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="PlsCan_Run.delete" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <style type="text/css">
        .auto-style1 {
            width: 501px;
        }
        .auto-style2 {
            width: 166px;
        }
    </style>

<body>
    <form id="form1">
     <div>
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Underline="True" Text="Delete Route"></asp:Label>

    
        <br />

    
        <br />
        <br />
        <table style="width:28%;" align="center">
            <tr>
                <td class="auto-style2">Route ID :</td>
                <td class="auto-style1">
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="routeID" DataValueField="routeID">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:routeDBConnectionString %>" SelectCommand="SELECT [routeID] FROM [Route]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
        </table>

    
    </div>
        <p>
            <asp:Label ID="lblDelete" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Reset" />
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Back" />
        </p>
    </form>
</body>
        </asp:Content>

