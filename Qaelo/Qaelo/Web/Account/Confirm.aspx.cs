using Qaelo.Data.Accounts;
using System;

namespace Qaelo.Web.Account
{
    public partial class Confirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(Request.QueryString["token"] != null)
            {
                string email = Request.QueryString["email"];
                string decrypted = Server.HtmlDecode(Request.QueryString["token"].ToString());

                if(new AccountConnection().alreadyVerified(email))
                {
                    lblConfirmMessage.Text = @"<img src='../../Images/Users/Verified.png' style='margin-left:-30px' height='150' width='150'/><br/>
                                                Account Already Confirmed, Please proceed to login.
                                                <br/><br/><a href='tempLogin.aspx' style='margin-left:-20px' class='btn btn-success'>Login</a>";
                }
                else
                {
                    if (new AccountConnection().isverified(email,decrypted))
                    {
                        //Set Email confirmation status to 
                        lblConfirmMessage.Text = @"<img src='../../Images/Users/Verified.png' style='margin-left:-30px' height='150' width='150'/><br/>
                                                    Congrats, your account has been confirmed.
                                                   <br/><br/><a href='tempLogin.aspx' style='margin-left:-20px' class='btn btn-success'>Login</a>";
                    }
                    else
                        lblConfirmMessage.Text = @"<img src='../../Images/Users/error.png' style='margin-left:-30px' height='150' width='150'/><br/>
                                                    Unfortunately, we can't confirm your email, please ensure that you are not confirming for the second time or the session might have expired";
                }
            }
        }
    }
}