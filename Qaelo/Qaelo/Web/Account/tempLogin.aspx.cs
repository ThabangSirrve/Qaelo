using Facebook;
using Qaelo.Data.Accounts;
using Qaelo.Models.StudentModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Account
{
    public partial class tempLogin : System.Web.UI.Page
    {

        public const string FaceBookAppKey = "140730493223337";
        //public const string FaceBookAppKey = "cc62f66d3987a4704c82563b210c58e5";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["logout"] != null)
            {
                //Logout everyone
                Session["STUDENT"] = null;
                Session["PROPERTYMANAGER"] = null;
                Session["COMPANY"] = null;
                Session["SOCIETY"] = null;
                Session["EVENTPOSTER"] = null;
                Session["SHOPOWNER"] = null;
                Session["ADMIN"] = null;
            }
            //Check if page is from registration 
            if (Request.QueryString["page"] != null)
            {
                if (Request.QueryString["page"].ToString() == "registration")
                {
                    lblSuccess.Text = @"An Email has been sent, Please confirm your email to continue";
                    //lblSuccess.Text = @"Thank you for registering an account with us, please enter your credentials to login";
                    lblErrorMessage.Text = "";
                }
                else if (Request.QueryString["page"].ToString() == "passwordReset")
                {
                    lblSuccess.Text = "Your Password was successfully recovered Please login below";
                    lblErrorMessage.Text = "";
                }
            }

            //facebook login
            if (string.IsNullOrEmpty(Request.QueryString["access_token"])) return; //ERROR! No token returned from Facebook!!

            //let's send an http-request to facebook using the token            
            string json = GetFacebookUserJSON(Request.QueryString["access_token"]);

            //and Deserialize the JSON response
            System.Web.Script.Serialization.JavaScriptSerializer js = new JavaScriptSerializer();
            FacebookUser oUser = js.Deserialize<FacebookUser>(json);
            if (oUser != null)
            {
                Response.Write("Welcome, " + oUser.name);
                Response.Write("<br />id, " + oUser.id);
                Response.Write("<br />email, " + oUser.email);
                Response.Write("<br />first_name, " + oUser.first_name);
                Response.Write("<br />last_name, " + oUser.last_name);
                Response.Write("<br />gender, " + oUser.gender);
                Response.Write("<br />link, " + oUser.link);
                Response.Write("<br />updated_time, " + oUser.updated_time);
                Response.Write("<br />birthday, " + oUser.birthday);
                Response.Write("<br />locale, " + oUser.locale);

                Response.Write("<br />picture, " + oUser.picture);
                if (oUser.location != null)
                {
                    Response.Write("<br />locationid, " + oUser.location.id);
                    Response.Write("<br />location_name, " + oUser.location.name);
                }
            }
        }
        private static string GetFacebookUserJSON(string access_token)
        {
            string url = string.Format("https://graph.facebook.com/me?access_token={0}&fields=email,name,first_name,last_name,link", access_token);

            WebClient wc = new WebClient();
            System.IO.Stream data = wc.OpenRead(url);
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            data.Close();
            reader.Close();

            return s;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //if (txtEmail.Text != "tslekwadi@gmail.com")
            //{
            //    lblErrorMessage.Text = "";
            //    lblSuccess.Text = "Website under maintenance mode";
            //    return;
            //}

            AccountConnection connection = new AccountConnection();

            //Check if the user exists in the unconifirmed accounts
            if (connection.unconfirmedAccount(txtEmail.Text))
            {
                lblErrorMessage.Text = "Please check your Inbox folder for confirmation email";
                lblSuccess.Text = "";
            }
            else
            {
                Student s = connection.loginStudent(txtEmail.Text, Secrecy.HashPassword(txtPassword.Text));

                if (s != null)
                {
                    Session["STUDENT"] = s;

                    if (Request.QueryString["page"] != null && Request.QueryString["page"].ToString().Contains("Student"))
                        Response.Redirect("~/Web/" + Request.QueryString["page"].ToString());

                    Response.Redirect("~/Web/Users/Student/students-profile.aspx");
                }
                else if (connection.correctShopOwner(txtEmail.Text, Secrecy.HashPassword(txtPassword.Text)))
                {
                    Session["SHOPOWNER"] = connection.loginShopOwner(txtEmail.Text, Secrecy.HashPassword(txtPassword.Text));

                    if (Request.QueryString["page"] != null && Request.QueryString["page"].ToString().Contains("Shop"))
                        Response.Redirect("~/Web/" + Request.QueryString["page"].ToString());

                    Response.Redirect("~/Web/Users/Shop/Home.aspx");
                }
                else if (connection.correctEventPoster(txtEmail.Text, Secrecy.HashPassword(txtPassword.Text)))
                {
                    Session["EVENTPOSTER"] = connection.loginEventPoster(txtEmail.Text, Secrecy.HashPassword(txtPassword.Text));

                    if (Request.QueryString["page"] != null && Request.QueryString["page"].ToString().Contains("EventPoster"))
                        Response.Redirect("~/Web/" + Request.QueryString["page"].ToString());

                    Response.Redirect("~/Web/Users/EventPoster/Home.aspx");
                }
                else if (connection.correctSociety(txtEmail.Text, Secrecy.HashPassword(txtPassword.Text)))
                {
                    Session["SOCIETY"] = connection.loginSociety(txtEmail.Text, Secrecy.HashPassword(txtPassword.Text));

                    if (Request.QueryString["page"] != null && Request.QueryString["page"].ToString().Contains("Society"))
                        Response.Redirect("~/Web/" + Request.QueryString["page"].ToString());

                    Response.Redirect("~/Web/Users/Society/Home.aspx");
                }
                else if (connection.correctCompany(txtEmail.Text, Secrecy.HashPassword(txtPassword.Text)))
                {
                    Session["COMPANY"] = connection.loginCompany(txtEmail.Text, Secrecy.HashPassword(txtPassword.Text));

                    if (Request.QueryString["page"] != null && Request.QueryString["page"].ToString().Contains("Company"))
                        Response.Redirect("~/Web/" + Request.QueryString["page"].ToString());

                    Response.Redirect("~/Web/Users/Company/Home.aspx");
                }
                else if (connection.correctPropertyManager(txtEmail.Text, Secrecy.HashPassword(txtPassword.Text)))
                {
                    Session["PROPERTYMANAGER"] = connection.loginPropertyManager(txtEmail.Text, Secrecy.HashPassword(txtPassword.Text));

                    if (Request.QueryString["page"] != null && Request.QueryString["page"].ToString().Contains("Accommodation"))
                        Response.Redirect("~/Web/" + Request.QueryString["page"].ToString());

                    Response.Redirect("~/Web/Users/Accommodation/landlord-my-rooms.aspx");
                }
                else if (txtPassword.Text == "2g@63po" && txtEmail.Text == "njabulo63@gmail.com")
                {
                        //connection.adminAccess(txtEmail.Text, Secrecy.HashPassword(txtPassword.Text))
                        Session["ADMIN"] = "njabulo63@gmail.com";
                        Response.Redirect("~/Web/Users/Admin/ListOfUsers.aspx");
                }
                else
                {
                    lblErrorMessage.Text = "Email or Password is incorrect";
                    lblSuccess.Text = "";
                }
            }
        }
    }
}