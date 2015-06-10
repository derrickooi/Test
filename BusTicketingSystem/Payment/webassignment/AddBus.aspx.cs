using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace PaymentModule
{
    public partial class BusMaintain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = generateID();
        }

        private String generateID()
        {
            string strSelect;
            SqlCommand cmdSelect;
            SqlDataReader dtr;

            SqlConnection conCust;
            string connStr = ConfigurationManager.ConnectionStrings["Payment"].ConnectionString;
            conCust = new SqlConnection(connStr);

            strSelect = "Select BusID From dbo.Bus";

            cmdSelect = new SqlCommand(strSelect, conCust);
            //cmdSelect.Parameters.AddWithValue("@CustomerID", TextBox4.Text);
            conCust.Open();
            dtr = cmdSelect.ExecuteReader();

            string lastValue = "";
            while (dtr.Read())
                lastValue = dtr["BusID"].ToString();



            if (lastValue == "")
            {
                return "B103";
            }
            else
            {
                double genID = double.Parse(lastValue.Replace("B", ""));
                genID = genID + 1;
                return ("B" + genID.ToString());
            }

        }
        private void cleartext() {
            
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            datepicker.Text = "";
            datepicker1.Text = "";
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strInsert;
            //SqlCommand cmdInsert;
            SqlDataAdapter da;
            SqlConnection conBus;
            string connStr = ConfigurationManager.ConnectionStrings["Payment"].ConnectionString;
            conBus = new SqlConnection(connStr);
            da = new SqlDataAdapter(connStr, conBus);

            strInsert = "Insert Into Bus (BusID,carPlateNo,noOfSeat, carRegistrationNumber, expDate, roadTax) Values (@BusID,@carPlateNo,@noOfSeat, @carRegistrationNumber, @expDate, @roadTax)";

            da.InsertCommand = new SqlCommand(strInsert, conBus);
            da.InsertCommand.Parameters.AddWithValue("@BusID", TextBox1.Text);
            da.InsertCommand.Parameters.AddWithValue("@carPlateNo", TextBox2.Text);
            da.InsertCommand.Parameters.AddWithValue("@noOfSeat", TextBox3.Text);
            da.InsertCommand.Parameters.AddWithValue("@carRegistrationNumber", TextBox4.Text);
            da.InsertCommand.Parameters.AddWithValue("@expDate", datepicker.Text);
            da.InsertCommand.Parameters.AddWithValue("@roadTax", datepicker1.Text);

            conBus.Open();
            da.InsertCommand.ExecuteNonQuery();

            Response.Write("<script>alert('Record Added');</script>");

            conBus.Close();
            cleartext();
            TextBox1.Text = generateID();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            cleartext();
        }

    }
}