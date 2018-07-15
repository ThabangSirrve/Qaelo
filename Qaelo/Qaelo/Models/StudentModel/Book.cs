using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qaelo.Models.StudentModel
{
    public class Book
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Description { get; set; }
        public string Field { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public string YearOfStudy { get; set; }

        public Book(int Id,int  StudentId,string Description,string Field, string Name, string Image,double Price,string YearOfStudy)
        {
            this.Id = Id;
            this.StudentId = StudentId;
            this.Description = Description;
            this.Field = Field;
            this.Name = Name;
            this.Image = Image;
            this.Price = Price;
            this.YearOfStudy = YearOfStudy;
        }

        public Book(int StudentId, string Description, string Field, string Name, string Image, double Price, string YearOfStudy)
        {
            this.StudentId = StudentId;
            this.Description = Description;
            this.Field = Field;
            this.Name = Name;
            this.Image = Image;
            this.Price = Price;
            this.YearOfStudy = YearOfStudy;
        }
    }
}