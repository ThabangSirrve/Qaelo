using Qaelo.Models.ShopOwnerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Facility
{
    public partial class manage_facilities : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SHOPOWNER"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Facility/manage-facilities.aspx");
            }
            //Load manager
            ShopOwner owner = (ShopOwner)Session["SHOPOWNER"];
            Data.ShopData.ShopConnection connection = new Data.ShopData.ShopConnection();

            if (Request.QueryString["delId"] != null)
            {
                if (connection.deleteshop(Convert.ToInt32(Request.QueryString["delId"].ToString()), owner.Id))
                    lblSuccess.Text = "Facility has been deleted successfuly";
                else
                    lblErrorMessage.Text = "An error occurred while deleting facility, please try again";
            }

            if (Request.QueryString["delSpecialId"] != null)
            {
                if (connection.deleteSpecial(Convert.ToInt32(Request.QueryString["delSpecialId"].ToString()), owner.Id))
                    lblSuccess.Text = "Discount has been deleted successfuly";
                else
                    lblErrorMessage.Text = "An error occurred while deleting discount, please try again";
            }

            if (Request.QueryString["page"] != null)
            {
                if (Request.QueryString["page"].Equals("edit-facilities"))
                    lblSuccess.Text = "Facility has been updated successfuly";
            }

            if (Request.QueryString["page"] != null)
            {
                if (Request.QueryString["page"].Equals("specials"))
                    lblSuccess.Text = "Discount has been added successfuly";
            }

            if (Request.QueryString["page"] != null)
            {
                if (Request.QueryString["page"].Equals("edited-discounts"))
                    lblSuccess.Text = "Discount has been updated successfuly";
            }

            //Load Shops
            List<Qaelo.Models.ShopOwnerModel.Shop> shops = connection.getAllMyShops(owner.Id);
            lblFacilityCount.Text = "(" + shops.Count() + ")";
            string html = "";

            foreach (Qaelo.Models.ShopOwnerModel.Shop shop in shops)
            {
                html += string.Format(@"<div class='col-sm-3'>
                <div class='thumbnail'>
                  <div class='w3-card-12'>
                      <figure >
                      <img src='../../../Images/Shops/{0}' class='' style='height:220px;width:100%'/>
                          <figcaption style = 'background-image: url('')'>
                               </figcaption>
                           </figure>
                    <div class='w3-container' style='margin:10px'>
                        <h6><b>{2}<br/>
                        <small>{3}</small></b></h6>
                        <strong>Address:<small>{4}</small></strong><br />
                       <strong> Open: <small>{5}</small></strong><br />
                        <strong><small>{6}</small>
                        </strong><br /><br />
                            <a href='manage-facilities.aspx?delId={7}' class='btn btn-danger pull-lef'>Delete</a>
                            <a href='edit-facility.aspx?editId={7}' class='btn btn-info pull-right'>Edit</a>
                    </div>
                  </div>
                </div>
            </div>", shop.Image, shop.Description, shop.Name, shop.University, shop.Address, shop.TradingHours, " ", shop.Id);
            }

            lblShops.Text = html;

            /**List Of Specials **/
            List<Qaelo.Models.ShopOwnerModel.ShopAds> specials = connection.getAllSpecialsByManagerId(owner.Id);
            lblDiscountCount.Text = "(" + specials.Count() +")"; 
            string htmlSpecials = "";

            foreach (Qaelo.Models.ShopOwnerModel.ShopAds shop in specials)
            {
                htmlSpecials += string.Format(@"<div class='col-sm-3'>
                <div class='thumbnail'>
                  <div class='w3-card-12'>
                      <figure >
                      <img src='../../../Images/Shops/Specials/{0}' class='' style='height:220px;width:100%'/>
                          <figcaption style = 'background-image: url('')'>
                               </figcaption>
                           </figure>    
                    <div class='w3-container' style='margin:10px'>
                        <h6><b>{2} - <small>{3}</small></b></h6>
                        <strong>Address:<small>{4}</small></strong><br />
                       <strong> Available: <small>{5}</small></strong><br />
                        <strong><small>{6}</small>
                        </strong><br /><br />
                            <a href='manage-facilities.aspx?delSpecialId={7}' class='btn btn-danger pull-lef'>Delete</a>
                            <a href='edit-discount.aspx?editId={7}' class='btn btn-info pull-right'>Edit now</a>
                    </div>
                  </div>
                </div>
            </div>", shop.Image, shop.Description, shop.Name, shop.University, shop.ShopNo, shop.TradingHours, "", shop.Id);
            }

            lblSpecials.Text = htmlSpecials;


        }
    }
}