using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlsCan_Run.Web
{
    public partial class deleteCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conCust;
            string strDelete;
            //SqlCommand cmdDelete;
            SqlDataAdapter da;

            /*open connection to database*/
            string connStr = ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString;
            conCust = new SqlConnection(connStr);
            da = new SqlDataAdapter(connStr, conCust);
            conCust.Open();

            strDelete = "Delete Customer where CustID=@CustID";
            da.DeleteCommand = new SqlCommand(strDelete, conCust);

            da.DeleteCommand.Parameters.AddWithValue("@CustID", DropDownList1.Text);

            int intNoofDelete = da.DeleteCommand.ExecuteNonQuery();

            conCust.Close();

            if (intNoofDelete != 0)
            {
                Response.Write("<script>alert('Record Deleted');</script>");
                DropDownList1.Text = "";
            }
            else
                Response.Write("<script>alert('No Such Record');</script>");
            DropDownList1.Text = "";
        }
    }
}