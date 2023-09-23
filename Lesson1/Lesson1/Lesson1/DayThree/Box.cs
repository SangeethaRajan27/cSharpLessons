using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.DayThree
{
    internal class Box
    {
        
        internal int Height;
        public int Length;
        public int Width;
    
        public Box(int x)
        {
            Console.WriteLine("Box Object Created");
        }
        public void Open()
        {
            Console.WriteLine("Box is Open");
        }
        public void Close()
        {
            Console.WriteLine("Box is Closed");
        }

        public override string ToString()
        {
            return $"Height:{Height},Length:{Length},Width:{Width}";
        }
    }
    internal class WoodenBox : Box 
    {
        public int Area;
        public WoodenBox():base(4)
        {
            Console.WriteLine("WoodenBox Constructor");
        }

        public void Move()
        {
            Console.WriteLine( "Woodenbox Shifted");
        }

        public override string ToString()
        {
            return "$";
        }


    }//child cass - inheritance (base-key word)
    internal class BoxTester
    {
        public static void TestOne()//parent class 
        {
            Box box = new Box(0);
            box.Height = 10;
            box.Length = 20; 
            box.Width = 5;
            box.Open();
            box.Close();
            String output=box.ToString();   
            Console.WriteLine(output);
            //box.Area();
        }
        public static void TestTwo()//child class 
        {
            WoodenBox box = new WoodenBox();
            box.Height = 10;
            box.Length = 20;
            box.Width = 5;
            box.Open();
            box.Close();
            String output = box.ToString();
            Console.WriteLine(output);
            box.Area = 10;
            box.Move();

        }

        public static void Testthree()//Type casting child class to parent class
        {
            Box bx = new WoodenBox();
            bx.Height = 10;
            bx.Length = 20;
            bx.Width = 5;
            bx.Open();
            bx.Close();
            String output = bx.ToString();//$
            Console.WriteLine(output);
            //bx.Area = 10;
            //bx.Move();

        }
    }
}
