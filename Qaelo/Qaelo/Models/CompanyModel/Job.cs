using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qaelo.Models.CompanyModel
{
    public class Job
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public DateTime ClosingDate { get; set; }
        public string ContactInfo { get; set; }
        public DateTime DatePosted { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }

        public Job(int Id, int CompanyId, DateTime ClosingDate,string ContactInfo,DateTime DatePosted,string Description,string Title,string Type)
        {
            this.Id = Id;
            this.CompanyId = CompanyId;
            this.ClosingDate = ClosingDate;
            this.ContactInfo = ContactInfo;
            this.DatePosted = DatePosted;
            this.Description = Description;
            this.Title = Title;
            this.Type = Type;
        }

        public Job(int CompanyId, DateTime ClosingDate, string ContactInfo, DateTime DatePosted, string Description, string Title, string Type)
        {
            this.CompanyId = CompanyId;
            this.ClosingDate = ClosingDate;
            this.ContactInfo = ContactInfo;
            this.DatePosted = DatePosted;
            this.Description = Description;
            this.Title = Title;
            this.Type = Type;
        }
    }
}