using Qaelo.Data.ShopData;
using Qaelo.Models.ShopOwnerModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Facility
{
    public partial class list_facility : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SHOPOWNER"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx");
            }
        }

        protected void btnfinish_Click(object sender, EventArgs e)
        {
            /*Start by Adding special to the database ***/
            if (txtDescription.Text.Equals("") || txtOpenHours.Equals("") || txtShoNo.Equals("") || txtShopName.Equals("") || txtText.Equals(""))
            {
                lblErrorMessage.Text = "All fields are required";
                return;
            }

            ShopOwner owner = (ShopOwner)Session["SHOPOWNER"];
            bool uploadStatus = true;
            string filename1 = "defaultProfilePic.jpg";

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

            if (uploadStatus)
            {
                string images = filename1;

                //Upload shop
                if (new ShopConnection().postShop(new Models.ShopOwnerModel.Shop(owner.Id, ddlFacility.SelectedItem.Text, txtDescription.Text, images, txtShopName.Text, txtOpenHours.Text, txtShoNo.Text, txtText.Text)))
                {
                    lblSuccess.Text = "You have successfully added a Special";
                    Response.Redirect("manage-facilities.aspx");
                }
                else
                {
                    lblErrorMessage.Text = "Sorry an error occured while listing your Special, please try again";
                }
            }
            else
            {
                lblErrorMessage.Text = "Sorry an error occured while listing your Special, please upload image again";
            }
        }
    }
}