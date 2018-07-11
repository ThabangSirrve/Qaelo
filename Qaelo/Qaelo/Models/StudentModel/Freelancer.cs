using Qaelo.Models.FreelancerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qaelo.Models.StudentModel
{
    public class Freelancer
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Work { get; set; }
        public string Description{ get; set; }
        public string Price{ get; set; }
        public string Image { get; set; }
        public PreviousWork PreviousWok { get; set; }

        public Freelancer(int Id,int StudentId,string Description,string Image,string Price,string Work)
        {
            this.Id = Id;
            this.StudentId = StudentId;
            this.Description = Description;
            this.Image = Image;
            this.Price = Price;
            this.Work = Work;
        }

        public Freelancer(int StudentId, string Description, string Image, string Price, string Work)
        {
            this.StudentId = StudentId;
            this.Description = Description;
            this.Image = Image;
            this.Price = Price;
            this.Work = Work;
        }
    }
}