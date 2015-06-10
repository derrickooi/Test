<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Reservation.aspx.cs" Inherits="PlsCan_Run.Reservation" %>
<asp:Content ID="reserve" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >

    <!DOCTYPE html>

<html>
<head>
    <title></title>
    <style type="text/css">
        .form {}
        .auto-style1 {
            width: 561px;
        }
        .auto-style2 {
            width: 844px;
        }
        .auto-style3 {
            height: 36px;
        }
        .auto-style7 {
            height: 34px;
        }
        .auto-style12 {
            height: 34px;
            width: 51%;
        }
        .auto-style13 {
            width: 137px;
        }
        .auto-style14 {
            width: 137px;
            height: 34px;
        }
        .auto-style15 {
            font-size: x-large;
        }
    </style>

    <script type="text/javascript">

        
    </script>

</head>
<body>
    <form id="form1" >

    <div>
    <!-- Main Table start -->
        
        <table>
                <tr>
                    <td class="auto-style2">
                        <!-- Left Table Start-->
                        <table border="0" style="width: 100%; margin-top:20px">
                            <tbody>
                                <tr>
                                    <td colspan="2"><h1 style="text-align:center">Ticket Reservation</h1></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <!--Center Side Start -->
                                    <td align="center" class="auto-style1">
                                        <asp:Panel ID="pnl3" runat="server" Height="519px">
                                        <div class="smallbox" style="margin: 0px">
                                            
                                            <asp:label ID="infolabel" runat="server">Welcome, Please select your journey.</asp:label>
                                            <br />
                                            <br />
                                            
                                            <table style="margin-left: 20px; width: 264px; height: 95px;" cellspacing="0" cellpadding="0"
                                                align="center" border="0.5">
                                                <tbody>
                                                    <tr>
                                                        <td class="auto-style3" width="37%">
                                                            From
                                                        </td>
                                                        <td>:</td>
                                                        <td width="63%" align="left" class="auto-style3" style="text-align: center">
                                                            <asp:DropDownList CssClass="form" ID="Source" runat="server" Height="27px" Width="150px" OnSelectedIndexChanged="Source_SelectedIndexChanged" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="routeFrom" DataValueField="routeFrom" AppendDataBoundItems="true">
                                                             <asp:ListItem Value="-1">
                                                                           --Select--
                                                                        </asp:ListItem>     
                                                            </asp:DropDownList>
                                                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BTSDBConn %>" SelectCommand="SELECT DISTINCT [routeFrom] FROM [Schedule]"></asp:SqlDataSource>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style3" width="37%">
                                                            To
                                                        </td>
                                                        <td>:</td>
                                                        <td width="63%" align="left" class="auto-style3" style="text-align: center">
                                                                <ContentTemplate>
                                                                    <div id="txtHint">
                                                                        <asp:DropDownList AppendDataBoundItems="true" CssClass="form" ID="Destination" runat="server" Height="27px" Width="150px" OnSelectedIndexChanged="Destination_SelectedIndexChanged" AutoPostBack="True" Enabled="False" DataSourceID="SqlDataSource2" DataTextField="routeTo" DataValueField="routeTo">
                                                                           

                                                                            <asp:ListItem Value="-1">
                                                                           --Select--
                                                                        </asp:ListItem>     

                                                                            
                                                                        </asp:DropDownList>
                                                                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BTSDBConn %>" SelectCommand="SELECT DISTINCT routeTo FROM Schedule WHERE (routeFrom = @routeFrom)">
                                                                            <SelectParameters>
                                                                                <asp:ControlParameter ControlID="Source" Name="routeFrom" PropertyName="SelectedValue" />
                                                                            </SelectParameters>
                                                                        </asp:SqlDataSource>
                                                                    </div>
                                                                </ContentTemplate>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style3" width="37%">
                                                            Depart on 
                                                        </td>
                                                        <td>:</td>
                                                        <td width="63%" align="left" class="auto-style3" style="text-align: center">
                                                           
                                                                <ContentTemplate>
                                                                    <asp:DropDownList ID="departon" runat="server" Height="27px" Width="150px" OnSelectedIndexChanged="departon_SelectedIndexChanged" AutoPostBack="True" Enabled="False" DataSourceID="SqlDataSource3" DataTextField="Date" DataValueField="Date" AppendDataBoundItems="true" >
                                                                         <asp:ListItem Value="-1">
                                                                           --Select--
                                                                        </asp:ListItem>     
                                                                    </asp:DropDownList>
                                                                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:BTSDBConn %>" SelectCommand="SELECT DISTINCT Date FROM Schedule WHERE (routeFrom = @routeFrom AND routeTo = @routeTo)">
                                                                        <SelectParameters>
                                                                            <asp:ControlParameter ControlID="Source" Name="routeFrom" PropertyName="SelectedValue" />
                                                                            <asp:ControlParameter ControlID="Destination" Name="routeTo" PropertyName="SelectedValue" />
                                                                        </SelectParameters>
                                                                    </asp:SqlDataSource>
                                                                </ContentTemplate>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style3" width="37%">
                                                            Time
                                                        </td>
                                                        <td>:</td>
                                                        <td width="63%" align="left" class="auto-style3" style="text-align: center">
                                                           
                                                                <ContentTemplate>
                                                                    <asp:DropDownList AppendDataBoundItems="true"  ID="DepartureTime" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DepartureTime_SelectedIndexChanged" Height="27px" Width="150px" Enabled="False" DataSourceID="SqlDataSource4" DataTextField="Time" DataValueField="Time">
                                                                      <asp:ListItem Value="-1">
                                                                           --Select--
                                                                        </asp:ListItem>     
                                                                    </asp:DropDownList>
                                                                    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:BTSDBConn %>" SelectCommand="SELECT  Time FROM Schedule WHERE (routeFrom = @routeFrom AND routeTo = @routeTo AND Date = @Date)">
                                                                        <SelectParameters>
                                                                            <asp:ControlParameter ControlID="Source" Name="routeFrom" PropertyName="SelectedValue" />
                                                                            <asp:ControlParameter ControlID="Destination" Name="routeTo" PropertyName="SelectedValue" />
                                                                            <asp:ControlParameter ControlID="departon" Name="Date" PropertyName="SelectedValue" />
                                                                        </SelectParameters>
                                                                    </asp:SqlDataSource>
                                                                </ContentTemplate>
                                                           
                                                        </td>
                                                    
                                                </tbody>
                                                
                                            </table>
                                        </div>
                                            </asp:Panel>
                                    </td>
                                    <!--Center Side End -->
                                    <!--Right Side open -->
                                    <td style="width:55%">
                                      
                                        <asp:Panel ID="pnl1" runat="server"> 
                                          
                                            <asp:Label ID="lblinfo1" runat="server" Text="**Please choose your desired seat(s)." Visible="False" Font-Italic="True" Font-Size="Small"></asp:Label>
                                            <br />
                                          
                                            <asp:Table border="0" ID="seattable" runat="server" BorderStyle="Double" BorderWidth="2px">
                                                <asp:TableRow>
                                                    <asp:TableCell ID="TableCell1" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s1" ToolTip="Window Side" ImageUrl="~/Images/available_seat_img.gif"
                                                             runat="server" OnClick="s1_Click" PostBackUrl="~/Reservation.aspx" />1</asp:TableCell>
                                                    <asp:TableCell ID="TableCell2" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s6"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s6_Click" />6</asp:TableCell>
                                                    <asp:TableCell ID="TableCell3" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s7"  ToolTip="Window Side" ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s7_Click" />7</asp:TableCell>
                                                    <asp:TableCell ID="TableCell4" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s12"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s12_Click" />12</asp:TableCell>
                                                    <asp:TableCell ID="TableCell5" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s13"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s13_Click" />13</asp:TableCell>
                                                    <asp:TableCell ID="TableCell6" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s18"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s18_Click" />18</asp:TableCell>
                                                    <asp:TableCell ID="TableCell7" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s19"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s19_Click" />19</asp:TableCell>
                                                    <asp:TableCell ID="TableCell8" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s24"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s24_Click" />24</asp:TableCell>
                                                    <asp:TableCell ID="TableCell9" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s25"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s25_Click" />25</asp:TableCell>
                                                    <asp:TableCell ID="TableCell10" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s31"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s31_Click" />31</asp:TableCell></asp:TableRow>
                                                <asp:TableRow>
                                                    <asp:TableCell ID="TableCell11" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s2" ImageUrl="~/Images/available_seat_img.gif" 
                                                            runat="server" OnClick="s2_Click" />2</asp:TableCell>
                                                    <asp:TableCell ID="TableCell12" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s5"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s5_Click" />5</asp:TableCell>
                                                    <asp:TableCell ID="TableCell13" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s8"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s8_Click" />8</asp:TableCell>
                                                    <asp:TableCell ID="TableCell14" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s11"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s11_Click" />11</asp:TableCell>
                                                    <asp:TableCell ID="TableCell15" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s14"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s14_Click" />14</asp:TableCell>
                                                    <asp:TableCell ID="TableCell16" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s17"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s17_Click" />17</asp:TableCell>
                                                    <asp:TableCell ID="TableCell17" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s20"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s20_Click" />20</asp:TableCell>
                                                    <asp:TableCell ID="TableCell18" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s23"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s23_Click" />23</asp:TableCell>
                                                    <asp:TableCell ID="TableCell19" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s26"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s26_Click" />26</asp:TableCell>
                                                    <asp:TableCell ID="TableCell20" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s30"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s30_Click" />30</asp:TableCell>
                                                </asp:TableRow>
                                                <asp:TableRow>
                                                    <asp:TableCell ID="TableCell21" runat="server">&nbsp; </asp:TableCell>
                                                    <asp:TableCell ID="TableCell22" runat="server">&nbsp; </asp:TableCell>
                                                    <asp:TableCell ID="TableCell23" runat="server">&nbsp; </asp:TableCell>
                                                    <asp:TableCell ID="TableCell24" runat="server">&nbsp; </asp:TableCell>
                                                    <asp:TableCell ID="TableCell25" runat="server">&nbsp; </asp:TableCell>
                                                    <asp:TableCell ID="TableCell26" runat="server">&nbsp; </asp:TableCell>
                                                    <asp:TableCell ID="TableCell27" runat="server">&nbsp; </asp:TableCell>
                                                    <asp:TableCell ID="TableCell28" runat="server">&nbsp; </asp:TableCell>
                                                    <asp:TableCell ID="TableCell29" runat="server">&nbsp; </asp:TableCell>
                                                    <asp:TableCell ID="TableCell30" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s29"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s29_Click" />29</asp:TableCell>
                                                </asp:TableRow>
                                                <asp:TableRow>
                                                    <asp:TableCell ID="TableCell31" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s3"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s3_Click" />3</asp:TableCell>
                                                    <asp:TableCell ID="TableCell32" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s4"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s4_Click" />4</asp:TableCell>
                                                    <asp:TableCell ID="TableCell33" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s9"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s9_Click" />9</asp:TableCell>
                                                    <asp:TableCell ID="TableCell34" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s10"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s10_Click" />10</asp:TableCell>
                                                    <asp:TableCell ID="TableCell35" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s15"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s15_Click" />15</asp:TableCell>
                                                    <asp:TableCell ID="TableCell36" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s16"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s16_Click" />16</asp:TableCell>
                                                    <asp:TableCell ID="TableCell37" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s21"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s21_Click" />21</asp:TableCell>
                                                    <asp:TableCell ID="TableCell38" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s22"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s22_Click" />22</asp:TableCell>
                                                    <asp:TableCell ID="TableCell39" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s27"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s27_Click" />27</asp:TableCell>
                                                    <asp:TableCell ID="TableCell40" class="seatCell" valign="middle" runat="server">
                                                        <asp:ImageButton ID="s28"  ImageUrl="~/Images/available_seat_img.gif"
                                                            runat="server" OnClick="s28_Click" />28</asp:TableCell>
                                                </asp:TableRow>
                                            </asp:Table>
                                            <br />
                                            <br />
                                            <table align="center" border="0.5" cellpadding="0" cellspacing="0" style="margin-left: 20px; width: 300px; height: 95px;">
                                                <tbody>
                                                        <tr>
                                                            <td class="auto-style12" style="text-align: left">Seat Number : </td>
                                                            <td align="left" width="63%" class="auto-style7">
                                                                <asp:TextBox ID="txtseatnumber" runat="server" Height="20px" ReadOnly="true" Width="159px" style="margin-top: 0px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style12" style="text-align: left">Seat Quantity : </td>
                                                        <td align="left" width="63%" class="auto-style7">
                                                            <asp:TextBox ID="txtseatqty" runat="server" Enabled="False" Height="20px" ReadOnly="true" Width="50px">0</asp:TextBox>
                                                        </td>
                                                    </tr>
                                                       <tr>
                                                        <td class="auto-style12" style="text-align: left">Fare Per Seat :</td>
                                                        <td align="left" width="63%" class="auto-style7">&nbsp;<asp:Label ID="Label1" runat="server" Width="189px">RM35.00</asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style12" style="text-align: left">Total Bus Fare : </td>
                                                        <td align="left" width="63%" class="auto-style7">RM
                                                            <asp:Label ID="lbltotalfare" runat="server" Width="71px">0</asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                    <td> </td>
                                                    <td style="text-align: right">
                        <asp:ImageButton ID="btnNext" ImageUrl="~/Images/btn_go.png" runat="server" OnClick="btnNext_Click" style="height: 23px" />
                                                        &nbsp;&nbsp;&nbsp;
                                                    </td>
                                                </tr>
                                                </tbody>
                                            </table>
                                            <br />
                                            <br />
                       </asp:panel>
                                   
                                        <asp:Panel ID="pnl2" runat="server" Visible="False" Height="498px">
                                            <div id="blueBox">
                                                <div id="blueBoxtitle">
                                                    <h4>
                                                        CUSTOMER INFORMATION
                                                    </h4>
                                                    <p>
                                                        <asp:Label ID="lblinfo2" runat="server" Text="**Please fill in your informations&lt;br/&gt;(For verifying purpose upon ticket reservation)" Visible="False" Font-Italic="True" Font-Size="Small"></asp:Label>
                                                    </p>
                                                </div>
                                                <div style="float: right; width: 435px; height: 200px;">
                                                    <table cellspacing="0" cellpadding="0" style="width: 432px">
                                                        <tbody>
                                                            <tr>
                                                                <td class="auto-style14">
                                                                    Reservation Number
                                                                </td>
                                                                <td class="auto-style7">
                                                                    :
                                                                </td>
                                                                <td class="auto-style7">
                                                                    <asp:Literal ID="litpnr" runat="server" />
                                                                </td>
                                                                <td> </td>
                                                            </tr>
                                                            <tr>
                                                                <td class="auto-style14">
                                                                    Name
                                                                </td>
                                                                <td class="auto-style7">
                                                                    :
                                                                </td>
                                                                <td class="auto-style7">
                                                                    <asp:TextBox ID="txtname" runat="server" Height="20px" />
                                                                    
                                                                    <%--<asp:RangeValidator ID="range" Text ="Invalid Name" Type="String"   ControlToValidate="txtname" runat="server" /> --%>
                                                                </td>
                                                                <td><asp:RequiredFieldValidator ID="rfvname" runat="server" ErrorMessage="*" ControlToValidate="txtname" ForeColor="Red" CssClass="auto-style15" /></td>
                                                            </tr>
                                                             <tr>
                                                                <td class="auto-style14">
                                                                   IC No. / Passport No.
                                                                </td>
                                                                <td class="auto-style7">
                                                                    :
                                                                </td>
                                                                <td class="auto-style7">
                                                                    <asp:TextBox ID="txtpassport" runat="server" Height="20px" />
                                                                    
                                                                    <%--<asp:RangeValidator ID="range" Text ="Invalid Name" Type="String"   ControlToValidate="txtname" runat="server" /> --%>
                                                                </td>
                                                                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="txtname" ForeColor="Red" CssClass="auto-style15" /></td>
                                                            </tr>
                                                            <tr>
                                                                <td class="auto-style14">
                                                                    Phone Number
                                                                </td>
                                                                <td class="auto-style7">
                                                                    :
                                                                </td>
                                                                <td class="auto-style7">
                                                                    <asp:TextBox ID="txtphone" runat="server" Height="20px" />
                                                                    
                                                                </td>
                                                                <td style="vertical-align: middle"><asp:RequiredFieldValidator ID="rfvph" ControlToValidate="txtphone" ErrorMessage="*"
                                                                        runat="server" ForeColor="Red" CssClass="auto-style15" />
                                                                    </td>
                                                                </tr>
                                                            <tr>
                                                            <td class="auto-style12" style="text-align: left">Seat Number</td>
                                                                <td>:</td>
                                                            <td align="left" width="63%" class="auto-style7">
                                                                <asp:Literal ID="seatnumber" runat="server"></asp:Literal>
                                                            </td>
                                                                <td> </td>
                                                        </tr>
                                                                <tr>
                                                                    <td align="left" class="auto-style14">
                                                                        Total Seat
                                                                    </td>
                                                                    <td align="left" class="auto-style7">
                                                                        :
                                                                    </td>
                                                                    <td align="left" class="auto-style7">
                                                                        <asp:Literal ID="littotalseat" runat="server"></asp:Literal>
                                                                    </td>
                                                                    <td> </td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="left" class="auto-style14">
                                                                        Fare Per Seat
                                                                    </td>
                                                                    <td align="left" width="5%" class="auto-style7">
                                                                        :
                                                                    </td>
                                                                    <td align="left" width="49%" class="auto-style7">
                                                                        <asp:Literal ID="litrent" runat="server"></asp:Literal>
                                                                    </td>
                                                                    <td> </td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="left" class="auto-style14">
                                                                        Bus Number
                                                                    </td>
                                                                    <td width="5%" align="left" class="auto-style7">
                                                                        :
                                                                    </td>
                                                                    <td align="left" width="49%" class="auto-style7">
                                                                        <asp:Literal ID="litbusnumber" runat="server" />
                                                                    </td>
                                                                    <td> </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="auto-style13" height="25">
                                                                        Total Rent
                                                                    </td>
                                                                    <td width="5%">
                                                                        :
                                                                    </td>
                                                                    <td class="redText">
                                                                        RM<asp:Literal ID="littotalrent" runat="server" />
                                                                    </td>
                                                                    <td> &nbsp;</td>
                                                                </tr>
                                                            <tr>
                                                                <td class="auto-style13" height="25">&nbsp;</td>
                                                                <td width="5%">&nbsp;</td>
                                                                <td class="redText" style="text-align: right">
                                                                    <asp:ImageButton ID="btnSave" runat="server" ImageUrl="~/Images/btn_submit.png" Visible="False" OnClick="btnSave_Click" />
                                                                </td>
                                                                <td>&nbsp;</td>
                                                            </tr>
                                                        </tbody>
                                                    </table>
                                                </div>
                                        </asp:Panel>
                                    </td>
                          
                                    <!--Right Side End -->
                                </tr>
                            </tbody>
                        </table>
                        <!-- end of Center-->
                    </td>
                </tr>
                <tr>
                    <td align="center" class="auto-style2">
                        <asp:Label ID="lblerror" runat="server" Font-Bold="True" Font-Size="Medium" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="auto-style2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <br />
                    </td>
                </tr>
            </table>
            <!-- Main Table End -->
    </div>
    </form>
</body>
</html>
</asp:Content>