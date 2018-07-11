using Qaelo.Data.ShopData;
using Qaelo.Models.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Admin
{
    public partial class unConfirmAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["ADMIN"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx?");
            }

            #region Shop Owner

            ShopConnection shopConnection = new ShopConnection();
            //Check if Shopowner is to be confirmed 
            if (Request.QueryString["ShopId"] != null)
            {
                int id = Convert.ToInt32(Request.QueryString["ShopId"]);
                //Confirm user

                /***ADMIN ***/
                if (shopConnection.unVerifyShopowner(id))
                {
                    lblSuccess.Text = "You have successfully Deactivated the Account";
                    lblErrorMessage.Text = "";
                }
                else
                {
                    lblSuccess.Text = "";
                    lblErrorMessage.Text = "Could not Deactivate Account, please try again";
                }

            }
            List<Qaelo.Models.ShopOwnerModel.ShopOwner> shops = shopConnection.getAllShopOwners();

            foreach (Qaelo.Models.ShopOwnerModel.ShopOwner item in shops)
            {
                if (item.Verified)
                {
                    lblShopOwner.Text += string.Format(@"<tr>
                                                <td>{0}</td>
                                                <td>{1}</td>
                                                <td>{2}</td>
                                                <td>{3}</td>
                                                <td><a href='unConfirmAccount.aspx?ShopId={4}' class='btn btn-danger'>Deactivate</a></td>", item.FullName, item.Email, item.Number, General.getDateString(item.RegistrationDate), item.Id);
                }
            }
            #endregion

            #region Posters
            Data.EventsData.EventConnection posterConnection = new Data.EventsData.EventConnection();

            //Check if eventPoster is to be confirmed 
            if (Request.QueryString["posterId"] != null)
            {
                int id = Convert.ToInt32(Request.QueryString["posterId"]);
                //Confirm user

                /***ADMIN ***/
                if (posterConnection.unverify(id))
                {
                    lblSuccess.Text = "You have successfully Deactivated the Account";
                    lblErrorMessage.Text = "";
                }
                else
                {
                    lblSuccess.Text = "";
                    lblErrorMessage.Text = "Could not Deactivate Account, please try again";
                }
            }
            List<Qaelo.Models.EventPosterModel.EventPoster> posters = posterConnection.getAllPosters();

            foreach (Qaelo.Models.EventPosterModel.EventPoster item in posters)
            {
                if (item.Verified)
                {
                    lblEventPoster.Text += string.Format(@"<tr>
                                                <td>{0}</td>
                                                <td>{1}</td>
                                                <td>{2}</td>
                                                <td>{3}</td>
                                                <td><a href='unConfirmAccount.aspx?posterId={4}' class='btn btn-danger'>Deactivate</a></td>", item.FullName, item.Email, item.Number, General.getDateString(item.RegistrationDate), item.Id);
                }
            }
            #endregion

            #region Property Owner
            Data.AccommodationData.ManagerConnection managerConnection = new Data.AccommodationData.ManagerConnection();

            //Check if eventPoster is to be confirmed 
            if (Request.QueryString["managerId"] != null)
            {
                int id = Convert.ToInt32(Request.QueryString["managerId"]);
                //Confirm user

                /***ADMIN ***/
                if (managerConnection.unverify(id))
                {
                    lblSuccess.Text = "You have successfully Deactivate the Account";
                    lblErrorMessage.Text = "";
                }
                else
                {
                    lblSuccess.Text = "";
                    lblErrorMessage.Text = "Could not Deactivate Account, please try again";
                }
            }
            List<Qaelo.Models.AccommodationModel.Manager> managers = managerConnection.getAllManagers();

            foreach (Qaelo.Models.AccommodationModel.Manager item in managers)
            {
                if (item.verified)
                {
                    lblManagers.Text += string.Format(@"<tr>
                                                <td>{0}</td>
                                                <td>{1}</td>
                                                <td>{2}</td>
                                                <td>{3}</td>
                                                <td><a href='unConfirmAccount.aspx?managerId={4}' class='btn btn-danger'>Deactivate</a></td>", item.firstName + item.lastName, item.email, item.number, General.getDateString(item.registrationDate), item.id);
                }
            }
            #endregion

            #region Societies
            Data.SocietyData.SocietyConnection societyConnection = new Data.SocietyData.SocietyConnection();

            //Check if eventPoster is to be confirmed 
            if (Request.QueryString["societyId"] != null)
            {
                int id = Convert.ToInt32(Request.QueryString["societyId"]);
                //Confirm user

                /***ADMIN ***/
                if (societyConnection.unverify(id))
                {
                    lblSuccess.Text = "You have successfully Deactivated the Account";
                    lblErrorMessage.Text = "";
                }
                else
                {
                    lblSuccess.Text = "";
                    lblErrorMessage.Text = "Could not Deactivate Account, please try again";
                }
            }
            List<Qaelo.Models.SocietyModel.Society> societies = societyConnection.getAllSocieties();

            foreach (Qaelo.Models.SocietyModel.Society item in societies)
            {
                if (item.Verified)
                {
                    lblSocieties.Text += string.Format(@"<tr>
                                                <td>{0}</td>
                                                <td>{1}</td>
                                                <td>{2}</td>
                                                <td>{3}</td>
                                                <td><a href='unConfirmAccount.aspx?societyId={4}' class='btn btn-danger'>Deactivate</a></td>", item.Name, item.Email, item.Number, General.getDateString(item.RegistrationDate), item.Id);
                }
            }
            #endregion
        }
    }
}