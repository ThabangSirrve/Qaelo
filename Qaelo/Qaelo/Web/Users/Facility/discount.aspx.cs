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
    public partial class discount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SHOPOWNER"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx");
            }

            divError.Visible = false;

        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            ShopOwner owner = (ShopOwner)Session["SHOPOWNER"];

            if (txtDescription.Text == string.Empty || txtName.Text == string.Empty || txtOpenHours.Text == string.Empty
                || txtPrice.Text == string.Empty || txtShoNo.Text == string.Empty || txtShopName.Text == string.Empty
                || txtText.Text == string.Empty)
            {
                divError.Visible = true;
                return;
            }
            else
            {
                divError.Visible = false;
            }
            string filename1 = "defaultProfilePic.jpg";
            //Check if the files have something 
            if (fu1.HasFile)
            {
                try
                {
                    filename1 = owner.Id + Path.GetFileName(fu1.FileName);
                    fu1.SaveAs(Server.MapPath("~/Images/Shops/Specials/") + filename1);
                }
                catch (Exception ex)
                {
                    divError.Visible = true;
                    return;
                }
            }


            //Special is no refer to as Discount 
            Qaelo.Models.ShopOwnerModel.Shop special = new Qaelo.Models.ShopOwnerModel.Shop(owner.Id, txtPrice.Text, txtDescription.Text, filename1, txtName.Text, txtOpenHours.Text, txtShoNo.Text
                , txtText.Text);

            if (new ShopConnection().postSpecial(special))
            {
                Response.Redirect("manage-facilities.aspx?page=specials");
            }
            else
            {
                divError.InnerHtml = "<p>An error occured while saving your discout please try agian.</p>";
            }

            //try
            //{
            //    if (!Page.IsValid) return;

            //    // Create the order in your DB and get the ID
            //    string amount = "";
            //    string orderId = "";

            //    if( adR70.Checked)
            //    {
            //        amount = "70";
            //    }
            //    else if(adR100.Checked)
            //    {
            //        amount = "100";
            //    }
            //    else if(adR300.Checked)
            //    {
            //        amount = "300";
            //    }

            //    string name = "Qaelo, Shop advert order" + orderId;

            //    string description = "Advert Payment, Order #" + orderId;

            //    string site = "";
            //    string merchant_id = "";
            //    string merchant_key = "";

            //    // Check if we are using the test or live system
            //    string paymentMode = System.Configuration.ConfigurationManager.AppSettings["PaymentMode"];

            //    if (paymentMode == "test")
            //    {
            //        site = "https://sandbox.payfast.co.za/eng/process?";
            //        merchant_id = "10000100";
            //        merchant_key = "46f0cd694581a";
            //    }
            //    else if (paymentMode == "live")
            //    {
            //        site = "https://www.payfast.co.za/eng/process?";
            //        merchant_id = System.Configuration.ConfigurationManager.AppSettings["PF_MerchantID"];
            //        merchant_key = System.Configuration.ConfigurationManager.AppSettings["PF_MerchantKey"];
            //    }
            //    else
            //    {
            //        throw new InvalidOperationException("Cannot process payment if PaymentMode (in web.config) value is unknown.");
            //    }

            //    // Build the query string for payment site

            //    System.Text.StringBuilder str = new System.Text.StringBuilder();
            //    str.Append("merchant_id=" + HttpUtility.UrlEncode(merchant_id));
            //    str.Append("&merchant_key=" + HttpUtility.UrlEncode(merchant_key));
            //    str.Append("&return_url=" + HttpUtility.UrlEncode(System.Configuration.ConfigurationManager.AppSettings["PF_ReturnURL"]));
            //    str.Append("&cancel_url=" + HttpUtility.UrlEncode(System.Configuration.ConfigurationManager.AppSettings["PF_CancelURL"]));
            //    str.Append("&notify_url=" + HttpUtility.UrlEncode(System.Configuration.ConfigurationManager.AppSettings["PF_NotifyURL"]));

            //    str.Append("&m_payment_id=" + HttpUtility.UrlEncode(orderId));
            //    str.Append("&amount=" + HttpUtility.UrlEncode(amount));
            //    str.Append("&item_name=" + HttpUtility.UrlEncode(name));
            //    str.Append("&item_description=" + HttpUtility.UrlEncode(description));

            //    //Default email


            //    // Redirect to PayFast
            //    Response.Redirect(site + str.ToString());
            //}
            //catch (Exception ex)
            //{
            //    // Handle your errors here (log them and tell the user that there was an error)
            //}
        }
    }
}