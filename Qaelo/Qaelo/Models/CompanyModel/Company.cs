using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qaelo.Models.CompanyModel
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyType { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string FacebookLink { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Password { get; set; }
        public string ProfileImage { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string UserType { get; set; }
        public bool Verified { get; set; }

        public Company(int Id,string CompanyType,string Description, string Email, string FacebookLink, string Name, string Number, string Password, string ProfileImage, DateTime RegistrationDate, string UserType,bool Verified)
        {
            this.Description = Description;
            this.Id = Id;
            this.CompanyType = CompanyType;
            this.Email = Email;
            this.FacebookLink = FacebookLink;
            this.Name = Name;
            this.Number = Number;
            this.Password = Password;
            this.ProfileImage = ProfileImage;
            this.RegistrationDate = RegistrationDate;
            this.UserType = UserType;
            this.Verified = Verified;
        }

        public Company(string CompanyType,string Description,string Email, string FacebookLink, string Name, string Number, string Password, string ProfileImage, DateTime RegistrationDate, string UserType, bool Verified)
        {
            this.Description = Description;
            this.CompanyType = CompanyType;
            this.Email = Email;
            this.FacebookLink = FacebookLink;
            this.Name = Name;
            this.Number = Number;
            this.Password = Password;
            this.ProfileImage = ProfileImage;
            this.RegistrationDate = RegistrationDate;
            this.UserType = UserType;
            this.Verified = Verified;
        }

    }
}