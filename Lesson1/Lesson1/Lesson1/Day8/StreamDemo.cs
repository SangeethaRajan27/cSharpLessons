using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.NewFolder
{
    internal class StreamDemo
    {            
        public static void TestOne()
            {
                char cr;
                Console.WriteLine( "Press a key followed by ENTER:");
                int x = Console.Read();
                cr = (char)x;
                Console.WriteLine("\n" +  x + "Your key is:" + cr);
                
            }
        public static void TestTwo()
        {
            char cr = ' ';
            Console.WriteLine("Press a key q to Exit:");
            
            while(cr != 'q')
            {
                cr = (char)Console.Read();
                Console.WriteLine( "Your key is :" + cr);
            }
        }
        public static void TestThree()
        {
            Console.Out.WriteLine("Enter a sentence");
            string? str = Console.ReadLine();
            Console.Out.WriteLine(" " + str);

        }
        public static void TestNullableTypes()
        {
            int? x = 89;
            x = null;
            if (x.HasValue)
            {
                Console.Out.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine( x.GetValueOrDefault());
            }
            

        }o

    }
}
