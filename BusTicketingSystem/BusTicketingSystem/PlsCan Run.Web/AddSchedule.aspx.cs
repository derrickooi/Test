using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; // IMPORTANT
using System.Configuration;// IMPORTANT

namespace BusTicketingSystem
{

    public partial class AddSchedule : System.Web.UI.Page
    {
         string strSelect;
            SqlCommand cmdSelect;
            SqlDataReader dtr;

            SqlConnection conSche;
            string connStr = ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString;
            
        protected void Page_Load(object sender, EventArgs e)
        {
            String strSelect;
            SqlCommand cmdSelect;
            SqlDataReader dtr;
            SqlConnection conBus;



            string connStr = ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString;
            conBus = new SqlConnection(connStr);


            strSelect = "SELECT COUNT(*) AS counts FROM Schedule";
            cmdSelect = new SqlCommand(strSelect, conBus);
            conBus.Open();
            dtr = cmdSelect.ExecuteReader();


            if (dtr.Read())
            {
                string newID;
                int count = (Convert.ToInt32(dtr["counts"].ToString())) + 1;
                newID = "S" + count.ToString("D4");
                txtScheduleID.Text = newID;
                
            }

            
            
        }

        protected void txtDepart_TextChanged(object sender, EventArgs e)
        {

        }

        

        protected void txtRouteID_TextChanged(object sender, EventArgs e)
        {

            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           
        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conSche = new SqlConnection(connStr);


            strSelect = "Insert Into Schedule (ScheduleId, routeId, routeFrom, routeTo , Date, Time) Values (@ScheduleId,@routeId, @routeFrom, @routeTo, @Date, @Time )";

            cmdSelect = new SqlCommand(strSelect, conSche);
            cmdSelect.Parameters.AddWithValue("@ScheduleId", txtScheduleID.Text);
            cmdSelect.Parameters.AddWithValue("@routeId", txtRouteID.Text);
            cmdSelect.Parameters.AddWithValue("@RouteFrom", txtDepart.Text);
            cmdSelect.Parameters.AddWithValue("@RouteTo",  txtDestination.Text);
            cmdSelect.Parameters.AddWithValue("@Date", txtDate.Text);
            cmdSelect.Parameters.AddWithValue("@Time", txtTime.Text);
            



            conSche.Open();
            cmdSelect.ExecuteNonQuery();

            

            conSche.Close();
            
        }

        protected void txtRouteID_TextChanged1(object sender, EventArgs e)
        {
            conSche = new SqlConnection(connStr);
            strSelect = "Select * From dbo.Route where RouteId=@RouteId";

            cmdSelect = new SqlCommand(strSelect, conSche);
            cmdSelect.Parameters.AddWithValue("@RouteId", txtRouteID.Text);

            conSche.Open();
            dtr = cmdSelect.ExecuteReader();




            if (dtr.HasRows)
            {
                while (dtr.Read())
                {
                    txtDepart.Text = dtr["routeFrom"].ToString();
                    txtDestination.Text = dtr["routeTo"].ToString();

                }

            }
            else
            {

            }
            conSche.Close();
            dtr.Close();
        }

        protected void txtDate_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void txtDepart_TextChanged1(object sender, EventArgs e)
        {
            if (txtRouteID.Text == "")
            {
                txtDepart.Text = "";

            }
        }

        protected void txtScheduleID_TextChanged(object sender, EventArgs e)
        {

        }

        

        
    }
}