using Qaelo.Data.EventsData;
using Qaelo.Data.SocietyData;
using Qaelo.Models.EventPosterModel;
using Qaelo.Models.Utility;
using System;

namespace Qaelo.Web.Users.Student
{
    public partial class Event : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Load event 
            Qaelo.Models.StudentModel.Student student = (Qaelo.Models.StudentModel.Student)Session["STUDENT"];
            
            if (Request.QueryString["eventId"] != null)
            {
                EventConnection connecton = new EventConnection();

                //Like and unlike 
                if(student != null)
                {
                    if (Request.QueryString["like"] != null)
                    {
                        connecton.likeEvent(Convert.ToInt32(Request.QueryString["like"].ToString()), student.Id);
                    }
                    else if (Request.QueryString["unlike"] != null)
                    {
                        connecton.unlikeEvent(Convert.ToInt32(Request.QueryString["unlike"].ToString()), student.Id);
                    }
                }
                else
                {
                    if (Request.QueryString["like"] != null)
                    {
                          Response.Redirect("~/Web/Account/tempLogin.aspx");
                    }
                }

            int eventId =Convert.ToInt32(Request.QueryString["eventId"]);
            MyEvent myEvent = connecton.getEventById(eventId);

                if (myEvent == null)
                    return;

                if(student != null)
                {
                    if (connecton.eventLikedByUser(myEvent.Id, student.Id))
                    {
                        lblPanelTopic.Text = string.Format(@"{0} - {1}<a href='students-event.aspx?unlike={2} &eventId={2}' class='btn btn-danger btn-xs pull-right'>Liked</a>", myEvent.Name, myEvent.Location, myEvent.Id);
                    }
                    else
                    {
                        lblPanelTopic.Text = string.Format(@"{0} - {1}<a href='students-event.aspx?like={2} &eventId={2}' class='btn btn-primary btn-xs pull-right'>Like</a>", myEvent.Name, myEvent.Location, myEvent.Id);
                    }
                }
                else
                {
                    lblPanelTopic.Text = string.Format(@"{0} - {1}<a href='students-event.aspx?like={2} &eventId={2}' class='btn btn-primary btn-xs pull-right'>Like</a>", myEvent.Name, myEvent.Location, myEvent.Id);
                }

                lblDate.Text = General.getDateString(myEvent.Date);
            if (myEvent.Image != "")
                imgImage1.Src = "../../../Images/Events/" + myEvent.Image;

            //Get Event Manager
            Qaelo.Models.EventPosterModel.EventPoster poster = connecton.getPoster(myEvent.EventPosterId);
            lblName.Text = poster.FullName;
            lblEmail.Text = poster.Email;
            lblNumber.Text = poster.Number;

            lblDescription.Text = myEvent.Description.Replace(char.ConvertFromUtf32(13), "<br/>");
            TicketModel ticket = connecton.getTicketById(eventId);

            if ( ticket != null)
            {
                lblTicketSales.Text = ticket.PriceDescription.Replace(char.ConvertFromUtf32(13), "<br/>");
                lblTicketAccountdetails.Text =string.Format(@"<p>Bank Name :{0}</p>
                                <p>Account Holder :{1}</p>
                                <p>Account No: {2}</p>
                                <p>Branch Code: {3}</p>
                                <p>Reference : {4}</p>",ticket.BankName, ticket.AccountHolder, ticket.AccountNo, ticket.BranchCode, ticket.reference);
                divTickets.Visible = true;
            }
            else
            {
                divTickets.Visible = false;
            }

            }
            else if(Request.QueryString["seventId"] != null)
            {
                SocietyConnection connecton = new SocietyConnection();
                int eventId = Convert.ToInt32(Request.QueryString["seventId"]);
                MyEvent myEvent = connecton.getEventById(eventId);

                if (myEvent == null)
                    return;

                if(student != null)
                {
                    //Like and unlike 
                    if (Request.QueryString["like"] != null)
                    {
                        connecton.likeEvent(Convert.ToInt32(Request.QueryString["like"].ToString()), myEvent.EventPosterId, student.Id);
                    }
                    else if (Request.QueryString["unlike"] != null)
                    {
                        connecton.unlikeEvent(Convert.ToInt32(Request.QueryString["unlike"].ToString()), student.Id);
                    }
                }
                else
                {
                    if (Request.QueryString["like"] != null)
                    {
                         Response.Redirect("~/Web/Account/tempLogin.aspx");
                    }
                }

                if(student != null)
                {
                    if (new Qaelo.Data.SocietyData.SocietyConnection().eventLikedByUser(myEvent.Id, student.Id))
                    {
                        lblPanelTopic.Text = string.Format(@"{0} - {1}<a href='students-event.aspx?unlike={2} &seventId={2}' class='btn btn-danger btn-xs pull-right'>Liked</a>", myEvent.Name, myEvent.Location, myEvent.Id);
                    }
                    else
                    {
                        lblPanelTopic.Text = string.Format(@"{0} - {1}<a href='students-event.aspx?like={2} &seventId={2}' class='btn btn-primary btn-xs pull-right'>Like</a>", myEvent.Name, myEvent.Location, myEvent.Id);
                    }
                }
                else
                {
                    lblPanelTopic.Text = string.Format(@"{0} - {1}<a href='students-event.aspx?like={2} &seventId={2}' class='btn btn-primary btn-xs pull-right'>Like</a>", myEvent.Name, myEvent.Location, myEvent.Id);
                }



                lblDate.Text = General.getDateString(myEvent.Date);
                if (myEvent.Image != "")
                    imgImage1.Src = "../../../Images/Events/" + myEvent.Image;

                //Get Event Manager
                Qaelo.Models.SocietyModel.Society poster = connecton.getSociety(myEvent.EventPosterId);
                lblName.Text = poster.Name;
                lblEmail.Text = poster.Email;
                lblNumber.Text = poster.Number;

                lblDescription.Text = myEvent.Description.Replace(char.ConvertFromUtf32(13), "<br/>");
                TicketModel ticket = new EventConnection().getTicketById(eventId);

                if (ticket != null)
                {
                    lblTicketSales.Text = ticket.PriceDescription.Replace(char.ConvertFromUtf32(13), "<br/>");
                    lblTicketAccountdetails.Text = string.Format(@"<p>Bank Name :{0}</p>
                                <p>Account Holder :{1}</p>
                                <p>Account No: {2}</p>
                                <p>Branch Code: {3}</p>
                                <p>Reference : {4}</p>", ticket.BankName, ticket.AccountHolder, ticket.AccountNo, ticket.BranchCode, ticket.reference);
                    divTickets.Visible = true;
                }
                else
                {
                    divTickets.Visible = false;
                }
            }
            else
            {
                Response.Redirect("~/Web/Users/Student/students-events.aspx");
            }
        }
    }
}