using Qaelo.Data.AccommodationData;
using Qaelo.Models.AccommodationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Student
{
    public partial class Room : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session
            //if (Session["STUDENT"] == null)
            //    Response.Redirect("~/Web/Account/tempLogin.aspx");

            if (Request.QueryString["id"] == null)
                Response.Redirect("~/Web/Users/Student/student-accommodation.aspx");

            int id = Convert.ToInt32(Request.QueryString["id"].ToString());

            reserveRoom.HRef = "students-book-a-room.aspx?id=" + id;

            if(Request.QueryString["reserve"] != null && Request.QueryString["id"] != null)
            {
                lblSuccess.Text = "Successfully Reserved this room, Please wait for email confirmation from the landlord";
            }

            Qaelo.Models.StudentModel.Student student = (Models.StudentModel.Student)(Session["STUDENT"]);

              AccommodationConnection connection = new AccommodationConnection();
            //Check if the user clicked the join button 
             
            if(student != null)
            {
                if (Request.QueryString["joinId"] != null)
                {
                    Qaelo.Models.AccommodationModel.Accommodation myroom = connection.getRoom(Convert.ToInt32(Request.QueryString["joinId"].ToString()));

                    connection.joinPropery(myroom.managerId, myroom.id, student.Id);
                }
                else if (Request.QueryString["unjoinId"] != null)
                {
                    Qaelo.Models.AccommodationModel.Accommodation myroom = connection.getRoom(Convert.ToInt32(Request.QueryString["unjoinId"].ToString()));

                    connection.unjoinProperty(myroom.id, student.Id);
                }
            }
            else
            {
                if (Request.QueryString["joinId"] != null)
                {
                    Response.Redirect("~/Web/Account/tempLogin.aspx");
                }
            }

            string name = "";
            //Load the Room 
            Qaelo.Models.AccommodationModel.Accommodation room = (new AccommodationConnection().getRoom(id));

            if (room == null)
                return;

            Manager manager = new ManagerConnection().getManager(room.managerId);
            //Confirm Veririfcation

            if (manager != null)
            {
                if (manager.verified)
                {
                    if (manager.propertyName != "")
                    {
                        name = manager.propertyName;
                    }
                    else
                    {
                        name = "Room Available";
                    }

                    if(student != null)
                    {
                        if(connection.propertyJoinedByUser(room.id, student.Id))
                        {
                            lblPanelTopic.Text = string.Format(@"{0} - {1}km away from {2}<a href='students-room.aspx?unjoinId={3} &id={3}' class='btn btn-danger btn-xs pull-right'>Joined</a>", name, room.distanceFromCampus, room.campus, room.id);
                        }
                        else
                        {
                           lblPanelTopic.Text = string.Format(@"{0} - {1}km away from {2}<a href='students-room.aspx?joinId={3} &id={3}' class='btn btn-primary btn-xs pull-right'>Join Property</a>", name, room.distanceFromCampus, room.campus, room.id);
                        }
                    }
                    else
                    {
                        lblPanelTopic.Text = string.Format(@"{0} - {1}km away from {2}<a href='students-room.aspx?joinId={3} &id={3}' class='btn btn-primary btn-xs pull-right'>Join Property</a>", name, room.distanceFromCampus, room.campus, room.id);
                    }

                    string[] listOfImages = room.images.Split(';');

                    if(listOfImages[0] != "")
                         imgImage1.Src = "../../../Images/Accommodation/" + listOfImages[0];
                    if (listOfImages[1] != "")
                        imgImage2.Src = "../../../Images/Accommodation/" + listOfImages[1];
                    if (listOfImages[2] != "")
                        imgImage3.Src = "../../../Images/Accommodation/" + listOfImages[2];
                    if (listOfImages[3] != "")
                        imgImage4.Src = "../../../Images/Accommodation/" + listOfImages[3];
                    if (listOfImages[4] != "")
                        imgImage5.Src = "../../../Images/Accommodation/" + listOfImages[4];

                    lblLocation.Text = room.address;
                    lblRoomType.Text = room.accomodationType;

                    lblEmail.Text = manager.email;
                    lblName.Text = manager.firstName + " " + manager.lastName;
                    lblNumber.Text = manager.number;
                    lblDescription.Text = room.description.Replace(char.ConvertFromUtf32(13), "<br/>");
                }
                else
                {
                    Response.Redirect("~/Web/Users/Student/student-accommodation.aspx");
                }
            }
            else
            {
                Response.Redirect("~/Web/Users/Student/student-accommodation.aspx");
            }
        }

        protected void btnPayDeposit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            Qaelo.Models.AccommodationModel.Accommodation myroom = new AccommodationConnection().getRoom(id);


            try
            {
                if (!Page.IsValid) return;

                // Create the order in your DB and get the ID
                string amount = myroom.price.ToString();
                string orderId = myroom.id.ToString();
                string name = "Qaelo, Room No" + orderId;

                string description = "Payment";

                string site = "";
                string merchant_id = "";
                string merchant_key = "";

                // Check if we are using the test or live system
                string paymentMode = System.Configuration.ConfigurationManager.AppSettings["PaymentMode"];

                if (paymentMode == "test")
                {
                    site = "https://sandbox.payfast.co.za/eng/process?";
                    merchant_id = "10000100";
                    merchant_key = "46f0cd694581a";
                }
                else if (paymentMode == "live")
                {
                    site = "https://www.payfast.co.za/eng/process?";
                    merchant_id = System.Configuration.ConfigurationManager.AppSettings["PF_MerchantID"];
                    merchant_key = System.Configuration.ConfigurationManager.AppSettings["PF_MerchantKey"];
                }
                else
                {
                    throw new InvalidOperationException("Cannot process payment if PaymentMode (in web.config) value is unknown.");
                }

                // Build the query string for payment site

                System.Text.StringBuilder str = new System.Text.StringBuilder();
                str.Append("merchant_id=" + HttpUtility.UrlEncode(merchant_id));
                str.Append("&merchant_key=" + HttpUtility.UrlEncode(merchant_key));
                str.Append("&return_url=" + HttpUtility.UrlEncode(System.Configuration.ConfigurationManager.AppSettings["PF_ReturnURL"]));
                str.Append("&cancel_url=" + HttpUtility.UrlEncode(System.Configuration.ConfigurationManager.AppSettings["PF_CancelURL"]));
                str.Append("&notify_url=" + HttpUtility.UrlEncode(System.Configuration.ConfigurationManager.AppSettings["PF_NotifyURL"]));

                str.Append("&m_payment_id=" + HttpUtility.UrlEncode(orderId));
                str.Append("&amount=" + HttpUtility.UrlEncode(amount));
                str.Append("&item_name=" + HttpUtility.UrlEncode(name));
                str.Append("&item_description=" + HttpUtility.UrlEncode(description));

                //Default email


                // Redirect to PayFast
                Response.Redirect(site + str.ToString());
            }
            catch (Exception ex)
            {
                // Handle your errors here (log them and tell the user that there was an error)
            }
        }
    }
}