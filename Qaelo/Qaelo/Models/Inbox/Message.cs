using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qaelo.Models.Inbox
{
    public class Message
    {
        public int Id { get; set; }
        public string SenderID { get; set; }
        public string ReceiverID { get; set; }
        public string NameFrom { get; set; }
        public string NameTo { get; set; }
        public DateTime Date{ get; set; }
        public bool Read { get; set; }
        public string Content { get; set; }

        public Message(int Id, string SenderID, string ReceiverID, string NameFrom, string NameTo, DateTime date, bool Read, string Content)
        {
            this.Id = Id;
            this.SenderID = SenderID;
            this.ReceiverID = ReceiverID;
            this.NameFrom = NameFrom;
            this.NameTo = NameTo;
            this.Date = date;
            this.Read = Read;
            this.Content = Content;
        }

        public Message(string SenderID, string ReceiverID, string NameFrom, string NameTo, DateTime date, bool Read, string Content)
        {
            this.SenderID = SenderID;
            this.ReceiverID = ReceiverID;
            this.NameFrom = NameFrom;
            this.NameTo = NameTo;
            this.Date = date;
            this.Read = Read;
            this.Content = Content;
        }
    }

}