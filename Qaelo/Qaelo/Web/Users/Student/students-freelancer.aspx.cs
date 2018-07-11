using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Student
{
    public partial class students_freelancer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["STUDENT"] == null)
            //{
            //    Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Student/students-profile.aspx");
            //}
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            Qaelo.Models.StudentModel.Student student = (Qaelo.Models.StudentModel.Student)Session["STUDENT"];

            string images = "";
            string price = "";
            string work = "";

            //set price 
            if (ddlPriceTerms.SelectedItem.Value == "Negotiable")
                price = "Negotiable";
            else
                price = txtPrice.Text + " " + ddlPriceTerms.SelectedItem.Value;

            if (ddlWork1.SelectedItem.Value != "NONE")
                work += ddlWork1.SelectedItem.Value + ";";
            else
            {
                lblErrorMessage.Text = "Please select your freelancing specialty";
            }

            if (ddlWork2.SelectedItem.Value != "NONE")
                work += ddlWork2.SelectedItem.Value + ";";
            else
                work += ";";

            if (ddlWork3.SelectedItem.Value != "NONE")
                work += ddlWork3.SelectedItem.Value + ";";
            else
                work += ";";


            //Select Images 
            string f1 = "default.jpg";
            string f2 = "default.jpg";
            string f3 = "default.jpg";

            if (file1.HasFile)
            {
                try
                {
                    f1 = student.Id + Path.GetFileName(file1.FileName);
                    file1.SaveAs(Server.MapPath("~/Images/Freelancer/") + f1);
                }
                catch (Exception ex)
                {
                    f1 = "default.jpg";
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }
            }
            else
                f1 = "default.jpg";

            if (file2.HasFile)
            {
                try
                {
                    f2 = student.Id + Path.GetFileName(file2.FileName);
                    file2.SaveAs(Server.MapPath("~/Images/Freelancer/") + f2);
                }
                catch (Exception ex)
                {
                    f2 = "default.jpg";
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }
            }
            else
                f2 = "default.jpg";

            if (file3.HasFile)
            {
                try
                {
                    f3 = student.Id + Path.GetFileName(file3.FileName);
                    file3.SaveAs(Server.MapPath("~/Images/Freelancer/") + f3);
                }
                catch (Exception ex)
                {
                    f3 = "default.jpg";
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }
            }
            else
                f3 = "default.jpg";

            images = f1 + ";" + f2 + ";" + f3;

            new Data.StudentData.StudentConnection().postWork(new Models.StudentModel.Freelancer(student.Id, txtDescription.Text, images, price, work));

            Response.Redirect("students-profile.aspx?page=freelancer");
        }
    }
}