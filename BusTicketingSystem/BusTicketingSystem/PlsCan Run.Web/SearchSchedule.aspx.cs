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
    public partial class SearchSchedule : System.Web.UI.Page
    {
        string strSelect;
        SqlCommand cmdSelect;
        SqlDataReader dtr;

        SqlConnection conSche;
        string connStr = ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conSche = new SqlConnection(connStr);
            strSelect = "SELECT * FROM Schedule where ScheduleId = @ScheduleId";
            

            cmdSelect = new SqlCommand(strSelect, conSche);
            cmdSelect.Parameters.AddWithValue("@ScheduleId", txtSchedule.Text);
           
            conSche.Open();
            dtr = cmdSelect.ExecuteReader();


           


            if (dtr.HasRows)
            {
                while (dtr.Read())
                {


                    txtRoute.Text = dtr["RouteId"].ToString();
                    txtDate.Text = dtr["Date"].ToString();
                    txtTime.Text = dtr["Time"].ToString();
                    txtDepart.Text = dtr["routeFrom"].ToString();
                    txtDestinate.Text = dtr["routeTo"].ToString();


                    

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

        protected void txtRoute_TextChanged(object sender, EventArgs e)
        {
            conSche = new SqlConnection(connStr);
            strSelect = "Select * From dbo.Route where RouteId=@RouteId";

            cmdSelect = new SqlCommand(strSelect, conSche);
            cmdSelect.Parameters.AddWithValue("@RouteId", txtRoute.Text);
            conSche.Open();
            dtr = cmdSelect.ExecuteReader();




            if (dtr.HasRows)
            {
                while (dtr.Read())
                {
                    txtDepart.Text = dtr["routeFrom"].ToString();
                    txtDestinate.Text = dtr["routeTo"].ToString();

                }

            }
            else
            {

            }
            conSche.Close();
            dtr.Close();
        }

     

        protected void Button2_Click(object sender, EventArgs e)
        {


            conSche = new SqlConnection(connStr);

            conSche.Open();

            strSelect = "Delete Schedule where ScheduleId=@ScheduleId";
            cmdSelect = new SqlCommand(strSelect, conSche);

            cmdSelect.Parameters.AddWithValue("@ScheduleId", txtSchedule.Text);

            int intNoofDelete = cmdSelect.ExecuteNonQuery();

            conSche.Close();

            if (intNoofDelete != 0)
            {
                lblEdit.Text = "Record for this schedule is deleted";
                txtSchedule.Text = "";
                txtRoute.Text = "";
                txtDate.Text = "";
                txtTime.Text = "";
                
            }
            else
                lblEdit.Text = "No record for this schedule";
                
        }

        protected void txtSchedule_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("ScheduleMenu.aspx");
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            conSche = new SqlConnection(connStr);
            strSelect = "Update Schedule Set routeFrom = @routeFrom, routeTo = @routeTo, Date=@Date, Time=@Time Where ScheduleId=@ScheduleId";

            conSche.Open();

            cmdSelect = new SqlCommand(strSelect, conSche);
            cmdSelect.Parameters.AddWithValue("@ScheduleId", txtSchedule.Text);
            cmdSelect.Parameters.AddWithValue("@routeFrom", txtDepart.Text);
            cmdSelect.Parameters.AddWithValue("@routeTo", txtDestinate.Text);
            cmdSelect.Parameters.AddWithValue("@Date", txtDate.Text);
            cmdSelect.Parameters.AddWithValue("@Time", txtTime.Text);

            int intNoofUpdate = cmdSelect.ExecuteNonQuery();

            if (intNoofUpdate != 0)
            {
                lblEdit.Text = "Schedule is updated";

            }
            else
            {
                lblEdit.Text = "No record for this schedule.";

            }

            conSche.Close();

            Response.Redirect("SearchSchedule.aspx");
        }

        //conSche = new SqlConnection(connStr);
        //    strSelect = "Select * From dbo.Route where RouteId=@RouteId";

        //    cmdSelect = new SqlCommand(strSelect, conSche);
        //    cmdSelect.Parameters.AddWithValue("@RouteId", txtRoute.Text);
        //    conSche.Open();
        //    dtr = cmdSelect.ExecuteReader();




        }
    }
