using Qaelo.Data.SocietyData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Society
{
    public partial class ListEvent1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnFinish_Click(object sender, EventArgs e)
        {

            string filename1 = "";
            Models.SocietyModel.Society society = (Models.SocietyModel.Society)Session["SOCIETY"];

            //Check if the files have something 
            if (fu1.HasFile)
            {
                try
                {
                    filename1 = society.Id + Path.GetFileName(fu1.FileName);
                    fu1.SaveAs(Server.MapPath("~/Images/Events/") + filename1);
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                    return;
                }
            }
            else
            {
                lblErrorMessage.Text = "Please upload Image";
                return;
            }

            new SocietyConnection().postEvent(new Models.EventPosterModel.MyEvent(society.Id, txtText.Text, Convert.ToDateTime(txtDate.Text), DateTime.Now, txtDescription.Text, Convert.ToDouble(txtPrice.Text), filename1, txtAddress.Text, txtName.Text, txtText.Text));

            lblSuccess.Text = "Successfully Added a new event ";
            Response.Redirect("ManageEvents.aspx");
        }
    }
}