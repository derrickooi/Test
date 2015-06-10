using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlsCan_Run
{
    public partial class CustomerMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBack1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminMenu.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("addCustomer.aspx");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("editCustomer.aspx");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("allCust.aspx");
        }
    }
}