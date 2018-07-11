using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qaelo.Models.AccommodationModel
{
    public class RoomAd
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public DateTime DatePosted { get; set; }
        public double RentAmount { get; set; }
        public string Arrangement { get; set; }
        public string Gender { get; set; }
        public string Number { get; set; }
        public string PaymentType { get; set; }

        public RoomAd(int StudentId, string Arrangement,DateTime DatePosted, string Gender, string Number, string PaymentType, double RentAmount)
        {
            this.StudentId = StudentId;
            this.RentAmount = RentAmount;
            this.Arrangement = Arrangement;
            this.Gender = Gender;
            this.Number = Number;
            this.PaymentType = PaymentType;
            this.DatePosted = DatePosted;
        }

        public RoomAd(int Id,int StudentId,string Arrangement, DateTime DatePosted, string Gender, string Number,string PaymentType, double RentAmount)
        {
            this.Id = Id;
            this.StudentId = StudentId;
            this.RentAmount = RentAmount;
            this.Arrangement = Arrangement;
            this.Gender = Gender;
            this.Number = Number;
            this.PaymentType = PaymentType;
            this.DatePosted = DatePosted;
        }
    }
}