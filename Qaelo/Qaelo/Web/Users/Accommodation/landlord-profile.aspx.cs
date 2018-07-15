using Qaelo.Data.AccommodationData;
using Qaelo.Data.Accounts;
using Qaelo.Models.AccommodationModel;
using System;
using System.IO;


namespace Qaelo.Web.Users.Accommodation
{
    public partial class landlord_profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ////Get a manager
            if (Session["PROPERTYMANAGER"] == null)
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Accommodation/landlord-profile.aspx");

            Manager manager = (Manager)(Session["PROPERTYMANAGER"]);
            if (!IsPostBack)
            {
                //Populate the Fields
                txtAccommodationName.Text = manager.propertyName;
                txtDescription.Text = manager.descriptionOfProperty;
                txtEmail.Text = manager.email;
                //txtFacebookLink.Text = manager.facebookLink;
                txtLastName.Text = manager.lastName;
                txtName.Text = manager.firstName;
                txtNumber.Text = manager.number;
                ddlAccredited.SelectedItem.Value = manager.accredited.ToString();

                string value = "";

                if (manager.accredited)
                    value = "true";
                else
                    value = "false";

                ddlAccredited.SelectedIndex = ddlAccredited.Items.IndexOf(ddlAccredited.Items.FindByValue(value));

            }
        }


        protected void btnFinish_Click(object sender, EventArgs e)
        {
            Manager manager = (Manager)(Session["PROPERTYMANAGER"]);
            //Validation Test
            string filename = "";

            ////Capture data
            //if (wizardPicture.HasFile)
            //{
            //    try
            //    {
            //        filename = Path.GetFileName(wizardPicture.FileName);
            //        wizardPicture.SaveAs(Server.MapPath("../../../Images/Users/Accommodation/") + filename);
            //    }
            //    catch (Exception ex)
            //    {
            //        lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
            //    }
            //}
            //else
            //{
            //    filename = Session["PROFILEIMAGE"].ToString();
            //}

            //Store to database 

            Manager man = new Manager(manager.id, Convert.ToBoolean(ddlAccredited.SelectedItem.Value), txtDescription.Text, txtEmail.Text, "", txtName.Text, txtLastName.Text, txtNumber.Text, "", filename, txtAccommodationName.Text, DateTime.Now, "PropertyManager", false);                                                                      //  RegistrationDate, UserType, Verified
            if (new ManagerConnection().updateManager(man, manager.id))
            {
                lblSuccess.Text = "Profile updated successfully";
                Session["PROPERTYMANAGER"] = man;
                Response.Redirect("landlord-profile.aspx");
            }
            else
            {
                lblErrorMessage.Text = "An error occured while updating your profile";
            }
            Session["PROFILEIMAGE"] = null;
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == txtNewPassword.Text && !(txtConfirmPassword.Text == "" && "" == txtNewPassword.Text))
            {
                AccountConnection account = new AccountConnection();

                Manager s = (Manager)(Session["PROPERTYMANAGER"]);

                //Test password 

                if (account.correctPropertyManager(s.email, Secrecy.HashPassword(txtCurrentPassword.Text)) && new ManagerConnection().updateManagerPassword(s.id, Secrecy.HashPassword(txtNewPassword.Text), Secrecy.HashPassword(txtCurrentPassword.Text)))
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