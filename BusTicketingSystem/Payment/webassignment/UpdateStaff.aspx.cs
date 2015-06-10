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
    public partial class UpdateStaff : System.Web.UI.Page
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
            DropDownList2.Text = "Resigned";
            TextBox1.Enabled = true;
        }

  

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conStaff;
            String strUpdate;
            //SqlCommand cmdUpdate;
            SqlDataAdapter da;
            /*open connection to database*/
            string connStr = ConfigurationManager.ConnectionStrings["Payment"].ConnectionString;
            conStaff = new SqlConnection(connStr);

            conStaff.Open();
            da = new SqlDataAdapter(connStr, connStr);
            strUpdate = "Update Staff Set Name=@Name, icNumber=@icNumber, address=@address, position=@position, salary=@salary, contactNo=@contactNo, loginID =@loginID, loginPSW=@loginPSW, status=@status Where StaffID=@StaffID";

            da.UpdateCommand = new SqlCommand(strUpdate, conStaff);
            da.UpdateCommand.Parameters.AddWithValue("@StaffID", TextBox1.Text);
            da.UpdateCommand.Parameters.AddWithValue("@Name", TextBox2.Text);
            da.UpdateCommand.Parameters.AddWithValue("@icNumber", TextBox3.Text);
            da.UpdateCommand.Parameters.AddWithValue("@address", TextBox4.Text);
            da.UpdateCommand.Parameters.AddWithValue("@position", DropDownList1.SelectedValue);
            da.UpdateCommand.Parameters.AddWithValue("@salary", TextBox5.Text);
             da.UpdateCommand.Parameters.AddWithValue("@contactNo", TextBox6.Text);
             da.UpdateCommand.Parameters.AddWithValue("@loginID", TextBox7.Text);
             da.UpdateCommand.Parameters.AddWithValue("@loginPSW", TextBox8.Text);
             da.UpdateCommand.Parameters.AddWithValue("@status", DropDownList2.SelectedValue);


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

        protected void Button2_Click(object sender, EventArgs e)
        {
           
            string strSelect;
            // SqlCommand cmdSelect;
            //SqlDataReader dtr;
            SqlDataAdapter da;

            SqlConnection conStaff;
            string connStr = ConfigurationManager.ConnectionStrings["Payment"].ConnectionString;
            conStaff = new SqlConnection(connStr);
            conStaff.Open();
            strSelect = "Select * From dbo.Staff where StaffID=@StaffID";
            da = new SqlDataAdapter(strSelect, connStr);
            da.SelectCommand = new SqlCommand(strSelect, conStaff);
            da.SelectCommand.Parameters.AddWithValue("@StaffID", TextBox1.Text);

            // dtr = da.SelectCommand.ExecuteReader();
            DataSet custDS = new DataSet();

            da.Fill(custDS, "Staff");

            foreach (DataRow row in custDS.Tables["Staff"].Rows)
            {
                TextBox2.Text = row["Name"].ToString();
                TextBox3.Text = row["icNumber"].ToString();
                TextBox4.Text = row["address"].ToString();
                DropDownList1.Text = row["position"].ToString();
                TextBox5.Text = row["salary"].ToString();
                TextBox6.Text = row["contactNo"].ToString();
                TextBox7.Text = row["loginID"].ToString();
                TextBox8.Text = row["loginPSW"].ToString();
                DropDownList2 .Text = row["status"].ToString();


            }

            conStaff.Close();
            TextBox1.Enabled = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            cleartext();
        }

    }
}