using Qaelo.Data.StudentData;
using Qaelo.Models.StudentModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Student
{
    public partial class students_edit_books : System.Web.UI.Page
    {
        StudentConnection connection = new StudentConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["STUDENT"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Student/students-profile.aspx");
            }

            if (!IsPostBack)
            {
                //Check if user owns this book otherwise redirect them to student profile 
                Qaelo.Models.StudentModel.Student student = (Qaelo.Models.StudentModel.Student)Session["STUDENT"];
                Book book = null;
                int bookId = -1;
                try
                {
                    //Get the book 
                    book = connection.getBookById(Convert.ToInt32(Request.QueryString["id"]));
                    //Check if its the owner
                    if (student.Id != book.StudentId)
                        Response.Redirect("students-profile.aspx");
                }
                catch
                {
                    Response.Redirect("students-profile.aspx");
                }

                //Populate Textboxes
                txtDescription.Text = book.Description;
                txtPrice.Text = book.Price.ToString();
                txtTitle.Text = book.Name;
                image1.Src = "../../../Images/Book/" + book.Image;

                //work on dropdown 
                ddlField.SelectedIndex = ddlField.Items.IndexOf(ddlField.Items.FindByValue(book.Field));
                ddlYear.SelectedIndex = ddlYear.Items.IndexOf(ddlYear.Items.FindByValue(book.YearOfStudy));
            }
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            Book oldBook = connection.getBookById(Convert.ToInt32(Request.QueryString["id"]));

            string image = "";
            //save changes 
            if (txtDescription.Text == "" || txtTitle.Text == "" || txtPrice.Text == "")
            {
                lblErrorMessage.Text = "All fields are required!!!";
                return;
            }

            if (file1.HasFile)
            {
                //Then change the image 
                image = oldBook.StudentId + Path.GetFileName(file1.FileName);
                file1.SaveAs(Server.MapPath("~/Images/Book/") + image);

                //Save image
                oldBook.Image = image;
            }

            oldBook.Name = txtTitle.Text;
            oldBook.Price = Convert.ToDouble(txtPrice.Text);
            oldBook.Description = txtDescription.Text;
            oldBook.YearOfStudy = ddlYear.SelectedItem.Value;
            oldBook.Field = ddlField.SelectedItem.Value;

            //Save book changes 
            connection.editBook(oldBook);
            Response.Redirect("students-profile.aspx?page=editbook");
        }
    }
}