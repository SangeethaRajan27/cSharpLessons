using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.DayOne
{
    internal class Number
    {
        public static void Integers()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Grape");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Apple");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Orange");
                }
        else
                {
                    Console.WriteLine(i);
                }
            }
        }


    }


}
