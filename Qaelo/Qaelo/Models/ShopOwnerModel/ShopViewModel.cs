using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qaelo.Models.ShopOwnerModel
{
    public class ShopViewModel
    {
        public int Id { get; set; }
        public int ShopOwnerId { get; set; }
        public string Campus { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string TradingHours { get; set; }
        public string Address { get; set; }
        public string University { get; set; }

        public virtual ShopOwner shopOwner { get; set; }
    }
}