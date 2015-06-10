<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentSummary.aspx.cs" MasterPageFile="~/MasterPage.master" Inherits="PlsCan_Run.PaymentSummary" %>
<asp:Content ID="reserve" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <!DOCTYPE html>

<html>
<head >
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 24px;
        }
        .auto-style3 {
            width: 123px;
        }
        .auto-style4 {
            height: 24px;
            width: 123px;
        }
        .auto-style6 {
            height: 112px;
        }
        .auto-style7 {
            height: 40px;
        }
        .auto-style8 {
            text-align: right;
            height: 37px;
        }
        .auto-style9 {
            height: 37px;
        }
        .auto-style10 {
            width: 123px;
            height: 37px;
        }
    </style>

    <script type="text/javascript">
        function printSummary() {
            var printContents = document.getElementById("printableArea").innerHTML;
            var originalContents = document.body.innerHTML;

            document.body.innerHTML = printContents;

            window.print();

            document.body.innerHTML = originalContents;
        }

        function close_window() {
            if (confirm("Close Window?"))
            {
                close();
            }
        }
        </script>

</head>
<body>
    <form id="form1">
    <div id="printableArea">
    
        <table cellpadding="2" cellspacing="0" style="border: 2px solid gray; padding: 5px; height: 387px; width: 671px;" align="center">
            <tbody align="left">
                <tr>
                    <td align="center" colspan="6" style="border-bottom: 2px solid gray; padding-bottom:5px; vertical-align: top;" class="auto-style6">
                        <asp:Image ID="img1" runat="server" Height="114px" ImageUrl="~/Images/ticketbanner.jpg" Width="665px" />
                    </td>
                </tr>
                <span style="color: rgb(0, 0, 0); font-family: Arial; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255);">
                <tr>

                    <td align="center" colspan="4" style="border-bottom: 2px solid gray; padding-bottom:5px; vertical-align: top; text-align: center; font-family: arial, Helvetica, sans-serif; font-size: 12px;" class="auto-style7">

                        <strong>Headquater Office :
                        <br />
                        </strong>Lot 73 & 86, Jalan Logam 5,
Kamunting Industrial Estate,
                        <br />
                        34600 Kamunting, Taiping Perak D.R. Malaysia
                    </td>

                    <td align="center" colspan="2" style="border-bottom: 2px solid gray; padding-bottom:5px; vertical-align: top; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: 12px;" class="auto-style7">
                        <strong>Hotline : </strong>
                        <br />
                        1300-88-842538 
                        <br />
                        03-2035 5525
                    </td>

                </tr>
                <tr>

                    <td colspan="6"></td>
                </tr>
                <tr>
                    <td style="font-weight: bold">Ticket Number :</td>
                    <td class="arial18" style="font-weight: bold">:</td>
                    <td class="redText">
                        <asp:Label ID="lblPID" runat="server" style="font-weight: 700"></asp:Label>
                    </td>
                    <td style="font-weight: bold">Depart Date </td>
                    <td class="arial18" style="font-weight: bold">:</td>
                    <td class="auto-style3">
                        <asp:Label ID="lblDate" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" style="font-weight: bold">Reserve ID</td>
                    <td class="auto-style1" style="font-weight: bold">:</td>
                    <td class="auto-style1">
                        <asp:Label ID="lblRID" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style1" style="font-weight: bold">Depart Time </td>
                    <td class="auto-style1" style="font-weight: bold">:</td>
                    <td class="auto-style4">
                        <asp:Label ID="lblTime" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="font-weight: bold">Payment Method </td>
                    <td class="arial18" style="font-weight: bold">:</td>
                    <td>
                        <asp:Label ID="lblPayMethod" runat="server"></asp:Label>
                    </td>
                    <td style="font-weight: bold">Depart From </td>
                    <td class="arial18" style="font-weight: bold">:</td>
                    <td class="auto-style3">
                        <asp:Label ID="lbldepartFrom" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="font-weight: bold">Seat Numbers</td>
                    <td class="arial18" style="font-weight: bold">:</td>
                    <td>
                        <asp:Label ID="lblseatNo" runat="server"></asp:Label>
                    </td>
                    <td style="font-weight: bold">Depart To </td>
                    <td class="arial18" style="font-weight: bold">:</td>
                    <td class="auto-style3">
                        <asp:Label ID="lblarrivalTo" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="font-weight: bold" class="auto-style8" colspan="4">Total Payment</td>
                    <td class="auto-style9" style="font-weight: bold">:</td>
                    <td class="auto-style10">
                        <asp:Label ID="lblGTotal" runat="server" style="font-weight: 700"></asp:Label>
                    </td>
                </tr>
            </tbody>
        </table>
      
    
    </div>
        </span>
        <p>
            &nbsp;</p>
        <p>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Height="32px" Text="Print" Width="85px" OnClientClick="printSummary();" />
            </p>
    </form>
</body>
</html></asp:Content>