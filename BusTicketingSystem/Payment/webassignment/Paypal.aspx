<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Paypal.aspx.cs" Inherits="PaymentModule.Paypal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;name<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;price<br />
    <asp:ImageButton ID="PayPalBtn" runat="server" ImageUrl="https://www.paypalobjects.com/en_GB/i/btn/btn_paynow_LG.gif" OnClick="PayPalBtn_Click" style="height: 26px"  />
    </div>
    </form>
</body>
</html>
