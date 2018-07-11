using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qaelo.Models.EventPosterModel
{
    public class TicketModel
    {
        //Id, EventId, AccountHolder, AccountNo, BankName, BranchCode, PriceDescription, Reference
        public int Id { get; set; }
        public int EventId { get; set; }
        public string AccountHolder { get; set; }

        public string AccountNo { get; set; }
        public string BankName { get; set; }
        public int BranchCode { get; set; }


        public string PriceDescription { get; set; }
        public string reference { get; set; }


        public TicketModel(int Id, int EventId, string AccountHolder, string AccountNo, string BankName, int BranchCode, string PriceDescription, string reference)
        {
            this.Id = Id;
            this.EventId = EventId;
            this.AccountHolder = AccountHolder;
            this.AccountNo = AccountNo;
            this.BankName = BankName;
            this.BranchCode = BranchCode;
            this.PriceDescription = PriceDescription;
            this.reference = reference;
        }
        public TicketModel( int EventId, string AccountHolder, string AccountNo, string BankName, int BranchCode, string PriceDescription, string reference)
        {
          
            this.EventId = EventId;
            this.AccountHolder = AccountHolder;
            this.AccountNo = AccountNo;
            this.BankName = BankName;
            this.BranchCode = BranchCode;
            this.PriceDescription = PriceDescription;
            this.reference = reference;
        }
    }
}