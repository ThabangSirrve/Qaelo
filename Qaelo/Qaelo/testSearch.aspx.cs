using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo
{
    public partial class search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Read file
            //try
            //{   // Open the text file using a stream reader.
            //    string line;

            //    // Read the file and display it line by line.
            //    System.IO.StreamReader file = new System.IO.StreamReader("c:\\Users\\Thomas-PC\\desktop\\universities.txt");
            //    while ((line = file.ReadLine()) != null)
            //    {
            //        lblUniversitites.Text += "'" + line.Replace("'", "’") + "', " + "<br/>";

            //    }
            //    file.Close();
            //}
            //catch (Exception ex)
            //{
            //    lblUniversitites.Text = "Error occured " + ex.Message + "<br/> current directory is  ";
            //}

           // Read file
            try
            {   // Open the text file using a stream reader.
                string line;

                // Read the file and display it line by line.
                System.IO.StreamReader file = new System.IO.StreamReader("c:\\Users\\Thomas-PC\\desktop\\freelancers.txt");
                //System.IO.StreamReader file = new System.IO.StreamReader(Server.MapPath("~/freelancers.txt"));
                
                while ((line = file.ReadLine()) != null)
                {
                    lblUniversitites.Text += "'" + line + "', " + "<br/>";
                    ddlFreelacers.Items.Add(new ListItem(line, line));

                }
                file.Close();
            }
            catch (Exception ex)
            {
                lblUniversitites.Text = "Error occured " + ex.Message + "<br/> current directory is  ";
            }
        }
    }
}