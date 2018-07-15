using Qaelo.Data.SocietyData;
using Qaelo.Models.EventPosterModel;
using Qaelo.Models.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Society
{
    public partial class Managestudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SOCIETY"] == null)
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Society/ManageEvents.aspx");

            SocietyConnection connection = new SocietyConnection();
            Qaelo.Models.SocietyModel.Society poster = (Qaelo.Models.SocietyModel.Society)Session["SOCIETY"];

            //check delete Event 
            if (Request.QueryString["delId"] != null)
            {
                if (connection.deleteEvent(Convert.ToInt32(Request.QueryString["delId"].ToString()), poster.Id))
                    lblSuccess.Text = "Event has been deleted successfuly";
                else
                    lblErrorMessage.Text = "An error occurred while deleting event please try again";

            }
            //Load all events
            List<MyEvent> events = connection.getAllMyEvents(poster.Id);

            string html = "";

            foreach (MyEvent item in events)
            {
                string price = " Free";

                if (item.EntryFee > 0)
                    price = " R" + item.EntryFee.ToString();
                //Check if the event was liked
                string description = item.Description;

                if (description.Length > 45)
                    description = description.Substring(0, 45) + "...";

                html += string.Format(@"<div class='col-lg-3'>
                  <div class='thumbnail'>
                  <div class='w3-card-12'>
                      <img src = '../../../Images/Events/{0}' class='' style='height:220px;width:100%' />
                    <div class='w3-container' style='margin:10px'>
                        <h6><b>{6}-<small style = 'font-size:12px' > {1}</small></b></h6>
                        <small><cite title = '' ><i class='glyphicon glyphicon-map-marker'>
                           </i> {2}</cite></small>
                      <p>{3}</p>
                        <strong>Entry Fee :{4}
                        </a></strong><br/>
                        <p>
                            <a href='ManageEvents.aspx?delId={5}' class='btn btn-danger pull-left'> Delete</a>
                            <a href='EditEvent.aspx?editId={5}' class='btn btn-info pull-right'> Edit</a>
                        </p>
                    </div><br /><br />
                    </div>
                  </div>
                 </div>", item.Image, General.getDateString(item.Date), item.Location, description, price, item.Id,item.Id);
            }

           //if (html == "") html = "<div class='alert alert-info'><h3>I'ts Empty here, Data will soon be available as soon as you post an event</div></h3>";

            listOfEvents.Text = html;
        }
    }
}