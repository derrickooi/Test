using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlsCan_Run
{
    public partial class StaffMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("addstaff.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("editstaff.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("allstaff.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminMenu.aspx");
        }
    }
}