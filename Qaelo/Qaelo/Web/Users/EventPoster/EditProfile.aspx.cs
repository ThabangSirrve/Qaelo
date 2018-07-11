using Qaelo.Data.Accounts;
using Qaelo.Data.EventsData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.EventPoster
{
    public partial class EditProfile1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EVENTPOSTER"] == null)
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/EventPoster/EditProfile.aspx");

            if(!IsPostBack)
            {
                Qaelo.Models.EventPosterModel.EventPoster poster = (Qaelo.Models.EventPosterModel.EventPoster)Session["EVENTPOSTER"];
                txtEmail.Text = poster.Email;
                txtFullName.Text = poster.FullName;
                txtNumber.Text = poster.Number;

            }
            //wizardPicturePreview.Src = "~/Images/Events/" + poster.ProfileImage;
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            Qaelo.Models.EventPosterModel.EventPoster poster = (Qaelo.Models.EventPosterModel.EventPoster)Session["EVENTPOSTER"];
            //Validation Test
            string filename = "";

            //Capture data
            //if (wizardPicture.HasFile)
            //{
            //    try
            //    {
            //        filename = poster.Id + Path.GetFileName(wizardPicture.FileName);
            //        wizardPicture.SaveAs(Server.MapPath("~/Images/Events/") + filename);
            //    }
            //    catch (Exception ex)
            //    {
            //        lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
            //    }
            //}
            //else
            //{
            //    filename = poster.ProfileImage;
            //}

            //Store to database 

            Qaelo.Models.EventPosterModel.EventPoster pos = new Qaelo.Models.EventPosterModel.EventPoster(poster.Id, poster.Email, txtFullName.Text, txtNumber.Text, "", filename, DateTime.Now, "", false);
            if (new EventConnection().updateEventPoster(pos))
            {
                lblSuccess.Text = "Profile updated successfully";
                Session["PROPERTYMANAGER"] = pos;
                Response.Redirect("Home.aspx");
            }
            else
            {
                lblErrorMessage.Text = "An error occured while updating your profile";
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == txtNewPassword.Text && !(txtConfirmPassword.Text == "" && "" == txtNewPassword.Text))
            {
                AccountConnection account = new AccountConnection();

                Qaelo.Models.EventPosterModel.EventPoster s = (Qaelo.Models.EventPosterModel.EventPoster)(Session["EVENTPOSTER"]);

                //Test password 
                if (account.correctEventPoster(s.Email, Secrecy.HashPassword(txtCurrentPassword.Text)) && new AccountConnection().updateEventPassword(s.Id, Secrecy.HashPassword(txtNewPassword.Text), Secrecy.HashPassword(txtCurrentPassword.Text)))
                {
                    lblSuccess.Text = "Successfuly Updated Password";
                    lblErrorMessage.Text = "";
                }
                else
                {
                    lblErrorMessage.Text = "Incorrect Current Password";
                    lblSuccess.Text = "";
                }
            }
            else
            {
                lblErrorMessage.Text = "New password and confirm Password Do not match ";
                lblSuccess.Text = "";
            }
        }
    }
}