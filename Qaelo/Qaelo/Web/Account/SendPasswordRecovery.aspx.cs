using Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Account
{
    public partial class SendPasswordRecovery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static bool sendRegistrationEmail(string email, string encrypt)
        {
            bool success = false;

            try
            {
                MailMessage message = new MailMessage();

                message.From = new MailAddress("Accounts@qaelo.com");

                message.To.Add(new MailAddress(email));

                message.Subject = "Account Confirmation";
                message.IsBodyHtml = true;

                //Azure
                string j = "https://qaelo.com/Web/Account/PasswordRecovery.aspx?email=" + email + "&token=" + encrypt;
                
                //LocalHost 
                //string j = "http://localhost:53020/Web/Account/PasswordRecovery.aspx?email=" + email + "&token=" + encrypt;
                
                //HTML
                var body = new StringBuilder();
                body.AppendLine(string.Format(@"Please click the password reset link to create a new password <br/>"));
                body.AppendLine("<a href='" + j + "''>" + j + "</a>");
                //END HTML

                message.Body = body.ToString();

                SmtpClient smtp = new SmtpClient("webmail.qaelo.com");

                smtp.Credentials = new System.Net.NetworkCredential("accounts@qaelo.com", "Account5000qaelo");

                smtp.Port = 25;

                smtp.EnableSsl = false;

                smtp.Send(message);

                success = true;

            }
            catch
            {
                success = false;
            }

            return success;
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            Data.Accounts.AccountConnection connection = new Data.Accounts.AccountConnection();
            //Check if user Exist
            if (!connection.isValidUser(txtEmail.Text))
            {
                //User doesnot exist 
                lblErrorMessage.Text = "Email does not exist";
                lblSuccess.Text = "";
                return;
            }
            //Encrypt
            string encrypt = new CryptoService().HashText(txtEmail.Text, DateTime.Now.ToShortDateString());

            //Encode the encrypted string
            string encoded = Server.UrlEncode(Server.HtmlEncode(encrypt));

            //Check whether its an unconfirmed account
            bool isUserUnconfirmed = connection.unconfirmedAccount(txtEmail.Text);
            isUserUnconfirmed = connection.unconfirmedAccountCompany(txtEmail.Text);
            isUserUnconfirmed = connection.unconfirmedAccountEventPoster(txtEmail.Text);
            isUserUnconfirmed = connection.unconfirmedAccountPropertyManager(txtEmail.Text);
            isUserUnconfirmed = connection.unconfirmedAccountShopOwner(txtEmail.Text);
            isUserUnconfirmed = connection.unconfirmedAccountSociety(txtEmail.Text);

            if (isUserUnconfirmed)
            {
                //Cannot reset your Password , you must confirm your account first
                lblErrorMessage.Text = "Sorry user Does not exist, Please confirm your account";
                lblSuccess.Text = "";
                return;
            }

            if(connection.sendForgotPasswordLink(txtEmail.Text, encrypt))
            {
                sendRegistrationEmail(txtEmail.Text, encoded);
                lblSuccess.Text = "Successfully Sent password recovery options to " + txtEmail.Text;
                lblErrorMessage.Text = "";
            }
            else
            {
                lblErrorMessage.Text = "Could not send email, Please try again later";
                lblSuccess.Text = "";
            }

        }
    }
}