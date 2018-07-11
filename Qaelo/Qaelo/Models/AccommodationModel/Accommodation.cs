using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qaelo.Models.AccommodationModel
{
    public class Accommodation
    {
        public int id { get; set; }
        public bool accredited { get; set; }
        public string address { get; set; }
        public string accomodationType { get; set; }// apartment or commune
        public string arrangement { get; set; }//single or sharing 
        public string campus { get; set; }
        public DateTime datePosted { get; set; }
        public string description { get; set; }//
        public string distanceFromCampus { get; set; }//Distance from the campus
        public string gender { get; set; }
        public string images { get; set; }
        public int managerId { get; set; }
        public double price { get; set; }
        public string university { get; set; }//University which they are based 
        public bool status { get; set; }

        public Accommodation(int id,bool accredited, string accomodationType, string address, string arrangement, string campus, DateTime datePosted, string description,  string distanceFromCampus,
        string gender, string images,int managerId, double price, string university, bool status)
        {
            this.datePosted = datePosted;
            this.id = id;
            this.accredited = accredited;
            this.address = address;
            this.accomodationType = accomodationType;
            this.arrangement = arrangement;
            this.description = description;
            this.distanceFromCampus = distanceFromCampus;
            this.campus = campus;
            this.gender = gender;
            this.images = images;
            this.price = price;
            this.university = university;
            this.managerId = managerId;
            this.status = status;
        }

        public Accommodation(bool accredited, string accomodationType, string address, string arrangement, string campus, DateTime datePosted, string description, string distanceFromCampus,
        string gender, string images, int managerId, double price, string university,bool status)
        {
            this.datePosted = datePosted;
            this.accredited = accredited;
            this.address = address;
            this.accomodationType = accomodationType;
            this.arrangement = arrangement;
            this.description = description;
            this.distanceFromCampus = distanceFromCampus;
            this.campus = campus;
            this.gender = gender;
            this.images = images;
            this.price = price;
            this.university = university;
            this.managerId = managerId;
            this.status = status;
        }
    }
}