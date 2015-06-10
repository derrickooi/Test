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
    public partial class addCustomer : System.Web.UI.Page
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
            string connStr = ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString;
            conStaff = new SqlConnection(connStr);
            da = new SqlDataAdapter(connStr, conStaff);

            strInsert = "Insert Into Customer (CustID,Name,icNo,contact, address, email) Values (@CustID,@Name,@icNo, @contact,@address,@email)";

            da.InsertCommand = new SqlCommand(strInsert, conStaff);
            da.InsertCommand.Parameters.AddWithValue("@CustID", TextBox1.Text);
            da.InsertCommand.Parameters.AddWithValue("@Name", TextBox2.Text);
            da.InsertCommand.Parameters.AddWithValue("@icNo", TextBox3.Text);
            da.InsertCommand.Parameters.AddWithValue("@contact", TextBox4.Text);
            da.InsertCommand.Parameters.AddWithValue("@address", TextBox6.Text);
            da.InsertCommand.Parameters.AddWithValue("@email", TextBox7.Text);

            conStaff.Open();
            da.InsertCommand.ExecuteNonQuery();

            Response.Write("<script>alert('Record Added');</script>");

            conStaff.Close();
            cleartext();
        }

        public void cleartext()
        {
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            Response.Redirect("addCustomer.aspx");
        }

        private String generateID()
        {
            string strSelect;
            SqlCommand cmdSelect;
            SqlDataReader dtr;

            SqlConnection conStaff;
            string connStr = ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString;
            conStaff = new SqlConnection(connStr);

            strSelect = "Select CustID From dbo.Customer";

            cmdSelect = new SqlCommand(strSelect, conStaff);
            //cmdSelect.Parameters.AddWithValue("@CustomerID", TextBox4.Text);
            conStaff.Open();
            dtr = cmdSelect.ExecuteReader();

            string lastValue = "";
            while (dtr.Read())
                lastValue = dtr["CustID"].ToString();


            conStaff.Close();
            if (lastValue == "")
            {
                return "C1001";
            }
            else
            {
                double genID = double.Parse(lastValue.Replace("C", ""));
                genID = genID + 1;
                return ("C" + genID.ToString());
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            cleartext();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerMenu.aspx");
        }
    }
}