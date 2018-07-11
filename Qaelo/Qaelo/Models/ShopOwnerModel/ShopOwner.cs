using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qaelo.Models.ShopOwnerModel
{
    public class ShopOwner
    {
        //Id, FullName, Email, Number, Password, RegistrationDate, UserType, Verified

        public int Id {get;set;}
        public string FullName {get;set;}
        public string Email {get;set;}
        public string Number {get;set;}
        public string Password {get;set;}
        public DateTime RegistrationDate{get;set;}
        public string UserType{get;set;}
        public bool Verified{get;set;}

        public ShopOwner(int Id, string Email, string FullName, string Number, string Password, DateTime RegistrationDate, string UserType,bool Verified)
        {
            this.Id = Id;
            this.Email = Email;
            this.FullName = FullName;
            this.Number = Number;
            this.Password = Password;
            this.RegistrationDate = RegistrationDate;
            this.UserType = UserType;
            this.Verified = Verified;
        }

        public ShopOwner(string Email, string FullName, string Number, string Password, DateTime RegistrationDate, string UserType, bool Verified)
        {
            this.Email = Email;
            this.FullName = FullName;
            this.Number = Number;
            this.Password = Password;
            this.RegistrationDate = RegistrationDate;
            this.UserType = UserType;
            this.Verified = Verified;
        }
    }

}