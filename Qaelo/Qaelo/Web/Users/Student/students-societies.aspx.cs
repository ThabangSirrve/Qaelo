using Qaelo.Data.SocietyData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Student
{
    public partial class Societies : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

            SocietyConnection connection = new Data.SocietyData.SocietyConnection();
            Qaelo.Models.StudentModel.Student student = (Qaelo.Models.StudentModel.Student)Session["STUDENT"];


            //Check if the user clicked the join button 
            if (Request.QueryString["joinId"] != null)
            {
                if (student != null)
                {
                    int societyId = Convert.ToInt32(Request.QueryString["joinId"].ToString());
                    connection.joinSociety(societyId, student.Id);
                }
                else
                {
                    //Redirect
                    Response.Redirect("~/Web/Account/tempLogin.aspx");
                }
            }
            else if (Request.QueryString["unJoinId"] != null)
            {
                if (student != null)
                {
                    int societyId = Convert.ToInt32(Request.QueryString["unJoinId"].ToString());

                    connection.unJoinSociety(societyId, student.Id);
                }
            }

            List<Qaelo.Models.SocietyModel.Society> societies = connection.getAllSocietiesByVarsity(txtText.Text);

            string html = "";

            if (student != null)
            {
                foreach (Qaelo.Models.SocietyModel.Society society in societies)
                {
                    if (new SocietyConnection().getSociety(society.Id).Verified)
                    {
                        //Check if the society was likeed 
                        if (connection.societyJoinedByUser(society.Id, student.Id))
                        {
                            html += string.Format(@"<div class='col-sm-3'>
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
                                <a href='Societies.aspx?unJoinId={7}' class='btn btn-danger pull-right'>Joined</a>
                            </strong><br />
                        </div><br />
                      </div>
                    </div>
                        </div>
                ", society.ProfileImage, society.Description, society.Name, society.University, society.SocietyType, society.MeetingTime, society.Number, society.Id);
                        }
                        else
                        {
                            html += string.Format(@"<div class='col-sm-3'>
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
                                <a href='Societies.aspx?joinId={7}' class='btn btn-default pull-right'>Join</a>
                            </strong><br />
                        </div><br />
                      </div>
                    </div>
                        </div>
                ", society.ProfileImage, society.Description, society.Name, society.University, society.SocietyType, society.MeetingTime, society.Number, society.Id);

                        }


                    }
                }//End of for each
            }
            else
            {
                foreach (Qaelo.Models.SocietyModel.Society society in societies)
                {
                    html += string.Format(@"<div class='col-sm-3'>
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
                                <a href='Societies.aspx?joinId={7}' class='btn btn-default pull-right'>Join</a>
                            </strong><br />
                        </div><br />
                      </div>
                    </div>
                        </div>
                ", society.ProfileImage, society.Description, society.Name, society.University, society.SocietyType, society.MeetingTime, society.Number, society.Id);

                }
            }

            //if (html == "")
            //{
            //    html = "<div class='alert alert-info'><h3>unfortunately Societies are not available at the moment</div></h3>";
            //}

            lblListOfSocieties.Text = html;
        }
    }
}