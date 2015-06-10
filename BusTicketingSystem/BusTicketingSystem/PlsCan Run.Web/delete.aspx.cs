using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; // IMPORTANT
using System.Configuration;// IMPORTANT

namespace PlsCan_Run
{
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conCust;
            string strDelete;
            SqlCommand cmdDelete;

            /*open connection to database*/
            string connStr = ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString;
            conCust = new SqlConnection(connStr);

            conCust.Open();

            strDelete = "Delete Route where routeID=@routeID";
            cmdDelete = new SqlCommand(strDelete, conCust);

            cmdDelete.Parameters.AddWithValue("@routeID", DropDownList1.Text);

            cmdDelete.ExecuteNonQuery();

            conCust.Close();

           
            
                lblDelete.Text = "Record deleted";

                Response.Redirect("delete.aspx");
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("RouteMenu.aspx");
        }
    }
}