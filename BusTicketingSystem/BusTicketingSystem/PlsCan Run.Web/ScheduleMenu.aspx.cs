using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlsCan_Run
{
    public partial class ScheduleMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBack3_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminMenu.aspx");
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddSchedule.aspx");
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchSchedule.aspx");
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            Response.Redirect("Schedule.aspx");
        }

     

        protected void Button20_Click(object sender, EventArgs e)
        {
            Response.Redirect("Report.aspx");
        }


    }
}