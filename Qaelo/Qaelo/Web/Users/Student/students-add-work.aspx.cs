using Qaelo.Data.StudentData;
using Qaelo.Models.FreelancerModel;
using Qaelo.Models.StudentModel;
using System;
using System.IO;

namespace Qaelo.Web.Users.Student
{

    public partial class students_add_work : System.Web.UI.Page
    {
        StudentConnection connection = new StudentConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["STUDENT"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Student/students-add-work.aspx");
            }

            //load previous work images
            Qaelo.Models.StudentModel.Student student = (Qaelo.Models.StudentModel.Student)(Session["STUDENT"]);

            PreviousWork work = connection.getPortfolio(student.Id);

            if (work != null && !IsPostBack)
            {
                //Load the previous work
                string[] pictures = work.Pictures.Split(';');
                txtLink.Text = work.Links;
                string[] videos = work.Videos.Split(';');

            }
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {

            string name = "";

            Qaelo.Models.StudentModel.Student student = (Qaelo.Models.StudentModel.Student)Session["STUDENT"];

            string f1 = "default.jpg";
            string f2 = "default.jpg";
            string f3 = "default.jpg";
            string f4 = "default.jpg";
            string f5 = "default.jpg";
            string f6 = "default.jpg";


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


            if (file4.HasFile)
            {
                try
                {
                    f4 = student.Id + Path.GetFileName(file4.FileName);
                    file4.SaveAs(Server.MapPath("~/Images/Freelancer/") + f4);
                }
                catch (Exception ex)
                {
                    f4 = "default.jpg";
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }
            }
            else
                f4 = "default.jpg";

            if (file5.HasFile)
            {
                try
                {
                    f5 = student.Id + Path.GetFileName(file5.FileName);
                    file5.SaveAs(Server.MapPath("~/Images/Freelancer/") + f5);
                }
                catch (Exception ex)
                {
                    f5 = "default.jpg";
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }
            }
            else
                f5 = "default.jpg";


            if (file6.HasFile)
            {
                try
                {
                    f6 = student.Id + Path.GetFileName(file6.FileName);
                    file6.SaveAs(Server.MapPath("~/Images/Freelancer/") + f6);
                }
                catch (Exception ex)
                {
                    f6 = "default.jpg";
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }
            }
            else
                f6 = "default.jpg";

            string pictures = f1 + ";" + f2 + ";" + f3;
            string videos = f4 + ";" + f5 + ";" + f6;

            PreviousWork previousWork = new PreviousWork(student.Id, pictures, videos, txtLink.Text);

            connection.postPortfolio(previousWork);

            lblSuccess.Text = "Sucessfully Saved previous work";

            Response.Redirect("students-profile.aspx?page=previousWork");
        }
    }
}