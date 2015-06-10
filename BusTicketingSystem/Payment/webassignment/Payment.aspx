<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="PaymentModule.Payment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
        }
        .auto-style3 {
        }
        .auto-style4 {
            width: 175px;
        }
        .auto-style5 {
            width: 264px;
        }
        .auto-style6 {
            width: 264px;
            height: 25px;
        }
        .auto-style7 {
            height: 25px;
        }
        .auto-style10 {
            width: 262px;
        }
        .auto-style11 {
            height: 26px;
        }
    </style>
</head>

    <%--<script type="text/Javascript">
        function confirm_meth() {
            if (confirm("Confirm payment?") == true) {
                alert("You had made payment");
                
            }
            else {
                alert("You had canceled payment");
            }
        }
</script>--%>
    
<body>
    <form id="form1" runat="server">
        <h1>Payment Module</h1>
        <p>

            ReserveID Search:&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Retrieve" />
        </p>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1" colspan="4">
                        <strong>Payment Details:</strong></td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Text="Payment ID:"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtPID" runat="server" Width="158px" Enabled="False"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        Reserve ID:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtRID" runat="server" Width="158px" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        Departure:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtDepart" runat="server" Width="158px" Enabled="False"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        Arrival:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtArrival" runat="server" Width="158px" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        Date:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtDate" runat="server" Width="158px" Enabled="False"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        Time:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtTime" runat="server" Width="158px" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">
                        Seat Number :</td>
                    <td class="auto-style11" colspan="3">
                        <asp:TextBox ID="txtseatNo" runat="server" Width="181px" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
                </table>

        <p>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style5">
                        <strong>Payment Method:</strong></td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label2" runat="server" Text="Credit Card Type:"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem> </asp:ListItem>
                            <asp:ListItem>Visa(+3%)</asp:ListItem>
                            <asp:ListItem>Master(+5%)</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                </table>
            <br />
            <table style="width:100%;">
                <tr>
                    <td colspan="2"><strong>Payment Price:</strong></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Amount:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAmount" runat="server" Width="157px" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Charge"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCharge" runat="server" Width="157px" Enabled="False" AutoPostBack="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Grandtotal:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtGTotal" runat="server" Width="158px" Enabled="False" AutoPostBack="True"></asp:TextBox>
                        </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </p>
        <p>

    <asp:ImageButton ID="PayPalBtn" runat="server" ImageUrl="https://www.paypalobjects.com/en_GB/i/btn/btn_paynow_LG.gif" OnClick="PayPalBtn_Click"  />
            <!--OnClientClick ="confirm_meth() "--> 
        &nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Clear" />
&nbsp; 
            <br />
        </p>
    

        <p>

            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Forgot ReserveID ?" />
        </p>
        <p>

            <asp:Label ID="Label7" runat="server" Text="Customer IC:" Visible="False"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Visible="False"></asp:TextBox>
            <asp:Label ID="Label9" runat="server" Text="(eg.931010-07-3333)" Visible="False"></asp:Label>
        </p>
        <p>

            <asp:Label ID="Label8" runat="server" Text="Phone Number:" Visible="False"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Visible="False"></asp:TextBox>
            <asp:Label ID="Label10" runat="server" Text="(eg.014-2358271)" Visible="False"></asp:Label>
        </p>
        <p>

            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Get ReserveID" Visible="False" />
        </p>
        <p>

            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>

            <table style="width:100%;">
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td>
                        <asp:TextBox ID="txtAcc" runat="server" Width="154px" Visible="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td>
                        <asp:TextBox ID="txtCCNo" runat="server" Width="154px" Visible="False"></asp:TextBox>
                    </td>
                </tr>
            </table>

            </p>
        <p>
            &nbsp;</p>
        </form>
</body>
</html>
