using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qaelo.Models.FreelancerModel
{
    public class PreviousWork
    {
        //FreelacnerId
        public int FreelacnerId { get; set; }
        public string Pictures { get;set;}
        public string Videos { get;set;}
        public string Links { get;set;}


        public PreviousWork(int FreelacnerId,string Pictures,string Videos,string Links)
        {
            this.FreelacnerId = FreelacnerId;
            this.Pictures = Pictures;
            this.Videos = Videos;
            this.Links = Links;
        }

        public PreviousWork(string Pictures, string Videos, string Links)
        {
            this.Pictures = Pictures;
            this.Videos = Videos;
            this.Links = Links;
        }
    }
}