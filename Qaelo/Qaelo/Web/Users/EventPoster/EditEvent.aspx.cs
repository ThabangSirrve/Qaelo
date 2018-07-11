using Qaelo.Data.EventsData;
using Qaelo.Models.EventPosterModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.EventPoster
{
    public partial class EditEvent1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EVENTPOSTER"] == null)
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/EventPoster/ManageEvents.aspx");

            if (Request.QueryString["editId"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/EventPoster/ManageEvents.aspx");
            }
            EventConnection connection = new EventConnection();

            if (IsPostBack)
            {

            }
            else
            {
                int eventId = Convert.ToInt32(Request.QueryString["editId"].ToString());

                MyEvent myEvent = connection.getEventById(eventId);

                txtAddress.Text = myEvent.Location;
                txtDate.Text = myEvent.Date.ToShortDateString();
                txtDescription.Text = myEvent.Description;
                txtName.Text = myEvent.Name;
                txtPrice.Text = myEvent.EntryFee.ToString();
                txtText.Text = myEvent.University;
                //}
            }
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            if (txtText.Text.Equals("") || txtAddress.Equals("") || txtDescription.Text.Equals("") || txtName.Text.Equals("") || txtPrice.Text.Equals(""))
            {
                lblErrorMessage.Text = "All fields are required";
                return;
            }

            //Get the event
            EventConnection connection = new EventConnection();
            Qaelo.Models.EventPosterModel.EventPoster poster = (Qaelo.Models.EventPosterModel.EventPoster)Session["EVENTPOSTER"];
            Qaelo.Models.EventPosterModel.MyEvent myEvent = connection.getEventById(Convert.ToInt32(Request.QueryString["editId"].ToString()));

            string filename1 = "";
            bool uploadStatus = true;

            //Check if the files have something 
            if (fu1.HasFile)
            {
                try
                {
                    filename1 = poster.Id + Path.GetFileName(fu1.FileName);
                    fu1.SaveAs(Server.MapPath("~/Images/Events/") + filename1);
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                    uploadStatus = false;
                }
            }
            else
            {
                filename1 = myEvent.Image;
            }

            if (uploadStatus)
            {
                DateTime eventDate = myEvent.Date;

                if(!txtDate.Text.Equals(""))
                {
                    eventDate = Convert.ToDateTime(txtDate.Text);
                }

                //Upload shop
                if (connection.updateEvent(new Models.EventPosterModel.MyEvent(myEvent.Id, poster.Id,"", eventDate, myEvent.DatePosted, txtDescription.Text, Convert.ToDouble(txtPrice.Text), filename1, txtAddress.Text, txtName.Text, txtText.Text)))
                {
                    lblSuccess.Text = "You have successfully Edited " + txtName.Text + " event";
                    Response.Redirect("ManageEvents.aspx");
                }
                else
                {
                    lblErrorMessage.Text = "Sorry an error occured while editing your event, please try again";
                }
            }
            else
            {
                lblErrorMessage.Text = "Sorry an error occured while editing your event, please upload image again";
            }
        }
    }
}