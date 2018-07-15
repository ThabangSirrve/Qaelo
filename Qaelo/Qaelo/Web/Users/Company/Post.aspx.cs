using Qaelo.Data.CompanyData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Company
{
    public partial class Post : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["COMPANY"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx?page=Users/Company/Post.aspx");
            }
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {

            Qaelo.Models.CompanyModel.Company com = (Qaelo.Models.CompanyModel.Company)Session["COMPANY"];
            

            if (new CompanyConnection().createPost(new Models.CompanyModel.Job(com.Id,Convert.ToDateTime(txtCDate.Text),txtADetails.Text, DateTime.Now,txtDescription.Text, txtTitle.Text,ddlType.SelectedItem.Value)))
            {
                Response.Redirect("ManagePostings.aspx?page=post");
            }
            else
            {
                lblErrorMessage.Text = "An error occured,please try again";
                lblSuccess.Text = "";
            }


        }
    }
}