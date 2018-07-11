using Qaelo.Data.Accounts;
using Qaelo.Data.CompanyData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Company
{
    public partial class EditProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["COMPANY"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Company/EditProfile.aspx");
            }

            if(!IsPostBack)
            {
                //Get Company 
                Qaelo.Models.CompanyModel.Company company = (Qaelo.Models.CompanyModel.Company)Session["COMPANY"];
                txtDescription.Text = company.Description;
                txtEmail.Text = company.Email;
                txtFacebookLink.Text = company.FacebookLink;
                txtName.Text = company.Name;
                txtNumber.Text = company.Number;
                txtCompanyType.Text = company.CompanyType;
                wizardPicturePreview.Src = "~/Images/Users/Company/" + company.ProfileImage;
            }
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            string filename = "";
            Qaelo.Models.CompanyModel.Company company = (Qaelo.Models.CompanyModel.Company)Session["COMPANY"];

            //Check if the files have something
            if (wizardPicture.HasFile)
            {
                try
                {
                    filename = company.Id + Path.GetFileName(wizardPicture.FileName);
                    wizardPicture.SaveAs(Server.MapPath("~/Images/Users/Company/") + filename);
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                    return;
                }
            }
            else
            {
                filename = company.ProfileImage;
            }

            Qaelo.Models.CompanyModel.Company companyUpdate = new Models.CompanyModel.Company(company.Id, txtCompanyType.Text, txtDescription.Text, company.Email, txtFacebookLink.Text, txtName.Text, txtNumber.Text, "", filename, company.RegistrationDate, company.UserType, company.Verified);

            if (new CompanyConnection().updateCompany(companyUpdate))
            {
                lblSuccess.Text = "Profile Updated Successfully";
                lblErrorMessage.Text = "";

                Session["COMPANY"] = companyUpdate;
            }
            else
            {
                lblErrorMessage.Text = "Could not update profile, please try again";
                lblSuccess.Text = "";
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == txtNewPassword.Text)
            {
                AccountConnection account = new AccountConnection();
                Qaelo.Models.CompanyModel.Company s = (Qaelo.Models.CompanyModel.Company)Session["COMPANY"];

                //Test password 

                if (account.correctCompany(s.Email, Secrecy.HashPassword(txtCurrentPassword.Text)) && account.updateCompanyPassword(s.Id, Secrecy.HashPassword(txtNewPassword.Text), Secrecy.HashPassword(txtCurrentPassword.Text)))
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