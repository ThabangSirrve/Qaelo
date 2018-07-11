using Qaelo.Data.AccommodationData;
using Qaelo.Models.AccommodationModel;
using Qaelo.Models.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Accommodation
{
    public partial class MyListings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["PROPERTYMANAGER"] != null)
            {
                AccommodationConnection connection = new AccommodationConnection();

                Manager manager = (Manager)(Session["PROPERTYMANAGER"]);

                //Check if delete button was clicked 
                if (Request.QueryString["delId"] != null)
                {
                    if(connection.deletedRoom(Convert.ToInt32(Request.QueryString["delId"].ToString()), manager.id))
                    {
                        lblSuccess.Text = "Successsfully Deleted room";
                    }
                    else
                    {
                        lblErrorMessage.Text = "Failed to delete room";
                    }
                }

                //check if room was made unavailable 

                if (Request.QueryString["available"] != null)
                {
                    Models.AccommodationModel.Accommodation room = new AccommodationConnection().getRoom(Convert.ToInt32(Request.QueryString["available"]));

                    connection.availableStatus(room,false);
                }
                else if (Request.QueryString["unAvailable"] != null)
                {
                    Models.AccommodationModel.Accommodation room = new AccommodationConnection().getRoom(Convert.ToInt32(Request.QueryString["unAvailable"]));
                    connection.availableStatus(room,true);
                }

                List<Qaelo.Models.AccommodationModel.Accommodation> rooms = connection.getAllMyRooms(manager.id);
                string html = "";
                string accommodationName = manager.propertyName;
                string address = "";

                foreach (Qaelo.Models.AccommodationModel.Accommodation room in rooms)
                {
                    //Get Images
                    string[] listOfImages = room.images.Split(';');

                    string nfsas = "";
                    string gender = "";
                    string campus = room.campus;

                    if (accommodationName.Length > 21)
                    {
                        accommodationName = accommodationName.Substring(0, 21) + "...";
                    }
                    if (room.address.Length > 41)
                        address = room.address.Substring(0, 40) + "...";
                    else
                        address = room.address;

                    if (campus.Length > 18)
                        campus = room.campus.Substring(0, 18) + "...";
                    else
                        campus = room.campus;

                    if (room.gender == "All")
                        gender = "";
                    else
                        gender = room.gender;

                    if (room.accredited)
                        nfsas = "<i class='glyphicon glyphicon-check'></i> Student Loan Accredited";
                    else
                        nfsas = "<i class='glyphicon glyphicon-check'></i>Cash Only";

                    //check if available or not 
                    string available = "";

                    if(room.status)
                    {
                        available = "<a class='btn btn-success' href='landlord-my-rooms.aspx?available=" + room.id + "'>Available</a>";
                    }
                    else
                    {
                        available = "<a class='btn btn-danger' href='landlord-my-rooms.aspx?unAvailable="+ room.id +"'>Not available</a>";
                    }
                        html += string.Format(@"<div class='col-xs-12 col-sm-6 col-md-6'>
                         <div class='well well-sm'>
                        <div class='row'>
                            <div class='col-sm-6 col-md-6'>
                            <a data-toggle='modal' data-target='#myModal{0}' href='#myGallery{0}' data-slide-to='0'>
                               <img src = '../../../Images/Accommodation/{1}' class='img-rounded' height='250' width='100%'/>
                            </a>
                            </div>
                            <div class='col-sm-6 col-md-6'>
                                <i class='small pull-right' style='background-color:aliceblue'>{2}</i>
                                <h4>{3}</h4>
                       <a href='#'> <small><cite title = 'Brxiton' ><i class='glyphicon glyphicon-map-marker'>
                        </i> {9}</cite></small>
                        <div class='list-group'>
                            <div class='list-group-item'>{4}</div>
                            <div class='list-group-item'><i class='fa fa-users' aria-hidden='true'></i>{5} <b> {6}</b></div>
                            <div class='list-group-item'><i class='fa fa-map-marker' aria-hidden='true'></i>{7} KM from {8}</div>
                        </div>
                            </a>
                            <a type ='button' href='landlord-my-rooms.aspx?delId={0}' class='btn btn-danger pull-left'>Delete</a>
                            <a type ='button' href='landlord-edit-room.aspx?editId={0}' style='margin-left:20px' class='btn btn-info pull-right'>Edit</a>
                        </p>
                    </div>
                </div>
            </div>
        </div> ", room.id, listOfImages[0], available, accommodationName, nfsas, room.arrangement, gender, room.distanceFromCampus, campus, room.address);
                    
                    //Modal
                    html += string.Format(@"<div class='modal fade-scale' id='myModal{0}' style='margin-top:10%'>
                            <div class='modal-dialog'>
                            <div class='modal-content'>
                            <div class='modal-body'>

                            <div id = 'myGallery{0}' cl ass='carousel slide' data-interval='false'>
                            <div class='carousel-inner'>
                            <div class='item active'> <img src = '../../../Images/Accommodation/{1}' alt='item0' width='100%'>
                            </div>
                            <div class='item'> <img src = '../../../Images/Accommodation/{2}' alt='item2' width='100%'>
                            </div>
                            <div class='item'> <img src = '../../../Images/Accommodation/{3}' alt='item3' width='100%'>
                            </div>
                            <div class='item'> <img src = '../../../Images/Accommodation/{4}' alt='item4' width='100%'>
                            </div>
                            <div class='item'> <img src = '../../../Images/Accommodation/{5}' alt='item5' width='100%'>
                            </div>
                            </div>

                            <a class='left carousel-control' href='#myGallery{0}' role='button' data-slide='prev'> <span class='glyphicon glyphicon-chevron-left'></span></a> <a class='right carousel-control' href='#myGallery{0}' role='button' data-slide='next'> <span class='glyphicon glyphicon-chevron-right'></span></a>
                            </div>
                            </div>
                            </div>
                            </div>
                            </div>", room.id, listOfImages[0], listOfImages[1], listOfImages[2], listOfImages[3], listOfImages[4]);
                }

                lblListOfRooms.Text = html;
            }
            else
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Accommodation/landlord-my-rooms.aspx");
            }
        }
    }
}