using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BusTicketingSystem
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox1.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;

            GridView1.Visible = true;
            Button2.Visible = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("ScheduleMenu.aspx");
        }
    }
}