using Qaelo.Data.AccommodationData;
using Qaelo.Models.AccommodationModel;
using System;
using System.Collections.Generic;
using System.IO;


namespace Qaelo.Web.Users.Accommodation
{
    public partial class landlord_edit_room : System.Web.UI.Page
    {
        string campusName = "";

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["PROPERTYMANAGER"] == null)
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Accommodation/landlord-my-rooms.aspx");

            if (Request.QueryString["editId"] == null)
                Response.Redirect("~/Web/Account/landlord-my-rooms.aspx");
            //Get accommodation
            if (IsPostBack)
            {
                //nothing
            }
            else
            {
                if (Request.QueryString["editId"] != null)
                {

                    Qaelo.Models.AccommodationModel.Accommodation room = (new AccommodationConnection().getRoom(Convert.ToInt32(Request.QueryString["editId"].ToString())));

                    txtAddress.Text = room.address;
                    txtDescription.Text = room.description;
                    txtDistance.Text = room.distanceFromCampus.ToString();
                    txtPrice.Text = room.price.ToString();
                    txtText.Text = room.university;

                    string value = "";

                    if (room.accredited)
                        value = "true";
                    else
                        value = "false";

                    ddlAccreditation.SelectedIndex = ddlAccreditation.Items.IndexOf(ddlAccreditation.Items.FindByValue(value));
                    ddlArrangement.SelectedIndex = ddlArrangement.Items.IndexOf(ddlArrangement.Items.FindByValue(room.arrangement));
                    ddlGender.SelectedIndex = ddlGender.Items.IndexOf(ddlGender.Items.FindByValue(room.gender));

                    Session["IMAGES"] = room.images;
                }
                else
                {
                    lblErrorMessage.Text = "Invalid room Id";
                }
            }
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            string imageList = Session["IMAGES"].ToString();
            string[] listOfImages = imageList.Split(';');
            string filename1 = "";
            string filename2 = "";
            string filename3 = "";
            string filename4 = "";
            string filename5 = "";
            Manager man = (Manager)(Session["PROPERTYMANAGER"]);
            //Check if the files have something 
            if (fu1.HasFile)
            {
                try
                {
                    filename1 = man.id + Path.GetFileName(fu1.FileName);
                    fu1.SaveAs(Server.MapPath("~/Images/Accommodation/") + filename1);
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }
            }
            else
            {
                filename1 = listOfImages[0];
            }
            //File 2
            if (fu2.HasFile)
            {
                try
                {
                    filename2 = man.id + Path.GetFileName(fu2.FileName) + DateTime.Now.ToShortTimeString();

                    fu2.SaveAs(Server.MapPath("~/Images/Accommodation/") + filename2);
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }
            }
            else
            {
                filename2 = listOfImages[1];
            }
            //file 3
            if (fu3.HasFile)
            {
                try
                {
                    filename3 = man.id + Path.GetFileName(fu3.FileName);
                    fu3.SaveAs(Server.MapPath("~/Images/Accommodation/") + filename3);
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;

                }
            }
            else
            {
                filename3 = listOfImages[2];
            }

            //file 4
            if (fu4.HasFile)
            {
                try
                {
                    filename4 = man.id + Path.GetFileName(fu4.FileName);
                    fu4.SaveAs(Server.MapPath("~/Images/Accommodation/") + filename4);
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;

                }
            }
            else
            {
                filename4 = listOfImages[3];
            }

            //file 5
            if (fu5.HasFile)
            {
                try
                {
                    filename5 = man.id + Path.GetFileName(fu5.FileName);
                    fu5.SaveAs(Server.MapPath("~/Images/Accommodation/") + filename5);
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }
            }
            else
            {
                filename5 = listOfImages[4];
            }

            //Combine all the images
            string images = filename1 + ";" + filename2 + ";" + filename3 + ";" + filename4 + ";" + filename5;

            if (new AccommodationConnection().updateRoom(new Models.AccommodationModel.Accommodation(Convert.ToInt32(Request.QueryString["editId"].ToString()), Convert.ToBoolean(ddlAccreditation.SelectedItem.Value), ddlAccommodationType.SelectedItem.Value, txtAddress.Text
                , ddlArrangement.SelectedItem.Value, campusName, new AccommodationConnection().getDatePosted(Convert.ToInt32(Request.QueryString["editId"].ToString())), txtDescription.Text, txtDistance.Text, ddlGender.SelectedItem.Value, images, man.id, Convert.ToDouble(txtPrice.Text), txtText.Text, true), man.id))
            {
                lblSuccess.Text = "Room Edited Successfully";
                Session["IMAGES"] = images;
                Response.Redirect("landlord-my-rooms.aspx");
            }
            else
            {
                lblErrorMessage.Text = "Sorry Changes to the room could not be Saved";
            }

        }
    }
}