using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; // IMPORTANT
using System.Configuration;
using System.Xml;
using System.Text;


namespace BTS
{
    public partial class Reservation : System.Web.UI.Page
    {
        private int seatCount;
       // private String seatNumber;
     


        protected void Page_Load(object sender, EventArgs e)
        {
            if (DepartureTime.SelectedIndex == 0)
            {
                pnl1.Visible = false;
                s1.ImageUrl = "~/Images/available_seat_img.gif";
                s2.ImageUrl = "~/Images/available_seat_img.gif";
                s3.ImageUrl = "~/Images/available_seat_img.gif";
                s4.ImageUrl = "~/Images/available_seat_img.gif";
                s5.ImageUrl = "~/Images/available_seat_img.gif";
                s6.ImageUrl = "~/Images/available_seat_img.gif";
                s7.ImageUrl = "~/Images/available_seat_img.gif";
                s8.ImageUrl = "~/Images/available_seat_img.gif";
                s9.ImageUrl = "~/Images/available_seat_img.gif";
                s10.ImageUrl = "~/Images/available_seat_img.gif";
                s11.ImageUrl = "~/Images/available_seat_img.gif";
                s12.ImageUrl = "~/Images/available_seat_img.gif";
                s13.ImageUrl = "~/Images/available_seat_img.gif";
                s14.ImageUrl = "~/Images/available_seat_img.gif";
                s15.ImageUrl = "~/Images/available_seat_img.gif";
                s16.ImageUrl = "~/Images/available_seat_img.gif";
                s17.ImageUrl = "~/Images/available_seat_img.gif";
                s18.ImageUrl = "~/Images/available_seat_img.gif";
                s19.ImageUrl = "~/Images/available_seat_img.gif";
                s20.ImageUrl = "~/Images/available_seat_img.gif";
                s21.ImageUrl = "~/Images/available_seat_img.gif";
                s22.ImageUrl = "~/Images/available_seat_img.gif";
                s23.ImageUrl = "~/Images/available_seat_img.gif";
                s24.ImageUrl = "~/Images/available_seat_img.gif";
                s25.ImageUrl = "~/Images/available_seat_img.gif";
                s26.ImageUrl = "~/Images/available_seat_img.gif";
                s27.ImageUrl = "~/Images/available_seat_img.gif";
                s28.ImageUrl = "~/Images/available_seat_img.gif";
                s29.ImageUrl = "~/Images/available_seat_img.gif";
                s30.ImageUrl = "~/Images/available_seat_img.gif";
                s31.ImageUrl = "~/Images/available_seat_img.gif";

            }
            else
            {
                pnl1.Visible = true;
            }


           

        }

