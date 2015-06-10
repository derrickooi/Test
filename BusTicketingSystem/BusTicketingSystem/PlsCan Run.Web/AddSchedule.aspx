<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddSchedule.aspx.cs" MasterPageFile="~/MasterPage.master" Inherits="BusTicketingSystem.AddSchedule" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<style type="text/css">
    .modalBackground {

        background-color: black;
        filter: alpha(opacity=90);
        opacity: 0.8;

    }
    .modalPopup {
        border: 3px solid black;
        background-color: #FFFFFF;
        padding-top: 10px;
        padding-left: 10px;
    }
    .validHighlight {
    
    background-color: lemonchiffon;
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
    </style>

<!DOCTYPE html>

<html>
<head>
    <title></title>
    </head>
<body>
    <form id="form1">
    <div>


    
        Add Schedule<br />
        <br />
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        </div>

       

        
        <p>

        <asp:Button ID="show" runat="server" Text="Show Route" />
        <asp:Panel ID="Panel1" CssClass="modalPopup" runat="server" Height="284px" Width="359px">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="routeID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Width="316px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="routeID" HeaderText="Route ID" ReadOnly="True" SortExpression="routeID" />
                    <asp:BoundField DataField="routeFrom" HeaderText="From" SortExpression="routeFrom" />
                    <asp:BoundField DataField="routeTo" HeaderText="To" SortExpression="routeTo" />
                    <asp:BoundField DataField="price" HeaderText="Price" SortExpression="price" />
                </Columns>
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BTSDBConn %>" SelectCommand="SELECT * FROM [Route]"></asp:SqlDataSource>
            <br />
            <asp:Button ID="pop" runat="server" Text="OK" />
        </asp:Panel>
        <asp:ModalPopupExtender ID="ModalPopupExtender1" runat="server" OkControlID="pop" PopupControlID="Panel1" BackgroundCssClass="modalBackground" TargetControlID="show"></asp:ModalPopupExtender>

        </p>


        <p>
            
            
            
            Schedule ID :
            <asp:TextBox ID="txtScheduleID" runat="server" CssClass="unwatermark" OnTextChanged="txtScheduleID_TextChanged"></asp:TextBox>
            
            
            
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtScheduleID" Display="None" ErrorMessage="Please Enter Schedule ID" ForeColor="Red" ValidationGroup="1"></asp:RequiredFieldValidator>
            <asp:ValidatorCalloutExtender ID="ValidatorCalloutExtender1" TargetControlID="RequiredFieldValidator1" HighlightCssClass="validHighlight" runat="server"></asp:ValidatorCalloutExtender>
            <asp:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1" TargetControlID="txtScheduleID" WatermarkText="Eg. S0001" WatermarkCssClass="watermark" runat="server"></asp:TextBoxWatermarkExtender>
            
            
        </p>
        
        
        <p>
            
            Route ID :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtRouteID" runat="server" AutoPostBack="True" OnTextChanged="txtRouteID_TextChanged1"></asp:TextBox>
            
                
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="watermark" runat="server" ControlToValidate="txtRouteID"  Display="None" ErrorMessage="Please Enter RouteID" ValidationGroup="1" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:ValidatorCalloutExtender ID="ValidatorCalloutExtender2" TargetControlID="RequiredFieldValidator2" HighlightCssClass="validHighlight" runat="server"></asp:ValidatorCalloutExtender>
            <asp:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender2" TargetControlID="txtRouteID" WatermarkText="Eg. R0001" WatermarkCssClass="watermark" runat="server"></asp:TextBoxWatermarkExtender>
        </p>
        <p>
            
            Depart :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtDepart" runat="server" AutoPostBack="True" Enabled="False" OnTextChanged="txtDepart_TextChanged1"></asp:TextBox>
                
        </p>
        <p>
            
            Destinate :&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDestination" runat="server" AutoPostBack="True" Enabled="False"></asp:TextBox>
                
        </p>
        <p>
            
            Date :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
           
            <asp:TextBox ID="txtDate" runat="server" OnTextChanged="txtDate_TextChanged"></asp:TextBox>
            <asp:CalendarExtender ID="CalendarExtender1" TargetControlID="txtDate" runat="server"></asp:CalendarExtender>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDate" Display="None" ValidationGroup="1" ErrorMessage="Please Select A Date" ForeColor="Red"/>
            <asp:ValidatorCalloutExtender ID="ValidatorCalloutExtender3" TargetControlID="RequiredFieldValidator3"  runat="server"/>
        </p>
        
        <p>
            
            Time :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTime" runat="server" ></asp:TextBox>
            <asp:MaskedEditExtender ID="MaskedEditExtender1" TargetControlID="txtTime" MaskType="None" Mask="99:99LL" runat="server"></asp:MaskedEditExtender>
                
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtTime" ValidationGroup="1" Display="None" ErrorMessage="Please Enter a Time" ForeColor="Red"/>
            <asp:ValidatorCalloutExtender ID="ValidatorCalloutExtender4" TargetControlID="RequiredFieldValidator4"  runat="server"></asp:ValidatorCalloutExtender>
            <asp:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender3" TargetControlID="txtTime" WatermarkText="Eg. 12:00 AM" WatermarkCssClass="watermark" runat="server"></asp:TextBoxWatermarkExtender>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" ValidationGroup="1"  />
        <asp:Button ID="Button2" runat="server" Text="Cancel" />
    </form>
</body>
</html>
    </asp:Content>