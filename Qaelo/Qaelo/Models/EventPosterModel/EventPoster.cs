
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qaelo.Models.EventPosterModel
{
    public class EventPoster
    {
        //Id, Email, FullName, Number, Password, ProfileImage, RegistrationDate, UserType, Verified
        public int Id {get; set;}
        public string Email {get; set;}
        public string FullName { get; set; }
        public string Number{ get; set; }
        public string Password{ get; set; }
        public string ProfileImage{ get; set; }
        public DateTime RegistrationDate{ get; set; }
        public string UserType{ get; set; }
        public bool Verified{ get; set; }

        public EventPoster(int Id,string Email, string FullName, string Number, string Password, string ProfileImage, DateTime RegistrationDate, string UserType, bool Verified)
        {
            this.Id = Id;
            this.Email = Email;
            this.FullName = FullName;
            this.Number = Number;
            this.Password = Password;
            this.ProfileImage = ProfileImage;
            this.RegistrationDate = RegistrationDate;
            this.UserType = UserType;
            this.Verified = Verified;
        }

        public EventPoster(string Email, string FullName, string Number, string Password, string ProfileImage, DateTime RegistrationDate, string UserType, bool Verified)
        {
            this.Email = Email;
            this.FullName = FullName;
            this.Number = Number;
            this.Password = Password;
            this.ProfileImage = ProfileImage;
            this.RegistrationDate = RegistrationDate;
            this.UserType = UserType;
            this.Verified = Verified;
        }
    }
}