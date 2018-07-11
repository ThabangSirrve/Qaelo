using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qaelo.Models.StudentModel
{
    public class Student
    {
        public int Id { get; set; }
        public string Campus { get; set; }
        public string Description { get; set; }//Short motivation about the individual
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string Institution { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }
        public string Password { get; set; }
        public string ProfileImage { get; set; }
        public string QualificationEnrolled { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string UserType { get; set; }
        public string YearOfStudy { get; set; }

        public Student(int Id, string Campus, string Description, string Email, string FirstName, string Institution, string LastName, string Number, string Password, string ProfileImage, string QualificationEnrolled, DateTime RegistrationDate, string UserType,string YearOfStudy)
        {
            this.Id = Id;
            this.Campus = Campus;
            this.Description = Description;
            this.Email = Email;
            this.FirstName = FirstName;
            this.Institution = Institution;
            this.LastName = LastName;
            this.Number = Number;
            this.Password = Password;
            this.ProfileImage = ProfileImage;
            this.QualificationEnrolled = QualificationEnrolled;
            this.RegistrationDate = RegistrationDate;
            this.UserType = UserType;
            this.YearOfStudy = YearOfStudy;
        }

        public Student(string Campus, string Description, string Email, string FirstName, string Institution, string LastName, string Number, string Password, string ProfileImage, string QualificationEnrolled, DateTime RegistrationDate, string UserType, string YearOfStudy)
        {
            this.Campus = Campus;
            this.Description = Description;
            this.Email = Email;
            this.FirstName = FirstName;
            this.Institution = Institution;
            this.LastName = LastName;
            this.Number = Number;
            this.Password = Password;
            this.ProfileImage = ProfileImage;
            this.QualificationEnrolled = QualificationEnrolled;
            this.RegistrationDate = RegistrationDate;
            this.UserType = UserType;
            this.YearOfStudy = YearOfStudy;
        }
    }
}