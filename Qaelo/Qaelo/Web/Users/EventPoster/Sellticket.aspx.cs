using Qaelo.Data.EventsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.EventPoster
{
    public partial class Sellticket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EVENTPOSTER"] == null)
                Response.Redirect("~/Web/Account/tempLogin.aspx?");

            if (Request.QueryString["eventId"] == null)
                Response.Redirect("ManageEvents.aspx?");
        }
        protected void btnFinish_Click(object sender, EventArgs e)
        {

            int eventId = Convert.ToInt32(Request.QueryString["eventId"]);
            if (txtAccHolder.Text == "" || txtAccNo.Text == "" || txtBraCode.Text == "" || txtDescription.Text == "" || txtFullBank.Text == "")
            {
                lblErrorMessage.Text = "Please fill in all the details ";
                lblSuccess.Text = "";
            }
            else
            {
                //Save Data
                if (new EventConnection().addticket(new Models.EventPosterModel.TicketModel(eventId, txtAccHolder.Text, txtAccNo.Text, txtFullBank.Text, Convert.ToInt32(txtBraCode.Text), txtDescription.Text, txtReference.Text)))
                {
                    Response.Redirect("ManageEvents.aspx?page=sellTicket");
                }
                else
                {
                    lblErrorMessage.Text = "An error occured while saving chances in database";
                }
            }
        }
    }
}