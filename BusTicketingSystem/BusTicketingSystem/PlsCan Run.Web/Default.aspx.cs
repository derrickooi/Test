using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient; // IMPORTANT
using System.Configuration;// IMPORTANT

namespace PlsCan_Run
{
    public partial class Default : System.Web.UI.Page
    {
        string strSelect;
        SqlCommand cmdSelect;
        SqlDataReader dtr;

        SqlConnection conSche;
        string connStr = ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conSche = new SqlConnection(connStr);
            strSelect = "SELECT loginID, loginPSW FROM Staff";


            cmdSelect = new SqlCommand(strSelect, conSche);

            conSche.Open();
            dtr = cmdSelect.ExecuteReader();





            if (dtr.HasRows)
            {
                while (dtr.Read())
                {

                    if (dtr["loginID"].ToString() == TextBox1.Text && dtr["loginPSW"].ToString() == TextBox2.Text)
                    {
                        Response.Write("<script language='javascript'>window.alert('Welcome.');window.location='Home.aspx';</script>");
                    
                        break;

                    }
                    else {
                        Response.Write("<script language='javascript'>window.alert('Invalid ID or Password.');window.location='Default.aspx';</script>");

                        break;
                    }


                }

            }
            else
            {

            }
            conSche.Close();
            dtr.Close();
        }
    }
}