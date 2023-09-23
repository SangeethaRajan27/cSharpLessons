using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Day5
{
    internal class Employee
    {
        class Emp
        {
            private readonly double Id;
            public string Title;
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public double Salary { get; set; }
            public Emp() { }
            public Emp(double v1)
            {
                Id = v1;
            }
            public double GetID()
            {
                return Id;
            }
            public static void EmpArray()
            {
                Emp[] elist = new Emp[10];
                for (int i = 0; i < 10; i++)
                {
                    Emp e1 = new Emp(i);
                    e1.FirstName = "Emp" + i;
                    elist[i] = e1;
                }



                Console.WriteLine("No of Employees " + elist.Length);
                for (int i = 0; i < 10; i++)
                {
                    Emp e1 = elist[i];
                    Console.WriteLine("ID=" + e1.GetID() + " Name=" + e1.FirstName);
                }
            }
        }
    }
}
