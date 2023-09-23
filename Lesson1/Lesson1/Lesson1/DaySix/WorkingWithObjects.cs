using Lesson1.Day5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Day6
{
    internal class WorkingWithObjects
    {
        public static void TestOne()
        {
            Object objectOne = new object();
            Console.WriteLine($"ToString: {objectOne.ToString()}");
            Console.WriteLine($"HashCode: {objectOne.GetHashCode()}");
            Type typeOne = objectOne.GetType();
            Console.WriteLine($"Type: {typeOne.FullName}");



            String stringData = "WorldCup 2023";
            Console.WriteLine($"ToString: {stringData.ToString()}");
            Console.WriteLine($"HashCode: {stringData.GetHashCode()}");
            Type typeTwo = stringData.GetType();
            Console.WriteLine($"Type: {typeTwo.FullName}");
        }

        public static void TestTwo()
        {
            Emp empOne = new Emp();
            //Emp empTwo = new Emp();
            //Emp empThree = new Emp();
            empOne.ID = 1001;empOne.Name = "Sam";
            Emp empTwo = empOne;
            empOne.ID = 1002; empTwo.Name = "Samm";
            Emp empThree = empOne;
            empOne.ID = 1003; empThree.Name = "Sammm";
            bool flag = (empOne.Equals(empTwo));
            Console.WriteLine( flag);
            flag = (empOne.Equals(empThree));
            Console.WriteLine(flag);
            //Console.WriteLine( flag);
            Console.WriteLine( empOne.GetHashCode());
            Console.WriteLine(empTwo.GetHashCode());
            Console.WriteLine(empThree.GetHashCode());



        }
    }
}
