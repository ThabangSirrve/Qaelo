using Facebook;
using Qaelo.Models.StudentModel;
using System;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;

namespace Qaelo.Web.Account
{
    public partial class facebook_login : System.Web.UI.Page
    {
        public const string FaceBookAppKey = "140730493223337";
        Data.Accounts.AccountConnection connection = new Data.Accounts.AccountConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request.QueryString["access_token"])) return; //ERROR! No token returned from Facebook!!

            //let's send an http-request to facebook using the token            
            string json = GetFacebookUserJSON(Request.QueryString["access_token"]);


            //and Deserialize the JSON response
            JavaScriptSerializer js = new JavaScriptSerializer();

            FacebookUser oUser = js.Deserialize<FacebookUser>(json);
            if (oUser != null)
            {
                string email = "";
                string gender = "";

                if (oUser.email == null)
                    email = " ";
                else
                    email = oUser.email;

                if (oUser.gender == null)
                    gender = " ";
                else
                    gender = oUser.gender;


                Response.Write("Welcome, " + oUser.name);
                Response.Write("<br />id, " + oUser.id);
                Response.Write("<br />Email : " + email);
                Response.Write("<br />First_name: " + oUser.first_name);
                Response.Write("<br />Last_name: " + oUser.last_name);
                Response.Write("<br />Gender: " + gender);
                Response.Write("<br />Link: " + oUser.link);
                string profilePic = string.Format("https://graph.facebook.com/{0}/picture?type=large&w‌​idth=720&height=720", oUser.id);
                //string profilePic = string.Format("https://graph.facebook.com/{0}/picture", oUser.id);
                //
                Response.Write(string.Format("<br /><img src='{0}'/>", profilePic));

                //check if id exists in db 
                if(connection.validFacebookLogin(oUser.id.ToString()))
                {
                    //get user from database
                    Session["STUDENT"] = connection.loginWithFacebook(email, oUser.id.ToString());
                }
                else
                {
                    //Save user details 
                    Student student = new Student("", "", email, oUser.first_name, "", oUser.last_name, "", oUser.id.ToString(), profilePic, "", DateTime.Now, "Student", "");
                    connection.registerStudent(student);

                    //Add freelancing account 
                    int studentId = connection.getIdByFacebookId(oUser.id.ToString());

                    new Data.StudentData.StudentConnection().postWork(new Models.StudentModel.Freelancer(studentId, "", ";;;", "", ";;;"));
                    Session["STUDENT"] = student;
                }
                Response.Redirect("~/Web/Users/Student/students-profile.aspx");
            }
        }

        private static string GetFacebookUserJSON(string access_token)
        {
            string url = string.Format("https://graph.facebook.com/me?access_token={0}&fields=email,name,first_name,last_name,link,birthday,cover,devices,gender", access_token);

            WebClient wc = new WebClient();
            Stream data = wc.OpenRead(url);
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            data.Close();
            reader.Close();

            return s;
        }
    }
}