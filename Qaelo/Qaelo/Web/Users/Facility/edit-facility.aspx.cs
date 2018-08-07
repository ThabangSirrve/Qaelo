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
    public partial class edit_facility : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SHOPOWNER"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Facility/manage-facilities.aspx");
            }

            ShopConnection connection = new ShopConnection();

            if (!IsPostBack)
            {
                if (Request.QueryString["editId"] != null)
                {
                    Qaelo.Models.ShopOwnerModel.Shop shop = connection.getShopById(Convert.ToInt32(Request.QueryString["editId"].ToString()));
                    txtDescription.Text = shop.Description;
                    txtShopName.Text = shop.Name;
                    txtOpenHours.Text = shop.TradingHours;
                    txtShoNo.Text = shop.Address.ToString();
                    txtText.Text = shop.University;
                    ddlYear.SelectedIndex = ddlYear.Items.IndexOf(ddlYear.Items.FindByValue(shop.Campus));
                }
                else
                {
                    lblErrorMessage.Text = "Inalid Special Id";
                }
            }

        }

        protected void btnfinish_Click(object sender, EventArgs e)
        {

            ShopOwner owner = (ShopOwner)Session["SHOPOWNER"];
            bool uploadStatus = true;
            string filename1 = "";
            int shopId = Convert.ToInt32(Request.QueryString["editId"]);

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
                filename1 = new ShopConnection().getShopById(shopId).Image;
            }

            if (uploadStatus)
            {
                //Upload shop
                if (new ShopConnection().updateShop(new Models.ShopOwnerModel.Shop(shopId, owner.Id, ddlYear.SelectedItem.Value, txtDescription.Text, filename1, txtShopName.Text, txtOpenHours.Text, txtShoNo.Text, txtText.Text), owner.Id))
                {
                    lblSuccess.Text = "You have successfully Edit " + txtShopName.Text + " Facility";
                    Response.Redirect("manage-facilities.aspx?page=edit-facilities");
                }
                else
                {
                    lblErrorMessage.Text = "Sorry an error occured while listing your facility, please try again";
                }
            }
            else
            {
                lblErrorMessage.Text = "Sorry an error occured while listing your facility, please upload image again";
            }
        }
    }
}