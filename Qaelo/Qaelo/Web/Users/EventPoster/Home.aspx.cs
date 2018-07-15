using Qaelo.Data.EventsData;
using Qaelo.Models.EventPosterModel;
using System;
using System.Collections.Generic;

namespace Qaelo.Web.Users.EventPoster
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EVENTPOSTER"] == null)
                Response.Redirect("~/Web/Account/tempLogin.aspx");

            EventConnection connection = new EventConnection();
            Qaelo.Models.EventPosterModel.EventPoster poster = (Qaelo.Models.EventPosterModel.EventPoster)Session["EVENTPOSTER"];

            //Load all the id's of the students who liked an event 
            string html = "";
            List<int> eventIds = connection.getListOfEventIds(poster.Id);

            //Load all the Students
            foreach(int id in eventIds)
            {
                List<int> userIds = connection.getListOfStudentIds(id);
                MyEvent myEvent = connection.getEventById(id);

                if(userIds.Count > 0)
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
                foreach (int userId in userIds)
                {
                    Qaelo.Models.StudentModel.Student s = connection.getStudent(userId);
                    html += string.Format(@"
                                            <tr>
                                            <td><img src='../../../Images/Users/Students/{0}' class='img-thumbnail' width='50' height='50' /></td>
                                            <td>{1}</td>
                                            <td>{2}</td>
                                            <td>{3}</td>
                                          </tr>", s.ProfileImage,s.FirstName + " " + s.LastName , s.Email,s.Number,myEvent.Name);
                }

                html += "</tbody></table><br/>";

                }
            }

            //if (html == "") html = "<div class='alert alert-warning'><h4>I'ts Empty here, Data will soon be available as soon as your events get interaction</div></h4>";

            lblListOfUsers.Text = html;
        }
    }
}