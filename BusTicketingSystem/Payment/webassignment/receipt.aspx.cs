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
    public partial class AddStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = generateID();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strInsert;
            //SqlCommand cmdInsert;
            SqlDataAdapter da;
            SqlConnection conStaff;
            string connStr = ConfigurationManager.ConnectionStrings["Payment"].ConnectionString;
            conStaff = new SqlConnection(connStr);
            da = new SqlDataAdapter(connStr, conStaff);

            strInsert = "Insert Into Staff (StaffID,Name,icNumber, address,position,salary, contactNo, loginID, loginPSW,status) Values (@StaffID,@Name,@icNumber, @address,@position,@salary, @contactNo, @loginID, @loginPSW,@status)";

            da.InsertCommand = new SqlCommand(strInsert, conStaff);
        ("@status", DropDownList2.SelectedValue);

            conStaff.Open();
            da.InsertCommand.ExecuteNonQuery();

            Response.Write("<script>alert('Record Added');</script>");

            conStaff.Close();
            cleartext();
            TextBox1.Text = generateID();
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
        }

        private String generateID()
        {
            string strSelect;
            SqlCommand cmdSelect;
            SqlDataReader dtr;

            SqlConnection conStaff;
            string connStr = ConfigurationManager.ConnectionStrings["Payment"].ConnectionString;
            conStaff = new SqlConnection(connStr);

            strSelect = "Select StaffID From dbo.Staff";

            cmdSelect = new SqlCommand(strSelect, conStaff);
            //cmdSelect.Parameters.AddWithValue("@CustomerID", TextBox4.Text);
            conStaff.Open();
            dtr = cmdSelect.ExecuteReader();

            string lastValue = "";
            while (dtr.Read())
                lastValue = dtr["StaffID"].ToString();



            if (lastValue == "")
            {
                return "S10";
            }
            else
            {
                double genID = double.Parse(lastValue.Replace("S", ""));
                genID = genID + 1;
                return ("S" + genID.ToString());
            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            cleartext();
        }
    }
}