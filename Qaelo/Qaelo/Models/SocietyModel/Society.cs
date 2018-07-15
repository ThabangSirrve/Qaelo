using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qaelo.Models.SocietyModel
{
    public class Society
    {
        //Id, Campus, Email, FacebookLink, Name, Number, Password, ProfileImage, RegistrationDate, SocietyType, University, UserType, Video, Verified
        public int Id {get;set;}
        public string Campus { get; set; }
        public string Description { get; set; }
        public string Email{get;set;}
        public string FacebookLink { get;set;}
        public string MeetingDay{ get; set; }
        public string MeetingTime { get; set; }
        public string Name {get;set;}//Name of the society
        public string Number{get;set;}
        public string Password{get;set;}
        public string ProfileImage{get;set;}
        public DateTime RegistrationDate{get;set;}
        public string SocietyType{get;set;}
        public string University { get; set; }
        public string UserType{get;set;}
        public string Video{get;set;}
        public bool Verified{get;set;}

        public Society(int Id,string Campus,string Description,string Email,string FacebookLink,string MeetingDay, string MeetingTime , string Name, string Number, string Password, string ProfileImage,DateTime RegistrationDate, string SocietyType,string University, string UserType, string Video,bool Verified)
        {
            this.Id = Id;
            this.Campus = Campus;
            this.Email = Email;
            this.FacebookLink = FacebookLink;
            this.MeetingTime = MeetingTime;
            this.Name = Name;
            this.Number = Number;
            this.Password = Password;
            this.ProfileImage = ProfileImage;
            this.RegistrationDate = RegistrationDate;
            this.SocietyType = SocietyType;
            this.University = University;
            this.UserType = UserType;
            this.Verified = Verified;
            this.Video = Video;
            this.MeetingDay = MeetingDay;
            this.Description = Description;
        }

        public Society(string Campus,string Description,string Email,string FacebookLink, string MeetingDay,string MeetingTime , string Name, string Number, string Password, string ProfileImage, DateTime RegistrationDate, string SocietyType, string University, string UserType, string Video, bool Verified)
        {
            this.Email = Email;
            this.Campus = Campus;
            this.FacebookLink = FacebookLink;
            this.MeetingTime = MeetingTime;
            this.Name = Name;
            this.Number = Number;
            this.Password = Password;
            this.ProfileImage = ProfileImage;
            this.RegistrationDate = RegistrationDate;
            this.SocietyType = SocietyType;
            this.University = University;
            this.UserType = UserType;
            this.Verified = Verified;
            this.Video = Video;
            this.MeetingDay = MeetingDay;
            this.Description = Description;
        }
    }
}