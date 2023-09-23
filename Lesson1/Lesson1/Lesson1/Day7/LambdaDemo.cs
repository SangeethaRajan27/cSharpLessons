using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lesson1.Day7
{
    internal class LambdaDemo
    {
        public static void TestA()
        {
            Func<int, int> foo = (x) => x / 2;
            int i = 100;
            int result = foo(i);
            Console.WriteLine(result);
        }
        public static void TestB()
        {
            Func<int> foo = () => 100;

            int result = foo();
            Console.WriteLine(result);
        }
        public static void TestC()
        {
            Func<double, double, double> callme = (x, y) => (x + y) / 2;
            int v1 = 101;
            int v2 = 10;
            double result = callme(v1, v2);
            Console.WriteLine(result);
        }
        public static void TestD()
        {
            Func<int, double> foo = x =>(double) x / 2;
            int v1 = 101;
            double result = foo(v1);
            Console.WriteLine(result);
        }
        public static void TestF()
        {
            Func<double, int> foo = x => (int)x / 2;
            double v1 = 101;
            int result = foo(v1);
            Console.WriteLine(result);
        }
        /*public static void TestE()
        {
            Func<double,int> foo = x => x / 2;
            double  v1 = 101;
            int result = foo(v1);
            Console.WriteLine(result);
        }*/
        static void Echo(Func<string> foo)
        {
            string s = foo();
            Console.WriteLine(s);
            
        }
        public static void TestEcho()
        {
            Echo(() => "Hello");
            Echo(() => "world");
        }
       
        static  double Dotrans(Func<int,int,double> fooo)
        {
            return fooo(50, 5);
        }
        public static void TestDotrans()
        {
            Func <int,int,double> Multiply = (x,y) => x * y;
            double d = Dotrans(Multiply);
            Console.WriteLine( d);
            Func<int, int, double> Add = (x, y) => x + y;
            d= Dotrans(Add);
            Console.WriteLine(d);
            Func<int, int, double> Divide = (x, y) =>
            {
                if (y == 0) y = 1; return x / y;
            };
            double d1 = Dotrans(Divide);
            Console.WriteLine(d1);
        }

        

        

    }
}

