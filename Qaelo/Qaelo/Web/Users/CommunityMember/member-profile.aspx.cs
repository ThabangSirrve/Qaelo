using Qaelo.Data.AccommodationData;
using Qaelo.Data.ShopData;
using Qaelo.Data.StudentData;
using Qaelo.Models.AccommodationModel;
using Qaelo.Models.FreelancerModel;
using Qaelo.Models.StudentModel;
using Qaelo.Models.Utility;
using System;
using System.Collections.Generic;
using System.IO;

namespace Qaelo.Web.Users.CommunityMember
{
    public partial class member_profile : System.Web.UI.Page
    {
        StudentConnection connection = new StudentConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["STUDENT"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/CommunityMember/member-profile.aspx");
            }

            Qaelo.Models.StudentModel.Student student = (Qaelo.Models.StudentModel.Student)Session["STUDENT"];

            string html = "";

            if (Request.QueryString["page"] != null)
            {
                if (Request.QueryString["page"] == "sellbooks")
                {
                    lblSuccess.Text = "You have successfully Posted your used textbook";
                }
                else if (Request.QueryString["page"] == "freelancer")
                {
                    lblSuccess.Text = "You have successfully registered yourself as a freelancer";
                }
                else if (Request.QueryString["page"] == "profile")
                {
                    lblSuccess.Text = "You have successfully updated your profile";
                }
                else if (Request.QueryString["page"] == "editbook")
                {
                    lblSuccess.Text = "You have successfully updated your book";
                }
                else if (Request.QueryString["page"].Equals("previousWork"))
                {
                    lblSuccess.Text = "Successfully added your previous work";
                }
            }
            //Make Profile Public or private 
            if (Request.QueryString["disable"] != null)
            {
                //Delete Profile From Societies table
                connection.deleteStudentProfile(Convert.ToInt32(Request.QueryString["disable"].ToString()));
                lblSuccess.Text = lblSuccess.Text = "";
                lblErrorMessage.Text = "Your Profile is now Private";
            }
            else if (Request.QueryString["enable"] != null)
            {
                //Insert Profile into Societies table 
                if (!connection.isProfilePublic(Convert.ToInt32(Request.QueryString["enable"])))
                    connection.uploadStudentProfile(student);

                lblSuccess.Text = lblSuccess.Text = "Your Profile is now Public";
                lblErrorMessage.Text = "";
            }

            //removeAd
            if (Request.QueryString["removeAd"] != null)
            {
                int id = Convert.ToInt32(Request.QueryString["removeAd"]);
                //delete
                new AccommodationConnection().deleteRoomAd(id, student);
                lblSuccess.Text = "Successfully deleted room advert";
            }

            //delete book 
            if (Request.QueryString["remove"] != null)
            {
                int id = Convert.ToInt32(Request.QueryString["remove"]);
                //delete
                connection.deleteBook(id, student);
                lblSuccess.Text = "Successfully deleted book";
            }
            else if (Request.QueryString["edit"] != null)
            {
                //Edit book 
                Response.Redirect("students-edit-books.aspx?id=" + Convert.ToInt32(Request.QueryString["edit"]));
            }

