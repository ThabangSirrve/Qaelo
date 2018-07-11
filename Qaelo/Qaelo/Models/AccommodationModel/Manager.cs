using System;

namespace Qaelo.Models.AccommodationModel
{
    public class Manager
    {
        public int id { get; set; }
        public bool accredited { get; set; }
        public string descriptionOfProperty { get; set; }
        public string email { get; set; }
        public string facebookLink { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string number { get; set; }
        public string password { get; set; }
        public string profileImage { get; set; }
        public string propertyName { get; set; }
        public DateTime registrationDate { get; set; }
        public string userType { get; set; }
        public bool verified { get; set; }

        public Manager(int id,bool accredited, string descriptionOfProperty, string email, string facebookLink,string firstName, string lastName, string number,  string password, string profileImage, string propertyName, DateTime registrationDate, string userType, bool verified)
        {
            this.id = id;
            this.accredited = accredited;
            this.descriptionOfProperty = descriptionOfProperty;
            this.email = email;
            this.facebookLink = facebookLink;
            this.firstName = firstName;
            this.lastName = lastName;
            this.number = number;
            this.password = password;
            this.profileImage = profileImage;
            this.propertyName = propertyName;
            this.verified = verified;
            this.userType = userType;
            this.registrationDate = registrationDate;
        }

        public Manager(bool accredited, string descriptionOfProperty, string email, string facebookLink, string firstName, string lastName, string number, string password, string profileImage, string propertyName,DateTime registrationDate, string userType,bool verified)
        {
            this.registrationDate = registrationDate;
            this.accredited = accredited;
            this.descriptionOfProperty = descriptionOfProperty;
            this.email = email;
            this.facebookLink = facebookLink;
            this.firstName = firstName;
            this.lastName = lastName;
            this.number = number;
            this.password = password;
            this.profileImage = profileImage;
            this.propertyName = propertyName;
            this.verified = verified;
            this.userType = userType;
        }
    }
}