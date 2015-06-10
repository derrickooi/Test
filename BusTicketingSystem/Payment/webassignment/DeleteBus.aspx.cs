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
    public partial class DeleteBus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conBus;
            string strDelete;
            //SqlCommand cmdDelete;
            SqlDataAdapter da;

            /*open connection to database*/
            string connStr = ConfigurationManager.ConnectionStrings["Payment"].ConnectionString;
            conBus = new SqlConnection(connStr);
            da = new SqlDataAdapter(connStr, conBus);
            conBus.Open();

            strDelete = "Delete Bus where BusID=@BusID";
            da.DeleteCommand = new SqlCommand(strDelete, conBus);

            da.DeleteCommand.Parameters.AddWithValue("@BusID", TextBox1.Text);

            int intNoofDelete = da.DeleteCommand.ExecuteNonQuery();

            conBus.Close();

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