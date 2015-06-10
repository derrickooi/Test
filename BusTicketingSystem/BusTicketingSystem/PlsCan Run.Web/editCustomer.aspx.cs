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
    public partial class editCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conStaff;
            String strUpdate;
            SqlCommand cmdUpdate;
            //SqlDataAdapter da;
            /*open connection to database*/
            string connStr = ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString;
            conStaff = new SqlConnection(connStr);

            conStaff.Open();

            strUpdate = "Update Customer Set Name=@Name, icNo=@icNo, contact=@contact, address=@address, email=@email Where CustID=@CustID";

            cmdUpdate = new SqlCommand(strUpdate, conStaff);
            cmdUpdate.Parameters.AddWithValue("@CustID", DropDownList2.Text);
            cmdUpdate.Parameters.AddWithValue("@Name", TextBox2.Text);
            cmdUpdate.Parameters.AddWithValue("@icNo", TextBox3.Text);
            cmdUpdate.Parameters.AddWithValue("@contact", TextBox4.Text);
            cmdUpdate.Parameters.AddWithValue("@address", TextBox6.Text);
            cmdUpdate.Parameters.AddWithValue("@email", TextBox7.Text);


            int intNoofUpdate = cmdUpdate.ExecuteNonQuery();

            if (intNoofUpdate != 0)
            {
                Response.Write("<script>alert('Record Updated');</script>");
                cleartext();
            }
            else
            {
                Response.Write("<script>alert('Update Fail');</script>");
                cleartext();
            }

            conStaff.Close();
        }
        public void cleartext()
        {
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            cleartext();
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conCust;
            string strEdit;
            SqlCommand cmdEdit;
            SqlDataReader dtr;
            /*open connection to database*/
            string connStr = ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString;
            conCust = new SqlConnection(connStr);

            conCust.Open();

            strEdit = "Select * from Customer WHERE CustID=@CustID";
            cmdEdit = new SqlCommand(strEdit, conCust);

            cmdEdit.Parameters.AddWithValue("@CustID", DropDownList2.SelectedValue);

            dtr = cmdEdit.ExecuteReader();

            while (dtr.Read())
            {
                TextBox2.Text = dtr["Name"].ToString();
                TextBox3.Text = dtr["icno"].ToString();
                TextBox4.Text = dtr["contact"].ToString();
               
                TextBox6.Text = dtr["address"].ToString();
                TextBox7.Text = dtr["email"].ToString();
                
            }
            conCust.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerMenu.aspx");
        }
    }
}