using Qaelo.Data.EventsData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.EventPoster
{
    public partial class PostEvent1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EVENTPOSTER"] == null)
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/EventPoster/EditProfile.aspx");
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            if (txtText.Text.Equals("") || txtAddress.Equals("") || txtDate.Text.Equals("") || txtDescription.Text.Equals("") || txtName.Text.Equals("") || txtPrice.Text.Equals(""))
            {
                lblErrorMessage.Text = "All fields are required";
                return;
            }

            Qaelo.Models.EventPosterModel.EventPoster ep = (Qaelo.Models.EventPosterModel.EventPoster)Session["EVENTPOSTER"];
            string filename1 = "";

            //Check if the files have something 
            if (fu1.HasFile)
            {
                try
                {
                    filename1 = ep.Id + Path.GetFileName(fu1.FileName);
                    fu1.SaveAs(Server.MapPath("~/Images/Events/") + filename1);
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                    return;
                }
            }

            Models.EventPosterModel.MyEvent myEvent = new Models.EventPosterModel.MyEvent(ep.Id, "", Convert.ToDateTime(txtDate.Text), DateTime.Now, txtDescription.Text, Convert.ToDouble(txtPrice.Text), filename1, txtAddress.Text, txtName.Text, txtText.Text);
            new EventConnection().postEvent(myEvent);

            lblSuccess.Text = "Successfully Added a new event ";

            if (ddlSellTickets.SelectedItem.Value == "True")
                Response.Redirect("SellTicket.aspx?eventId=" + new EventConnection().getId(myEvent));
            else
                Response.Redirect("ManageEvents.aspx");
        }
    }
}