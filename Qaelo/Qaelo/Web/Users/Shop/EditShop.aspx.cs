using Qaelo.Data.ShopData;
using Qaelo.Models.ShopOwnerModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Shop
{
    public partial class EditShop1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["SHOPOWNER"] == null)
            //{
            //    Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Shop/ManageListings.aspx");
            //}

            //ShopConnection connection = new ShopConnection();

            //if (IsPostBack)
            //{

            //}
            //else
            //{
            //    if (Request.QueryString["editId"] != null)
            //    {
            //        Qaelo.Models.ShopOwnerModel.Shop shop = connection.getShopById(Convert.ToInt32(Request.QueryString["editId"].ToString()));
            //        txtDescription.Text = shop.Description;
            //        txtShopName.Text = shop.Name;
            //        txtOpenHours.Text = shop.TradingHours;
            //        txtShoNo.Text = shop.ShopNo.ToString();
            //        txtText.Text =  shop.University;

            //    }
            //    else
            //    {
            //        lblErrorMessage.Text = "Inalid Special Id";
            //    }
            //}

        }

        protected void btnFinish_Click(object sender, EventArgs e)
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
                if (new ShopConnection().updateShop(new Models.ShopOwnerModel.Shop(shopId, owner.Id, "", txtDescription.Text, filename1, txtShopName.Text, txtOpenHours.Text, Convert.ToInt32(txtShoNo.Text), txtText.Text), owner.Id))
                {
                    lblSuccess.Text = "You have successfully Edit " + txtShopName.Text + " a Special";
                    Response.Redirect("ManageListings.aspx");
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