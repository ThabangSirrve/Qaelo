using Qaelo.Data.SocietyData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Society
{
    public partial class EditEvent1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SOCIETY"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx?");
            }
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            //Get the event
            SocietyConnection connection = new SocietyConnection();
            Qaelo.Models.SocietyModel.Society society = (Qaelo.Models.SocietyModel.Society)Session["SOCIETY"];
            Qaelo.Models.EventPosterModel.MyEvent myEvent = connection.getEventById(Convert.ToInt32(Request.QueryString["editId"].ToString()));

            string filename1 = "";
            bool uploadStatus = true;

            //Check if the files have something 
            if (fu1.HasFile)
            {
                try
                {
                    filename1 = Path.GetFileName(fu1.FileName);
                    fu1.SaveAs(Server.MapPath("~/Images/Shops/") + filename1);
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
                //Upload shop
                if (connection.updateEvent(new Models.EventPosterModel.MyEvent(myEvent.Id, society.Id, "", myEvent.Date, DateTime.Now, txtDescription.Text, Convert.ToDouble(txtPrice.Text), filename1, txtAddress.Text, txtName.Text, txtText.Text)))
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