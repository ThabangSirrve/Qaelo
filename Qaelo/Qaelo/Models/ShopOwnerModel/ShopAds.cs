using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qaelo.Models.ShopOwnerModel
{
    public class ShopAds
    {
        //Id, ShopOwnerId, Campus, Description, Image, Name, TradingHours, ShopNo, University, SpecialStartDate, SpecialEndDate, OrderID, Status

        public int Id { get; set; }
        public int ShopOwnerId { get; set; }
        public string Campus { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string TradingHours { get; set; }
        public string ShopNo { get; set; }
        public string University { get; set; }
        public DateTime SpecialStartDate { get; set; }
        public DateTime SpecialEndDate { get; set; }
        public string OrderID { get; set; }
        public string Status { get; set; }

        public ShopAds(int Id, int ShopOwnerId, string Campus, string Description, string Image, string Name, string TradingHours, string ShopNo, string University, DateTime SpecialStartDate, DateTime SpecialEndDate, string OrderID, string Status)
        {
            this.Id = Id;
            this.ShopOwnerId = ShopOwnerId;
            this.Campus = Campus;
            this.Description = Description;
            this.Image = Image;
            this.Name = Name;
            this.TradingHours = TradingHours;
            this.ShopNo = ShopNo;
            this.University = University;
            this.SpecialEndDate = SpecialEndDate;
            this.SpecialStartDate = SpecialStartDate;
            this.OrderID = OrderID;
            this.Status = Status;
        }

        public ShopAds( int ShopOwnerId, string Campus, string Description, string Image, string Name, string TradingHours, string ShopNo, string University, DateTime SpecialStartDate, DateTime SpecialEndDate, string OrderID, string Status)
        {
            this.ShopOwnerId = ShopOwnerId;
            this.Campus = Campus;
            this.Description = Description;
            this.Image = Image;
            this.Name = Name;
            this.TradingHours = TradingHours;
            this.ShopNo = ShopNo;
            this.University = University;
            this.SpecialEndDate = SpecialEndDate;
            this.SpecialStartDate = SpecialStartDate;
            this.OrderID = OrderID;
            this.Status = Status;
        }
    }
}