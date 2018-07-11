using Qaelo.Data.Accounts;
using Qaelo.Data.SocietyData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Society
{
    public partial class EditProfile1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SOCIETY"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Society/EditProfile.aspx");
            }
            if (IsPostBack)
            {

            }
            else
            {
                Qaelo.Models.SocietyModel.Society society = (Qaelo.Models.SocietyModel.Society)Session["SOCIETY"];
                txtDescription.Text = society.Description;
                txtEmail.Text = society.Email;
                txtFacebookLink.Text = society.FacebookLink;
                txtMeetingDays.Text = society.MeetingDay;
                txtMeetingTime.Text = society.MeetingTime;
                txtName.Text = society.Name;
                txtNumber.Text = society.Number;
                txtSocityType.Text = society.SocietyType;
                txtText.Text = society.University;

                wizardPicturePreview.Src = "../../../Images/Scociety/" + society.ProfileImage;


            }
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            if (txtText.Text == "")
            {
                lblErrorMessage.Text = "Please select a valid institution";
                return;
            }
            Qaelo.Models.SocietyModel.Society society = (Qaelo.Models.SocietyModel.Society)Session["SOCIETY"];
            bool uploadStatus = true;

            string filename1 = "";

            //Check if the files have something 
            if (wizardPicture.HasFile)
            {
                try
                {
                    filename1 = Path.GetFileName(wizardPicture.FileName);
                    wizardPicture.SaveAs(Server.MapPath("~/Images/Shops/") + filename1);
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                    uploadStatus = false;
                }
            }
            else
            {
                filename1 = society.ProfileImage;
            }

            if (uploadStatus)
            {
                string images = filename1;

                //Upload shop
                if (new SocietyConnection().updateProfile(new Qaelo.Models.SocietyModel.Society("", txtDescription.Text, txtEmail.Text, txtFacebookLink.Text, txtMeetingDays.Text, txtMeetingTime.Text, txtName.Text, txtNumber.Text, "", filename1, society.RegistrationDate, txtSocityType.Text, txtText.Text, "", "", false), society.Id))
                {
                    //New Society
                    Session["SOCIETY"] = new SocietyConnection().getSociety(society.Id);
                    Response.Redirect("PostProfile.aspx?page=EditProfile");
                }
                else
                {
                    lblErrorMessage.Text = "Sorry an error occured while updating your profile, please try again";
                }
            }
            else
            {
                lblErrorMessage.Text = "Sorry an error occured while updating your profile, please upload image again";
            }


        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == txtNewPassword.Text)
            {
                AccountConnection account = new AccountConnection();
                Qaelo.Models.SocietyModel.Society s = (Qaelo.Models.SocietyModel.Society)Session["SOCIETY"];

                //Test password 

                if (account.correctSociety(s.Email, Secrecy.HashPassword(txtCurrentPassword.Text)) && account.updatePassword(s.Id, Secrecy.HashPassword(txtNewPassword.Text), Secrecy.HashPassword(txtCurrentPassword.Text)))
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