using System;
using System.Net.Mail;
using System.Text;
using Security;

namespace Qaelo.Web.Account
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(ddlUser.SelectedItem.Value == "Society" || ddlUser.SelectedItem.Value == "Company")
            {
                txtLastName.Visible = false;
            }
            else
            {
                txtLastName.Visible = true;
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == "" || txtFirstName.Text == "" || txtPassword.Text == "")
            {
                lblErrorMessage.Text = "All Felds are required";
                return;
            }
            if (ddlUser.SelectedItem.Value == "Student")
            {
                if(txtLastName.Text == "")
                {
                    lblErrorMessage.Text = "Last Name is required";
                    return;
                }
                //Check if the user exist
                if (new Data.Accounts.AccountConnection().validStudent(txtEmail.Text) && new Data.Accounts.AccountConnection().validEventPoster(txtEmail.Text) && new Data.Accounts.AccountConnection().validShopOwner(txtEmail.Text) && new Data.Accounts.AccountConnection().validCompany(txtEmail.Text) && new Data.Accounts.AccountConnection().validSociety(txtEmail.Text) && new Data.Accounts.AccountConnection().validPropertyManager(txtEmail.Text) && new Data.Accounts.AccountConnection().validStudent(txtEmail.Text))
                {
                    new Data.Accounts.AccountConnection().registerStudent(new Models.StudentModel.Student("", "", txtEmail.Text, txtFirstName.Text, "", txtLastName.Text, "", Secrecy.HashPassword(txtPassword.Text), "defaultProfilePic.jpg", "", DateTime.Now, "Student",""));

                    //Get student Id
                    int studentId = new Data.Accounts.AccountConnection().getStudentId(txtEmail.Text);

                    //Add freelancing account 
                    new Data.StudentData.StudentConnection().postWork(new Models.StudentModel.Freelancer(studentId,"", ";;;", "",";;;"));
                    //Encrypt
                    string encrypt = new CryptoService().HashText(txtEmail.Text, DateTime.Now.ToShortDateString());

                    //Encode the encrypted string
                    string encoded = Server.UrlEncode(Server.HtmlEncode(encrypt));

                    //Save
                    new Data.Accounts.AccountConnection().studentCreation(txtEmail.Text, encrypt);

                    //Send Email
                    if (sendRegistrationEmailTest(txtEmail.Text, txtFirstName.Text, encoded))
                        Response.Redirect("tempLogin.aspx?page=registration");//Redrect the user
                }
                else
                {
                    lblErrorMessage.Text = "Email Already Exists";
                }

            }
            else if (ddlUser.SelectedItem.Value == "Shop")
            {
                if (txtLastName.Text == "")
                {
                    lblErrorMessage.Text = "Last Name is required";
                    return;
                }
                if (new Data.Accounts.AccountConnection().validStudent(txtEmail.Text) && new Data.Accounts.AccountConnection().validEventPoster(txtEmail.Text) && new Data.Accounts.AccountConnection().validShopOwner(txtEmail.Text) && new Data.Accounts.AccountConnection().validCompany(txtEmail.Text) && new Data.Accounts.AccountConnection().validSociety(txtEmail.Text) && new Data.Accounts.AccountConnection().validPropertyManager(txtEmail.Text) && new Data.Accounts.AccountConnection().validStudent(txtEmail.Text))
                {
                    new Data.Accounts.AccountConnection().registerShopOwner(new Models.ShopOwnerModel.ShopOwner(txtEmail.Text, (txtFirstName.Text + txtLastName.Text), "", Secrecy.HashPassword(txtPassword.Text), DateTime.Now, "ShopOwner", true));

                    //Encrypt
                    string encrypt = new CryptoService().HashText(txtEmail.Text, DateTime.Now.ToShortDateString());

                    //Encode the encrypted string
                    string encoded = Server.UrlEncode(Server.HtmlEncode(encrypt));

                    //Save
                    new Data.Accounts.AccountConnection().ShopOwnerCreation(txtEmail.Text, encrypt);

                    //Send Email
                    if (sendRegistrationEmail(txtEmail.Text, txtPassword.Text, encoded))
                        Response.Redirect("tempLogin.aspx?page=registration");//Redrect the user
                }
                else
                {
                    lblErrorMessage.Text = "Email Already Exists";
                }
            }
            else if (ddlUser.SelectedItem.Value == "Event")
            {
                if (txtLastName.Text == "")
                {
                    lblErrorMessage.Text = "Last Name is required";
                    return;
                }
                if (new Data.Accounts.AccountConnection().validStudent(txtEmail.Text) && new Data.Accounts.AccountConnection().validEventPoster(txtEmail.Text) && new Data.Accounts.AccountConnection().validShopOwner(txtEmail.Text) && new Data.Accounts.AccountConnection().validCompany(txtEmail.Text) && new Data.Accounts.AccountConnection().validSociety(txtEmail.Text) && new Data.Accounts.AccountConnection().validPropertyManager(txtEmail.Text) && new Data.Accounts.AccountConnection().validStudent(txtEmail.Text))
                {
                    new Data.Accounts.AccountConnection().registerEventPoster(new Models.EventPosterModel.EventPoster(txtEmail.Text, (txtFirstName.Text + txtLastName.Text), "", Secrecy.HashPassword(txtPassword.Text), "defaultProfilePic.jpg", DateTime.Now, "EventPoster", true));

                    //Encrypt
                    string encrypt = new CryptoService().HashText(txtEmail.Text, DateTime.Now.ToShortDateString());

                    //Encode the encrypted string
                    string encoded = Server.UrlEncode(Server.HtmlEncode(encrypt));

                    //Save
                    new Data.Accounts.AccountConnection().EventPosterCreation(txtEmail.Text, encrypt);

                    //Send Email
                    if (sendRegistrationEmail(txtEmail.Text, txtPassword.Text, encoded))
                        Response.Redirect("tempLogin.aspx?page=registration");//Redrect the user
                }
                else
                {
                    lblErrorMessage.Text = "Email Already Exists";
                }
            }
            else if (ddlUser.SelectedItem.Value == "Society")
            {
                if (new Data.Accounts.AccountConnection().validStudent(txtEmail.Text) && new Data.Accounts.AccountConnection().validEventPoster(txtEmail.Text) && new Data.Accounts.AccountConnection().validShopOwner(txtEmail.Text) && new Data.Accounts.AccountConnection().validCompany(txtEmail.Text) && new Data.Accounts.AccountConnection().validSociety(txtEmail.Text) && new Data.Accounts.AccountConnection().validPropertyManager(txtEmail.Text) && new Data.Accounts.AccountConnection().validStudent(txtEmail.Text))
                {
                    new Data.Accounts.AccountConnection().registerSociety(new Models.SocietyModel.Society("","", txtEmail.Text, "", "","", txtFirstName.Text, "", Secrecy.HashPassword(txtPassword.Text), "defaultProfilePic.jpg", DateTime.Now,"", "", "", "", true));

                    //Encrypt
                    string encrypt = new CryptoService().HashText(txtEmail.Text, DateTime.Now.ToShortDateString());

                    //Encode the encrypted string
                    string encoded = Server.UrlEncode(Server.HtmlEncode(encrypt));

                    //Save
                    new Data.Accounts.AccountConnection().SocietyCreation(txtEmail.Text, encrypt);

                    //Send Email
                    if (sendRegistrationEmail(txtEmail.Text, txtPassword.Text, encoded))
                        Response.Redirect("tempLogin.aspx?page=registration");//Redrect the user
                }
                else
                {
                    lblErrorMessage.Text = "Email Already Exists";
                }
            }
            else if (ddlUser.SelectedItem.Value == "Company")
            {
                if (new Data.Accounts.AccountConnection().validStudent(txtEmail.Text) && new Data.Accounts.AccountConnection().validEventPoster(txtEmail.Text) && new Data.Accounts.AccountConnection().validShopOwner(txtEmail.Text) && new Data.Accounts.AccountConnection().validCompany(txtEmail.Text) && new Data.Accounts.AccountConnection().validSociety(txtEmail.Text) && new Data.Accounts.AccountConnection().validPropertyManager(txtEmail.Text) && new Data.Accounts.AccountConnection().validStudent(txtEmail.Text))
                {
                    new Data.Accounts.AccountConnection().registerCompany(new Models.CompanyModel.Company("","",txtEmail.Text, "", txtFirstName.Text, "", Secrecy.HashPassword(txtPassword.Text), "defaultProfilePic.jpg", DateTime.Now, "Company", true));

                    //Encrypt
                    string encrypt = new CryptoService().HashText(txtEmail.Text, DateTime.Now.ToShortDateString());

                    //Encode the encrypted string
                    string encoded = Server.UrlEncode(Server.HtmlEncode(encrypt));

                    //Save
                    new Data.Accounts.AccountConnection().CompanyCreation(txtEmail.Text, encrypt);

                    //Send Email
                    if (sendRegistrationEmail(txtEmail.Text,txtPassword.Text, encoded))
                        Response.Redirect("tempLogin.aspx?page=registration");//Redrect the user
                }
                else
                {
                    lblErrorMessage.Text = "Email Already Exists";
                }
            }
            else if (ddlUser.SelectedItem.Value == "Property")
            {
                if (txtLastName.Text == "")
                {
                    lblErrorMessage.Text = "Last Name is required";
                    return;
                }
                if (new Data.Accounts.AccountConnection().validStudent(txtEmail.Text) && new Data.Accounts.AccountConnection().validEventPoster(txtEmail.Text) && new Data.Accounts.AccountConnection().validShopOwner(txtEmail.Text) && new Data.Accounts.AccountConnection().validCompany(txtEmail.Text) && new Data.Accounts.AccountConnection().validSociety(txtEmail.Text) && new Data.Accounts.AccountConnection().validPropertyManager(txtEmail.Text) && new Data.Accounts.AccountConnection().validStudent(txtEmail.Text))
                {
                    new Data.Accounts.AccountConnection().registerPropertyManager(new Models.AccommodationModel.Manager(false,"",txtEmail.Text,"",txtFirstName.Text,txtLastName.Text,"", Secrecy.HashPassword(txtPassword.Text), "defaultProfilePic.jpg", "",DateTime.Now, "PropertyManager",true));

                    //Encrypt
                    string encrypt = new CryptoService().HashText(txtEmail.Text, DateTime.Now.ToShortDateString());

                    //Encode the encrypted string
                    string encoded = Server.UrlEncode(Server.HtmlEncode(encrypt));

                    //Save
                    new Data.Accounts.AccountConnection().PropertyManagerCreation(txtEmail.Text, encrypt);

                    //Send Email
                    if (sendRegistrationEmail(txtEmail.Text, txtPassword.Text, encoded))
                        Response.Redirect("tempLogin.aspx?page=registration");//Redrect the user
                }
                else
                {
                    lblErrorMessage.Text = "Email Already Exists";
                }
            }
            else
            {
                if (ddlUser.SelectedItem.Value == "NONE")
                {
                    lblErrorMessage.Text = "Please select Account type";
                    return;
                }
            }
        }

        public static bool sendRegistrationEmail(string email,string password,string encrypt)
        {
            bool success = false;

            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress("accounts@qaelo.com");
                message.To.Add(new MailAddress(email));
                message.Subject = "Account Confirmation";
                
                message.BodyEncoding = System.Text.Encoding.UTF8;
                message.SubjectEncoding = System.Text.Encoding.Default;
                message.IsBodyHtml = true;

                //Qaelo.com
                string j = "https://qaelo.com/Web/Account/Confirm.aspx?email=" + email + "&token=" + encrypt;

                //HTML
                var body = new StringBuilder();
                body.AppendLine(string.Format(@"Your account has succesfully created <br/>
                                   <br/>Please click  the link below to confirm your account. <br/>", email,"******") );
                body.AppendLine("<a href='" + j + "''>"+ j + "</a>");
                //END HTML
                
                message.Body = body.ToString();

                SmtpClient smtp = new SmtpClient("webmail.qaelo.com");

                smtp.Credentials = new System.Net.NetworkCredential("accounts@qaelo.com", "Account5000qaelo");

                smtp.Port = 25;

                smtp.EnableSsl = false;

                smtp.Send(message);

                success = true;

            }
            catch(Exception ex)
            {
                success = false;
            }

            return success;
        }

        public static bool sendRegistrationEmailTest(string email, string name, string encrypt)
        {
            bool success = false;

            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress("accounts@qaelo.com");
                message.To.Add(new MailAddress(email));
                message.Subject = "Account Confirmation";

                message.BodyEncoding = System.Text.Encoding.UTF8;
                message.SubjectEncoding = System.Text.Encoding.Default;
                message.IsBodyHtml = true;

                //Qaelo.com
                string j = "https://qaelo.com/Web/Account/Confirm.aspx?email=" + email + "&token=" + encrypt;

                //HTML
                var body = new StringBuilder();
                //body.AppendLine(string.Format(@"Your account has succesfully created <br/>
                //                  <br/>Please click  the link below to confirm your account. <br/>", email, "******"));
                //body.AppendLine("<a href='" + j + "''>" + j + "</a>");

                #region text

                body.AppendLine(string.Format(@"
                    <body
                    style='overflow: auto; padding:0; margin:0; font-size: 12px; font-family: arial, helvetica, sans-serif; cursor:auto; background-color:#444545'>
                    <table cellspacing='0' cellpadding='0' width='100%'
                    bgcolor='#444545'>
                    <tr>
                    <td style='FONT-SIZE: 0px; HEIGHT: 20px; LINE-HEIGHT: 0'></td>
                    </tr>
                    <tr>
                    <td valign='top'>
                    <table class='rtable' style='WIDTH: 600px; MARGIN: 0px auto'
                    cellspacing='0' cellpadding='0' width='600' align='center'
                    border='0'>
                    <tr>
                    <td class='contenttd'
                    style='BORDER-TOP: medium none; BORDER-RIGHT: medium none; BORDER-BOTTOM: medium none; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: medium none; PADDING-RIGHT: 0px; BACKGROUND-COLOR: transparent'>
                    <table style='WIDTH: 100%' cellspacing='0' cellpadding='0'
                    align='left'>
                    <tr class='hiddentds'>
                    <td
                    style='FONT-SIZE: 0px; HEIGHT: 0px; WIDTH: 367px; LINE-HEIGHT: 0; mso-line-height-rule: exactly'>
                    </td>
                    <td
                    style='FONT-SIZE: 0px; HEIGHT: 0px; WIDTH: 233px; LINE-HEIGHT: 0; mso-line-height-rule: exactly'>
                    </td>
                    </tr>
                    <tr style='HEIGHT: 10px'>
                    <th class='contenttd'
                    style='BORDER-TOP: medium none; BORDER-RIGHT: medium none; VERTICAL-ALIGN: middle; BORDER-BOTTOM: medium none; FONT-WEIGHT: normal; PADDING-BOTTOM: 20px; TEXT-ALIGN: left; PADDING-TOP: 20px; PADDING-LEFT: 0px; BORDER-LEFT: medium none; PADDING-RIGHT: 15px; BACKGROUND-COLOR: transparent'>
                    </th>
                    <th class='contenttd'
                    style='BORDER-TOP: medium none; BORDER-RIGHT: medium none; VERTICAL-ALIGN: middle; BORDER-BOTTOM: medium none; FONT-WEIGHT: normal; PADDING-BOTTOM: 20px; TEXT-ALIGN: left; PADDING-TOP: 20px; PADDING-LEFT: 15px; BORDER-LEFT: medium none; PADDING-RIGHT: 0px; BACKGROUND-COLOR: transparent'>
                    </th>
                    </tr>
                    </table>
                    </td>
                    </tr>
                    <tr>
                    <td class='contenttd'
                    style='BORDER-TOP: #f6b21d 5px solid; BORDER-RIGHT: medium none; BORDER-BOTTOM: medium none; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: medium none; PADDING-RIGHT: 0px; BACKGROUND-COLOR: #feffff'>
                    <table style='WIDTH: 100%' cellspacing='0' cellpadding='0'
                    align='left'>
                    <tr class='hiddentds'>
                    <td
                    style='FONT-SIZE: 0px; HEIGHT: 0px; WIDTH: 600px; LINE-HEIGHT: 0; mso-line-height-rule: exactly'>
                    </td>
                    </tr>
                    <tr style='HEIGHT: 10px'>
                    <th class='contenttd'
                    style='BORDER-TOP: medium none; BORDER-RIGHT: medium none; VERTICAL-ALIGN: top; BORDER-BOTTOM: medium none; FONT-WEIGHT: normal; PADDING-BOTTOM: 0px; TEXT-ALIGN: left; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: medium none; PADDING-RIGHT: 0px; BACKGROUND-COLOR: transparent'>
                    <!--[if gte mso 12]>
                        <table cellspacing='0' cellpadding='0' border='0' width='100%'><tr><td align='center'>
                    <![endif]-->
                    <table class='imgtable' style='MARGIN: 0px auto' cellspacing='0'
                    cellpadding='0' align='center' border='0'>
                    <tr>
                    <td
                    style='PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; PADDING-RIGHT: 0px'
                     align='center'>
                    <table cellspacing='0' cellpadding='0' border='0'>
                    <tr>
                    <td
                    style='BORDER-TOP: medium none; BORDER-RIGHT: medium none; BORDER-BOTTOM: medium none; BORDER-LEFT: medium none; BACKGROUND-COLOR: transparent'>
                    <img
                    style='BORDER-TOP: medium none; BORDER-RIGHT: medium none; BORDER-BOTTOM: medium none; BORDER-LEFT: medium none; DISPLAY: block'
                     alt='' src='https://qaelo.com/Email/Image_1.png'
                    width='600' height='380' hspace='0' vspace='0' /></td>
                    </tr>
                    </table>
                    </td>
                    </tr>
                    </table>
                    <!--[if gte mso 12]>
                        </td></tr></table>
                    <![endif]--></th>
                    </tr>
                    </table>
                    </td>
                    </tr>
                    <tr>
                    <td class='contenttd'
                    style='BORDER-TOP: #f6b21d 5px solid; BORDER-RIGHT: medium none; BORDER-BOTTOM: medium none; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: medium none; PADDING-RIGHT: 0px; BACKGROUND-COLOR: #feffff'>
                    <table style='WIDTH: 100%' cellspacing='0' cellpadding='0'
                    align='left'>
                    <tr class='hiddentds'>
                    <td
                    style='FONT-SIZE: 0px; HEIGHT: 0px; WIDTH: 600px; LINE-HEIGHT: 0; mso-line-height-rule: exactly'>
                    </td>
                    </tr>
                    <tr style='HEIGHT: 20px'>
                    <th class='contenttd'
                    style='BORDER-TOP: medium none; BORDER-RIGHT: medium none; VERTICAL-ALIGN: middle; BORDER-BOTTOM: medium none; FONT-WEIGHT: normal; PADDING-BOTTOM: 20px; TEXT-ALIGN: left; PADDING-TOP: 20px; PADDING-LEFT: 20px; BORDER-LEFT: medium none; PADDING-RIGHT: 20px; BACKGROUND-COLOR: #f5b21d'>
                    <p
                    style='FONT-SIZE: 22px; MARGIN-BOTTOM: 1em; FONT-FAMILY: arial, helvetica, sans-serif; MARGIN-TOP: 0px; COLOR: #fffeff; LINE-HEIGHT: 33px; BACKGROUND-COLOR: transparent; mso-line-height-rule: exactly'
                     align='center'>Hi {1} welcome to Qaelo, thanks for having an&nbsp;account
                    with us please click the following&nbsp;button below to confirm
                    your account and enjoy qaelo services.</p>
                    <!--[if gte mso 12]>
                        <table cellspacing='0' cellpadding='0' border='0' width='100%'><tr><td align='center'>
                    <![endif]-->
                    <table class='imgtable btnset'
                    style='TEXT-ALIGN: center; MARGIN: 0px auto' cellspacing='0'
                    cellpadding='0' border='0'>
                    <tr>
                    <td class='contenttd'
                    style='VERTICAL-ALIGN: middle; PADDING-BOTTOM: 0px; PADDING-TOP: 0px; PADDING-LEFT: 0px; PADDING-RIGHT: 0px'>
                    <a href='{0}'><img title='' border='none'
                    alt='Verify Account'
                    src='https://qaelo.com/Email/Image_2.png' /></a> </td>
                    </tr>
                    </table>
                    <!--[if gte mso 12]>
                        </td></tr></table>
                    <![endif]--></th>
                    </tr>
                    </table>
                    </td>
                    </tr>
                    <tr>
                    <td class='contenttd'
                    style='BORDER-TOP: medium none; BORDER-RIGHT: medium none; BORDER-BOTTOM: medium none; PADDING-BOTTOM: 10px; PADDING-TOP: 10px; PADDING-LEFT: 0px; BORDER-LEFT: medium none; PADDING-RIGHT: 0px; BACKGROUND-COLOR: transparent'>
                    <table style='WIDTH: 100%' cellspacing='0' cellpadding='0'
                    align='left'>
                    <tr class='hiddentds'>
                    <td
                    style='FONT-SIZE: 0px; HEIGHT: 0px; WIDTH: 600px; LINE-HEIGHT: 0; mso-line-height-rule: exactly'>
                    </td>
                    </tr>
                    <tr style='HEIGHT: 10px'>
                    <th class='contenttd'
                    style='BORDER-TOP: medium none; BORDER-RIGHT: medium none; VERTICAL-ALIGN: top; BORDER-BOTTOM: medium none; FONT-WEIGHT: normal; PADDING-BOTTOM: 0px; TEXT-ALIGN: left; PADDING-TOP: 0px; PADDING-LEFT: 0px; BORDER-LEFT: medium none; PADDING-RIGHT: 0px; BACKGROUND-COLOR: transparent'>
                    <div
                    style='PADDING-BOTTOM: 10px; TEXT-ALIGN: center; PADDING-TOP: 10px; PADDING-LEFT: 10px; PADDING-RIGHT: 10px'>
                    <table class='imgtable' style='DISPLAY: inline-block'
                    cellspacing='0' cellpadding='0' border='0'>
                    <tr>
                    <td style='PADDING-RIGHT: 5px'><a href='https://www.facebook.com/'
                    target='_blank'><img title='Facebook'
                    style='BORDER-TOP: medium none; BORDER-RIGHT: medium none; BORDER-BOTTOM: medium none; BORDER-LEFT: medium none; DISPLAY: block'
                     alt='Facebook'
                    src='https://qaelo.com/Email/Image_3.png' width='48'
                    height='48' /></a> </td>
                    <td style='PADDING-RIGHT: 5px'><a href='https://twitter.com/'
                    target='_blank'><img title='Twitter'
                    style='BORDER-TOP: medium none; BORDER-RIGHT: medium none; BORDER-BOTTOM: medium none; BORDER-LEFT: medium none; DISPLAY: block'
                     alt='Twitter'
                    src='https://qaelo.com/Email/Image_4.png' width='48'
                    height='48' /></a> </td>
                    <td><a href='https://www.instagram.com/' target='_blank'><img
                    title='Share content'
                    style='BORDER-TOP: medium none; BORDER-RIGHT: medium none; BORDER-BOTTOM: medium none; BORDER-LEFT: medium none; DISPLAY: block'
                     alt='Share content'
                    src='https://qaelo.com/Email/Image_5.png' width='48'
                    height='48' /></a> </td>
                    </tr>
                    </table>
                    </div>
                    </th>
                    </tr>
                    </table>
                    </td>
                    </tr>
                    <tr>
                    <td class='contenttd'
                    style='BORDER-TOP: medium none; BORDER-RIGHT: medium none; BORDER-BOTTOM: medium none; PADDING-BOTTOM: 1px; PADDING-TOP: 1px; PADDING-LEFT: 0px; BORDER-LEFT: medium none; PADDING-RIGHT: 0px; BACKGROUND-COLOR: transparent'>
                    <table style='WIDTH: 100%' cellspacing='0' cellpadding='0'
                    align='left'>
                    <tr class='hiddentds'>
                    <td
                    style='FONT-SIZE: 0px; HEIGHT: 0px; WIDTH: 600px; LINE-HEIGHT: 0; mso-line-height-rule: exactly'>
                    </td>
                    </tr>
                    <tr style='HEIGHT: 10px'>
                    <th class='contenttd'
                    style='BORDER-TOP: medium none; BORDER-RIGHT: medium none; VERTICAL-ALIGN: top; BORDER-BOTTOM: medium none; FONT-WEIGHT: normal; PADDING-BOTTOM: 1px; TEXT-ALIGN: left; PADDING-TOP: 1px; PADDING-LEFT: 15px; BORDER-LEFT: medium none; PADDING-RIGHT: 15px; BACKGROUND-COLOR: transparent'>
                    <p
                    style='FONT-SIZE: 10px; MARGIN-BOTTOM: 1em; FONT-FAMILY: arial, helvetica, sans-serif; MARGIN-TOP: 0px; COLOR: #7c7c7c; LINE-HEIGHT: 12px; BACKGROUND-COLOR: transparent; mso-line-height-rule: exactly'
                     align='center'>Qaelo Pty(Ltd) - 36 Hampton Avenue Johannesburg,
                    2092 South Africa<br />
                    <a style='COLOR: #dfe0e0'
                    href='https://qaelo.com/default.aspx'>www.qaelo.com</a> - <a
                    style='COLOR: #dfe0e0'
                    href='mailto:info@qaelo.com'>info@qaelo.com</a></p>
                    <p
                    style='FONT-SIZE: 10px; MARGIN-BOTTOM: 1em; FONT-FAMILY: arial, helvetica, sans-serif; MARGIN-TOP: 0px; COLOR: #7c7c7c; LINE-HEIGHT: 12px; BACKGROUND-COLOR: transparent; mso-line-height-rule: exactly'
                     align='center'>If you no longer wish to receive these emails,
                    simply click on the following link <a style='COLOR: #dfe0e0'
                    href='https://qaelo.com/unsubscribe.aspx'>Unsubscribe</a>.</p>
                    <p
                    style='FONT-SIZE: 10px; MARGIN-BOTTOM: 1em; FONT-FAMILY: arial, helvetica, sans-serif; MARGIN-TOP: 0px; COLOR: #7c7c7c; LINE-HEIGHT: 12px; BACKGROUND-COLOR: transparent; mso-line-height-rule: exactly'
                     align='center'>&copy;2017 Qaelo Pty (Ltd). All rights
                    reserved.</p>
                    </th>
                    </tr>
                    </table>
                    </td>
                    </tr>
                    </table>
                    </td>
                    </tr>
                    <tr>
                    <td style='FONT-SIZE: 0px; HEIGHT: 8px; LINE-HEIGHT: 0'>&nbsp;</td>
                    </tr>
                    </table>
                    ", j, name));
                //END HTML
                #endregion

                message.Body = body.ToString();

                SmtpClient smtp = new SmtpClient("webmail.qaelo.com");

                smtp.Credentials = new System.Net.NetworkCredential("accounts@qaelo.com", "Account5000qaelo");

                smtp.Port = 25;

                smtp.EnableSsl = false;

                smtp.Send(message);

                success = true;

            }
            catch (Exception ex)
            {
                success = false;
            }

            return success;
        }

    }
}
 