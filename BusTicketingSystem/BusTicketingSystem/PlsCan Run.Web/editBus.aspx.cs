using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlsCan_Run
{
    public partial class editBus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conBus;
            String strUpdate;
            SqlCommand cmdUpdate;
            //SqlDataAdapter da;
            /*open connection to database*/
            string connStr = ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString;
            conBus = new SqlConnection(connStr);

            conBus.Open();
          
            strUpdate = "Update Bus Set carPlateNo=@carPlateNo, noOfSeat=@noOfSeat, carRegistrationNumber=@carRegistrationNumber Where BusID=@BusID";

            cmdUpdate = new SqlCommand(strUpdate, conBus);
            cmdUpdate.Parameters.AddWithValue("@BusID", DropDownList1.Text);
            cmdUpdate.Parameters.AddWithValue("@carPlateNo", TextBox2.Text);
            cmdUpdate.Parameters.AddWithValue("@noOfSeat", TextBox3.Text);
            cmdUpdate.Parameters.AddWithValue("@carRegistrationNumber", TextBox4.Text);


            int intNoofUpdate = cmdUpdate.ExecuteNonQuery();

            if (intNoofUpdate != 0)
            {
                Response.Write("<script>alert('Record Updated');</script>");
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";

              

            }
            else
            {
                Response.Write("<script>alert('Update Fail');</script>");
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";



            }

            conBus.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";


            
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

            strEdit = "Select * from Bus WHERE BusID=@BusID";
            cmdEdit = new SqlCommand(strEdit, conCust);

            cmdEdit.Parameters.AddWithValue("@BusID", DropDownList1.SelectedValue);

            dtr = cmdEdit.ExecuteReader();

            while (dtr.Read())
            {
                TextBox2.Text = dtr["carPlateNo"].ToString();
                TextBox3.Text = dtr["noOfSeat"].ToString();
                TextBox4.Text = dtr["carRegistrationNumber"].ToString();
            }
            conCust.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("BusMenu.aspx");
        }


    }
}