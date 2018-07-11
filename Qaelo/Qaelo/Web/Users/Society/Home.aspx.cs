using Qaelo.Data.SocietyData;
using Qaelo.Models.EventPosterModel;
using System;
using System.Collections.Generic;

namespace Qaelo.Web.Users.Society
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SOCIETY"] == null)
                Response.Redirect("~/Web/Account/tempLogin.aspx");

            SocietyConnection connection = new SocietyConnection();

            Qaelo.Models.SocietyModel.Society poster = (Qaelo.Models.SocietyModel.Society)Session["SOCIETY"];

            if (!poster.Verified)
                lblVerified.Text = "<div class='alert alert-danger'><h3>Your profile and posts  Will only be public once your account has been verified by Admin</div></h3>";

            //Load all the id's of the students who liked an event 
            string html = "";
            List<int> eventIds = connection.getListOfEventIds(poster.Id);

            //Load all the Students
            foreach (int id in eventIds)
            {
                List<int> userIds = connection.getListOfStudentIds(id);

                MyEvent myEvent = connection.getEventById(id);
                    foreach (int userId in userIds)
                    {
                    html += string.Format(@"<h3 align='center'><a href='ManageEvents.aspx'>List of users who like {0} event</a></h3>
                                <table class='table responsive table-striped table-bordered' cellspacing='0' width='100%'>
                               <thead>
                              <tr>
                                <th>Profile</th>
                                <th>Name</th>
                                <th>Email</th>
                                <th>Number</th>
                              </tr>
                            </thead><tbody>", myEvent.Name);
                    Qaelo.Models.StudentModel.Student s = connection.getStudent(userId);
                        html += string.Format(@"
                                            <tr>
                                            <td><img src='../../../Images/Users/Students/{0}' class='img-thumbnail' width='50' height='50' /></td>
                                            <td>{1}</td>
                                            <td>{2}</td>
                                            <td>{3}</td>
                                          </tr>", s.ProfileImage, s.FirstName + " " + s.LastName, s.Email, s.Number, myEvent.Name);
                    html += "</tbody></table><br/>";

                }
            }

            if (html == "") html = "<div class='alert alert-warning'><h4>I'ts Empty here, Data will soon be available as soon as your events or profile get interaction</div></h4>";

            lblListOfUsers.Text = html;
        }
    }
}