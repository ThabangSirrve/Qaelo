using Qaelo.Models.ShopOwnerModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Qaelo.Web.Users.Shop
{
    public partial class ManageListings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SHOPOWNER"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Shop/ManageListings.aspx");
            }
            //Load manager
            ShopOwner owner = (ShopOwner)Session["SHOPOWNER"];
            Data.ShopData.ShopConnection connection = new Data.ShopData.ShopConnection();

            if (Request.QueryString["delId"] != null)
            {
                if (connection.deleteshop(Convert.ToInt32(Request.QueryString["delId"].ToString()), owner.Id))
                    lblSuccess.Text = "Shop has been deleted successfuly";
                else
                    lblErrorMessage.Text = "An error occurred while deleting, shop please try again";
            }

            if (Request.QueryString["delSpecialId"] != null)
            {
                if (connection.deleteSpecial(Convert.ToInt32(Request.QueryString["delSpecialId"].ToString()), owner.Id))
                    lblSuccess.Text = "Special has been deleted successfuly";
                else
                    lblErrorMessage.Text = "An error occurred while deleting special, please try again";
            }

            if (Request.QueryString["page"] != null)
            {
                if (Request.QueryString["page"].Equals("specials"))
                    lblSuccess.Text = "Special has been added successfuly";
            }
            //Load Shops
            List<Qaelo.Models.ShopOwnerModel.Shop> shops = connection.getAllMyShops(owner.Id);
            string html = "";

            foreach(Qaelo.Models.ShopOwnerModel.Shop shop in shops)
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
                        <h6><b>{2} - <small>{3}</small></b></h6>
                        <strong>Shop No:<small>{4}</small></strong><br />
                       <strong> Open: <small>{5}</small></strong><br />
                        <strong><small>{6}</small>
                        </strong><br /><br />
                            <a href='ManageListings.aspx?delId={7}' class='btn btn-danger pull-lef'>Delete</a>
                            <a href='EditShop.aspx?editId={7}' class='btn btn-info pull-right'>Edit</a>
                    </div>
                  </div>
                </div>
            </div>", shop.Image,shop.Description,shop.Name,shop.University,shop.Address,shop.TradingHours,"",shop.Id);
            }

            lblShops.Text = html;

            /**List Of Specials **/
            List<Qaelo.Models.ShopOwnerModel.ShopAds> specials = connection.getAllSpecialsByManagerId(owner.Id);
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
                        <strong>Shop No:<small>{4}</small></strong><br />
                       <strong> Open: <small>{5}</small></strong><br />
                        <strong><small>{6}</small>
                        </strong><br /><br />
                            <a href='ManageListings.aspx?delSpecialId={7}' class='btn btn-danger pull-lef'>Delete</a>
                            <a href='EditSpecial.aspx?editId={7}' class='btn btn-info pull-right'>Edit now</a>
                    </div>
                  </div>
                </div>
            </div>", shop.Image, shop.Description, shop.Name, shop.University, shop.ShopNo, shop.TradingHours, "", shop.Id);
            }
            
            lblSpecials.Text = htmlSpecials;
        }
    }
}