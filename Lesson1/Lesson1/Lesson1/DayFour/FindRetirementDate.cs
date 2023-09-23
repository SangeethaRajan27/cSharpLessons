using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.DayFour
{
    internal class FindRetirementDate
    {
        public static void Retirement()
        {
            Console.WriteLine("What is your Date of Birth (dd/mm/yyyy)");
            String strdob = Console.ReadLine();
            DateTime d1 = DateTime.Parse(strdob);
            DateTime newmonth = d1.AddYears(60).AddMonths(1);

            DateTime date = new DateTime(newmonth.Year, newmonth.Month, 1).AddDays(-1);
            Console.WriteLine("Retirement Day" + date.ToShortDateString());

        }
    }
}
