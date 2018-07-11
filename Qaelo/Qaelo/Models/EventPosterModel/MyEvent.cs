using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qaelo.Models.EventPosterModel
{
    public class MyEvent
    {
        //Id, EventPosterId, Campus, Date, DatePosted, Description, EntryFee, Image, Location, Name, University

        public int Id {get;set;}
        public int EventPosterId {get;set;}
        public string Campus {get;set;}
        public DateTime Date{get;set;}
        public DateTime DatePosted{get;set;}
        public string Description{get;set;}
        public double EntryFee{get;set;}
        public string Image{get;set;}
        public string Location{get;set;}
        public string Name {get;set;}
        public string University{get;set;}


        public MyEvent(int Id,int  EventPosterId,string Campus,DateTime Date,DateTime DatePosted,string Description,double EntryFee,string Image,string Location,string Name,string University)
        {
            this.Id = Id;
            this.EventPosterId = EventPosterId;
            this.Campus = Campus;
            this.Date = Date;
            this.DatePosted = DatePosted;
            this.Description = Description;
            this.EntryFee = EntryFee;
            this.Image = Image;
            this.Location = Location;
            this.Name = Name;
            this.University = University;
        }

        public MyEvent(int EventPosterId, string Campus, DateTime Date, DateTime DatePosted, string Description, double EntryFee, string Image, string Location, string Name, string University)
        {
            this.EventPosterId = EventPosterId;
            this.Campus = Campus;
            this.Date = Date;
            this.DatePosted = DatePosted;
            this.Description = Description;
            this.EntryFee = EntryFee;
            this.Image = Image;
            this.Location = Location;
            this.Name = Name;
            this.University = University;
        }
    }

}