using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace PaymentModule
{
    public partial class UpdateBus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conBus;
            String strUpdate;
            //SqlCommand cmdUpdate;
            SqlDataAdapter da;
            /*open connection to database*/
            string connStr = ConfigurationManager.ConnectionStrings["Payment"].ConnectionString;
            conBus = new SqlConnection(connStr);

            conBus.Open();
            da = new SqlDataAdapter(connStr, connStr);
            strUpdate = "Update Bus Set carPlateNo=@carPlateNo, noOfSeat=@noOfSeat, carRegistrationNumber=@carRegistrationNumber, expDate = @expDate, roadTax= @roadTax Where BusID=@BusID";

            da.UpdateCommand = new SqlCommand(strUpdate, conBus);
            da.UpdateCommand.Parameters.AddWithValue("@BusID", TextBox1.Text);
            da.UpdateCommand.Parameters.AddWithValue("@carPlateNo", TextBox2.Text);
            da.UpdateCommand.Parameters.AddWithValue("@noOfSeat", TextBox3.Text);
            da.UpdateCommand.Parameters.AddWithValue("@carRegistrationNumber", TextBox4.Text);
            da.UpdateCommand.Parameters.AddWithValue("@expDate", datepicker.Text);
            da.UpdateCommand.Parameters.AddWithValue("@roadTax", datepicker1.Text);

            int intNoofUpdate = da.UpdateCommand.ExecuteNonQuery();

            if (intNoofUpdate != 0)
            {
                Response.Write("<script>alert('Record Updated');</script>");
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                datepicker.Text = "";
                datepicker1.Text = "";
                TextBox1.Enabled = true;
                TextBox1.Text = "";
            }
            else
            {
                Response.Write("<script>alert('Update Fail');</script>");
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                datepicker.Text = "";
                datepicker1.Text = "";
                TextBox1.Enabled = true;
                TextBox1.Text = "";
            }

            conBus.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string strSelect;
            // SqlCommand cmdSelect;
            //SqlDataReader dtr;
            SqlDataAdapter da;

            SqlConnection conBus;
            string connStr = ConfigurationManager.ConnectionStrings["Payment"].ConnectionString;
            conBus = new SqlConnection(connStr);
            conBus.Open();
            strSelect = "Select * From dbo.Bus where BusID=@BusID";
            da = new SqlDataAdapter(strSelect, connStr);
            da.SelectCommand = new SqlCommand(strSelect, conBus);
            da.SelectCommand.Parameters.AddWithValue("@BusID", TextBox1.Text);

            // dtr = da.SelectCommand.ExecuteReader();
            DataSet custDS = new DataSet();
            
            da.Fill(custDS, "Bus");



            foreach (DataRow row in custDS.Tables["Bus"].Rows)
            {
                TextBox2.Text = row["carPlateNo"].ToString();
                TextBox3.Text = row["noOfSeat"].ToString();
                TextBox4.Text = row["carRegistrationNumber"].ToString();
                datepicker.Text = row["expDate"].ToString();
                datepicker1.Text = row["roadTax"].ToString();

            }

            conBus.Close();
            TextBox1.Enabled = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            datepicker.Text = "";
            datepicker1.Text = "";
            TextBox1.Enabled = true;

        }

  
    }
}