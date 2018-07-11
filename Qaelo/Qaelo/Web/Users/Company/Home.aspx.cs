using Qaelo.Data.CompanyData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Company
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["COMPANY"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx"); 
            }
            string html = "";
            CompanyConnection connection = new CompanyConnection();
            Qaelo.Models.CompanyModel.Company company = (Qaelo.Models.CompanyModel.Company)Session["COMPANY"];
            List<Qaelo.Models.CompanyModel.Job> jobs = connection.getAllPostByCompanyId(company.Id);

            foreach (Qaelo.Models.CompanyModel.Job item in jobs)
            {
                List<int> userIds = connection.getAllLikedUsers(item.Id, company.Id);

                html += string.Format(@"<h3 align='center'><a href='landlord-my-rooms.aspx'>List of users who like:{0} Post</a></h3>
                                <table class='table responsive table-striped table-bordered' cellspacing='0' width='100%'>
                               <thead>
                              <tr>
                                <th>Profile</th>
                                <th>Name</th>
                                <th>Email</th>
                                <th>Number</th>
                              </tr>
                            </thead><tbody>", item.Title);
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

            //if (html == "") html = "<div class='alert alert-info'><h3>I'ts Empty here, Data will soon be available as soon as your posts get interaction</div></h3>";

            lblListOfUsers.Text = html;
        }
    }
}