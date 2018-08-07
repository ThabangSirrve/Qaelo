using Qaelo.Data.ShopData;
using Qaelo.Models.ShopOwnerModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Facility
{
    public partial class edit_discount : System.Web.UI.Page
    {
        string file = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["editId"] == null)
                Response.Redirect("manage-facilities.aspx");

            if(!IsPostBack)
            {
                //Poplate all fields
                int Id = Convert.ToInt32(Request.QueryString["editId"].ToString());
                ShopAds special = new ShopConnection().getSpecialsById(Id);
    
                txtDescription.Text = special.Description;
                txtName.Text = special.Name;
                txtOpenHours.Text = special.TradingHours;
                txtPrice.Text = special.Campus;//using campus field as price field 
                txtShoNo.Text = special.ShopNo.ToString();
                txtShopName.Text = special.Name;
                txtText.Text = special.University;
                file = special.Image;
            }
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            ShopOwner owner = (ShopOwner)Session["SHOPOWNER"];
            int specialId = Convert.ToInt32(Request.QueryString["editId"].ToString());

            if (txtDescription.Text == string.Empty || txtName.Text == string.Empty || txtOpenHours.Text == string.Empty
                || txtPrice.Text == string.Empty || txtShoNo.Text == string.Empty || txtShopName.Text == string.Empty
                || txtText.Text == string.Empty)
            {
                divError.Visible = true;
            }
            else
            {
                divError.Visible = false;
            }

            string filename1 = file;
            //Check if the files have something 
            if (fu1.HasFile)
            {
                try
                {
                    filename1 = owner.Id + Path.GetFileName(fu1.FileName);
                    fu1.SaveAs(Server.MapPath("~/Images/Shops/Specials/") + filename1);
                }
                catch (Exception ex)
                {
                    divError.Visible = true;
                    return;
                }
            }
            else
            {
                filename1 = new ShopConnection().getSpecialsById(specialId).Image;
            }


            Qaelo.Models.ShopOwnerModel.Shop special = new Qaelo.Models.ShopOwnerModel.Shop(specialId, owner.Id, txtPrice.Text, txtDescription.Text, filename1, txtName.Text, txtOpenHours.Text, txtShoNo.Text
                , txtText.Text);

            if (new ShopConnection().updateSpecial(special, owner.Id))
            {
                Response.Redirect("manage-facilities.aspx?page=edited-discounts");
            }
            else
            {
                divError.InnerHtml = "<p>An error occured while saving your special please try agian.</p>";
            }
        }
    }
}