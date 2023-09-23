using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lesson1.DayFour
{
    internal class DateDemo
    {
        public static void Firstmethod()
        {
            Console.WriteLine(DateTime.Now);

            DateTime d1 = new DateTime(2018, 09, 22);
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToShortDateString());
        }
        public static void SecondMethod()
        {
            Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");
            String strdob = Console.ReadLine();
            DateTime d1 = DateTime.Parse(strdob);
            int year = d1.Year;
            Console.WriteLine("Year OF Dob " + year);
            int month = d1.Month;
            Console.WriteLine("Month OF Dob " + month);
            int day = d1.Day;
            Console.WriteLine("Day OF Dob " + day);
            DateTime d2 = d1.AddMonths(10);
            Console.WriteLine("AddMonths(10) " + d2.ToLongDateString());
            DateTime d3 = d1.AddDays(5);
            Console.WriteLine("AddDays(5) " + d3.ToShortDateString());
            DateTime d4 = d1.AddYears(58);
            Console.WriteLine("AddYears(58) " + d4.ToShortDateString());
            DateTime d5 = d1.AddYears(-5);
            Console.WriteLine("AddYears(-5) " + d5.ToShortDateString());
        }
        public static void Age()
        {
           // Console.WriteLine("Enter your name");
            Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");
            String strob = String.Empty;
            
            
                Console.ReadLine();
                String strdob = Console.ReadLine();
                DateTime d1 = DateTime.Parse(strdob);
                //int year = d1.Year;
                //int month = d1.Month;
                //int day = d1.Day;
                DateTime d2 = DateTime.Now;
                //int pyear = d2.Year;
                //int pmonth = d2.Month;
                //int pday = d2.Day;
                TimeSpan t = d2.Subtract(d1);
                DateTime Age = new DateTime(t.Ticks);
                Console.WriteLine("age is" + Age.ToShortDateString());
            
        }
        public static void Findage()
        {
            //Prompt the user for their date of birth
Console.WriteLine("Enter your date of birth (YYYY-MM-DD):");
            string dobString = String.Empty;
            try
            {
                dobString = Console.ReadLine();
                if (dobString == null)
                {
                    Console.WriteLine("Date Of Birth is NULL!!!");
                    return;
                }
                // Parse the date of birth
                DateTime dob = DateTime.Parse(dobString);



                // Calculate the age
                DateTime now = DateTime.Now;
                int ageYears = now.Year - dob.Year;
                if (now < dob.AddYears(ageYears))
                {
                    ageYears--;
                }
                int ageMonths = 0;
                if (now.Month >= dob.Month)
                    ageMonths = now.Month - dob.Month;
                else
                {
                    ageMonths = (12 - dob.Month) + now.Month;
                }
                int ageDays = 0;
                if (now.Day >= dob.Day)
                    ageDays = now.Day - dob.Day;
                else
                {
                    ageDays = DateTime.DaysInMonth(dob.Year, dob.Month - 1) - dob.Day + now.Day;
                    ageMonths--;
                }
            }





            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }

}
