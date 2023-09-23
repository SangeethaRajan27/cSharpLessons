using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Day8
{
    internal class CarAssiignment
    {
        public class Car
        {
            public string RegistrationNo { get; set; }
            public string Model { get; set; }
            public FuelType Fuel { get; set; }
            public Wheel[] Wheels { get; } = new Wheel[4];
            public Engine CarEngine { get; } = new Engine();



            public Car(string registrationNo, string model, FuelType fuel)
            {
                RegistrationNo = registrationNo;
                Model = model;
                Fuel = fuel;



                for (int i = 0; i < 4; i++)
                {
                    Wheels[i] = new Wheel();
                }
            }



            public enum FuelType
            {
                Petrol,
                Diesel,
                Electric,
                Hybrid
            }



            public class Wheel
            {
                public string Brand { get;set; }
                public string Size { get; set; }
            }



            public class Engine
            {
                public string Type { get; set; }
                public int Power { get; set; }
            }
        }



         public class Program
        {
            static void Main(string[] args)
            {
                Car myCar = new Car("ABC123", "Sedan", Car.FuelType.Petrol);



                Console.WriteLine($"Registration No: {myCar.RegistrationNo}");
                Console.WriteLine($"Model: {myCar.Model}");
                Console.WriteLine($"Fuel Type: {myCar.Fuel}");



                foreach (var wheel in myCar.Wheels)
                {
                    Console.WriteLine($"Wheel: {wheel}");
                }
            }
        }
    }
}

