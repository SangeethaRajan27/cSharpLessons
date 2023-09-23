using LessonA.DayTwo;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.DayTwo
{
    internal class Appointment
    {
        public string Location { get; set; }
        public string Date { get; set; } = string.Empty;
        public string FromTime { get; set; } = string.Empty;
        public string NameOne { get; set; } = string.Empty;
        public string NameTwo { get; set; } = string.Empty;
        public string ToTime { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string ContactNo { get; set; } = string.Empty;
        public string MailId { get; set; }
        public override string ToString()
        {
            return $"Location:{this.Location},Date:{Date},\n"+$"From Time:{FromTime}-To Time:{ToTime}\n"+$"Meeting With:{NameOne},{NameTwo}\n"+$"Address:{Address},Contact:{ContactNo},Mail:{MailId}";
        }

        internal class Meeting
        {
            public static void Hello()
            {
                Appointment  meet = new Appointment();
                meet.Location = "GAVS";
                meet.Date = "23rd,August";
                meet.FromTime = "11 am";
                meet.ToTime = "12 pm";
                meet.NameOne = "Garu";
                meet.NameTwo = "JK";
                meet.Address = "GAVS Technologies,Sholinganallur,Chennai";
                meet.ContactNo = "324675";
                meet.MailId = "123@gavstech.com";


                String value = meet.ToString();
                Console.WriteLine(value);

            }
        }





    }
}
