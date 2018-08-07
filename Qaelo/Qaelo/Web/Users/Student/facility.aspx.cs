using Qaelo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Student
{
    public partial class facility : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {


            //Load manager
            Data.ShopData.ShopConnection connection = new Data.ShopData.ShopConnection();
            //Load Shops
            List<Qaelo.Models.ShopOwnerModel.Shop> shops = connection.getAllShopsBySearch(txtText.Text,ddlYear.SelectedItem.Text);


            string html = "";

            foreach (Qaelo.Models.ShopOwnerModel.Shop shop in shops)
            {
                html += string.Format(@"<div class='col-sm-3'>
                    <div class='thumbnail'>
                      <div class='w3-card-12'>
                          <figure class=''>
                          <img src='../../../Images/Shops/{0}' class='' style='height:220px;width:100%'/>
                              <figcaption style = 'background-image: url('')'>{1}
                                   </figcaption>
                               </figure>
                        <div class='w3-container' style='margin:10px'>
                            <h6><b>{2} - <small>{3}</small></b></h6>
                            <strong>Address:<small>{4}</small></strong><br />
                           <strong> Open: <small>{5}</small></strong><br />
                            <strong><small>{6}</small>
                                <a href='#shop{7}' data-toggle='modal' class='btn btn-default pull-right'>View Facility</a>
                            </strong><br />
                        </div><br />
                      </div>
                    </div>
                </div>", shop.Image, "", shop.Name, shop.University, shop.Address, shop.TradingHours,"", shop.Id);

                //Display Pop up 
                string chatLink = "";

                if (Session["STUDENT"] == null)
                    chatLink = "<a class='btn btn-success' href='../../Account/tempLogin.aspx'> Let's Chat</a>";
                else
                    chatLink = string.Format("<a class='btn btn-success' href='chat.aspx?chatTo={0}'> Let's Chat</a> ", shop.ShopOwnerId + "F");

                    lblSingleFacility.Text += string.Format(@"<div class='modal fade' id='shop{0}' tabindex='-1' role='dialog' aria-labelledby='myModalLabel' aria-hidden='true'>
                        <div class='modal-dialog modal-lg'>
                        <div class='modal-content'>
                                    <div class='modal-body'>
                                        <div class='container'>
                                            <div class='col-sm-10'>
                                                <div class='col-sm-5'>
                                                    <h2>About Facility</h2>
                                                    <hr />
                                                <strong>Facility Name: </strong>{1}<br/><br/>       
                                                <strong>Description:</strong><br/>{4} <br/><br/>          
                                                <a class='btn btn-warning' href='#'>View Pricelist</a>
                                                </div>
                                                <div class='col-sm-5'>
                                                    <h2>Operating Info</h2>
                                                   <hr /> 
                                                <strong>Address: </strong>{5}<br/>{3}<br/>
                                                <strong>Operating Hours: </strong>{6}<br/>      
                                                 {7}
                                                </div>
                                             </div>
                                        </div>
                                    <div class='modal-footer'>
                                        <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
                                    </div>
                                    </div>
                                </div>
                            </div>
                            </div>", shop.Id, shop.Name, shop.University, "", shop.Description.Replace(char.ConvertFromUtf32(13), "<br/>"), shop.Address, shop.TradingHours, chatLink);

            }

            lblFacilities.Text = html;
        }
    }
}