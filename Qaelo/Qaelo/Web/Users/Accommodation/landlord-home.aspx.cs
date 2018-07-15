using Qaelo.Data.AccommodationData;
using System;
using System.Collections.Generic;

namespace Qaelo.Web.Users.Accommodation
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PROPERTYMANAGER"] == null)
                Response.Redirect("~/Web/Account/tempLogin.aspx");

            AccommodationConnection connection = new AccommodationConnection();

            Qaelo.Models.AccommodationModel.Manager manager = (Qaelo.Models.AccommodationModel.Manager)Session["PROPERTYMANAGER"];
            if (!manager.verified)
                lblVerified.Text = "<div class='alert alert-danger'><h3>Your profile and Posts  Will only be public once your account has been verified by Admin</div></h3>";

            //Load all the id's of the students who liked an event 
            string html = "";

            //Get all rooms by manager 
            List<Qaelo.Models.AccommodationModel.Accommodation> rooms = connection.getAllMyRooms(manager.id);

            foreach(Qaelo.Models.AccommodationModel.Accommodation room in rooms)
            {
               List<int> userIds = connection.getAllJoinedUsers(room.id,manager.id);

                    html += string.Format(@"<h3 align='center'><a href='landlord-my-rooms.aspx'>List of users who Joined R{0} {1} room </a></h3>
                                <table class='table responsive table-striped table-bordered' cellspacing='0' width='100%'>
                               <thead>
                              <tr>
                                <th>Profile</th>
                                <th>Name</th>
                                <th>Email</th>
                                <th>Number</th>
                              </tr>
                            </thead><tbody>", room.price,room.arrangement);

                    foreach (int userId in userIds)
                    {
                        Qaelo.Models.StudentModel.Student s = new Data.Accounts.AccountConnection().getStudent(userId);
                        html += string.Format(@"
                                            <tr>
                                            <td><img src='../../../Images/Users/Students/{0}' class='img-thumbnail' width='50' height='50' /></td>
                                            <td>{1}</td>
                                            <td>{2}</td>
                                            <td>{3}</td>
                                          </tr>", s.ProfileImage, s.FirstName + " " + s.LastName, s.Email, s.Number);
                    }

                    html += "</tbody></table><br/>";
            }

            //if (html == "") html = "<div class='alert alert-info'><h3>I'ts Empty here, Data will soon be available as soon as your rooms get interaction</div></h3>";

            lblListOfUsers.Text = html;
        }
    }
}