using Qaelo.Data.SocietyData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Society
{
    public partial class PostProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["SOCIETY"] == null)
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Society/PostProfile.aspx");

            Qaelo.Models.SocietyModel.Society society = (Qaelo.Models.SocietyModel.Society)Session["SOCIETY"];
            SocietyConnection connection = new SocietyConnection();

            if (Request.QueryString["page"]!= null)
            {
                lblSuccess.Text = "Successfully Updated your profile";
            }

            if(Request.QueryString["disable"] != null)
            {
                //Delete Profile From Societies table
                
                connection.deleteSocietiesProfile(society.Id);

                lblSuccess.Text = lblSuccess.Text = "";
                lblErrorMessage.Text = "Your Profile is now Private";
            }
            else if(Request.QueryString["enable"] != null)
            {
                //Insert Profile into Societies table 
                
                if(!connection.isProfilePublic(society.Id))
                    connection.uploadSocietiesProfile(society);

                lblSuccess.Text = lblSuccess.Text = "Your Profile is now Public";
                lblErrorMessage.Text = "";
            }

            string html = "";

            if(connection.isProfilePublic(society.Id))
            {
                html += string.Format(@"<div class='col-lg-3 col-lg-offset-3'>
                <h4> Your Current Profile Preview</h4>
                <div class='thumbnail'>
                  <div class='w3-card-12'>
                                <figure >
                                    <img src='../../../Images/Scociety/{0}'  class='' style='height:220px;width:100%' />
                          <figcaption style = 'background-image: url('')'>
                                {1}                  
                          </figcaption>
                           </figure>
                    <div class='w3-container' style='margin:10px'>
                        <h6><b>{2}- <small style='font-size:12px'>{3}</small></b></h6>
                        <strong>Type:<small>{4}</small></strong><br />
                       <strong> Meeting time: <small>{5}</small></strong><br />
                        <strong>Call:<small>{6}</small>
                      <a href='PostProfile.aspx?disable=delete' class='btn btn-danger pull-right'>Disable Profile</a>
                        </strong><br /><br/>
                    </div>
                  </div>
                </div>
                    </div>
            ", society.ProfileImage, society.Description, society.Name, society.University, society.SocietyType, society.MeetingTime, society.Number, society.Id);

            }
            else
            {
                html += string.Format(@"<div class='col-lg-3 col-lg-offset-3'>
<h3> Your Current Profile Preview</h3>
                <div class='thumbnail'>
                  <div class='w3-card-12'>
                                <figure >
                                    <img src='../../../Images/Scociety/{0}'  class='' style='height:220px;width:100%' />
                          <figcaption style = 'background-image: url('')'>
                                {1}                  
                          </figcaption>
                           </figure>
                    <div class='w3-container' style='margin:10px'>
                        <h6><b>{2}- <small style='font-size:12px'>{3}</small></b></h6>
                        <strong>Type:<small>{4}</small></strong><br />
                       <strong> Meeting time: <small>{5}</small></strong><br />
                        <strong>Call:<small>{6}</small>
                      <a href='PostProfile.aspx?enable=enable' class='btn btn-success pull-right'>Enable Profile</a>
                        </strong><br /><br/>
                    </div>
                  </div>
                </div>
                    </div>
            ", society.ProfileImage, society.Description, society.Name, society.University, society.SocietyType, society.MeetingTime, society.Number, society.Id);

            }

            lblSociety.Text = html;
        }
    }
}