﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlsCan_Run
{
    public partial class AdminMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffMenu.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerMenu.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("BusMenu.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("ScheduleMenu.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("RouteMenu.aspx");
        }

      
    }
}