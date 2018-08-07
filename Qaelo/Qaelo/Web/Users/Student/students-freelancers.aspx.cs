using Qaelo.Data.StudentData;
using Qaelo.Models.FreelancerModel;
using Qaelo.Models.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Student
{
    public partial class students_freelancers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //load 

//            if (Request.QueryString[] != null)
//            {
//                string html = "";
//                Models.StudentModel.Freelancer freelancer = connection.getf
//                int length = General.getLengthOfLongestFreelancer(freelancers);

//                foreach (Models.StudentModel.Freelancer freelancer in freelancers)
//                {
//                    if (connection.isProfilePublic(freelancer.StudentId))
//                    {
//                        //if a student is a freelancer then include it here
//                        string[] abilities = freelancer.Work.Split(';');
//                        string work = "";

//                        for (int i = 0; i < abilities.Count(); i++)
//                            if (abilities[i].Count() > 0)
//                                if ((i + 1) == abilities.Count())
//                                    work += abilities[i];
//                                else
//                                {
//                                    if (abilities[i].Count() > 4)
//                                        work += "<li>" + abilities[i] + "</li>";
//                                    //work += "." + abilities[i] + "." + "<br/>";
//                                }

//                        string fr = "<h6 style='margin-top:10px'>I freelance as a : <br/><ul></h6><small style='font-size:12px'>" + work + "</b></small><ul/>";
//                        Qaelo.Models.StudentModel.Student student = connection.getStudent(freelancer.StudentId);
//                        string[] images = freelancer.Image.Split(';');

//                        html += string.Format(@"
//                        <div class='col-md-3 thumbnail'>
//                          <div class='w3-card-12'>
//                                        <figure >
//                                          <img src='../../../Images/Users/Students/{0}' style='height:220px;width:100%' />
//                                  <figcaption style = 'background-image: url('')'>
//                                        {1}                  
//                                  </figcaption>
//                                   </figure>
//                            <div class='w3-container' style='margin:10px'>
//                                <h6><b>{2}</b></h6>
//                                {4}<br/>
//                              <a href='#freelancer{5}'  data-toggle='modal' class='btn pull-right form-control' style='background:#d89b4e'>View profile</a>
//                                <br/><br/>
//                            </div>
//                          </div>
//                        </div>

                       
//                    ", student.ProfileImage, student.Description, student.FirstName + " " + student.LastName, student.Institution, fr, student.Id);

//                        //Modal pop up 

//                        //Get freelance portfolio
//                        PreviousWork portfolio = connection.getPortfolio(student.Id);

//                        string image1 = "default.jpg";
//                        string image2 = "default.jpg";
//                        string image3 = "default.jpg";

//                        string video1 = "videoDefault.mp4";
//                        string video2 = "videoDefault.mp4";
//                        string video3 = "videoDefault.mp4";

//                        string cvDescription = "";

//                        if (portfolio != null)
//                        {
//                            //Test for images
//                            string[] pictures = portfolio.Pictures.Split(';');

//                            if (pictures[0] != string.Empty)
//                            {
//                                image1 = pictures[0];
//                            }

//                            if (pictures[1] != string.Empty)
//                            {
//                                image2 = pictures[1];
//                            }

//                            if (pictures[2] != string.Empty)
//                            {
//                                image3 = pictures[2];
//                            }

//                            //Test for videos
//                            string[] videos = portfolio.Videos.Split(';');

//                            if (videos[0] != string.Empty)
//                            {
//                                video1 = videos[0];
//                            }

//                            if (videos[1] != string.Empty)
//                            {
//                                video2 = videos[1];
//                            }

//                            if (videos[2] != string.Empty)
//                            {
//                                video3 = videos[2];
//                            }

//                            cvDescription = portfolio.Links;

//                        }

//                        lblSingleProfile.Text += string.Format(@"<div class='modal fade' id='freelancer{11}' tabindex='-1' role='dialog' aria-labelledby='myModalLabel' aria-hidden='true'>
//                            <div class='modal-dialog modal-lg'>
//                            <div class='modal-content'>
//                                        <div class='modal-body'>
//                                            <div class='container'>
//                                                <div class='col-sm-9'>
//                                                    <div class='col-sm-5'>
//                                                        <h2>My Freelance Profile</h2>
//                                                        <hr />            
//                                                        <strong>Freelance:</strong><p>{2}</p>
//                                                        <strong>Freelancing Description:</strong><p>{3}</p>
//                                                        <strong>Price:</strong><p>{4}</p>
//                                                    </div>
//                                                    <div class='col-sm-5'>
//                                                        <h2>Contact Info</h2>
//                                                         <hr />   
//                                                        <strong>Full Name :</strong><p>{5}</p>
//                                                        <strong>Email:</strong><p>{6}</p>
//                                                        <a class='btn btn-success' href='#'>Let's Chat</a>
//                                                    </div>
//                                                 </div>

//                                                 <div class='col-sm-9' style='margin-top:50px'> </div>

//                                                 <!-- Portfolio-->
//                                                <div class='col-sm-9'>                                       
//                                                         <div class='panel-group' id='accordion{11}'>
//                                                             <div class='panel panel-warning'>
//                                                                 <div class='panel-heading'>
//                                                                    <h4 class='panel-title'>
//                                                                         <a data-toggle='collapse' data-parent='#accordion{11}' href='#collapse1{11}'>
//                                                                          View My Portfolio Pictures</a>
//                                                              </h4>
//                                                            </div>
                                                        
//                                                    <div id='collapse1{11}' class='panel-collapse collapse'>
//                                                          <div class='panel-body'>
//                                                              <div class='col-sm-12'>
                                                    
                                                                  
//                                                                                                        <div class='col-sm-4'>
//                                                                                                            <a id='popover1{11}' class='btn' rel='popover1{11}' data-content=''  >
//                                                                                                                <img src='../../../Images/Freelancer/{12}' class='img-thumbnail' />
//                                                                                                            </a>
                                                                                                             
//                                                                                                        </div>
                                                                                                       
//                                                                                                         <div class='col-sm-4'>
//                                                                                                             <a id='popover2{11}' class='btn' rel='popover2{11}' data-content=''  >
//                                                                                                             <img src='../../../Images/Freelancer/{13}' class='img-thumbnail' />
//                                                                                                                 </a>
//                                                                                                        </div>
                                                                                                       
//                                                                                                         <div class='col-sm-4'>
//                                                                                                             <a id='popover3{11}' class='btn' rel='popover3{11}' data-content=''  >
//                                                                                                             <img src='../../../Images/Freelancer/{14}' class='img-thumbnail' />
//                                                                                                                 </a>
//                                                                                                        </div>
//                                                                                                     </div>
//                                                          </div>
//                                                        </div>
                                                      
//             </div>
//         </div>
//         <!-- Next conetent here-->


//                                                      <div class='panel panel-warning'>
//                                                        <div class='panel-heading'>
//                                                          <h4 class='panel-title'>
//                                                            <a data-toggle='collapse' data-parent='#accordion{11}' href='#collapse2{11}'>
//                                                            View My Portfolio Videos</a>
//                                                          </h4>
//                                                        </div>
//                                                        <div id='collapse2{11}' class='panel-collapse collapse '>
//                                                          <div class='panel-body'>
//                                                              <div class='col-sm-12'>
//                                                                <div class='col-sm-4'>
//                                                                    <video src='../../../Images/Freelancer/{15}' class='img-thumbnail' style='height:150px;' controls='controls' />
//                                                                </div>
                                                                                                       
//                                                                 <div class='col-sm-4'>
//                                                                     <video src='../../../Images/Freelancer/{16}' class='img-thumbnail' style='height:150px;' controls='controls' />
//                                                                </div>
                                                                                                        
//                                                                <div class='col-sm-4'>
//                                                                    <video src='../../../Images/Freelancer/{17}' class='img-thumbnail' style='height:150px;' controls='controls' />
//                                                                </div>
                                                                                                     
//                                                              </div>

//                                                          </div>
//                                                        </div>
//                                                      </div>
//    <!-- Next content here-->
//                                                <div class='panel panel-warning'>
//                                                        <div class='panel-heading'>
//                                                          <h4 class='panel-title'>
//                                                            <a data-toggle='collapse' data-parent='#accordion{11}' href='#collapse3{11}'>
//                                                            View My Portfolio CV</a>
//                                                          </h4>
//                                                        </div>
//                                                        <div id='collapse3{11}' class='panel-collapse collapse'>
//                                                          <div class='panel-body'>
//                                                              <div class='col-sm-12'>
                                                    
//                                                                                                        <p>
//                                                                                                           {18}
//                                                                                                        </p>
//                                                                                                     </div>

//                                                          </div>
//                                                        </div>
//                                                      </div>
//     </div>

                                               
//                                                 </div>
//                                        <div class='modal-footer'>
//                                            <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
//                                        </div>
//                                        </div>
//                                    </div>
//                                </div>
//</div>", student.Institution, student.QualificationEnrolled, freelancer.Work, freelancer.Description, freelancer.Price, student.FirstName + " " + student.LastName, student.Email, student.Number, images[0], images[1], images[2], student.Id, image1, image2, image3, video1, video2, video3, cvDescription);

//                    }
//                }

//                if (html.Length > 0)
//                    lblProfileView.Text = html;
//            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //Get all students from selected varsity 
            StudentConnection connection = new StudentConnection();
            string query = " Institution = " + "'" + txtText.Text + "'";
            List<Qaelo.Models.StudentModel.Student> students = connection.getAllStudents(query);

            List<Qaelo.Models.StudentModel.Freelancer> freelancers = new List<Models.StudentModel.Freelancer>();

            //add each profile to freelance list 
            foreach(Qaelo.Models.StudentModel.Freelancer freelancer in connection.getAllFreelancers())
            {
                //add student as freelance 
                if(connection.getStudent(freelancer.StudentId) != null)
                    if (connection.getStudent(freelancer.StudentId).Institution.Equals(txtText.Text))
                        if(freelancer.Work.Contains(txtFreelancers.Text))
                            freelancers.Add(freelancer);
            }
            string html = "";
            int length = General.getLengthOfLongestFreelancer(freelancers);

            foreach (Models.StudentModel.Freelancer freelancer in freelancers)
            {
                if (connection.isProfilePublic(freelancer.StudentId))
                {
                    //if a student is a freelancer then include it here
                    string[] abilities = freelancer.Work.Split(';');
                    string work = "";

                    for (int i = 0; i < abilities.Count(); i++)
                        if (abilities[i].Count() > 0)
                            if ((i + 1) == abilities.Count())
                                work += abilities[i];
                            else
                            {
                                if(abilities[i].Count() > 4)
                                    work += "<li>" + abilities[i] + "</li>";
                                //work += "." + abilities[i] + "." + "<br/>";
                            }

                    string fr = "<h6 style='margin-top:10px'>I freelance as a : <br/><ul></h6><small style='font-size:12px'>" + work + "</b></small><ul/>";
                    Qaelo.Models.StudentModel.Student student = connection.getStudent(freelancer.StudentId);
                    string[] images = freelancer.Image.Split(';');

                    html += string.Format(@"
                        <div class='col-md-3 thumbnail'>
                          <div class='w3-card-12'>
                                        <figure >
                                          <img src='../../../Images/Users/Students/{0}' style='height:220px;width:100%' />
                                  <figcaption style = 'background-image: url('')'>
                                        {1}                  
                                  </figcaption>
                                   </figure>
                            <div class='w3-container' style='margin:10px'>
                                <h6><b>{2}</b></h6>
                                {4}<br/>
                              <a href='#freelancer{5}'  data-toggle='modal' class='btn pull-right form-control' style='background:#d89b4e'>View profile</a>
                                <br/><br/>
                            </div>
                          </div>
                        </div>

                       
                    ", student.ProfileImage, student.Description, student.FirstName + " " + student.LastName, student.Institution, fr, student.Id);

                    //Modal pop up 

                    //Get freelance portfolio
                    PreviousWork portfolio = connection.getPortfolio(student.Id);

                    string image1 = "default.jpg";
                    string image2 = "default.jpg";
                    string image3 = "default.jpg";

                    string video1 = "videoDefault.mp4";
                    string video2 = "videoDefault.mp4";
                    string video3 = "videoDefault.mp4";

                    string cvDescription = "";

                    if(portfolio != null)
                    {
                        //Test for images
                        string[] pictures = portfolio.Pictures.Split(';');

                        if (pictures[0] != string.Empty)
                        {
                            image1 = pictures[0];
                        }

                        if (pictures[1] != string.Empty)
                        {
                            image2 = pictures[1];
                        }

                        if (pictures[2] != string.Empty)
                        {
                            image3 = pictures[2];
                        }

                        //Test for videos
                        string[] videos = portfolio.Videos.Split(';');

                        if (videos[0] != string.Empty)
                        {
                            video1 = videos[0];
                        }

                        if (videos[1] != string.Empty)
                        {
                            video2 = videos[1];
                        }

                        if (videos[2] != string.Empty)
                        {
                            video3 = videos[2];
                        }

                        cvDescription = portfolio.Links;

                    }

                    lblSingleProfile.Text += string.Format(@"<div class='modal fade' id='freelancer{11}' tabindex='-1' role='dialog' aria-labelledby='myModalLabel' aria-hidden='true'>
                            <div class='modal-dialog modal-lg'>
                            <div class='modal-content'>
                                        <div class='modal-body'>
                                            <div class='container'>
                                                <div class='col-sm-9'>
                                                    <div class='col-sm-5'>
                                                        <h2>My Freelance Profile</h2>
                                                        <hr />            
                                                        <strong>Freelance:</strong><p>{2}</p>
                                                        <strong>Freelancing Description:</strong><p>{3}</p>
                                                        <strong>Price:</strong><p>{4}</p>
                                                    </div>
                                                    <div class='col-sm-5'>
                                                        <h2>Contact Info</h2>
                                                         <hr />   
                                                        <strong>Full Name :</strong><p>{5}</p>
                                                        <strong>Email:</strong><p>{6}</p>
                                                        <a class='btn btn-success' href='#'>Let's Chat</a>
                                                    </div>
                                                 </div>

                                                 <div class='col-sm-9' style='margin-top:50px'> </div>

                                                 <!-- Portfolio-->
                                                <div class='col-sm-9'>                                       
                                                         <div class='panel-group' id='accordion{11}'>
                                                             <div class='panel panel-warning'>
                                                                 <div class='panel-heading'>
                                                                    <h4 class='panel-title'>
                                                                         <a data-toggle='collapse' data-parent='#accordion{11}' href='#collapse1{11}'>
                                                                          View My Portfolio Pictures</a>
                                                              </h4>
                                                            </div>
                                                        
                                                    <div id='collapse1{11}' class='panel-collapse collapse'>
                                                          <div class='panel-body'>
                                                              <div class='col-sm-12'>
                                                    
                                                                  
                                                                                                        <div class='col-sm-4'>
                                                                                                            <a id='popover1{11}' class='btn' rel='popover1{11}' data-content=''  >
                                                                                                                <img src='../../../Images/Freelancer/{12}' class='img-thumbnail' />
                                                                                                            </a>
                                                                                                             
                                                                                                        </div>
                                                                                                       
                                                                                                         <div class='col-sm-4'>
                                                                                                             <a id='popover2{11}' class='btn' rel='popover2{11}' data-content=''  >
                                                                                                             <img src='../../../Images/Freelancer/{13}' class='img-thumbnail' />
                                                                                                                 </a>
                                                                                                        </div>
                                                                                                       
                                                                                                         <div class='col-sm-4'>
                                                                                                             <a id='popover3{11}' class='btn' rel='popover3{11}' data-content=''  >
                                                                                                             <img src='../../../Images/Freelancer/{14}' class='img-thumbnail' />
                                                                                                                 </a>
                                                                                                        </div>
                                                                                                     </div>
                                                          </div>
                                                        </div>
                                                      
             </div>
         </div>
         <!-- Next conetent here-->


                                                      <div class='panel panel-warning'>
                                                        <div class='panel-heading'>
                                                          <h4 class='panel-title'>
                                                            <a data-toggle='collapse' data-parent='#accordion{11}' href='#collapse2{11}'>
                                                            View My Portfolio Videos</a>
                                                          </h4>
                                                        </div>
                                                        <div id='collapse2{11}' class='panel-collapse collapse '>
                                                          <div class='panel-body'>
                                                              <div class='col-sm-12'>
                                                                <div class='col-sm-4'>
                                                                    <video src='../../../Images/Freelancer/{15}' class='img-thumbnail' style='height:150px;' controls='controls' />
                                                                </div>
                                                                                                       
                                                                 <div class='col-sm-4'>
                                                                     <video src='../../../Images/Freelancer/{16}' class='img-thumbnail' style='height:150px;' controls='controls' />
                                                                </div>
                                                                                                        
                                                                <div class='col-sm-4'>
                                                                    <video src='../../../Images/Freelancer/{17}' class='img-thumbnail' style='height:150px;' controls='controls' />
                                                                </div>
                                                                                                     
                                                              </div>

                                                          </div>
                                                        </div>
                                                      </div>
    <!-- Next content here-->
                                                <div class='panel panel-warning'>
                                                        <div class='panel-heading'>
                                                          <h4 class='panel-title'>
                                                            <a data-toggle='collapse' data-parent='#accordion{11}' href='#collapse3{11}'>
                                                            View My Portfolio CV</a>
                                                          </h4>
                                                        </div>
                                                        <div id='collapse3{11}' class='panel-collapse collapse'>
                                                          <div class='panel-body'>
                                                              <div class='col-sm-12'>
                                                    
                                                                                                        <p>
                                                                                                           {18}
                                                                                                        </p>
                                                                                                     </div>

                                                          </div>
                                                        </div>
                                                      </div>
     </div>

                                               
                                                 </div>
                                        <div class='modal-footer'>
                                            <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
                                        </div>
                                        </div>
                                    </div>
                                </div>
</div>", student.Institution, student.QualificationEnrolled, freelancer.Work, freelancer.Description, freelancer.Price, student.FirstName + " " + student.LastName, student.Email, student.Number, images[0], images[1], images[2], student.Id,image1,image2,image3,video1,video2,video3,cvDescription);

                }
            }

            if (html.Length > 0)
                lblProfileView.Text = html;
        }
    }
}