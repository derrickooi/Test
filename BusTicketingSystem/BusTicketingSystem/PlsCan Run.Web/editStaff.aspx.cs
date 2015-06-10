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
    public partial class editStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void cleartext()
        {
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";

            DropDownList1.Text = "Admin";
            
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

            strEdit = "Select * from Staff WHERE StaffID=@StaffID";
            cmdEdit = new SqlCommand(strEdit, conCust);

            cmdEdit.Parameters.AddWithValue("@StaffID", DropDownList2.SelectedValue);

            dtr = cmdEdit.ExecuteReader();

            while (dtr.Read())
            {
                TextBox2.Text = dtr["Name"].ToString();
                TextBox3.Text = dtr["icNumber"].ToString();
                TextBox4.Text = dtr["address"].ToString();
                DropDownList1.Text = dtr["position"].ToString();
                TextBox5.Text = dtr["salary"].ToString();
                TextBox6.Text = dtr["contactNo"].ToString();
                TextBox7.Text = dtr["loginID"].ToString();
                TextBox8.Text = dtr["loginPSW"].ToString();
                DropDownList3.Text = dtr["status"].ToString();
            }
            conCust.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conStaff;
            String strUpdate;
            //SqlCommand cmdUpdate;
            SqlDataAdapter da;
            /*open connection to database*/
            string connStr = ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString;
            conStaff = new SqlConnection(connStr);

            conStaff.Open();
            da = new SqlDataAdapter(connStr, connStr);
            strUpdate = "Update Staff Set Name=@Name, icNumber=@icNumber, address=@address, position=@position, salary=@salary, contactNo=@contactNo, loginID =@loginID, loginPSW=@loginPSW Where StaffID=@StaffID";

            da.UpdateCommand = new SqlCommand(strUpdate, conStaff);
            da.UpdateCommand.Parameters.AddWithValue("@StaffID", DropDownList2.SelectedValue);
            da.UpdateCommand.Parameters.AddWithValue("@Name", TextBox2.Text);
            da.UpdateCommand.Parameters.AddWithValue("@icNumber", TextBox3.Text);
            da.UpdateCommand.Parameters.AddWithValue("@address", TextBox4.Text);
            da.UpdateCommand.Parameters.AddWithValue("@position", DropDownList1.SelectedValue);
            da.UpdateCommand.Parameters.AddWithValue("@salary", TextBox5.Text);
            da.UpdateCommand.Parameters.AddWithValue("@contactNo", TextBox6.Text);
            da.UpdateCommand.Parameters.AddWithValue("@loginID", TextBox7.Text);
            da.UpdateCommand.Parameters.AddWithValue("@loginPSW", TextBox8.Text);


            int intNoofUpdate = da.UpdateCommand.ExecuteNonQuery();

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

        protected void Button3_Click(object sender, EventArgs e)
        {
            cleartext();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffMenu.aspx");
        }
    }
}