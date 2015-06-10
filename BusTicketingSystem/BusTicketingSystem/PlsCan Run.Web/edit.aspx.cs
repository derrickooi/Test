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
    public partial class edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // DropDownList1.SelectedIndex = 0;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conCust;
            String strUpdate;
            SqlCommand cmdUpdate;

            /*open connection to database*/
            string connStr = ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString;
            conCust = new SqlConnection(connStr);

            conCust.Open();

            strUpdate = "Update Route Set routeFrom=@routeFrom, routeTo=@routeTo, price=@price Where routeID=@routeID";

            cmdUpdate = new SqlCommand(strUpdate, conCust);
            cmdUpdate.Parameters.AddWithValue("@routeID", DropDownList1.Text);
            cmdUpdate.Parameters.AddWithValue("@routeFrom", TextBox3.Text);
            cmdUpdate.Parameters.AddWithValue("@routeTo", TextBox4.Text);
            cmdUpdate.Parameters.AddWithValue("@price", TextBox2.Text);

            int intNoofUpdate = cmdUpdate.ExecuteNonQuery();

            if (intNoofUpdate != 0)
            {
                lblEdit.Text = "record updated";

            }
            
            conCust.Close();
            cleartext();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conCust;
            string strEdit;
            SqlCommand cmdEdit;
            SqlDataReader dtr;
            /*open connection to database*/
            string connStr = ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString;
            conCust = new SqlConnection(connStr);

            conCust.Open();

            strEdit = "Select * from Route WHERE routeID=@routeID";
            cmdEdit = new SqlCommand(strEdit, conCust);

            cmdEdit.Parameters.AddWithValue("@routeID", DropDownList1.SelectedValue);

            dtr = cmdEdit.ExecuteReader();

            while (dtr.Read())
            {
                TextBox3.Text = dtr["routeFrom"].ToString();
                TextBox4.Text = dtr["routeTo"].ToString();
                TextBox2.Text = dtr["price"].ToString();
            }
            conCust.Close();
        }
        private void cleartext()
        {
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox2.Text = "";
            Response.Redirect("edit.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("RouteMenu.aspx");
        }



    }
}