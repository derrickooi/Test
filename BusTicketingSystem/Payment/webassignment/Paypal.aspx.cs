using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace PaymentModule
{
    public partial class Paypal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PayPalBtn_Click(object sender, ImageClickEventArgs e)
        {
            string business = "payment@comfort4u.com";
             string itemName = TextBox1.Text;
             double itemAmount = double.Parse(TextBox2.Text);
            string currencyCode = "USD";
            string returns = "http://localhost:1475/Reservation.aspx";

            StringBuilder ppHref = new StringBuilder();

            ppHref.Append("https://www.sandbox.paypal.com/cgi-bin/webscr?cmd=_xclick");
            ppHref.Append("&business=" + business);
            ppHref.Append("&item_name=" + itemName);
            ppHref.Append("&amount=" + itemAmount.ToString("#.00"));
            ppHref.Append("&currency_code=" + currencyCode);
            ppHref.Append("&return="+returns);

            Response.Redirect(ppHref.ToString(), true);
        }
    }
}