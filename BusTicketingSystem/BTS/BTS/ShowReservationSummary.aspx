<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowReservationSummary.aspx.cs" Inherits="BTS.Print" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
            height: 21px;
        }
        .auto-style9 {
            height: 21px;
            width: 123px;
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

        </script>

</head>
<body>
    <form id="form1" runat="server">
    <div id="printableArea">
    
        <table cellpadding="2" cellspacing="0" style="border: 2px solid gray; padding: 5px; height: 387px; width: 671px;">
            <tbody align="left">
                <tr>
                    <td align="center" colspan="7" style="border-bottom: 2px solid gray; padding-bottom:5px; vertical-align: top;" class="auto-style6">
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

                    <td align="center" colspan="3" style="border-bottom: 2px solid gray; padding-bottom:5px; vertical-align: top; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: 12px;" class="auto-style7">
                        <strong>Hotline : </strong>
                        <br />
                        1300-88-842538 
                        <br />
                        03-2035 5525
                    </td>

                </tr>
                <tr>

                    <td colspan="7"></td>
                </tr>
                <tr>
                    <td style="font-weight: bold">Ticket Number :</td>
                    <td class="arial18" style="font-weight: bold">:</td>
                    <td class="redText">
                        <asp:Label ID="lblRsvID" runat="server" style="font-weight: 700"></asp:Label>
                    </td>
                    <td style="font-weight: bold">Depart Date </td>
                    <td class="arial18" style="font-weight: bold">:</td>
                    <td class="auto-style3">
                        <asp:Label ID="lblDate" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" style="font-weight: bold">Name </td>
                    <td class="auto-style1" style="font-weight: bold">:</td>
                    <td class="auto-style1">
                        <asp:Label ID="lblName" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style1" style="font-weight: bold">Depart Time </td>
                    <td class="auto-style1" style="font-weight: bold">:</td>
                    <td class="auto-style4">
                        <asp:Label ID="lblTime" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="font-weight: bold">Phone No. </td>
                    <td class="arial18" style="font-weight: bold">:</td>
                    <td>
                        <asp:Label ID="lblPhone" runat="server"></asp:Label>
                    </td>
                    <td style="font-weight: bold">From </td>
                    <td class="arial18" style="font-weight: bold">:</td>
                    <td class="auto-style3">
                        <asp:Label ID="lblFrom" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="font-weight: bold">IC No.</td>
                    <td class="arial18" style="font-weight: bold">:</td>
                    <td>
                        <asp:Label ID="lblIC" runat="server"></asp:Label>
                    </td>
                    <td style="font-weight: bold">To </td>
                    <td class="arial18" style="font-weight: bold">:</td>
                    <td class="auto-style3">
                        <asp:Label ID="lblTo" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="font-weight: bold">Seat Numbers </td>
                    <td class="arial18" style="font-weight: bold">:</td>
                    <td>
                        <asp:Label ID="lblSeatNo" runat="server"></asp:Label>
                    </td>
                    <td style="font-weight: bold">No.of Passengers </td>
                    <td class="arial18" style="font-weight: bold">:</td>
                    <td class="auto-style3">
                        <asp:Label ID="lblPassenger" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="font-weight: bold">Bus Number </td>
                    <td class="arial18" style="font-weight: bold">:</td>
                    <td>
                        <asp:Label ID="lblBusNo" runat="server"></asp:Label>
                    </td>
                    <td style="font-weight: bold">Total Fare</td>
                    <td class="arial18" style="font-weight: bold">:</td>
                    <td class="auto-style3">
                        <asp:Label ID="lblFare" runat="server" style="font-weight: 700"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"> </td>
                    <td class="auto-style8"></td>
                    <td class="auto-style9"></td>
                </tr>
            </tbody>
        </table>
      
    
    </div>
        </span>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" Height="32px" Text="Print" Width="85px" OnClientClick="printSummary();" />
        </p>
    </form>
</body>
</html>
