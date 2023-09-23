using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Day6
{
    internal class ParametersDemo
    {
        //by ref Parameters
        public static void ByRefMethod(int v1, ref int v2)
        {
            Console.WriteLine("\tM1==> v1={0},v2={1}", v1, v2);//5, 10
            v1 = v1 + 100;
            v2 = v1 * 2000;
            Console.WriteLine("\tM1==> v1={0},v2={1}", v1, v2);//105, 210000 
        }
        public static void TestByRefMethod()
        {
            int x = 5;
            int y = 10;
            Console.WriteLine("TestM1==> x={0},y={1}", x, y);//5, 10
            ByRefMethod(x, ref y);
            Console.WriteLine("TestM1==> x={0},y={1}", x, y);//5, 210000
        }
        //out parameter
        public static void OutParameterMethod(int v1, out int v2)
        {
            //Console.WriteLine("v1={0},v2={1}", v1, v2); out v2 is unassigned
            v1 = v1 + 100;
            //v2 = v2 * 2000; //out v2 is unassigned
            v2 = v1 * 5; // v2 (y) is assigned
            Console.WriteLine("\t M2==> v1={0},v2={1}", v1, v2);
        }
        public static void TestOutParameter()
        {
            int x = 5;
            int y = 10;
            Console.WriteLine("Before M2==> x={0},y={1}", x, y); // 5, 10
            OutParameterMethod(x, out y);
            //M2(v2: out x, v1: y);//Using Named Arguments
            Console.WriteLine("After M2==> x={0},y={1}", x, y);// 5, 525
        }
        public static void OptionalParameters(int v1 = 123, int v2 = 456)//optional
        {
            Console.WriteLine($"\tM3==> v1={v1},v2={v2}");
            v1 = v1 + 100;
            v2 = v2 * 2000;
            Console.WriteLine($"\tM3==> v1={v1},v2={v2}");
        }
        public static void TestOptionalParameter()
        {
            int x = 5;
            int y = 10;
            Console.WriteLine($"x={x},y={y}");
            OptionalParameters();
            OptionalParameters(x, y);
            OptionalParameters(v2: x, v1: y);//Using Named Arguments
        }
        //params - variable length argument
        public static void AddIntParameters(params int[] arguments)
        {
            int add = 0;
            Console.WriteLine("Param Length " + arguments.Length);
            foreach (int argu in arguments)
            {
                add += argu;
            }
            Console.WriteLine(add);
        }
        public static void TestAddIntParams()
        {
            AddIntParameters(1);
            AddIntParameters(1, 2, 3, 4, 5);
        }
    }
}
