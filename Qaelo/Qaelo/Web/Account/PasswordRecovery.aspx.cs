using Qaelo.Data.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Account
{
    public partial class PasswordRecovery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["token"] != null)
            {
                if(Request.QueryString["email"] != null)
                {
                    string email = Request.QueryString["email"];
                    string decrypted = Server.HtmlDecode(Request.QueryString["token"].ToString());

                    if(txtConfirmNewPassword.Text.Length < 2)
                    {
                        lblSuccess.Text = "";
                        lblErrorMessage.Text = "Password is too short";
                    }

                    if (txtConfirmNewPassword.Text == txtNewPassword.Text)
                    {
                        AccountConnection connection = new AccountConnection();

                        //Confirm that they have actually sent a link
                        if (connection.correctPasswordReset(email, decrypted))
                        {
                            //Change the password
                            string userType = connection.GetUserType(email);

                            if (userType == "COMPANY")
                            {
                                if (connection.resetPasswordCompany(email, Secrecy.HashPassword(txtConfirmNewPassword.Text)))
                                {
                                    lblErrorMessage.Text = "";
                                    lblSuccess.Text = "New password recorded successfully";
                                    connection.deletePasswordResetLink(email);
                                    Response.Redirect("tempLogin.aspx?page=passwordReset");//Redrect the user
                                }
                               else
                                {
                                    lblErrorMessage.Text = "Password Could not be recorded";
                                    lblSuccess.Text = "";
                                }
                            }
                            else if (userType == "SHOP")
                            {
                                if (connection.resetPasswordShopOwner(email, Secrecy.HashPassword(txtConfirmNewPassword.Text)))
                                {
                                    lblErrorMessage.Text = "";
                                    lblSuccess.Text = "New password recorded successfully";
                                    connection.deletePasswordResetLink(email);
                                    Response.Redirect("tempLogin.aspx?page=passwordReset");//Redrect the user
                                }
                                else
                                {
                                    lblErrorMessage.Text = "Password Could not be recorded";
                                    lblSuccess.Text = "";
                                }
                            }

                            else if (userType == "SOCIETY")
                            {
                                if (connection.resetPasswordSociety(email, Secrecy.HashPassword(txtConfirmNewPassword.Text)))
                                {
                                    lblErrorMessage.Text = "";
                                    lblSuccess.Text = "New password recorded successfully";
                                    connection.deletePasswordResetLink(email);
                                    Response.Redirect("tempLogin.aspx?page=passwordReset");//Redrect the user
                                }
                                else
                                {
                                    lblErrorMessage.Text = "Password Could not be recorded";
                                    lblSuccess.Text = "";
                                }
                            }
                            else if (userType == "STUDENT")
                            {
                                if (connection.resetPasswordStudent(email, Secrecy.HashPassword(txtConfirmNewPassword.Text)))
                                {
                                    lblErrorMessage.Text = "";
                                    lblSuccess.Text = "New password recorded successfully";
                                    connection.deletePasswordResetLink(email);
                                    Response.Redirect("tempLogin.aspx?page=passwordReset");//Redrect the user
                                }
                                else
                                {
                                    lblErrorMessage.Text = "Password Could not be recorded";
                                    lblSuccess.Text = "";
                                }
                            }

                            else if (userType == "PROPERTY")
                            {
                                if (connection.resetPasswordManagers(email, Secrecy.HashPassword(txtConfirmNewPassword.Text)))
                                {
                                    lblErrorMessage.Text = "";
                                    lblSuccess.Text = "New password recorded successfully";
                                    connection.deletePasswordResetLink(email);
                                    Response.Redirect("tempLogin.aspx?page=passwordReset");//Redrect the user
                                }
                                else
                                {
                                    lblErrorMessage.Text = "Password Could not be recorded";
                                    lblSuccess.Text = "";
                                }
                            }

                            else if (userType == "EVENTPOSTER")
                            {
                                if (connection.resetPasswordEventPoster(email, Secrecy.HashPassword(txtConfirmNewPassword.Text)))
                                {
                                    lblErrorMessage.Text = "";
                                    lblSuccess.Text = "New password recorded successfully";
                                    connection.deletePasswordResetLink(email);
                                    Response.Redirect("tempLogin.aspx?page=passwordReset");//Redrect the user
                                }
                                else
                                {
                                    lblErrorMessage.Text = "Password Could not be recorded";
                                    lblSuccess.Text = "";
                                }
                            }
                            else
                            {
                                lblErrorMessage.Text = "User Type does not exist";
                                lblSuccess.Text = "";
                            }
                        }
                        else
                        {
                            lblErrorMessage.Text = "Password reset link already used, please reset your pass word again";
                            lblSuccess.Text = "";
                        }
                    }
                    else
                    {
                        lblErrorMessage.Text = "Passwords don't match";
                        lblSuccess.Text = "";
                    }
                }
                else
                {
                    lblErrorMessage.Text = "Please use the password reset link sent to your email";
                    lblSuccess.Text = "";
                }
                        
            }
            else
            {
                lblErrorMessage.Text = "Invalid Password Reset Link";
                lblSuccess.Text = "";
            }
        }
    }
}