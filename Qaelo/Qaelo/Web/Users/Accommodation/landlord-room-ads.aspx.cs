using Qaelo.Data.AccommodationData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Accommodation
{
    public partial class roomAds : System.Web.UI.Page
    {
        AccommodationConnection connection = new AccommodationConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PROPERTYMANAGER"] == null)
                Response.Redirect("~/Web/Account/tempLogin.aspx");


            Qaelo.Models.AccommodationModel.Manager manager = (Qaelo.Models.AccommodationModel.Manager)Session["PROPERTYMANAGER"];
            //if (!manager.verified)
            //    lblVerified.Text = "<div class='alert alert-danger'><h3>Your profile and Posts  Will only be public once your account has been verified by Admin</div></h3>";

            //Load all the id's of the students who liked an event 
            string html = "";

            // We check if there's a room post by the room manager 
            List<Qaelo.Models.AccommodationModel.Accommodation> rooms = connection.getAllMyRooms(manager.id);

            //if there's no post by the manager then we know that we dont have to display anything

            // if there's an post then we get all the universities where the manager has placed post  and compare with the student's post
            if (rooms != null)
            {
                List<Qaelo.Models.AccommodationModel.RoomAd> roomAds = connection.getAllRoomAds();
                //Get all rooms by manager 

                    foreach (Qaelo.Models.AccommodationModel.RoomAd roomAd in roomAds)
                    {
                        if (new Data.StudentData.StudentConnection().getStudentUniversity(roomAd.StudentId).Equals(rooms.First().university))
                        {

                            html += string.Format(@"                                
                                    <tr>
                                         
                                          <td>{0}</td>
                                          <td>{1}</td>
                                          <td>{2}</td>
                                          <td>{3}</td>
                                          <td>{4}</td>
                                          <td>{5}</td>
                                       
                                   </tr>
                                    ", new Data.StudentData.StudentConnection().getStudent(roomAd.StudentId).FirstName, roomAd.Number, roomAd.Arrangement, roomAd.Gender, roomAd.PaymentType, roomAd.RentAmount);
                        }
                    }
                //if (html == "") html = "<div class='alert alert-info'><h3>I'ts Empty here, Data will soon be available as soon as your students make new room ads</div></h3>";

            }
          lblAds.Text = html;
        }
    }
}