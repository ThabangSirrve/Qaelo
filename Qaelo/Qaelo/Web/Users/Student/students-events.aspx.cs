using Qaelo.Data.EventsData;
using Qaelo.Data.SocietyData;
using Qaelo.Models.EventPosterModel;
using Qaelo.Models.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Student
{
    public partial class Events : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            EventConnection connection = new EventConnection();
            string html = "";

            List<MyEvent> events = connection.getAllEventsByUniversity(txtText.Text);

                foreach (MyEvent item in events)
                {
                if(item != null)
                {

                    if (new EventConnection().isPosterVerified(item.EventPosterId))
                    {

                        string price = " Free";

                        if (item.EntryFee > 0)
                            price = item.EntryFee.ToString();

                            html += string.Format(@"<div class='col-lg-3'>
                  <div class='thumbnail'>
                  <div class='w3-card-12'>
                      <img src = '../../../Images/Events/{0}' class='' style='height:220px;width:100%' />
                    <div class='w3-container' style='margin:10px'>
                        <h6><b>{6}-<small style = 'font-size:12px' > {1}</small></b></h6>
                        <small><cite title = '' ><i class='glyphicon glyphicon-map-marker'>
                           </i> <a href='https://maps.google.com/?q={2}' target='_blank'>{2}</a></cite></small>
                      <p>{3}</p></a>
                        <strong>Entry Fee :{4}
                                <a href='#event{5}' data-toggle='modal' class='btn btn-default pull-right'>View</a>
                            </strong>
                    </div><br />
                    </div>
                  </div>
                 </div>", item.Image, General.getDateString(item.Date), item.Location, "", price, item.Id, item.Name);



                        //Add view for event
                        //Get Event Manager details 
                        Qaelo.Models.EventPosterModel.EventPoster poster = new EventConnection().getPoster(item.EventPosterId);
                        TicketModel ticket = new EventConnection().getTicketById(item.Id);


                        //Ticket information
                        string ticketInformation = "";

                        if (ticket != null)
                        {
                            string priceDescription ="- "+  ticket.PriceDescription.Replace(char.ConvertFromUtf32(13), "<br/> -");
                            string howToPay = string.Format(@"<p>- Bank Name :{0}</p>
                                <p>- Account Holder :{1}</p>
                                <p>- Account No: {2}</p>
                                <p>- Branch Code: {3}</p>
                                <p>- Reference : {4}</p>", ticket.BankName, ticket.AccountHolder, ticket.AccountNo, ticket.BranchCode, ticket.reference);

                            ticketInformation = string.Format(@"<div class='col-sm-12'>
                                        <br />
                                        <h4>Ticket Price(s)</h4>
                                        <p> {0}</p>

                                        <br />
                                        <h4>How To Pay</h4>
                                        <p> {1}</p>
                                    </div>", priceDescription,howToPay);
                            
                        }

                        lblEvent.Text += string.Format(@"<div class='modal fade' id='event{0}' tabindex='-1' role='dialog' aria-labelledby='myModalLabel' aria-hidden='true'>
                        <div class='modal-dialog modal-lg'>
                        <div class='modal-content'>

                            <div class='modal-header' style='background-color:mediumvioletred;margin-bottom:8px'>
                                <div class='container-fluid'>
                                    <div class='col-sm-12'>
                                        <div style='color:white'> {1} - {2}
                                        <a href='https://maps.google.com/?q={3}' target='_blank' class='pull-right' style='color:white;margin-top:-5px'><img src='../../../getDirections.png'  style='height:32px;width:32px;color:dodgerblue'/></a> 
                                        <span class='pull-right'>Get Directions</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                                   
                            <div class='modal-body'>
                                <div class='row'>
                                    <div class='col-lg-12' style='margin:20px'>
                                        <div class='col-lg-6'>
                                            <img src='../../../Images/Events/{4}' class='img-thumbnail' style='height:250px;width:100%'  />
                                        </div>

                                        <div class='col-lg-6'>
                                            <h4>Event Name</h4>
                                            <p>{1}</p>
                                            <br />
                                            <h4>Date</h4>
                                            <p>{2}</p>
                                            <br />
                                            <h4>For More info, Contact:</h4>
                                            <p> 
                                             <strong>Name :</strong>{5}<br />
                                             <strong>Call :</strong>{6}<br />
                                             <strong>Email:</strong>{7}<br />
                                            </p>
                                            <br/><strong>Price:</strong>{8}
                                        </div>
                                    
                                        </div>

                                    <div class='col-lg-12'>
                                         <br/><h4>Description</h4>
                                            <p>{9}</p>
                                    </div>

                                    {10} <!-- Ticket information -->

                                </div>
                                    </div>
                                   
                            <div class='modal-footer'>
                                        <button  class='btn btn-danger pull-right' data-dismiss='modal'>Back</button>
                                    </div>
                                </div>
                              </div>
                             </div>", item.Id,item.Name, General.getDateString(item.Date),item.Location,item.Image,poster.FullName,poster.Number,poster.Email,item.EntryFee,item.Description, ticketInformation);
                    }//End of Verification
                }
                }


            //if (html == "")
            //{
            //    html = "<div class='alert alert-info'><h3>Currently there are no events at the moment</h3></div>";
            //}

            listOfEvents.Text = html;
        }
    }
}