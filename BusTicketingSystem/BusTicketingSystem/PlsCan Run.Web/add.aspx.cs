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
    public partial class add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            routeID.Text = generateID();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strInsert;
            SqlCommand cmdInsert;

            SqlConnection conCust;
            string connStr = ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString;
            conCust = new SqlConnection(connStr);


            strInsert = "Insert Into Route (routeID,routeFrom,routeTo,price) Values (@routeID, @routeFrom, @routeTo, @price )";

            cmdInsert = new SqlCommand(strInsert, conCust);
            cmdInsert.Parameters.AddWithValue("@routeID", routeID.Text);
            cmdInsert.Parameters.AddWithValue("@routeFrom", routeFrom.Text);
            cmdInsert.Parameters.AddWithValue("@routeTo", routeTo.Text);
            cmdInsert.Parameters.AddWithValue("@price", price.Text);


            conCust.Open();
            cmdInsert.ExecuteNonQuery();

            lblAdd.Text = "New route added!";
            

            conCust.Close();
            cleartext();
        }
        private String generateID()
        {
            string strSelect;
            SqlCommand cmdSelect;
            SqlDataReader dtr;

            SqlConnection conCust;
            string connStr = ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString;
            conCust = new SqlConnection(connStr);

            strSelect = "Select routeID From Route";

            cmdSelect = new SqlCommand(strSelect, conCust);
            //cmdSelect.Parameters.AddWithValue("@CustomerID", TextBox4.Text);
            conCust.Open();
            dtr = cmdSelect.ExecuteReader();

            string lastValue = "";
            while (dtr.Read())
                lastValue = dtr["routeID"].ToString();


            conCust.Close();
            if (lastValue == "")
            {
                return "R1001";
            }
            else
            {
                double genID = double.Parse(lastValue.Replace("R", ""));
                genID = genID + 1;
                return ("R" + genID.ToString());
            }



        }
        private void cleartext() {
            routeFrom.Text = "";
            routeTo.Text = "";
            price.Text = "";
            Response.Redirect("add.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("RouteMenu.aspx");
        }

        protected void routeID_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}