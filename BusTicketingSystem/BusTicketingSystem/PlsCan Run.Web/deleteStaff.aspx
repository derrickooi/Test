<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="deleteStaff.aspx.cs" Inherits="PlsCan_Run.deleteStaff" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">



<body>
    <form id="form1">
    <div>
    
        <h1><strong>Delete Staff Details</strong></h1>
        <p>Staff ID:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete" />
        </p>
    
    </div>
    </form>
</body>

</asp:Content>