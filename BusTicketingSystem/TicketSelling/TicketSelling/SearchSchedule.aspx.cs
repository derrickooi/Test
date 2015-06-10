using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; // IMPORTANT
using System.Configuration;// IMPORTANT

namespace TicketSelling
{
    public partial class SearchSchedule : System.Web.UI.Page
    {
        string strSelect;
        SqlCommand cmdSelect;
        SqlDataReader dtr;

        SqlConnection conSche;
        string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conSche = new SqlConnection(connStr);
            strSelect = "SELECT Schedule.ScheduleId, Route.RouteId, Route.Depart, Route.Destinate, Schedule.Date, Schedule.Time FROM Schedule INNER JOIN Route ON Schedule.RouteId = Route.RouteId";
            

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
                    txtDepart.Text = dtr["Depart"].ToString();
                    txtDestinate.Text = dtr["Destinate"].ToString();


                    

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
                    txtDepart.Text = dtr["Depart"].ToString();
                    txtDestinate.Text = dtr["Destinate"].ToString();

                }

            }
            else
            {

            }
            conSche.Close();
            dtr.Close();
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            conSche = new SqlConnection(connStr);
            strSelect = "Update Schedule Set RouteId=@RouteId, Date=@Date, Time=@Time Where ScheduleId=@ScheduleId";

            conSche.Open();

            cmdSelect = new SqlCommand(strSelect, conSche);
            cmdSelect.Parameters.AddWithValue("@ScheduleId", txtSchedule.Text);
            cmdSelect.Parameters.AddWithValue("@RouteId", txtRoute.Text);
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

        //conSche = new SqlConnection(connStr);
        //    strSelect = "Select * From dbo.Route where RouteId=@RouteId";

        //    cmdSelect = new SqlCommand(strSelect, conSche);
        //    cmdSelect.Parameters.AddWithValue("@RouteId", txtRoute.Text);
        //    conSche.Open();
        //    dtr = cmdSelect.ExecuteReader();




        }
    }
