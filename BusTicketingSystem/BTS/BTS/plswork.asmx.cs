
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BTS
{
    /// <summary>
    /// Summary description for plswork
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class plswork : System.Web.Services.WebService
    {

        [WebMethod(Description = "Insert Payment into Payment table")]
        public int InsertPayment(string paymentID, string reserveID, string Depart, string Arrival, string Date, string Time, string seatNumber, decimal grandTotal)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Payment"].ConnectionString))
            {
                string Query = "INSERT INTO [Payment] VALUES ('" + paymentID + "','" + reserveID + "','" + Depart + "','" + Arrival + "','" + Date + "','" + Time + "','" + seatNumber + "','" + grandTotal + "')";
                SqlCommand command = new SqlCommand(Query, connection);
                command.CommandType = CommandType.Text;
                connection.Open();
                int row = command.ExecuteNonQuery();

                return row;

            }
        }

        [WebMethod(Description = "Retrieve reserve ID and show related items")]
        public DataSet retrievePayment(string RsvID)
        {

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Payment"].ConnectionString))
            {
                string Query = "Select * From dbo.ReservationTable where  RsvID=  '" + RsvID + "'";
               
                SqlCommand command = new SqlCommand(Query, connection);
                command.CommandType = CommandType.Text;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
              //  SqlDataAdapter da = new SqlDataAdapter(Query, "Payment");

                DataTable myTable = new DataTable("myTable");              
                //myTable.Columns.Add("PaymentID", typeof(string));
                myTable.Columns.Add("RsvID", typeof(string));
                myTable.Columns.Add("RsvDate", typeof(string));
                myTable.Columns.Add("RsvTime", typeof(string));
                myTable.Columns.Add("RsvFrom", typeof(string));
                myTable.Columns.Add("RsvTo", typeof(string));
                myTable.Columns.Add("RsvSeatNumber", typeof(string));
                myTable.Columns.Add("RsvTotalFare", typeof(string));

                while (reader.Read())
            {
                 myTable.Rows.Add(new object[]
                 {
                      //reader["PaymentID"].ToString(), 
                      reader["RsvID"].ToString(), 
                      reader["RsvDate"].ToString(), reader["RsvTime"], reader
                      ["RsvFrom"], reader["RsvTo"], reader["RsvSeatNumber"],
                      reader["RsvTotalFare"]});
                 }
                 //myTable.Load(reader);
                 myTable.AcceptChanges();

                 DataSet ds = new DataSet();
                // da.Fill(ds, "Payment");
                 ds.Tables.Add(myTable);
                 ds.AcceptChanges();
                 return ds;
            }
            }
       
    }
}
