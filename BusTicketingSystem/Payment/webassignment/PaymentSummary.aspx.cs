using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PaymentModule.ServiceReference1;


namespace PaymentModule
{
    public partial class PaymentSummary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            retrieveData();

            ServiceReference1.plsworkSoapClient client = new ServiceReference1.plsworkSoapClient();

            int row = client.InsertPayment(lblPID.Text, lblRID.Text, lbldepartFrom.Text, lblarrivalTo.Text, lblDate.Text, lblTime.Text, lblseatNo.Text, decimal.Parse(lblGTotal.Text));
            if (row > 0)
            {
                Response.Write("<script>alert('Payment Record insert successfuly');</script>");

            }
            else { Response.Write("<script>alert('Payment Record not insert');</script>"); }

         
        }

        private void retrieveData()
        {

            lblPID.Text = Session["PID"].ToString();
            lblRID.Text = Session["RID"].ToString();
            lbldepartFrom.Text = Session["Depart"].ToString();
            lblarrivalTo.Text = Session["Arrival"].ToString();
            lblDate.Text = Session["Date"].ToString();
            lblTime.Text = Session["Time"].ToString();
            lblseatNo.Text = Session["SeatNumber"].ToString();
            lblGTotal.Text = Session["GrandTotal"].ToString();
            lblPayMethod.Text = Session["PayMethod"].ToString();
        }


      
    }
}