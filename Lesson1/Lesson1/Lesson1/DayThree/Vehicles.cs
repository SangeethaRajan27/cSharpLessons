using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lesson1.DayThree
{
    internal abstract class Vehicles
    {
        public Vehicles() 
        {
            Console.WriteLine( "Vehicle Constructor");
        }   

        public void Start()
        {
            Console.WriteLine( "Vehicle Started");
        }
        //end of class

        internal class Car : Vehicles
        {
            public Car()
            {
                Console.WriteLine("Car Constructor");
            }
        }
        class VehiclesTester
        {
            public static void TestOne()
            {
                //Vehicles tester = new Vehicles();
                Vehicles tester = new Car();
                tester.Start();
            }
        }

    }
}
