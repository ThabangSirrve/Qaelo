using Qaelo.Data.AccommodationData;
using Qaelo.Models.AccommodationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Accommodation
{
    public partial class reservations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PROPERTYMANAGER"] == null)
                Response.Redirect("~/Web/Account/tempLogin.aspx");

            AccommodationConnection connection = new AccommodationConnection();

            Qaelo.Models.AccommodationModel.Manager manager = (Qaelo.Models.AccommodationModel.Manager)Session["PROPERTYMANAGER"];
           
            //Load all the id's of the students who liked an event 
            string html = "";

            //handle  action buttons
                //accepted 
                if(Request.QueryString["accept"] != null)
                {
                int id = Convert.ToInt32(Request.QueryString["accept"]);
                Reservation reservation = connection.getReservation(id);
                //Send email
                sendNotificationEmail(new Data.StudentData.StudentConnection().getStudent(reservation.StudentId).Email, reservation.FullName,"Your Reservation has been approved please contact the landlord or wait for further communication from the landlord");
                connection.deletedReservation(id);
                  }
                //rejected
                else if (Request.QueryString["decline"] != null)
                {
                int id = Convert.ToInt32(Request.QueryString["accept"]);
                Reservation reservation = connection.getReservation(id);

                //Send email
                sendNotificationEmail(new Data.StudentData.StudentConnection().getStudent(reservation.StudentId).Email, reservation.FullName, "Unfortunately your reservation for room number " + reservation.RoomNo + " Was declined");

                connection.deletedReservation(Convert.ToInt32(Request.QueryString["decline"]));
                //send Email

                }
            
            //Get all rooms by manager 
            List<Qaelo.Models.AccommodationModel.Reservation> rooms = connection.getAllReservations();

            lblDocuments.Text = "";

            foreach (Qaelo.Models.AccommodationModel.Reservation room in rooms)
            {
                html += string.Format(@"            
                                    <div class='col-sm-12'>
                                         <div class='form-group'>
                                          <div class='col-sm-2'>{0}</div>
                                          <div class='col-sm-2'>{1}</div>
                                          <div class='col-sm-2'>{2}</div>
                                          <div class='col-sm-2'>{3}</div>
                                          <div class='col-sm-4'>{4}</div>
                                        </div>
                                   </div>
                                    <div class='col-sm-12'><hr/></div>
                                    ", room.FullName, room.MonthOfStay.ToShortDateString(), room.RoomNo, "<a href='#' data-toggle='modal' data-target='#share' type='button' class='btn btn-info'>View</a>", "<a href='reservations.aspx?decline="+room.Id + "' class='btn btn-danger'>Decline</a> <a href='reservations.aspx?accept=" + room.Id + "' class='btn btn-success'>Accept</a>");
                                                        
                                   lblDocuments.Text += string.Format(@"<label>Salary Advice</label>
                                     <embed src='../../../Images/Accommodation/{0}' width='720px' height='480px'/>
                                            <label>3 Months Bank Statement</label>
                                     <embed src='../../../Images/Accommodation/{1}' width='720px' height='480px'/>
                                            <label>Guardian's certified ID</label>
                                     <embed src='../../../Images/Accommodation/{2}' width='720px' height='480px'/>
                                            <label>Student ID</label>
                                     <embed src='../../../Images/Accommodation/{3}' width='720px' height='480px'/>",room.SalaryAdvice,room.BankStatement,room.GuardianID,room.StudentIdentity);
            }

            lblListOfUsers.Text = html;
        }

        //Send emails
        public static bool sendNotificationEmail(string email,string name,string messageFromLandlord)
        {
            bool success = false;

            try
            {
                MailMessage message = new MailMessage();

                message.From = new MailAddress("Accounts@qaelo.com");

                message.To.Add(new MailAddress(email));

                message.Subject = "Account Confirmation";
                message.IsBodyHtml = true;

                //Azure

                //LocalHost 
                //string j = "http://localhost:53020/Web/Account/PasswordRecovery.aspx?email=" + email + "&token=" + encrypt;

                //HTML
                var body = new StringBuilder();
                body.AppendLine(string.Format(@"<h1>Hi {0} </h1><br/>
                                                 {1}", name,messageFromLandlord));
                //END HTML

                message.Body = body.ToString();

                SmtpClient smtp = new SmtpClient("webmail.qaelo.com");

                smtp.Credentials = new System.Net.NetworkCredential("accounts@qaelo.com", "Account5000qaelo");

                smtp.Port = 25;

                smtp.EnableSsl = false;

                smtp.Send(message);

                success = true;

            }
            catch
            {
                success = false;
            }

            return success;
        }
    }
}