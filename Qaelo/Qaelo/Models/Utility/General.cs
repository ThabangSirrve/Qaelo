using Qaelo.Models.StudentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qaelo.Models.Utility
{
    public static class General
    {
        public static string monthString(int m)
        {
            string month = "";

            switch (m)
            {
                case 1:
                    month = "Jan";
                    break;
                case 2:
                    month = "Feb";
                    break;
                case 3:
                    month = "Mar";
                    break;
                case 4:
                    month = "Apr";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "Jun";
                    break;
                case 7:
                    month = "Jul";
                    break;
                case 8:
                    month = "Aug";
                    break;
                case 9:
                    month = "Sep";
                    break;
                case 10:
                    month = "Oct";
                    break;
                case 11:
                    month = "Nov";
                    break;
                case 12:
                    month = "Dec";
                    break;
            }
            return month;
        }

        public static string getDateString(DateTime date)
        {
            string dateString = " " + date.Day + " " + General.monthString(date.Month) + " " + date.Year;

            return dateString;
        }

        public static string getPastTimeString(DateTime myDate)
        {
            string dateString = "";
            DateTime today = DateTime.Now;

            //By Year First and wor your way down 
            if (myDate.Year == today.Year)
            {
                //Then proceed to month 
                if (myDate.Month == today.Month)
                {
                    //Then Proceed to day
                    if (myDate.Day == today.Day)
                    {
                        //Proceed to hours 
                        if (myDate.Hour == today.Hour)
                        {
                            //Then Proceed to Minutes
                            if (myDate.Minute == today.Minute)
                            {
                                //Proceed to Seconds 
                                if (myDate.Second == today.Second)
                                {
                                    dateString = Convert.ToString("Just now");
                                }
                                else
                                {
                                    dateString = Convert.ToString(today.Second - myDate.Second + " second(s) ago");
                                }
                            }
                            else
                            {
                                dateString = Convert.ToString(today.Minute - myDate.Minute + " minutes(s) ago");
                            }
                        }
                        else
                        {
                            dateString = Convert.ToString(today.Hour - myDate.Hour + " hour(s) ago");
                        }
                    }
                    else
                    {
                        dateString = Convert.ToString(today.Day - myDate.Day + " day(s) ago");
                    }
                }
                else
                {
                    dateString = Convert.ToString(today.Month - myDate.Month + " month(s) ago");
                }
            }
            else
            {
                dateString = Convert.ToString(today.Year - myDate.Year + " year(s) ago");
            }


            return dateString;

        }

        public static string fillString(string myString,int maxLength)
        {
            int numCharacters = maxLength;
            string buildString = myString + " ";
            int length = myString.Length;

            while (length < numCharacters)
            {
                length++;
                buildString += "<i style='opacity: -20'>*</i>";
            }

            return buildString;
        }
        
        public static int getLengthOfLongestFreelancer(List<Freelancer> freelancers)
        {
            int Max = 0;

            foreach (Freelancer item in freelancers)
            {
                if (item.Work.Length > Max)
                    Max = item.Work.Length;
            }
            return Max;
        }
    }
}