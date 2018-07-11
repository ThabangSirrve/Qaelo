using Qaelo.Data.CompanyData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Company
{
    public partial class EditPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["COMPANY"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Company/EditPost.aspx");
            }

            if (!IsPostBack)
            {
                //Get Company 
                if(Request.QueryString["editId"]!= null)
                {
                     Qaelo.Models.CompanyModel.Job job = new CompanyConnection().getPostById(Convert.ToInt32(Request.QueryString["editId"]));

                    txtADetails.Text = job.ContactInfo;
                    txtDescription.Text = job.Description;
                    txtCDate.Text = job.ClosingDate.ToShortDateString();
                    txtTitle.Text = job.Title;
                    int index = 0;

                    if (job.Type.ToUpper() == "JOB")
                        index = 2;
                    else if (job.Type.ToUpper() == "BURSARY")
                        index = 1;

                    ddlType.SelectedIndex = index;
                }
                else
                {
                    lblErrorMessage.Text = "";
                    lblSuccess.Text = "";
                }
            }
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            Qaelo.Models.CompanyModel.Company com = (Qaelo.Models.CompanyModel.Company)Session["COMPANY"];

            if (new CompanyConnection().updatePost(new Models.CompanyModel.Job(Convert.ToInt32(Request.QueryString["editId"]), com.Id, DateTime.Now, txtADetails.Text, DateTime.Now, txtDescription.Text, txtTitle.Text, ddlType.SelectedItem.Value)))
            {
                Response.Redirect("ManagePostings.aspx?page=editPost");
            }
            else
            {
                lblErrorMessage.Text = "An error occured,please try again";
                lblSuccess.Text = "";
            }

        }
    }
}