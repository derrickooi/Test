using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Text;
using System.Collections;

namespace PlsCan_Run
{
    public partial class Payment : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Payment.mdf;Integrated Security=True;User Instance=True");
        decimal charge;


        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //   
        //    ServiceReference1.CountSoapClient client = new ServiceReference1.CountSoapClient();
        //    int row = client.InsertPayment(txtPID.Text, txtRID.Text, txtDepart.Text, txtArrival.Text, txtDate.Text, txtTime.Text, txtseatNo.Text, decimal.Parse(txtGTotal.Text), txtCCNo.Text, DropDownList1.SelectedItem.ToString(),txtAcc.Text );
        //    if (row > 0)
        //    {
        //        Response.Write("<script>alert('Payment Record insert successfuly');</script>");
        //         TextBox1.Text =txtRID.Text = txtDepart.Text = txtArrival.Text = txtDate.Text = txtTime.Text = txtseatNo.Text = txtAmount.Text = txtCharge.Text = txtGTotal.Text = txtCCNo.Text = txtAcc.Text= "";
        //        DropDownList1.Text = "Visa(+3%)";
        //    }
        //    else { Response.Write("<script>alert('Payment Record not insert');</script>"); }

        //    txtPID.Text = generateID();
            

        //}


        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString);
            conn.Open();
            string ID = TextBox1.Text;
            SqlCommand cmd = new SqlCommand("SELECT RsvID FROM dbo.ReservationTable WHERE RsvID=@RsvID", conn);
            cmd.Parameters.AddWithValue("@RsvID", ID);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader != null && reader.HasRows)
            {
                string strSelect;
                SqlDataAdapter da;

                SqlConnection conPay;
                string connStr = ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString;
                conPay = new SqlConnection(connStr);
                conPay.Open();
                strSelect = "Select * From dbo.ReservationTable where rsvID=@rsvID";
                da = new SqlDataAdapter(strSelect, connStr);
                da.SelectCommand = new SqlCommand(strSelect, conPay);
                da.SelectCommand.Parameters.AddWithValue("@rsvID", TextBox1.Text);

                // dtr = da.SelectCommand.ExecuteReader();
                DataSet custDS = new DataSet();
                da.Fill(custDS, "ReservationTable");

                foreach (DataRow row in custDS.Tables["ReservationTable"].Rows)
                {
                    // txtPID.Text = row["PaymentID"].ToString();
                    txtRID.Text = row["rsvID"].ToString();
                    txtDepart.Text = row["RsvFrom"].ToString();
                    txtArrival.Text = row["RsvTo"].ToString();
                    txtDate.Text = row["RsvDate"].ToString();
                    txtTime.Text = row["RsvTime"].ToString();
                    txtseatNo.Text = row["RsvSeatNumber"].ToString();
                    txtAmount.Text = row["RsvTotalFare"].ToString();

                }

                conPay.Close();
            }

            else
            {
                //if username is matching 
                Response.Write("<script>alert('Record not exist.');</script>");
                TextBox1.Text = "";
                conn.Close();

            }
        }

       


        

        protected void Page_Load(object sender, EventArgs e)
        {
            txtPID.Text = generateID();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;

            txtPID.Text = generateID();
            txtRID.Text = row.Cells[1].Text;
            txtDepart.Text = row.Cells[2].Text;
            txtArrival.Text = row.Cells[3].Text;
            txtDate.Text = row.Cells[4].Text;
            txtTime.Text = row.Cells[5].Text;
            txtseatNo.Text = row.Cells[6].Text;
            txtAmount.Text = row.Cells[7].Text;
            GridView1.Visible = false;

            txtCharge.Text = "";
            txtGTotal.Text = "";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            cleartext();
        }

        public void cleartext(){
        
            txtRID.Text = "";
            txtDepart.Text = "";
            txtArrival.Text = "";
            txtDate.Text = "";
            txtTime.Text = "";
            txtseatNo.Text = "";
            txtGTotal.Text = "";
            txtCCNo.Text = "";
            DropDownList1.Text = "";
            txtAcc.Text = "";
            txtAmount.Text = "";
            txtCharge.Text = "";
            TextBox1.Text = "";
            TextBox3.Text = "";
            TextBox2.Text = "";
            Label7.Visible = false;
            Label8.Visible = false;
            TextBox2.Visible = false;
            TextBox3.Visible = false;
            Label9.Visible = false;
            Label10.Visible = false;
            Button5.Visible = false;
            GridView1.Visible = false;
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
          
            string connStr = ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString;
            SqlConnection conPay;
            conPay = new SqlConnection(connStr);
            conPay.Open();
            SqlDataReader dtr;
            SqlCommand cmdSelect;
            string RsvIC = TextBox2.Text;
            string strSelect = "Select * From dbo.ReservationTable WHERE RsvIC = @RsvIC and RsvPhoneNo=@RsvPhoneNo";

         
            cmdSelect = new SqlCommand(strSelect, conPay);
            cmdSelect.Parameters.AddWithValue("@RsvIC", TextBox2.Text);
            cmdSelect.Parameters.AddWithValue("@RsvPhoneNo", TextBox3.Text);
           
            SqlDataReader reader = cmdSelect.ExecuteReader();
           

            if (reader != null && reader.HasRows)
            {
            GridView1.Visible = true;
          


            GridView1.DataSource = reader;
            GridView1.DataBind();
            }

            else
            {
                //if username is matching 
                Response.Write("<script>alert('Wrong Customer IC or Customer Phone Number.');</script>");
                TextBox2.Text = "";
                TextBox3.Text ="";
                conPay.Close();
                GridView1.Visible = false;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text == "")
            {
                Response.Write("<script>alert('Invalid.No Amount');</script>");
                DropDownList1.Text = "";
            }

            else
            {
                decimal amount = decimal.Parse(txtAmount.Text);
                if (DropDownList1.SelectedIndex == 1)
                {
                    charge = amount * 3 / 100;
                    txtCharge.Text = charge.ToString("N2");
                }
                else if (DropDownList1.SelectedIndex == 2)
                {
                    charge = amount * 5 / 100;
                    txtCharge.Text = charge.ToString("N2");
                }
                else if (DropDownList1.SelectedIndex == 0) {
                    txtCharge.Text = "";
                    txtGTotal.Text = "";
                }

                decimal gTotal = amount + charge;
                txtGTotal.Text = gTotal.ToString("N2");
            }
        }


        private String generateID()
        {
            string strSelect;
            SqlCommand cmdSelect;
            SqlDataReader dtr;

            SqlConnection conPay;
            string connStr = ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString;
            conPay = new SqlConnection(connStr);

            strSelect = "Select PaymentID From dbo.Payment";

            cmdSelect = new SqlCommand(strSelect, conPay);
            //cmdSelect.Parameters.AddWithValue("@CustomerID", TextBox4.Text);
            conPay.Open();
            dtr = cmdSelect.ExecuteReader();

            string lastValue = "";
            while (dtr.Read())
                lastValue = dtr["PaymentID"].ToString();



            if (lastValue == "")
            {
                return "P100200";
            }
            else
            {
                double genID = double.Parse(lastValue.Replace("P", ""));
                genID = genID + 1;
                return ("P" + genID.ToString());
            }


        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Label7.Visible = true;
            Label8.Visible = true;
            TextBox3.Visible = true;
            TextBox2.Visible = true;
            Button5.Visible = true;
            Label9.Visible = true;
            Label10.Visible = true;
        }

        protected void PayPalBtn_Click(object sender, ImageClickEventArgs e)
        {
            if (txtAmount.Text == "" || DropDownList1.SelectedIndex == 0)
            {
                Response.Write("<script>alert('Select Payment Method.');</script>");
            }
            else
            {

                Session["PID"] = txtPID.Text;
                Session["RID"] = txtRID.Text;
                Session["Depart"] = txtDepart.Text;
                Session["Arrival"] = txtArrival.Text;
                Session["Date"] = txtDate.Text;
                Session["Time"] = txtTime.Text;
                Session["SeatNumber"] = txtseatNo.Text;
                Session["GrandTotal"] = txtGTotal.Text;
                Session["PayMethod"] = DropDownList1.Text;

                string business = "payment@comfort4u.com";
                string itemName = txtRID.Text;
                double itemAmount = double.Parse(txtGTotal.Text) / 3.3;
                string currencyCode = "USD";
                string returns = "http://localhost:6911/PaymentSummary.aspx";

                StringBuilder ppHref = new StringBuilder();

                ppHref.Append("https://www.sandbox.paypal.com/cgi-bin/webscr?cmd=_xclick");
                ppHref.Append("&business=" + business);
                ppHref.Append("&item_name=" + itemName);
                ppHref.Append("&amount=" + itemAmount.ToString("#.00"));
                ppHref.Append("&currency_code=" + currencyCode);
                ppHref.Append("&return=" + returns);

                Response.Redirect(ppHref.ToString(), true);

            }

        }



    

        }
    }
