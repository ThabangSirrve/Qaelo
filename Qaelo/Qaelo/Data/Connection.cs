using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Qaelo.Data
{
    public class Connection
    {
        private string conString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        protected string query;

        protected string getConnectionString() { return conString; }
    }
}