        protected void DepartureTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DepartureTime.SelectedIndex == 0)
            {
                pnl1.Visible = false;
                txtseatnumber.Text = "";
                txtseatqty.Text = "0";
            }
            else {
            

                //pnl1.Visible = true;
                if (splitSeat().Equals(""))
                {
                    pnl1.Visible = true;

                }
                else {
                    
                    string dbSeatNumber = splitSeat().Remove(0, 1);
                    string[] split = dbSeatNumber.Split(',');

                    foreach (string item in split)
                    {
                        //Console.WriteLine(item);
                        if (item == "S1")
                        {
                            s1.ImageUrl = "~/Images/booked_seat_img.gif";
                            s1.Enabled = false;
                        }
                        else if (item == "S2")
                        {
                            s2.ImageUrl = "~/Images/booked_seat_img.gif";
                            s2.Enabled = false;
                        }
                        else if (item == "S3")
                        {
                            s3.ImageUrl = "~/Images/booked_seat_img.gif";
                            s3.Enabled = false;
                        }
                        else if (item == "S4")
                        {
                            s4.ImageUrl = "~/Images/booked_seat_img.gif";
                            s4.Enabled = false;
                        }
                        else if (item == "S5")
                        {
                            s5.ImageUrl = "~/Images/booked_seat_img.gif";
                            s5.Enabled = false;
                        }
                        else if (item == "S6")
                        {
                            s6.ImageUrl = "~/Images/booked_seat_img.gif";
                            s6.Enabled = false;
                        }
                        else if (item == "S7")
                        {
                            s7.ImageUrl = "~/Images/booked_seat_img.gif";
                            s7.Enabled = false;
                        }
                        else if (item == "S8")
                        {
                            s8.ImageUrl = "~/Images/booked_seat_img.gif";
                            s8.Enabled = false;
                        }
                        else if (item == "S9")
                        {
                            s9.ImageUrl = "~/Images/booked_seat_img.gif";
                            s9.Enabled = false;
                        }
                        else if (item == "S10")
                        {
                            s10.ImageUrl = "~/Images/booked_seat_img.gif";
                            s10.Enabled = false;
                        }
                        else if (item == "S11")
                        {
                            s11.ImageUrl = "~/Images/booked_seat_img.gif";
                            s11.Enabled = false;
                        }
                        else if (item == "S12")
                        {
                            s12.ImageUrl = "~/Images/booked_seat_img.gif";
                            s12.Enabled = false;
                        }
                        else if (item == "S13")
                        {
                            s13.ImageUrl = "~/Images/booked_seat_img.gif";
                            s13.Enabled = false;
                        }
                        else if (item == "S14")
                        {
                            s14.ImageUrl = "~/Images/booked_seat_img.gif";
                            s14.Enabled = false;
                        }
                        else if (item == "S15")
                        {
                            s15.ImageUrl = "~/Images/booked_seat_img.gif";
                            s15.Enabled = false;
                        }
                        else if (item == "S16")
                        {
                            s16.ImageUrl = "~/Images/booked_seat_img.gif";
                            s16.Enabled = false;
                        }
                        else if (item == "S17")
                        {
                            s17.ImageUrl = "~/Images/booked_seat_img.gif";
                            s17.Enabled = false;
                        }
                        else if (item == "S18")
                        {
                            s18.ImageUrl = "~/Images/booked_seat_img.gif";
                            s18.Enabled = false;
                        }
                        else if (item == "S19")
                        {
                            s19.ImageUrl = "~/Images/booked_seat_img.gif";
                            s19.Enabled = false;
                        }
                        else if (item == "S20")
                        {
                            s20.ImageUrl = "~/Images/booked_seat_img.gif";
                            s20.Enabled = false;
                        }
                        else if (item == "S21")
                        {
                            s21.ImageUrl = "~/Images/booked_seat_img.gif";
                            s21.Enabled = false;
                        }
                        else if (item == "S22")
                        {
                            s22.ImageUrl = "~/Images/booked_seat_img.gif";
                            s22.Enabled = false;
                        }
                        else if (item == "S23")
                        {
                            s23.ImageUrl = "~/Images/booked_seat_img.gif";
                            s23.Enabled = false;
                        }
                        else if (item == "S24")
                        {
                            s24.ImageUrl = "~/Images/booked_seat_img.gif";
                            s24.Enabled = false;
                        }
                        else if (item == "S25")
                        {
                            s25.ImageUrl = "~/Images/booked_seat_img.gif";
                            s25.Enabled = false;
                        }
                        else if (item == "S26")
                        {
                            s26.ImageUrl = "~/Images/booked_seat_img.gif";
                            s26.Enabled = false;
                        }
                        else if (item == "S27")
                        {
                            s27.ImageUrl = "~/Images/booked_seat_img.gif";
                            s27.Enabled = false;
                        }
                        else if (item == "S28")
                        {
                            s28.ImageUrl = "~/Images/booked_seat_img.gif";
                            s28.Enabled = false;
                        }
                        else if (item == "S29")
                        {
                            s29.ImageUrl = "~/Images/booked_seat_img.gif";
                            s29.Enabled = false;
                        }
                        else if (item == "S30")
                        {
                            s30.ImageUrl = "~/Images/booked_seat_img.gif";
                            s30.Enabled = false;
                        }
                        else if (item == "S31")
                        {
                            s31.ImageUrl = "~/Images/booked_seat_img.gif";
                            s31.Enabled = false;
                        }


                    }
                }
                infolabel.Visible = false;
                lblinfo1.Visible = true;
                }
               
                
            
            
        }

        protected void s1_Click(object sender, ImageClickEventArgs e)
        {    
            if (s1.ImageUrl == "~/Images/available_seat_img.gif"){
               
               
                s1.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text =  txtseatnumber.Text + "S1,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }else{
            s1.ImageUrl = "~/Images/available_seat_img.gif";
            txtseatnumber.Text = txtseatnumber.Text.Replace("S1,", "");
            minusfare();
            minusseatqty();
            }
        }

        protected void s2_Click(object sender, ImageClickEventArgs e)
        {

            if (s2.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s2.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S2,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);

                addseatqty();

                addfare();

            }
            else
            {
                s2.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S2,", "");
                minusseatqty();
                minusfare();
            }
           
            
        }

        protected void s3_Click(object sender, ImageClickEventArgs e)
        {
            if (s3.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s3.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S3,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s3.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S3,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s4_Click(object sender, ImageClickEventArgs e)
        {
            if (s4.ImageUrl == "~/Images/available_seat_img.gif")
            {

               
                s4.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S4,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s4.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S4,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s5_Click(object sender, ImageClickEventArgs e)
        {
            if (s5.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s5.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S5,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s5.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S5,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s6_Click(object sender, ImageClickEventArgs e)
        {
            if (s6.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s6.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S6,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s6.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S6,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s7_Click(object sender, ImageClickEventArgs e)
        {
            if (s7.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s7.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S7,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s7.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S7,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s8_Click(object sender, ImageClickEventArgs e)
        {
            if (s8.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s8.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S8,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s8.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S8,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s9_Click(object sender, ImageClickEventArgs e)
        {
            if (s9.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s9.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S9,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s9.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S9,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s10_Click(object sender, ImageClickEventArgs e)
        {
            if (s10.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s10.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S10,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s10.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S10,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s11_Click(object sender, ImageClickEventArgs e)
        {
            if (s11.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s11.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S11,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s11.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S11,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s12_Click(object sender, ImageClickEventArgs e)
        {
            if (s12.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s12.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S12,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s12.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S12,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s13_Click(object sender, ImageClickEventArgs e)
        {
            if (s13.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s13.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S13,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s13.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S13,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s14_Click(object sender, ImageClickEventArgs e)
        {
            if (s14.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s14.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S14,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s14.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S14,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s15_Click(object sender, ImageClickEventArgs e)
        {
            if (s15.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s15.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S15,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s15.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S15,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s16_Click(object sender, ImageClickEventArgs e)
        {
            if (s16.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s16.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S16,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s16.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S16,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s17_Click(object sender, ImageClickEventArgs e)
        {
            if (s17.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s17.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S17,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s17.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S17,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s18_Click(object sender, ImageClickEventArgs e)
        {
            if (s18.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s18.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S18,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s18.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S18,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s19_Click(object sender, ImageClickEventArgs e)
        {
            if (s19.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s19.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S19,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s19.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S19,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s20_Click(object sender, ImageClickEventArgs e)
        {
            if (s20.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s20.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S20,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s20.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S20,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s21_Click(object sender, ImageClickEventArgs e)
        {
            if (s21.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s21.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S21,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s21.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S21,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s22_Click(object sender, ImageClickEventArgs e)
        {
            if (s22.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s22.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S22,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s22.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S22,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s23_Click(object sender, ImageClickEventArgs e)
        {
            if (s23.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s23.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S23,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s23.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S23,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s24_Click(object sender, ImageClickEventArgs e)
        {
            if (s24.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s24.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S24,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s24.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S24,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s25_Click(object sender, ImageClickEventArgs e)
        {
            if (s25.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s25.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S25,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s25.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S25,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s26_Click(object sender, ImageClickEventArgs e)
        {
            if (s26.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s26.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S26,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s26.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S26,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s27_Click(object sender, ImageClickEventArgs e)
        {
            if (s27.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s27.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S27,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s27.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S27,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s28_Click(object sender, ImageClickEventArgs e)
        {
            if (s28.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s28.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S28,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s28.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S28,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s29_Click(object sender, ImageClickEventArgs e)
        {
            if (s29.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s29.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S29,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s29.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S29,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s30_Click(object sender, ImageClickEventArgs e)
        {
            if (s30.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s30.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S30,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s30.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S30,", "");
                minusfare();
                minusseatqty();
            }
        }

        protected void s31_Click(object sender, ImageClickEventArgs e)
        {
            if (s31.ImageUrl == "~/Images/available_seat_img.gif")
            {


                s31.ImageUrl = "~/Images/selected_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text + "S31,";
                txtseatnumber.Text.Substring(0, txtseatnumber.Text.Length - 1);
                addseatqty();
                addfare();
            }
            else
            {
                s31.ImageUrl = "~/Images/available_seat_img.gif";
                txtseatnumber.Text = txtseatnumber.Text.Replace("S31,", "");
                minusfare();
                minusseatqty();
            }
        }


        private void addfare() {
            if (txtseatqty.Text == "0")
            {
                lbltotalfare.Text = "35.00";
            }
            else
            {
                double tmp1 = double.Parse(txtseatqty.Text);
                
               double tmp2 = tmp1 * 35.00;
                lbltotalfare.Text = tmp2.ToString("n2");
            }
        }

        private void minusfare() {
            double tmp1 = double.Parse(lbltotalfare.Text);
            tmp1 = tmp1 - 35.00;
            lbltotalfare.Text = tmp1.ToString("n2");
        }

        private void addseatqty() {
            if (txtseatqty.Text == "0")
            {
                txtseatqty.Text = "1";
            }
            else
            {
                int tmp = int.Parse(txtseatqty.Text);
                tmp = tmp + 1;
                txtseatqty.Text = tmp.ToString();
            }
        }


        private void minusseatqty() {
            int tmp = int.Parse(txtseatqty.Text);
            tmp = tmp - 1;
            txtseatqty.Text = tmp.ToString();
        }

        protected void ibnext_Click(object sender, ImageClickEventArgs e)
        {
           
        }

        protected void btnNext_Click(object sender, ImageClickEventArgs e)
        {
            pnl1.Visible = false;
            //pnl3.Visible = false;
            pnl2.Visible = true;
            Source.Enabled = false;
            Destination.Enabled = false;
            departon.Enabled = false;
            DepartureTime.Enabled = false;


            littotalseat.Text = txtseatqty.Text;
            littotalrent.Text = lbltotalfare.Text;
            litrent.Text = "RM35.00";
            seatnumber.Text = txtseatnumber.Text.Remove(txtseatnumber.Text.Length -1);
            litpnr.Text = generateID();
            litbusnumber.Text = "PLL779";
            btnSave.Visible = true;
            infolabel.Text = "Please fill in your information for verifying purpose upon ticket collection.";
            lblinfo2.Visible = true;
        }

        protected void Destination_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Destination.SelectedIndex != 0)
            {
                departon.Enabled = true;
            }
            else {
                departon.Enabled = false;
            }
        }

        protected void departon_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (departon.SelectedIndex != 0)
            {
                DepartureTime.Enabled = true;
            }
            else
            {
                DepartureTime.Enabled = false;
            }
        }

        protected void Source_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Source.SelectedIndex != 0)
            {
                Destination.Enabled = true;
            }
            else
            {
                Destination.Enabled = false;
            }
        }

        protected void btnSave_Click(object sender, ImageClickEventArgs e)
        {
            string strInsert;
            SqlCommand cmdInsert;

            SqlConnection conCust;
            string connStr = ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString;
            conCust = new SqlConnection(connStr);


            strInsert = "Insert Into ReservationTable (RsvID, RsvDate, RsvTime, RsvFrom, RsvTo, RsvSeatNumber, RsvTotalSeats, RsvTotalFare, RsvBusNo, RsvName, RsvPhoneNo, RsvIC) Values (@ID, @Date, @Time, @From, @To, @SeatNumber, @TotalSeats, @TotalFare, @BusNo, @Name, @PhoneNo, @IC)";

            cmdInsert = new SqlCommand(strInsert, conCust);

            cmdInsert.Parameters.AddWithValue("@ID", litpnr.Text);
            cmdInsert.Parameters.AddWithValue("@Date", departon.SelectedValue);
            cmdInsert.Parameters.AddWithValue("@Time", DepartureTime.SelectedValue);
            cmdInsert.Parameters.AddWithValue("@From", Source.SelectedValue);
            cmdInsert.Parameters.AddWithValue("@To", Destination.SelectedValue);
            cmdInsert.Parameters.AddWithValue("@SeatNumber", seatnumber.Text);
            cmdInsert.Parameters.AddWithValue("@TotalSeats", littotalseat.Text);
            cmdInsert.Parameters.AddWithValue("@TotalFare", littotalrent.Text);
            cmdInsert.Parameters.AddWithValue("@BusNo", litbusnumber.Text);
            cmdInsert.Parameters.AddWithValue("@Name",  txtname.Text);
            cmdInsert.Parameters.AddWithValue("@PhoneNo", txtphone.Text);
            cmdInsert.Parameters.AddWithValue("@IC",  txtpassport.Text);

            conCust.Open();
            cmdInsert.ExecuteNonQuery();

            //Type cstype = this.GetType();

            //// Get a ClientScriptManager reference from the Page class.
            //ClientScriptManager cs = Page.ClientScript;

            //// Check to see if the startup script is already registered.
            //if (!cs.IsStartupScriptRegistered(cstype, "PopupScript"))
            //{
            //    String cstext = "alert('Bus seat(s) suscessfully reserved.');";
            //    cs.RegisterStartupScript(cstype, "PopupScript", cstext, true);
            //    Response.Redirect("Reservation.aspx");
                
            //}

            Response.Write("<script language='javascript'>window.alert('Seat Booked Successfully.');window.location='Reservation.aspx';</script>");
            conCust.Close();

            generateXML();

            Response.Redirect("ShowReservationSummary.aspx");
            

        }

        private String generateID() {
            string strSelect;
            SqlCommand cmdSelect;
            SqlDataReader dtr;

            SqlConnection conCust;
            string connStr = ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString;
            conCust = new SqlConnection(connStr);

            strSelect = "Select RsvID From dbo.ReservationTable";

            cmdSelect = new SqlCommand(strSelect, conCust);
            //cmdSelect.Parameters.AddWithValue("@CustomerID", TextBox4.Text);
            conCust.Open();
            dtr = cmdSelect.ExecuteReader();
            
            string lastValue="";
            while (dtr.Read())
                lastValue = dtr["RsvID"].ToString();


            conCust.Close();
            if (lastValue == "")
            {
                return "RSV100200";
            }
            else {
                double genID = double.Parse(lastValue.Replace("RSV", ""));
                genID = genID +1;
                return ("RSV" + genID.ToString());
                }

            

        }

        private String splitSeat() {
            string strSelect;
            SqlCommand cmdSelect;
            SqlDataReader dtr;

            SqlConnection conCust;
            string connStr = ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString;
            conCust = new SqlConnection(connStr);

            strSelect = "Select RsvSeatNumber From dbo.ReservationTable WHERE RsvFrom=@From AND RsvTo=@To AND RsvDate=@Date AND RsvTime=@Time";

            cmdSelect = new SqlCommand(strSelect, conCust);
            cmdSelect.Parameters.AddWithValue("@Date", departon.SelectedValue);
            cmdSelect.Parameters.AddWithValue("@Time", DepartureTime.SelectedValue);
            cmdSelect.Parameters.AddWithValue("@From", Source.SelectedValue);
            cmdSelect.Parameters.AddWithValue("@To", Destination.SelectedValue);
            conCust.Open();
            dtr = cmdSelect.ExecuteReader();

            string dbSeatNumber = "";
            while (dtr.Read()) {

                dbSeatNumber = dbSeatNumber + ","+dtr["RsvSeatNumber"].ToString();
            }


            return dbSeatNumber;

        }

        private void generateXML(){

            XmlTextWriter xWriter = new XmlTextWriter(Server.MapPath("NewTicket.xml"), Encoding.UTF8);
            xWriter.WriteStartDocument();

            xWriter.WriteStartElement("TicketReservation");
            xWriter.WriteWhitespace("\n");
            xWriter.WriteElementString("ReservationID", litpnr.Text);
            xWriter.WriteWhitespace("\n");
            xWriter.WriteElementString("Date", departon.SelectedValue);
            xWriter.WriteWhitespace("\n");
            xWriter.WriteElementString("Time", DepartureTime.SelectedValue);
            xWriter.WriteWhitespace("\n");
            xWriter.WriteElementString("From", Source.SelectedValue);
            xWriter.WriteWhitespace("\n");
            xWriter.WriteElementString("To", Destination.SelectedValue);
            xWriter.WriteWhitespace("\n");
            xWriter.WriteElementString("SeatNumber", seatnumber.Text);
            xWriter.WriteWhitespace("\n");
            xWriter.WriteElementString("TotalPassenger",littotalseat.Text);
            xWriter.WriteWhitespace("\n");
            xWriter.WriteElementString("TotalFare", littotalrent.Text);
            xWriter.WriteWhitespace("\n");
            xWriter.WriteElementString("BusNo", litbusnumber.Text);
            xWriter.WriteWhitespace("\n");
            xWriter.WriteElementString("Name",  txtname.Text);
            xWriter.WriteWhitespace("\n");
            xWriter.WriteElementString("Phone", txtphone.Text);
            xWriter.WriteWhitespace("\n");
            xWriter.WriteElementString("IC",  txtpassport.Text);
            xWriter.WriteWhitespace("\n");
            xWriter.WriteEndDocument();
            xWriter.Close();
        }

    }
}