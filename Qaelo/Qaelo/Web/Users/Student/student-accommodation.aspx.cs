using Qaelo.Data.AccommodationData;
using Qaelo.Models.AccommodationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Student
{
    public partial class student_accommodation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

          
            if(Request.QueryString["search"] != null)
            {
                txtText.Text = Request.QueryString["search"].ToString();

                     #region not loggedin
             if (Session["STUDENT"] == null)
             {
                AccommodationConnection connection = new AccommodationConnection();

                //Load all the accommodations 
                string html = "";
                string accommodationName = "";
                string address = "";

                //Check if the user clicked the join button 
                if (Request.QueryString["joinId"] != null)
                {
                    //Login 
                    Response.Redirect("~/Web/Account/tempLogin.aspx");
                }
                else if (Request.QueryString["unjoinId"] != null)
                {
                    //Login
                    Response.Redirect("~/Web/Account/tempLogin.aspx");
                }

                string university = txtText.Text;

                List<Qaelo.Models.AccommodationModel.Accommodation> rooms = connection.getAllMyRoomsByUniversity(university);

                foreach (Qaelo.Models.AccommodationModel.Accommodation room in rooms)
                {
                    //Get accommodation Name
                    int managerId = room.id;

                    Manager manager = new ManagerConnection().getManager(room.managerId);
                    //Confirm Veririfcation

                    if (manager != null)
                    {
                        if (manager.verified)
                        {
                            if (manager.propertyName != "")
                            {
                                accommodationName = manager.propertyName;
                            }
                            else
                            {
                                accommodationName = "Room Available";
                            }


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
                                campus = room.campus.Substring(0, 15) + "...";
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

                            if (room.status)
                            {
                                available = "<a class='btn btn-success'>Available</a>";
                            }
                            else
                            {
                                available = "<a class='btn btn-danger' >Not available</a>";
                            }

                            //Before Joined Property

                            html += string.Format(@"<div class='col-xs-12 col-sm-12 col-md-12'>
                <div class='thumbnail'>
                    <div class='row'>
                        <div class='col-sm-6'>
                        <a data-toggle='modal' data-target='#myModal{0}' href='#myGallery{0}' data-slide-to='0'>
                           <img src = '../../../Images/Accommodation/{1}' class='img-rounded' height='250' width='100%'/>
                        </a>
                        </div>
                        <div class='col-sm-6 col-md-6'>
                            <i class='small pull-right' style='background-color:aliceblue'><small>{2}</small></i>
                            <h4>{3}</h4>
                           <a href='students-room.aspx?id={0}'> <small><cite title = 'Brxiton' ><i class='glyphicon glyphicon-map-marker'>
                            </i> {10}</cite></small>
                            <div class='list-group'>
                                <div class='list-group-item'>{4}</div>
                                <div class='list-group-item'><i class='fa fa-users' aria-hidden='true'></i>{5} <b> {6}</b></div>
                                <div class='list-group-item'><i class='fa fa-map-marker' aria-hidden='true'></i>{7} KM from {8}</div>
                            </div>
                                </a>
                            <div class='btn-group'>
                                <a type ='button' href='student-accommodation.aspx?joinId={0}' class='btn btn-success'>Join Property</a>
                            </div>
                            <p style = 'font-size:15px' class='pull-right'><b>R{9}</b>
                            </p>
                        </div>
                    </div>
                </div>
            </div> ", room.id, listOfImages[0], available, accommodationName, nfsas, room.arrangement, gender, room.distanceFromCampus, campus, room.price, room.address);

                            //Modal
                            html += string.Format(@"<div class='modal fade-scale' id='myModal{0}' style='margin-top:10%'>
                            <div class='modal-dialog'>
                            <div class='modal-content'>
                            <div class='modal-body'>

                            <div id = 'myGallery{0}' class='carousel slide' data-interval='false'>
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

                        }//If verified

                    }

                }
                //if (html == "")
                //    html = "<div class='alert alert-info'><h3>Unfortunately there are no rooms in this category</div></h3>";

                lblListOfRooms.Text = html;

            }
                    
                    #endregion

                    #region Loggedin 
                    else
                    {

                AccommodationConnection connection = new AccommodationConnection();
                Qaelo.Models.StudentModel.Student student = (Qaelo.Models.StudentModel.Student)(Session["STUDENT"]);

                //Load all the accommodations 
                string html = "";
                string accommodationName = "";
                int studentId = student.Id;
                string address = "";

                //Check if the user clicked the join button 
                if (Request.QueryString["joinId"] != null)
                {
                    Qaelo.Models.AccommodationModel.Accommodation room = connection.getRoom(Convert.ToInt32(Request.QueryString["joinId"].ToString()));

                    connection.joinPropery(room.managerId, room.id, studentId);
                }
                else if (Request.QueryString["unjoinId"] != null)
                {
                    Qaelo.Models.AccommodationModel.Accommodation room = connection.getRoom(Convert.ToInt32(Request.QueryString["unjoinId"].ToString()));

                    connection.unjoinProperty(room.id, studentId);
                }

                string university = txtText.Text;
                List<Qaelo.Models.AccommodationModel.Accommodation> rooms = connection.getAllMyRoomsByUniversity(university);

                foreach (Qaelo.Models.AccommodationModel.Accommodation room in rooms)
                {
                    //Get accommodation Name
                    int managerId = room.id;

                    Manager manager = new ManagerConnection().getManager(room.managerId);
                    //Confirm Veririfcation

                    if (manager != null)
                    {
                        if (manager.verified)
                        {
                            if (manager.propertyName != "")
                            {
                                accommodationName = manager.propertyName;
                            }
                            else
                            {
                                accommodationName = "Room Available";
                            }


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
                                campus = room.campus.Substring(0, 15) + "...";
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

                            if (room.status)
                            {
                                available = "<a class='btn btn-success'>Available</a>";
                            }
                            else
                            {
                                available = "<a class='btn btn-danger' >Not available</a>";
                            }


                            if (connection.propertyJoinedByUser(room.id, studentId))
                            {
                                //When the property is joined 
                                html += string.Format(@"<div class='col-xs-12 col-sm-12 col-md-12'>
                    <div class='thumbnail'>
                    <div class='row'>
                        <div class='col-sm-6'>
                        <a data-toggle='modal' data-target='#myModal{0}' href='#myGallery{0}' data-slide-to='0'>
                           <img src = '../../../Images/Accommodation/{1}' class='img-rounded' height='250' width='100%'/>
                        </a>
                        </div>
                        <div class='col-sm-6 col-md-6'>
                            <i class='small pull-right' style='background-color:aliceblue'><small>{2}</small></i>
                            <h4>{3}</h4>
                           <a href='students-room.aspx?id={0}'> <small><cite title = 'Brxiton' ><i class='glyphicon glyphicon-map-marker'>
                            </i> {10}</cite></small>
                            <div class='list-group'>
                                <div class='list-group-item'>{4}</div>
                                <div class='list-group-item'><i class='fa fa-users' aria-hidden='true'></i>{5} <b> {6}</b></div>
                                <div class='list-group-item'><i class='fa fa-map-marker' aria-hidden='true'></i>{7} KM from {8}</div>
                            </div>
                                </a>
                            <div class='btn-group'>
                                <a type ='button' href='student-accommodation.aspx?unjoinId={0} &search={11}' class='btn btn-danger'>Joined</a>
                            </div>
                            <p style = 'font-size:15px' class='pull-right'><b>R{9}</b>
                            </p>
                        </div>
                    </div>
                </div>
            </div> ", room.id, listOfImages[0], available, accommodationName, nfsas, room.arrangement, gender, room.distanceFromCampus, campus, room.price, address, Request.QueryString["search"]);

                            }
                            else
                            {
                                //Before Joined Property
                                html += string.Format(@"<div class='col-xs-12 col-sm-12 col-md-12'>
                <div class='thumbnail'>
                    <div class='row'>
                        <div class='col-sm-6 col-md-6'>
                        <a data-toggle='modal' data-target='#myModal{0}' href='#myGallery{0}' data-slide-to='0'>
                           <img src = '../../../Images/Accommodation/{1}' class='img-rounded' height='250' width='100%'/>
                        </a>
                        </div>
                        <div class='col-sm-6 col-md-6'>
                            <i class='small pull-right' style='background-color:aliceblue'><small>{2}</small></i>
                            <h4>{3}</h4>
                           <a href='students-room.aspx?id={0}'> <small><cite title = 'Brxiton' ><i class='glyphicon glyphicon-map-marker'>
                            </i> {10}</cite></small>
                            <div class='list-group'>
                                <div class='list-group-item'>{4}</div>
                                <div class='list-group-item'><i class='fa fa-users' aria-hidden='true'></i>{5} <b> {6}</b></div>
                                <div class='list-group-item'><i class='fa fa-map-marker' aria-hidden='true'></i>{7} KM from {8}</div>
                            </div>
                                </a>
                            <div class='btn-group'>
                                <a type ='button' href='student-accommodation.aspx?joinId={0} &search={11}' class='btn btn-success'>Join Property</a>
                            </div>
                            <p style = 'font-size:15px' class='pull-right'><b>R{9}</b>
                            </p>
                        </div>
                    </div>
                </div>
            </div> ", room.id, listOfImages[0], available, accommodationName, nfsas, room.arrangement, gender, room.distanceFromCampus, campus, room.price, room.address,Request.QueryString["search"]);
                            }
                            //Modal
                            html += string.Format(@"<div class='modal fade-scale' id='myModal{0}' style='margin-top:10%'>
                <div class='modal-dialog'>
                <div class='modal-content'>
                <div class='modal-body'>

                <div id = 'myGallery{0}' class='carousel slide' data-interval='false'>
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

                        }//If verified

                    }

                }
                        #endregion

                        //if (html == "")
                        //    html = "<div class='alert alert-info'><h3>Unfortunately there are no rooms in this category</div></h3>";
                        lblListOfRooms.Text = html;

                }//End of else
                }
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

            Response.Redirect("student-accommodation.aspx?" + "search=" + txtText.Text);
        }

    }
}