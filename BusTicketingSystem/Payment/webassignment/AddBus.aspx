<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBus.aspx.cs" Inherits="PaymentModule.BusMaintain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 242px;
        }
    </style>

     <link rel="stylesheet" href="http://localhost:55003/code.jquery.com/ui/1.11.0/themes/smoothness/jquery-ui.css"/>
  <script src="//code.jquery.com/jquery-1.10.2.js"></script>
  <script src="//code.jquery.com/ui/1.11.0/jquery-ui.js"></script>
  <link rel="stylesheet" href="/resources/demos/style.css"/>
  <script>
      $(function () {
          $("#datepicker").datepicker();
          $("#datepicker1").datepicker();
      });
  </script>
</head>
<body>
    <form id="form1" runat="server">
    <h1>
        <strong>Add Bus Details</strong></h1>
    <table style="width:100%;">
        <tr>
            <td class="auto-style1">Bus ID:</td>

            <td>
                <asp:TextBox ID="TextBox1" runat="server" Enabled="False" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Bus Car Plate Number:
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Total number of seat:
                </td><td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Car Registratation Number:</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Expired Date of Insurance:</td>
            <td>
                
                <asp:TextBox ID="datepicker" runat="server"></asp:TextBox>
                
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Road Tax</td>
   
                <td>
                    <asp:TextBox ID="datepicker1" runat="server"></asp:TextBox>
            </td>

        </tr>
    </table>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
     
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Clear" />
     
    </form>
</body>
</html>
