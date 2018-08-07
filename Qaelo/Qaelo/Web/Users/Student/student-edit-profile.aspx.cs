using Qaelo.Data.Accounts;
using Qaelo.Data.StudentData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Student
{
    public partial class student_edit_profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["STUDENT"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Student/student-edit-profile.aspx");
            }

            if (IsPostBack)
            {
            }
            else
            {
                Qaelo.Models.StudentModel.Student student = (Qaelo.Models.StudentModel.Student)Session["STUDENT"];

                txtDescription.Text = student.Description;
                txtEmail.Text = student.Email;
                txtName.Text = student.FirstName;
                txtLastName.Text = student.LastName;
                txtNumber.Text = student.Number;
                txtQualification.Text = student.QualificationEnrolled;
                if (student.YearOfStudy != string.Empty)
                    ddlYear.SelectedIndex = ddlYear.Items.IndexOf(ddlYear.Items.FindByValue(student.YearOfStudy));

                txtText.Text = student.Institution;

                string proficePic = "~/Images/Users/Students/" + student.ProfileImage;

                if (student.ProfileImage.Contains("http"))
                    proficePic = student.ProfileImage;

                wizardPicturePreview.Src = proficePic;

                //Freelancing autofill
                Qaelo.Models.StudentModel.Freelancer freelancer = new StudentConnection().Freelancer(student.Id);

                if (freelancer != null)
                {
                    ddlWork1.Text = freelancer.Work;
                    txtPrice.Text = freelancer.Price;
                    txtDescription.Text = freelancer.Description;
 
                    string terms = "";

                    if (freelancer.Price.Contains("Once-off"))
                    {
                        terms = "Once-off";
                        txtPrice.Text = freelancer.Price.Split(' ')[0];
                    }
                    else if (freelancer.Price.Contains("Per/Hour"))
                    {
                        terms = "Per/Hour";
                        txtPrice.Text = freelancer.Price.Split(' ')[0];
                    }
                    else if (freelancer.Price.Contains("Negotiable"))
                    {
                        terms = "Negotiable";
                    }
                    else
                    {
                        terms = "";
                    }


                    ddlPriceTerms.SelectedIndex = ddlPriceTerms.Items.IndexOf(ddlPriceTerms.Items.FindByValue(terms));
                }

            }
        }


        //protected void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    if (txtConfirmPassword.Text == txtNewPassword.Text)
        //    {
        //        AccountConnection account = new AccountConnection();
        //        Qaelo.Models.StudentModel.Student s = (Qaelo.Models.StudentModel.Student)Session["STUDENT"];

        //        //Test password 

        //        if (account.correctStudent(s.Email, Secrecy.HashPassword(txtCurrentPassword.Text)) && account.updateStudentPassword(s.Id, Secrecy.HashPassword(txtNewPassword.Text), Secrecy.HashPassword(txtCurrentPassword.Text)))
        //        {
        //            lblSuccess.Text = "Successfuly Updated Password";
        //            lblErrorMessage.Text = "";
        //        }
        //        else
        //        {
        //            lblErrorMessage.Text = "Incorrect Current Password";
        //            lblSuccess.Text = "";
        //        }
        //    }
        //    else
        //    {
        //        lblErrorMessage.Text = "New password and confirm Password Do not match ";
        //        lblSuccess.Text = "";
        //    }
        //}

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            Qaelo.Models.StudentModel.Student student = (Qaelo.Models.StudentModel.Student)Session["STUDENT"];

            if (txtText.Text == "")
            {
                lblErrorMessage.Text = "Please select a valid tertiary institutiom";
                return;
            }

            string filename1 = "";

            //Check if the files have something 
            if (wizardPicture.HasFile)
            {
                try
                {
                    filename1 = student.Id + Path.GetFileName(wizardPicture.FileName);
                    wizardPicture.SaveAs(Server.MapPath("~/Images/Users/Students/") + filename1);
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                    filename1 = student.ProfileImage;
                }
            }
            else
            {
                filename1 = student.ProfileImage;
            }

            /** Freelancing **/
            string price = "";
            string work = "";

            //set price 
            if (ddlPriceTerms.SelectedItem.Value == "Negotiable")
                price = "Negotiable";
            else
                price = txtPrice.Text + " " + ddlPriceTerms.SelectedItem.Value;

            //Validation 
            if (ddlWork1.Text != string.Empty)
                work += ddlWork1.Text;
            else
            {
                lblErrorMessage.Text = "Please select your freelancing specialty";
                return;
            }

            if (txtDescription.Text == "")
            {
                lblErrorMessage.Text = "Please provide description for your freelancing services";
                return;
            }
            else if (txtLastName.Text == "")
            {
                lblErrorMessage.Text = "Please provide provide your Surname";
                return;
            }
            else if (txtName.Text == "")
            {
                lblErrorMessage.Text = "Please provide provide your Name";
                return;
            }
            else if (txtNumber.Text == "")
            {
                lblErrorMessage.Text = "Please provide provide your Phone number";
                return;
            }
            else if (txtPrice.Text == "" && ddlPriceTerms.SelectedItem.Value != "Negotiable")
            {
                lblErrorMessage.Text = "Please provide price for your freelancing services";
                return;
            }
            else if (txtQualification.Text == "")
            {
                lblErrorMessage.Text = "Please provide provide qualification enrolled";
                return;
            }
            else if (ddlYear.SelectedItem.Value == "NONE")
            {
                lblErrorMessage.Text = "Please select year of study";
                return;
            }

                string images = filename1;
                //Upload 
                if (new StudentConnection().updateStudent(new Qaelo.Models.StudentModel.Student(student.Id, "", "", student.Email, txtName.Text, txtText.Text, txtLastName.Text, txtNumber.Text, "", filename1, txtQualification.Text, DateTime.Now, "", ddlYear.SelectedItem.Value)))
                {
                    //Save freelancing 
                    new StudentConnection().updateFreelancer(new Models.StudentModel.Freelancer(student.Id, txtDescription.Text, "", price, work));

                    Session["STUDENT"] = new AccountConnection().getStudent(student.Id);
                    Response.Redirect("students-profile.aspx?page=profile");
                }
                else
                {
                    lblErrorMessage.Text = "Sorry an error occured while updating your profile, please try again";
                }
        }
    }
}