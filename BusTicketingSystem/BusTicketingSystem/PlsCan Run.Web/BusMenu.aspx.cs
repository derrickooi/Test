using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlsCan_Run
{
    public partial class BusMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBack2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminMenu.aspx");
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Response.Redirect("addBus.aspx");
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Response.Redirect("editBus.aspx");
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            Response.Redirect("deleteBus.aspx");
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            Response.Redirect("allBus.aspx");
        }
    }
}