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
    public partial class deleteBus : System.Web.UI.Page
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
            string connStr = ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString;
            conBus = new SqlConnection(connStr);
            da = new SqlDataAdapter(connStr, conBus);
            conBus.Open();

            strDelete = "Delete Bus where BusID=@BusID";
            da.DeleteCommand = new SqlCommand(strDelete, conBus);

            da.DeleteCommand.Parameters.AddWithValue("@BusID", DropDownList1.Text);

            int intNoofDelete = da.DeleteCommand.ExecuteNonQuery();

            conBus.Close();

            if (intNoofDelete != 0)
            {
                Response.Write("<script>alert('Record Deleted');</script>");
               
            }
            else
                Response.Write("<script>alert('No Such Record');</script>");
        
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("BusMenu.aspx");
        }
    }
}