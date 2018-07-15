using Qaelo.Data.ShopData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Student
{
    public partial class testModal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (Qaelo.Models.ShopOwnerModel.ShopAds shop in new ShopConnection().getAllSpecials())
            {
                //create card view for specials 
                    lblSpecialLinks.Text += string.Format(@"<div class='col-sm-3'>
                    <div class='thumbnail'>
                      <div class='w3-card-12'>
                          <figure class=''>
                          <img src='../../../Images/Shops/Specials/{0}' class='' style='height:220px;width:100%'/>
                              <figcaption style = 'background-image: url('')'>{1}
                                   </figcaption>
                               </figure>
                        <div class='w3-container' style='margin:10px'>
                            <h6><b>{2} - <small>{3}</small></b></h6>
                            <strong>Shop No:<small>{4}</small></strong><br />
                           <strong> Open: <small>{5}</small></strong><br />
                            <strong>Call:<small>{6}</small>
                                <a href='#shopSpecial{7}' data-toggle='modal' class='btn btn-default pull-right'>View Special</a>
                            </strong><br />
                        </div><br />
                      </div>
                    </div>
                </div>", shop.Image, "", shop.Name, shop.University, shop.ShopNo, shop.TradingHours, new ShopConnection().getShopOwner(shop.ShopOwnerId).Number, shop.Id);


                    //Generate links for individual Special
                    //lblSpecialLinks.Text += string.Format("<a href='#shopSpecial{0}' data-toggle='modal'>View Special</a>",shop.Id);
                lblSpecials.Text += string.Format(@"<div class='modal fade' id='shopSpecial{4}' tabindex='-1' role='dialog' aria-labelledby='myModalLabel' aria-hidden='true'>
                        <div class='modal-dialog modal-lg'>
                        <div class='modal-content'>
                                    <div class='modal-body'>
                                        <div class='col-md-12' style='margin:20px'>
                                        <div class='col-md-6'>
                                            <img src='../../../Images/Shops/Specials/{0}' class='img-thumbnail' />
                                        </div>

                                        <div class='col-md-6'>
                                            <h4>Special Name</h4>
                                            <p>{1}</p>
                                            <br/><h4>Description</h4>
                                            <p>{2}</p>
                                            <br/><h4>Price:</h4>{3}
                                        </div>
                                    
                                        </div>
                                    <div class='modal-footer'>
                                        <button  class='btn btn-danger pull-right' data-dismiss='modal'>Back</button>
                                    </div>
                                    </div>
                                </div>
                            </div>
                            </div>", shop.Image, shop.Name, shop.Description.Replace(char.ConvertFromUtf32(13), "<br/>"), shop.Campus, shop.Id);
            }
        }
    }
}