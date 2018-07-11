using Qaelo.Data.AccommodationData;
using Qaelo.Data.EventsData;
using Qaelo.Data.ShopData;
using Qaelo.Data.SocietyData;
using Qaelo.Data.StudentData;
using Qaelo.Models.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Admin
{
    public partial class ListOfUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["ADMIN"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx?");
            }

            //Remove users from the system
            if (Request.QueryString["student"] != null) new StudentConnection().deleteStudent(Convert.ToInt32(Request.QueryString["student"]));
            else if (Request.QueryString["shop"] != null) new ShopConnection().deleteShoProfile(Convert.ToInt32(Request.QueryString["shop"]));
            else if (Request.QueryString["accommodation"] != null) new ManagerConnection().deletedManager(Convert.ToInt32(Request.QueryString["accommodation"]));
            else if (Request.QueryString["society"] != null) new SocietyConnection().deleteProfile(Convert.ToInt32(Request.QueryString["society"]));
            else if (Request.QueryString["event"] != null) new EventConnection().deleteEventPoster(Convert.ToInt32(Request.QueryString["event"]));

            /** Students **/

            List<Qaelo.Models.StudentModel.Student> students = new StudentConnection().getAllStudents();
            lblNumOfStudents.Text = students.Count.ToString();
            //Load students 
            foreach(Qaelo.Models.StudentModel.Student item in students)
            {

                if(item != null)
                {
                    lblStudents.Text += string.Format(@"<tr>
                                                    <td>{0}</td>
                                                    <td>{1}</td>
                                                    <td>{2}</td>
                                                    <td>{3}</td>
                                                    <td>{4}</td>
                                                    <td><a href='ListOfUsers.aspx?student={5}' class='btn btn-danger'>Remove</a></td>
                                                    ", item.FirstName + " " + item.LastName, item.Email, item.Number,item.Institution,General.getDateString(item.RegistrationDate),item.Id);
                }
            }

            /** Shop Owners **/

            List<Qaelo.Models.ShopOwnerModel.ShopOwner> shops = new ShopConnection().getAllShopOwners();
            lblNumOfShopOwner.Text = shops.Count.ToString();

            foreach (Qaelo.Models.ShopOwnerModel.ShopOwner item in shops)
            {
                if(item == null)
                {
                    lblShops.Text += string.Format(@"<tr>
                                                    <td>{0}</td>
                                                    <td>{1}</td>
                                                    <td>{2}</td>
                                                    <td>{3}</td>
                                                    <td><a href='ListOfUsers.aspx?shop={4}' class='btn btn-danger'>Remove</a></td>
                                                    ", item.FullName, item.Email, item.Number, General.getDateString(item.RegistrationDate), item.Id);
                }
            }

            /**Event Posters **/
            List<Qaelo.Models.EventPosterModel.EventPoster> posters = new EventConnection().getAllPosters();
            lblNumOfEventPosters.Text = posters.Count.ToString();

            foreach (Qaelo.Models.EventPosterModel.EventPoster item in posters)
            {
                if(item != null)
                {
                    lblEventPosters.Text += string.Format(@"<tr>
                                                    <td>{0}</td>
                                                    <td>{1}</td>
                                                    <td>{2}</td>
                                                    <td>{3}</td>
                                                    <td><a href='ListOfUsers.aspx?event={4}' class='btn btn-danger'>Remove</a></td>
                                                    ", item.FullName, item.Email, item.Number, General.getDateString(item.RegistrationDate), item.Id);
                }
            }

            /*** Porperty Owner **/
            List<Qaelo.Models.AccommodationModel.Manager> managers = new ManagerConnection().getAllManagers();
            lblNumOfPorpertyOwners.Text = managers.Count.ToString();



            foreach (Qaelo.Models.AccommodationModel.Manager item in managers)
            {
                if(item != null)
                {
                    lblAccommodations.Text += string.Format(@"<tr>
                                                    <td>{0}</td>
                                                    <td>{1}</td>
                                                    <td>{2}</td>
                                                    <td>{3}</td>
                                                    <td><a href='ListOfUsers.aspx?accommodation={4}' class='btn btn-danger'>Remove</a></td>
                                                     ", item.firstName + " " + item.lastName, item.email, item.number, General.getDateString(item.registrationDate), item.id);
                }
            }

        }
    }
}