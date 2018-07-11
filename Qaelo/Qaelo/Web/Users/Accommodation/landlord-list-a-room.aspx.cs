using Qaelo.Data.AccommodationData;
using Qaelo.Models.AccommodationModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Accommodation
{
    public partial class landlord_list_a_room : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PROPERTYMANAGER"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Accommodation/landlord-list-a-room.aspx");
            }
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            Manager manager = (Manager)Session["PROPERTYMANAGER"];
            bool uploadStatus = true;
            string filename1 = "defaultProfilePic.jpg";
            string filename2 = "defaultProfilePic.jpg";
            string filename3 = "defaultProfilePic.jpg";
            string filename4 = "defaultProfilePic.jpg";
            string filename5 = "defaultProfilePic.jpg";

            //Save 

            //Check if the files have something 
            if (fu1.HasFile)
            {
                try
                {
                    filename1 = manager.id + Path.GetFileName(fu1.FileName);
                    fu1.SaveAs(Server.MapPath("~/Images/Accommodation/") + filename1);
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                    uploadStatus = false;
                }
            }
            else { uploadStatus = false; }
            //File 2
            if (fu2.HasFile)
            {
                try
                {
                    filename2 = manager.id + Path.GetFileName(fu2.FileName);
                    fu2.SaveAs(Server.MapPath("~/Images/Accommodation/") + filename2);
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                    uploadStatus = false;
                }
            }
            else { uploadStatus = false; }
            //file 3
            if (fu3.HasFile)
            {
                try
                {
                    filename3 = manager.id + Path.GetFileName(fu3.FileName);
                    fu3.SaveAs(Server.MapPath("~/Images/Accommodation/") + filename3);
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                    uploadStatus = false;
                }
            }
            else { uploadStatus = false; }
            //file 4
            if (fu4.HasFile)
            {
                try
                {
                    filename4 = manager.id + Path.GetFileName(fu4.FileName);
                    fu4.SaveAs(Server.MapPath("~/Images/Accommodation/") + filename4);
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                    uploadStatus = false;
                }
            }
            else { uploadStatus = false; }

            //file 5
            if (fu5.HasFile)
            {
                try
                {
                    filename5 = manager.id + Path.GetFileName(fu5.FileName);
                    fu5.SaveAs(Server.MapPath("~/Images/Accommodation/") + filename5);
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                    uploadStatus = false;
                }
            }
            else { uploadStatus = false; }

            if (uploadStatus)
            {
                string images = filename1 + ";" + filename2 + ";" + filename3 + ";" + filename4 + ";" + filename5;
                AccommodationConnection connection = new AccommodationConnection();
                Qaelo.Models.AccommodationModel.Accommodation room = new Models.AccommodationModel.Accommodation(Convert.ToBoolean(ddlAccreditation.SelectedItem.Value), ddlAccommodationType.SelectedItem.Value, txtAddress.Text, ddlArrangement.SelectedItem.Value, txtText.Text, DateTime.Now, txtDescription.Text, txtDistance.Text, ddlGender.SelectedItem.Value, images, manager.id, Convert.ToDouble(txtPrice.Text), txtText.Text, true);
                connection.addRoom(room);

                lblSuccess.Text = "You have successfully added an Event";

                Response.Redirect("landlord-my-rooms.aspx");
            }
            else
            {
                lblErrorMessage.Text = "Sorry an error occured listing your room, Please upload 5 images";
            }
        }
    }
}