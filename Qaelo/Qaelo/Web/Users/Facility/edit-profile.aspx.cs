using Qaelo.Data.Accounts;
using Qaelo.Data.ShopData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Facility
{
    public partial class edit_profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SHOPOWNER"] == null)
            {
                Response.Redirect("~/Web/Account/tempLogin.aspx");
            }

            if (!IsPostBack)
            {
                ShopConnection connection = new ShopConnection();
                Qaelo.Models.ShopOwnerModel.ShopOwner owner = (Qaelo.Models.ShopOwnerModel.ShopOwner)Session["SHOPOWNER"];

                //Load the shops 
                txtEmail.Text = owner.Email;
                txtFullname.Text = owner.FullName;
                txtNumber.Text = owner.Number;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Qaelo.Models.ShopOwnerModel.ShopOwner owner = (Qaelo.Models.ShopOwnerModel.ShopOwner)Session["SHOPOWNER"];
            owner.FullName = txtFullname.Text;
            owner.Number = txtNumber.Text;

            new ShopConnection().updateShopOwner(owner);

            Session["SHOPOWNER"] = owner;
            Response.Redirect("~/Web/Users/Facility/Home.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == txtNewPassword.Text && !(txtConfirmPassword.Text == "" && "" == txtNewPassword.Text))
            {
                AccountConnection account = new AccountConnection();
                Qaelo.Models.ShopOwnerModel.ShopOwner s = (Qaelo.Models.ShopOwnerModel.ShopOwner)Session["SHOPOWNER"];

                //Test password 

                if (account.correctShopOwner(s.Email, Secrecy.HashPassword(txtCurrentPassword.Text)) && new ShopConnection().updatePassword(s.Id, Secrecy.HashPassword(txtNewPassword.Text), Secrecy.HashPassword(txtCurrentPassword.Text)))
                {
                    lblSuccess.Text = "Successfuly Updated Password";
                    lblErrorMessage.Text = "";
                }
                else
                {
                    lblErrorMessage.Text = "Incorrect Current Password";
                    lblSuccess.Text = "";
                }
            }
            else
            {
                lblErrorMessage.Text = "New password and confirm Password Do not match ";
                lblSuccess.Text = "";
            }
        }
    }
}