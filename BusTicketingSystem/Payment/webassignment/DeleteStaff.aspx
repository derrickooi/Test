<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteStaff.aspx.cs" Inherits="PaymentModule.DeleteStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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
</html>
