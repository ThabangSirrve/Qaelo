using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qaelo.Models.AccommodationModel
{
    public class Reservation
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string BankStatement { get;set;}
        public string Email {get;set;}
        public string FullName  { get;set;}
        public string HomeAddress  { get;set;}
        public string GuardianID { get; set;}
        public string Number { get;set;}
        public DateTime MonthOfStay { get;set;}
        public bool RoomAvailable { get;set;}
        public int RoomNo { get;set;}
        public string SalaryAdvice { get;set;}
        public string Sponsor { get;set;}
        public string StudentIdentity  { get;set;}
        public bool ViewedRoom { get;set;}

        public Reservation(int Id,int StudentId,string BankStatement,string Email,string FullName,string HomeAddress,string GuardianID,string Number, DateTime MonthOfStay,bool RoomAvailable,int RoomNo,string SalaryAdvice,string Sponsor,string StudentIdentity,bool ViewedRoom)
        {
            this.Id = Id;
            this.StudentId = StudentId;
            this.BankStatement = BankStatement;
            this.Email = Email;
            this.FullName = FullName;
            this.HomeAddress = HomeAddress;
            this.GuardianID = GuardianID;
            this.Number = Number;
            this.MonthOfStay = MonthOfStay;
            this.RoomAvailable = RoomAvailable;
            this.RoomNo = RoomNo;
            this.SalaryAdvice = SalaryAdvice;
            this.Sponsor = Sponsor;
            this.StudentIdentity = StudentIdentity;
            this.ViewedRoom = ViewedRoom;
        }

        public Reservation(int StudentId, string BankStatement, string Email, string FullName, string HomeAddress, string GuardianID, string Number, DateTime MonthOfStay, bool RoomAvailable, int RoomNo, string SalaryAdvice, string Sponsor, string StudentIdentity, bool ViewedRoom)
        {
            this.StudentId = StudentId;
            this.BankStatement = BankStatement;
            this.Email = Email;
            this.FullName = FullName;
            this.HomeAddress = HomeAddress;
            this.GuardianID = GuardianID;
            this.Number = Number;
            this.MonthOfStay = MonthOfStay;
            this.RoomAvailable = RoomAvailable;
            this.RoomNo = RoomNo;
            this.SalaryAdvice = SalaryAdvice;
            this.Sponsor = Sponsor;
            this.StudentIdentity = StudentIdentity;
            this.ViewedRoom = ViewedRoom;
        }
    }
}