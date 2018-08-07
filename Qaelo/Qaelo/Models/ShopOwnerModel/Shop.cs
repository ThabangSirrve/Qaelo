using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qaelo.Models.ShopOwnerModel
{
    public class Shop
    {
        public int Id {get; set;}
        public int ShopOwnerId { get; set;}
        public string Campus { get; set;}
        public string Description { get; set;}
        public string Image { get; set;}
        public string Name { get; set;}
        public string TradingHours { get; set;}
        public string  Address { get; set;}
        public string University { get; set;}
        

        public Shop(int Id,int ShopOwnerId,string Campus, string Description, string Image, string Name, string TradingHours, string Address, string University)
        {
            this.Id = Id;
            this.ShopOwnerId = ShopOwnerId;
            this.Campus = Campus;
            this.Description = Description;
            this.Image = Image;
            this.Name = Name;
            this.TradingHours = TradingHours;
            this.Address = Address;
            this.University = University;
        }

        public Shop(int ShopOwnerId, string Campus, string Description, string Image, string Name, string TradingHours, string Address, string University)
        {
            this.ShopOwnerId = ShopOwnerId;
            this.Campus = Campus;
            this.Description = Description;
            this.Image = Image;
            this.Name = Name;
            this.TradingHours = TradingHours;
            this.Address = Address;
            this.University = University;
        }
    }
}