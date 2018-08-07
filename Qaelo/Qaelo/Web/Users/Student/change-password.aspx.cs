using Qaelo.Data.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Student
{
    public partial class change_password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["STUDENT"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Student/student-edit-profile.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (txtConfirmPassword.Text == txtNewPassword.Text)
            {
                AccountConnection account = new AccountConnection();
                Qaelo.Models.StudentModel.Student s = (Qaelo.Models.StudentModel.Student)Session["STUDENT"];

                //Test password 

                if (account.correctStudent(s.Email, Secrecy.HashPassword(txtCurrentPassword.Text)) && account.updateStudentPassword(s.Id, Secrecy.HashPassword(txtNewPassword.Text), Secrecy.HashPassword(txtCurrentPassword.Text)))
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