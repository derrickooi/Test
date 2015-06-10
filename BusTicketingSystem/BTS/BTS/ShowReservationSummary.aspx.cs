using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace BTS
{
    public partial class Print : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            retrieveXML();
        }

        private void retrieveXML() {
            XmlTextReader reader = new XmlTextReader(Server.MapPath("NewTicket.xml"));
            XmlNodeType type;

           

            while (reader.Read())
            {

                type = reader.NodeType;

                if (type == XmlNodeType.Element)
                {

                    if (reader.Name == "ReservationID")
                    {
                        reader.Read();
                        lblRsvID.Text = reader.Value;

                    }

                    if (reader.Name == "Date")
                    {
                        reader.Read();
                        lblDate.Text = reader.Value;

                    }

                    if (reader.Name == "Time")
                    {
                        reader.Read();
                        lblTime.Text = reader.Value;

                    }

                    if (reader.Name == "From")
                    {
                        reader.Read();
                        lblFrom.Text = reader.Value;

                    }

                    if (reader.Name == "To")
                    {
                        reader.Read();
                        lblTo.Text = reader.Value;

                    }

                    if (reader.Name == "SeatNumber")
                    {
                            reader.Read();
                            lblSeatNo.Text = reader.Value;

                    }

                    if (reader.Name == "TotalPassenger")
                    {
                        reader.Read();
                        lblPassenger.Text = reader.Value;

                    }

                    if (reader.Name == "TotalFare")
                    {
                        reader.Read();
                        lblFare.Text = reader.Value;

                    }

                    if (reader.Name == "BusNo")
                    {
                        reader.Read();
                        lblBusNo.Text = reader.Value;

                    }

                    if (reader.Name == "Name")
                    {
                        reader.Read();
                        lblName.Text = reader.Value;

                    }

                    if (reader.Name == "Phone")
                    {
                        reader.Read();
                        lblPhone.Text = reader.Value;

                    }

                    if (reader.Name == "IC")
                    {
                        reader.Read();
                        lblIC.Text = reader.Value;

                    }

                    
                }
               
            }
        }

      
    }
}