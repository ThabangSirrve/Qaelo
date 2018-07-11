using Qaelo.Data.StudentData;
using Qaelo.Models.StudentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Student
{
    public partial class students_buy_textbooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //load 
            StudentConnection connection = new StudentConnection();
            
            //Get all students from selected varsity 
            string query = " Institution = " + "'" + txtText.Text + "'";
            List<Qaelo.Models.StudentModel.Student> students = connection.getAllStudents(query);

            // Get the books made by these students 
            List<Book> books = new List<Book>();

            foreach(Qaelo.Models.StudentModel.Student student in students)
            {
                //check if they have books and add to list 

                List<Book> studentBooks = connection.getAllStudentBoks(student.Id);

                foreach (Book book in studentBooks)
                {
                   // check whether the books match the search filter 

                    if(book.Field == ddlField.SelectedItem.Value && book.YearOfStudy == ddlYear.SelectedItem.Value)
                         books.Add(book);
                }
            }

            //List<Book> books = connection.getAllBooks();

            lblBooks.Text = "";
            int count = 0;

            foreach (Book book in books)
            {
                if (connection.isProfilePublic(book.StudentId))
                {
                    count++;
                    string desc = "";

                    if (book.Description.Length > 65)
                        desc = book.Description.Substring(0, 65);
                    else
                        desc = book.Description;

                    lblBooks.Text += string.Format(@"<div class='col-sm-6' style='margin-bottom:20px'>
                                                  <div class='col-sm-6'>
                                                    <img src = '../../../Images/Book/{0}' class='img-thumbnail' style='height:150px;width:100%' id='image1'/>
                                                  <br/><br/>
                                                </div>
                                                <div class='col-sm-6'>
                                                    <p style='font-size:smaller;font-style:normal'><strong>Title: <strong style='color:red'>{1}</strong></strong></p>
                                                    <p style='font-size:smaller;font-style:normal'><strong>Study Field: <strong style='color:dimgrey'>{2}</strong></strong></p>
                                                    <p style='font-size:smaller;font-style:normal'><strong>Year of Study: <strong style='color:dimgrey'>{3}</strong></strong></p>
                                                    <p style='font-size:smaller;font-style:normal'><strong>Price: R<strong style='color:dimgrey'>{4}.00</strong></strong></p>
                                                    <a href='#book{5}' class='btn btn-default btn-md' data-toggle='modal' style='background:#d89b4e'>More info</a>
                                                </div>
                                            </div>", book.Image, book.Name, book.Field, book.YearOfStudy, book.Price, book.Id);

                    //Modal

                    //get student 
                    Qaelo.Models.StudentModel.Student student = connection.getStudent(book.StudentId);
                    lblBooks.Text += string.Format(@"<div class='modal fade' id='book{7}' tabindex='-1' role='dialog' aria-labelledby='myModalLabel{1}' aria-hidden='true'>
                    <div class='modal-dialog modal-lg'>
                        <div class='modal-content'>
                                    <div class='modal-body'>
                                        <div class='container'>
                                            <div class='col-sm-10'>
                                                <div class='col-sm-4'>
                                                    <h2>Book Image</h2>
                                                    <img src = '../../../Images/Book/{0}' class='img-thumbnail' style='height:350px;width:100%' id='image1'/><br/><br/>
                                                </div>
                                                <div class='col-sm-4'>
                                                    <h2>About the book</h2>
                                                    <label><strong>Title:</strong></label>{1}<br />
                                                    <label><strong>Description:</strong></label>{2}<br/><br />
                                                    <label><strong>Price:</strong> {3}</label><br/><br />
                                                </div>
                                                <div class='col-sm-3'>
                                                    <h2>Seller info</h2>
                                                    <label><strong>Seller Name:</strong></label>{4}<br/>
                                                    <label><strong>Seller Number:</strong></label>{5}<br/>
                                                    <label><strong>University:</strong></label>{6}<br/>
                                                </div>
                                             </div>
                                            </div>
                                        </div>
                                    <div class='modal-footer'>
                                        <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
                                    </div>
                                    </div>
                                </div>
                            </div>", book.Image, book.Name, book.Description, book.Price, student.FirstName, student.Number, student.Institution, book.Id);
                }


            }

        }
    }
}