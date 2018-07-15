using Qaelo.Data.CompanyData;
using Qaelo.Models.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Company
{
    public partial class ManagePostings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["COMPANY"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Company/ManagePostings.aspx");
            }

            if(Request.QueryString["page"] != null)
            {
                if(Request.QueryString["page"].ToString() == "post")
                    lblSuccess.Text = "Successfully created a post";

                if (Request.QueryString["page"].ToString() == "editPost")
                    lblSuccess.Text = "Successfully Edited a post";
            }

            CompanyConnection connection = new CompanyConnection();
            Qaelo.Models.CompanyModel.Company company = (Qaelo.Models.CompanyModel.Company)Session["COMPANY"];

            if (Request.QueryString["delId"] != null)
            {
                if (connection.deletePost(Convert.ToInt32(Request.QueryString["delId"].ToString()),company.Id))
                {
                    lblSuccess.Text = "Post has been deleted successfuly";
                }
                else
                {
                    lblErrorMessage.Text = "An error occurred while deleting Post please try again";
                }
            }

            List<Qaelo.Models.CompanyModel.Job> jobs = connection.getAllPostByCompanyId(company.Id);

            string html = "";

            foreach (Qaelo.Models.CompanyModel.Job item in jobs)
            {
                html += string.Format(@"<div class='col-lg-3'>
                <div class='thumbnail'>
                  <div class='w3-card-12'>
                      <figure >
                      <img src='../../../Images/Users/Company/{0}' class='' style='height:220px;width:100%'/>
                          <figcaption style = 'background-image: url('')'>{1}
                               </figcaption>
                           </figure>
                    <div class='w3-container' style='margin:10px'>
                        <h6><b>{2} - <small>{3}</small></b></h6>
                       <strong> Closing Date : <small> {4}</small></strong><br/>
                       <strong> Date Posted: <small> {5}</small></strong><br/>
                        </strong>
                            <a href='ManagePostings.aspx?delId={6}' class='btn btn-danger pull-lef'>Delete</a>
                            <a href='EditPost.aspx?editId={6}' class='btn btn-info pull-right'>Edit</a>
                    </div>
                  </div>
                </div>
            </div>", company.ProfileImage, item.Description, company.Name, item.Title, General.getDateString(item.ClosingDate),General.getPastTimeString(item.DatePosted), item.Id);
            }

            lblPosts.Text = html;
        }
    }
}