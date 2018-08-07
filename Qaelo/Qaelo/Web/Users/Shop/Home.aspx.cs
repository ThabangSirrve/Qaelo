using Qaelo.Data.ShopData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Shop
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SHOPOWNER"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Shop/Home.aspx");
            }
            
            if(Request.QueryString["page"] == "editprofile")
            {
                lblSuccess.Text = "Successfully updated your profile";
            }

            ShopConnection connection = new ShopConnection();

            Qaelo.Models.ShopOwnerModel.ShopOwner owner = (Qaelo.Models.ShopOwnerModel.ShopOwner)Session["SHOPOWNER"];

            //Load all the id's of the students who liked an event 
            string html = "";

            //Load all the Students


            //Get all shops by owner 
            List<Qaelo.Models.ShopOwnerModel.Shop> shops = connection.getAllMyShops(owner.Id);

            foreach (Qaelo.Models.ShopOwnerModel.Shop shop in shops)
            {
                List<int> userIds = connection.getAllLikedUsers(shop.Id, owner.Id);

                html += string.Format(@"<h4 align='center'><a href='ManageListings.aspx'>List of users who Joined shop No:{0} specials </a></h3>
                                <table class='table responsive table-striped table-bordered' cellspacing='0' width='100%'>
                               <thead>
                              <tr>
                                <th>Profile</th>
                                <th>Name</th>
                                <th>Email</th>
                                <th>Number</th>
                              </tr>
                            </thead><tbody>", shop.Address);
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