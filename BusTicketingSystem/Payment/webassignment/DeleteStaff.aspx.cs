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
    public partial class DeleteStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conStaff;
            string strDelete;
            //SqlCommand cmdDelete;
            SqlDataAdapter da;

            /*open connection to database*/
            string connStr = ConfigurationManager.ConnectionStrings["Payment"].ConnectionString;
            conStaff = new SqlConnection(connStr);
            da = new SqlDataAdapter(connStr, conStaff);
            conStaff.Open();

            strDelete = "Delete Staff where StaffID=@StaffID";
            da.DeleteCommand = new SqlCommand(strDelete, conStaff);

            da.DeleteCommand.Parameters.AddWithValue("@StaffID", TextBox1.Text);

            int intNoofDelete = da.DeleteCommand.ExecuteNonQuery();

            conStaff.Close();

            if (intNoofDelete != 0)
            {
                Response.Write("<script>alert('Record Deleted');</script>");
                TextBox1.Text = "";
            }
            else
                Response.Write("<script>alert('No Such Record');</script>");
            TextBox1.Text = "";
        
        }
    }
}