            if (connection.isProfilePublic(student.Id))
            {
                //Profile link 
                string link = student.FirstName + "-" + student.LastName;
                //if a student is a freelancer then include it here
                Qaelo.Models.StudentModel.Freelancer fl = connection.Freelancer(student.Id);
                string freelancer = "";

                if (fl != null)
                    freelancer = "<h6>Freelancer :<small style='font-size:12px'>" + fl.Work.Replace(';', '\n') + "</small></h6>";

                string proficePic = "../../../Images/Users/Students/" + student.ProfileImage;

                if (student.ProfileImage.Contains("http"))
                    proficePic = student.ProfileImage;

                html += string.Format(@"
                <div class='thumbnail'>
                  <div class='w3-card-12'>
                                <figure >
                                  <img src='{0}' style='height:245px;width:245px' />
                          <figcaption style = 'background-image: url('')'>
                                {1}                  
                          </figcaption>
                           </figure>
                    <div class='w3-container' style='margin:10px'>
                        <h6 style='margin-bottom:10px'><b>{2}</b></h6>
                        {7}<br/>
                        <h6 style='margin-bottom:10px'>Location:<small style='font-size:12px'>{2}</small></h6>
                        <h6 style='margin-bottom:10px'>Link :<a style='font-size:12px' href='http://localhost:53020/profile/'>{6}</a></h6>
                      <a href='students-profile.aspx?disable={8}' class='btn btn-danger pull-right form-control'>Go Private!</a>
                        <br /><br/>
                    </div>
                  </div>
                </div>
                    
            ", proficePic, student.Description, student.FirstName + " " + student.LastName, student.Institution, student.QualificationEnrolled, student.YearOfStudy, "http://localhost:53020/profile/"+ link.ToLower(), freelancer, student.Id);

            }
            else
            {
                Qaelo.Models.StudentModel.Freelancer fl = connection.Freelancer(student.Id);
                string freelancer = "";

                if (fl != null)
                    freelancer = "<h6>Freelancer :</h6><small style='font-size:12px'>" + fl.Work.Replace(';', '\n') + "</small>";


                string proficePic = "../../../Images/Users/Students/" + student.ProfileImage;

                if (student.ProfileImage.Contains("http"))
                    proficePic = student.ProfileImage;

                html += string.Format(@"
                <div class='thumbnail'>
                  <div class='w3-card-12'>
                                <figure >
                                  <img src='{0}' style='height:245px;width:245px' />
                          <figcaption style = 'background-image: url('')'>
                                {1}                  
                          </figcaption>
                           </figure>
                    <div class='w3-container' style='margin:10px'>
                        <h6 style='margin-bottom:10px'><b>{2}- <small style='font-size:12px'>{3}</small></b></h6>
                        <h6 style='margin-bottom:10px'>Course Enrolled:<small style='font-size:12px'>{4}</small></h6>
                        <h6 style='margin-bottom:10px'>Year Of Study : <small style='font-size:12px'>{5}</small></h6>
                        <h6 style='margin-bottom:10px'>Email :<small style='font-size:12px'>{6}</small></h6>
                        {7}<br/><br/>
                      <a href='students-profile.aspx?enable={8}' class='btn btn-success pull-right form-control'>Go Public!</a>
                        <br /><br/>
                    </div>
                  </div>
                </div>
                   
            ", proficePic, student.Description, student.FirstName + " " + student.LastName, student.Institution, student.QualificationEnrolled, student.YearOfStudy, student.Email, freelancer, student.Id);
            }
            lblProfileView.Text = html;

            //Become a freelancer
            //if(!connection.isAllowedToPost(student.Id))
            //{
            //    lblFreelance.Text = "<a href='#cannotBecomeFreelancer'data-toggle='modal' class='btn btn-submit' >Freelancing</a>";
            //}
            //else
            //    lblFreelance.Text = "<a href='Freelancer.aspx' class='btn btn-submit' >Freelancing</a>";
            /*** load rooms ads ***/


            //List<RoomAd> ads = new AccommodationConnection().getRoomAds(student.Id);

            ////set what to appear on advertise on landlords 
            //if (ads.Count > 0)
            //{
            //    //Fill in   
            //    lblRoomAds.Text = "";
            //    foreach (RoomAd item in ads)
            //    {
            //        lblRoomAds.Text += string.Format(@"<tr>
            //                                    <td>{0}</td>
            //                                    <td>{1}</td>
            //                                    <td>{2}</td>
            //                                    <td>{3}</td>
            //                                    <td>{4}</td>
            //                                    <td><a href='CommunityMember-profile.aspx?removeAd={5}' class='btn btn-danger'>remove</a></td>
            //                                </tr>", General.getDateString(item.DatePosted), item.Arrangement, item.Gender, item.PaymentType, item.RentAmount, item.Id);
            //    }
            //    lblNumAdds.Text = ads.Count.ToString();
            //    //Set view to be current ads
            //    setView.HRef = "#viewAdd";
            //}
            //else
            //{
            //    //Fill some fields
            //    txtPhone.Text = student.Number;

            //    setView.HRef = "#share";
            //}

            //Check if the student has already some books sold
            List<Book> books = new StudentConnection().getAllStudentBoks(student.Id);
            lblPublished.Text = "";
            //if (books.Count > 0)
            //{
            //    if (books.Count >= 8)
            //        addNew.Visible = false;

            //    foreach (Book book in books)
            //    {

            //        string desc = "";

            //        if (book.Description.Length > 65)
            //            desc = book.Description.Substring(0, 65);
            //        else
            //            desc = book.Description;

            //        lblPublished.Text += string.Format(@"<div class='col-sm-4' style='margin:30px'>
            //                            <div class='col-sm-6'>
            //                                <img src='../../../Images/Book/{0}' class='img-thumbnail' style='height:150px;width:100%' id='image1'/>
            //                            </div>
            //                            <div class='col-sm-6'>
            //                                <label><strong>Title: {1}</strong></label><br/>
            //                                <label><strong>Price:R{2}.00</strong></label><br/>
            //                                <label><strong><a href='students-profile.aspx?remove={3}' class='btn btn-danger'>Delete</a></strong> <a href='students-profile.aspx?edit={3}' class='btn btn-finish btn-fill btn-warning btn-wd'>Edit</a></strong></label>
            //                            </div>
            //                        </div>
            //                    ", book.Image, book.Name, book.Price, book.Id);
            //    }

            //    lblsellbooks.Text = "<a href='#sellbooks'  data-toggle='modal'>My Store</a>";
            //}
            //else
            //{
            //    //Check if the student is allowed to post
            //    if (!connection.isAllowedToPost(student.Id))
            //        lblsellbooks.Text = "<a href='#cannotsellbooks'data-toggle='modal'> My Store</a>";
            //    else
            //        lblsellbooks.Text = "<a href='students-sell-textbooks.aspx'> My Store</a>";
            //}

            lblSuccess.Text = "";

            /******** Specials view **********/
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

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            Qaelo.Models.StudentModel.Student student = (Qaelo.Models.StudentModel.Student)Session["STUDENT"];

            new AccommodationConnection().postRoomAd(new Models.AccommodationModel.RoomAd(student.Id, ddlArragement.SelectedItem.Value, DateTime.Now, ddlGender.SelectedItem.Value, txtPhone.Text, ddlPaymentType.SelectedItem.Value, Convert.ToDouble(txtPrice.Text)));

            lblSuccess.Text = "Successfully Submitted Ad";

            Response.Redirect("CommunityMember-advertise-on-landloards-profile.aspx");
        }
    }
}