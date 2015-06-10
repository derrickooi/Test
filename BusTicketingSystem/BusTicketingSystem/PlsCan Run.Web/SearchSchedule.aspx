<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchSchedule.aspx.cs" MasterPageFile="~/MasterPage.master" Inherits="BusTicketingSystem.SearchSchedule" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<

    <style type="text/css">
        .auto-style1 {
            width: 95px;
        }
        .auto-style2 {
            width: 95px;
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
            width: 120px;
        }
        .auto-style4 {
            width: 120px;
        }
        .validHighlight {
    
    background-color: lemonchiffon;
    }
        .modalPopup {
        border: 3px solid black;
        background-color: #FFFFFF;
        padding-top: 10px;
        padding-left: 10px;
    }
        .modalBackground {

        background-color: black;
        filter: alpha(opacity=90);
        opacity: 0.8;

    }

    .unwatermark {

        height: 18px;
        width:148px;
    }
    .watermark {
        height:20px;
        width:150px;
        padding:2px 0 0 2px;
        border: 1px solid #BEBEBE;
        background-color:#F0F8FF;
        color:gray;




    }
        .auto-style5 {
            width: 95px;
            height: 46px;
        }
        .auto-style6 {
            height: 46px;
            width: 120px;
        }
    </style>


        <p>
            <asp:Button ID="Button3" runat="server" Text="Show Schedule" />
            <asp:Panel ID="Panel1" CssClass="modalPopup" runat="server">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ScheduleId" DataSourceID="SqlDataSource1" Height="157px" Width="448px">
                    <Columns>
                        <asp:BoundField DataField="ScheduleId" HeaderText="ScheduleId" ReadOnly="True" SortExpression="ScheduleId" />
                        <asp:BoundField DataField="routeFrom" HeaderText="routeFrom" SortExpression="routeFrom" />
                        <asp:BoundField DataField="routeTo" HeaderText="routeTo" SortExpression="routeTo" />
                        <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                        <asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BTSDBConn %>" SelectCommand="SELECT * FROM [Schedule]"></asp:SqlDataSource>
                <asp:Button ID="Button4" runat="server" Text="Button" />
            </asp:Panel>
            <asp:ModalPopupExtender ID="ModalPopupExtender1" OkControlID="Button4" PopupControlID="Panel1" BackgroundCssClass="modalBackground" TargetControlID="Button3" runat="server"></asp:ModalPopupExtender>
        </p>




    <table style="width: 38%; margin-right: 0px;">
        <tr>
           
            <td class="auto-style2">Schedule ID :</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtSchedule" runat="server" OnTextChanged="txtSchedule_TextChanged"></asp:TextBox>
                <asp:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1" TargetControlID="txtSchedule" WatermarkText="Eg. S0001" WatermarkCssClass="watermark" runat="server"></asp:TextBoxWatermarkExtender>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSchedule" ErrorMessage="Pleas enter Schedule ID" ValidationGroup="1" Display="None"></asp:RequiredFieldValidator>
                <asp:ValidatorCalloutExtender ID="ValidatorCalloutExtender1" TargetControlID="RequiredFieldValidator1" runat="server"></asp:ValidatorCalloutExtender>
            </td>
        </tr>
        <tr>
            
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style4">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Retrieve" ValidationGroup="1" />
            </td>
            
        </tr>
        <tr>
            
          <td class="auto-style5">Route ID :</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtRoute" runat="server" AutoPostBack="True" OnTextChanged="txtRoute_TextChanged"></asp:TextBox>
                <asp:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender2" TargetControlID="txtRoute" WatermarkText="Eg. R0001" WatermarkCssClass="watermark" runat="server"></asp:TextBoxWatermarkExtender>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtRoute" ErrorMessage="Pleas enter Route ID" ValidationGroup="2" Display="None"></asp:RequiredFieldValidator>
                <asp:ValidatorCalloutExtender ID="ValidatorCalloutExtender2" TargetControlID="RequiredFieldValidator1" runat="server"></asp:ValidatorCalloutExtender>
            </td>
            
        </tr>
        <tr>
            
            <td class="auto-style2">Depart :</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtDepart" runat="server" AutoPostBack="True" Enabled="False"></asp:TextBox>
                
                
            </td>
        </tr>
        <tr>
            
            <td class="auto-style2">Destinate :</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtDestinate" runat="server" AutoPostBack="True" Enabled="False"></asp:TextBox>
               
            </td>
        </tr>
        <tr>
            
            <td class="auto-style2">Date :</td>
            <td class="auto-style3">
                <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>

                        <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>  
                
                            <asp:CalendarExtender   
                        ID="CalendarExtender1"   
                        TargetControlID="txtDate"   
                        runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtDate" ErrorMessage="Please Select a Date" ValidationGroup="2" Display="None"></asp:RequiredFieldValidator>
                <asp:ValidatorCalloutExtender ID="ValidatorCalloutExtender6" TargetControlID="RequiredFieldValidator6" runat="server"></asp:ValidatorCalloutExtender>
            </td>
        </tr>
        <tr>
            
            <td class="auto-style2">Time :</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtTime" runat="server"></asp:TextBox>
                <asp:MaskedEditExtender ID="MaskedEditExtender1" TargetControlID="txtTime" MaskType="None" Mask="99:99LL" runat="server"></asp:MaskedEditExtender>
                <asp:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender3" TargetControlID="txtTime" WatermarkText="Eg. 12:00AM" WatermarkCssClass="watermark" runat="server"></asp:TextBoxWatermarkExtender>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtTime" ErrorMessage="Please Enter a Time" ValidationGroup="2" Display="None"></asp:RequiredFieldValidator>
                <asp:ValidatorCalloutExtender ID="ValidatorCalloutExtender7" TargetControlID="RequiredFieldValidator7" runat="server"></asp:ValidatorCalloutExtender>
            </td>
        </tr>
    </table>
        <br />
<br />
<br />
<br />
        <asp:Button runat="server"  ValidationGroup="2" Text="Update" ID="UpdateBtn" OnClick="UpdateBtn_Click" />
        <asp:ConfirmButtonExtender ID="ConfirmButtonExtender1" ConfirmText="Are You Sure You Want To Modify?" TargetControlID="UpdateBtn" runat="server"></asp:ConfirmButtonExtender>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" ValidationGroup="1" Text="Delete" />
        <%--<asp:ConfirmButtonExtender ID="ConfirmButtonExtender2" ConfirmText="Are You Sure You Want To Delete?" TargetControlID="Button2" runat="server"></asp:ConfirmButtonExtender>--%>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblEdit" runat="server"></asp:Label>
    
    <br />
<br />
<br />
<br />
<br />
<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Back" />
<br />
    
    </asp:Content>