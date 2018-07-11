using Qaelo.Data.StudentData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Student
{
    public partial class students_sell_textbooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["STUDENT"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Student/students-sell-textbooks.aspx");
            }
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            Qaelo.Models.StudentModel.Student student = (Qaelo.Models.StudentModel.Student)Session["STUDENT"];

            //Save image 
            string file = "";
            if (file1.HasFile)
            {
                try
                {
                    file = student.Id + Path.GetFileName(file1.FileName);
                    file1.SaveAs(Server.MapPath("~/Images/Book/") + file);
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }
            }
            else
            {
                lblErrorMessage.Text = "Please upload book image";
                return;
            }

            if (txtDescription.Text == "")
            {
                lblErrorMessage.Text = "Please provide decription of the book";
                return;
            }

            if (txtPrice.Text == "")
            {
                lblErrorMessage.Text = "Please provide book price";
                return;
            }

            if (txtTitle.Text == "")
            {
                lblErrorMessage.Text = "Please provide book title";
                return;
            }

            int price = 0;

            if (txtPrice.Text.Contains(",") || txtPrice.Text.Contains("."))
            {
                if (txtPrice.Text.Contains(","))
                {
                    price = Convert.ToInt32(txtPrice.Text.Split(',')[0]);
                }
                else if (txtPrice.Text.Contains("."))
                {
                    price = Convert.ToInt32(txtPrice.Text.Split('.')[0]);
                }
            }
            else
            {
                price = Convert.ToInt32(txtPrice.Text);
            }

            //Store book 
            new StudentConnection().postBook(new Models.StudentModel.Book(student.Id, txtDescription.Text, ddlField.SelectedItem.Value, txtTitle.Text, file, Convert.ToDouble(price), ddlYear.SelectedItem.Value));

            sendRegistrationEmail(txtshare1.Text);
            //Send email to a friend

            Response.Redirect("students-profile.aspx?page=sellbooks");

        }

        public static bool sendRegistrationEmail(string email)
        {
            bool success = false;

            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress("invites@qaelo.com");
                message.To.Add(new MailAddress(email));
                message.Subject = "Be Greater Today!";

                message.BodyEncoding = System.Text.Encoding.UTF8;
                message.SubjectEncoding = System.Text.Encoding.Default;
                message.IsBodyHtml = true;

                //Qaelo.com

                //HTML
                var body = new StringBuilder();
                body.AppendLine(string.Format(@"Hello there!,<br/> 
                                               I know that you value creating a successful name for yourself and making extra cash! Qaelo, pronounced 'Khayelo' is a social freelancing website for students, graduates and young professionals. Make money today through freelancing and sell your used textbooks to students for free like I’m doing today, I’m sure you have a used textbook to sell! So Sign up for a freelance profile now on http://www.qaelo.com and enjoy the lifestyle they offer, plus they take no commission!
                                                <br/>
                                                Please forward this email to family and friends that you know will benefit greatly with Qaelo! You're the best!
                                                <br/>
                                                Qaelo, helping you enjoy more free time!
"));
                //END HTML

                message.Body = body.ToString();

                SmtpClient smtp = new SmtpClient("webmail.qaelo.com");

                smtp.Credentials = new System.Net.NetworkCredential("invites@qaelo.com", "Invites5000Qaelo");

                smtp.Port = 25;

                smtp.EnableSsl = false;

                smtp.Send(message);

                success = true;

            }
            catch (Exception ex)
            {
                success = false;
            }

            return success;
        }
    }
}