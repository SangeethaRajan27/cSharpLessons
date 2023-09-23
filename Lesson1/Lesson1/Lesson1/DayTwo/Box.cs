using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.DayTwo
{
    internal class Box
    {
        public static int height;
        public  int width;
        public const String type = "Wododen";

        public int GetHeight() { return height; }
    }
    internal class TestBox
    {
        public static void TestOne()
        {
            //Box.width = 100;// cannot be accessed without static
            Box.height = 100;
            //objects in same class
            Box firstbox = new Box();
            Box secondbox = new Box();
            firstbox.width = 550;
            secondbox.width = 567;

            Console.WriteLine( $"First box ={ firstbox.width},{firstbox.GetHeight()}");//the static variable HEIGHT is also printed using a reference object.
            Console.WriteLine($"second box = {secondbox.width},{secondbox.GetHeight()}");
            Console.WriteLine(Box.type);
            //Box.type = "glass";

            Box.height = 432;
            Console.WriteLine($"First box ={firstbox.width},{firstbox.GetHeight()}");
            Console.WriteLine($"second box = {secondbox.width},{secondbox.GetHeight()}");

        }
    }
}
