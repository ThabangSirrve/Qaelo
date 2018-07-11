using Qaelo.Data.AccommodationData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Student
{
    public partial class students_book_a_room : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["STUDENT"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Student/students-book-a-room.aspx");
            }
            //Load anything that is possible to load 
            Qaelo.Models.StudentModel.Student student = (Qaelo.Models.StudentModel.Student)Session["STUDENT"];
            txtRoomNo.Text = Request.QueryString["Id"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Qaelo.Models.StudentModel.Student student = (Qaelo.Models.StudentModel.Student)Session["STUDENT"];

            if (txtMoveInDate.Text.Equals("") || txtPostalAddress.Text.Equals("") || txtRoomNo.Text.Equals(""))
            {
                lblErrorMessage.Text = "All fields are required";

                return;
            }

            string salary = "";
            string bankstatement = "";
            string guardianID = "";
            string id = "";

            //Save everthing <img src="../../../Images/Accommodation/44accommodation4.jpg" />

            //Process files 
            if (fuSalary.HasFile)
            {
                try
                {
                    salary = student.Id + Path.GetFileName(fuSalary.FileName);
                    fuSalary.SaveAs(Server.MapPath("~/Images/Accommodation/") + salary);
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                    return;
                }
            }

            if (fuBankStatement.HasFile)
            {
                try
                {
                    bankstatement = student.Id + Path.GetFileName(fuBankStatement.FileName);
                    fuBankStatement.SaveAs(Server.MapPath("~/Images/Accommodation/") + bankstatement);
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                    return;
                }
            }

            if (fuGuardianId.HasFile)
            {
                try
                {
                    guardianID = student.Id + Path.GetFileName(fuGuardianId.FileName);
                    fuGuardianId.SaveAs(Server.MapPath("~/Images/Accommodation/") + guardianID);
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                    return;
                }
            }

            if (fuID.HasFile)
            {
                try
                {
                    id = student.Id + Path.GetFileName(fuID.FileName);
                    fuID.SaveAs(Server.MapPath("~/Images/Accommodation/") + id);
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                    return;
                }
            }

            //submit reservations 
            new AccommodationConnection().reserveRoom(new Models.AccommodationModel.Reservation(student.Id, bankstatement, student.Email, student.FirstName + " " + student.LastName, txtPostalAddress.Text, guardianID, student.Number, Convert.ToDateTime(txtMoveInDate.Text), Convert.ToBoolean(ddlRoomAvailable.SelectedItem.Value), Convert.ToInt32(txtRoomNo.Text), salary, ddlSponsor.SelectedItem.Value, id, Convert.ToBoolean(ddlSeenRoom.SelectedItem.Value)));

            Response.Redirect("students-room.aspx?Id=" + Request.QueryString["Id"] + "&reserve=true");
        }
    }
}