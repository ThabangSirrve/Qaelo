using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qaelo.Models.ShopOwnerModel
{
    public class ShopOwnerViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string UserType { get; set; }
        public bool Verified { get; set; }


        public virtual List<Shop> shops { get; set; }
        public virtual List<Discount> Discounts { get; set; }
    }
}