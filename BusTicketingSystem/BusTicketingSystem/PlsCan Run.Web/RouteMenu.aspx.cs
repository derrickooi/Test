using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlsCan_Run
{
    public partial class RouteMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBack4_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminMenu.aspx");
        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            Response.Redirect("add.aspx");
        }

        protected void Button21_Click(object sender, EventArgs e)
        {
            Response.Redirect("edit.aspx");
        }

        protected void Button22_Click(object sender, EventArgs e)
        {
            Response.Redirect("delete.aspx");
        }

        protected void Button23_Click(object sender, EventArgs e)
        {
            Response.Redirect("PlsCan RunTestPage.aspx");
        }
    }
}