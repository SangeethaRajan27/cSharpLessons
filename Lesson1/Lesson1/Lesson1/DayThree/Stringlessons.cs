using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;



namespace Lesson1.DayThree
{
    internal class StringProgramOne
    {
        public static void Demo1()
        {
            String firstString = "Hello";
            char[] data = { 'H', 'E', 'L', 'L', 'O' };
            String secondString = new string(data);
            Console.WriteLine(firstString + " " + secondString);
            String thirdString = String.Empty;
            int x = 0;
        }
        public static void Demo2()
        {
            String s1 = "Tom And Jerry Are friends";
            
            Console.WriteLine("Length " + s1.Length);
            Char[] data = s1.ToCharArray();
            foreach (char c in data)
            {
                Console.WriteLine(c);
            }
        }

        public static void Demo3()
        {
            String s1 = "Tom And Jerry Are friends";
            String[] words = s1.Split(' ');
            Console.WriteLine("Wordcount " + words.Count());
            
            foreach (var i in words)
            {
                Console.WriteLine(i);
            }
        }

        public static void DemoD()
        {
            String firstString = "Tom and Jerry are Friends";
            String stringInUPPER = firstString.ToUpper();
            Console.WriteLine( "firstString:" + firstString);
            Console.WriteLine("stringInUPPER:"+ stringInUPPER);
            String stringInLower = firstString.ToLower();
            Console.WriteLine("firstString:" + firstString);
            Console.WriteLine("stringInLower:" + stringInLower);

        }
        public static void TestStringEquals()
        {
            String firstString = "Hello";
            String secondString = "Hello";
            String thirdString = "Gavs";



            bool firstResult = (firstString == secondString);
            bool secondResult = (firstString == thirdString);
            Console.WriteLine("firstString==secondString " + firstResult); // true
            Console.WriteLine("firstString==thirdString " + secondResult);// true



            firstResult = (firstString.Equals(secondString));
            secondResult = (firstString.Equals(thirdString));
            Console.WriteLine("firstString.Equals(secondString) " + firstResult); // true
            Console.WriteLine("firstString.Equals(thirdString) " + secondResult); // true       
        }

        public static void TestSubstring()
        {
            String s1 = "Itp looks like September is going to have more rain";
            Console.WriteLine(s1);
            Console.WriteLine("Length " + s1.Length);
            String s2 = s1.Substring(1);
            Console.WriteLine(s2);
            Console.WriteLine("s2 Length " + s2.Length);
            String s3 = s1.Substring(0, 5);
            Console.WriteLine(s3);
            Console.WriteLine("s3 Length " + s3.Length);
        }

        public static void TestCompareTo()
        {
            String s1 = "September";
            String s3 = "November";
            int x = s1.CompareTo(s3);
            Console.WriteLine("September Compare November = " + x);
            x = s1.CompareTo("Saptember");
            Console.WriteLine("September Compare Saptember = " + x);
            x = s1.CompareTo("September");
            Console.WriteLine("September Compare September = " + x);
            x = s1.CompareTo("Setpember");
            Console.WriteLine("September Compare Setpember = " + x);



            bool flag = s3.Contains("ber");
            Console.WriteLine("Contains- ber " + flag);
            String s2 = s1.Insert(3, " 2017 ");
            Console.WriteLine("Insert " + s2);



            var reversdata = s1.Reverse();
            String s4 = new String(reversdata.ToArray());
            Console.WriteLine("Reverse " + s4);
        }

        public static void SortingStrings()
        {
            //sort the names
            String[] names = new String[5];
            names[0] = "X";
            names[1] = "Basker";
            names[2] = "Anandh";
            names[3] = "John";
            names[4] = "anandh";



            //String temp;
            String temp = String.Empty;
            int len = names.Length;
            Console.WriteLine(len);
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < (len - 1); j++)
                {
                    if (names[j].CompareTo(names[j + 1]) > 0)
                    {
                        temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < len; i++)
            {
                Console.Write(names[i] + ",");
            }
        }

        public static void AssignSameStringMultipleTimes()
        {
            int begin = DateTime.Now.Millisecond;
            String s1 = "Abcd";
            for (int i = 1; i < 1000000; i++)
            {
                String s2 = "Hello";
            }
            int after = DateTime.Now.Millisecond;
            Console.WriteLine(after - begin);
            Console.WriteLine(s1 + " ms");
        }

        public static void ModifyNumberMultipleTimes()
        {
            int begin = DateTime.Now.Millisecond;
            double x = 100;
            for (int i = 1; i < 1000000; i++)
            {
                x += i;
            }
            int after = DateTime.Now.Millisecond;
            Console.WriteLine(after - begin);
            Console.WriteLine(x);
        }

        public static void ModifyStringMultipleTimes()
        {
            int begin = DateTime.Now.Millisecond;
            String s1 = "Abcd";
            for (int i = 1; i < 1000000; i++)
            {
                s1 += i;
            }
            int after = DateTime.Now.Millisecond;
            Console.WriteLine(after - begin);
            Console.WriteLine(s1 + " ms");
        }

        public static void LeaveLetterTemplate()
        {
            String letter = "Sir,\n As I am suffering from {3} , I want leave for {4} days,\n from {1} to {2}.\n\n Thank You \n {0}";



            String reason = "fever";
            String myName = "Venkat";
            String no_of_Days = "4";
            String fromdate = "6-Aug-2018";
            String todate = "9-Aug-2018";



            String s1 = String.Format(letter, myName, fromdate, todate, no_of_Days, reason);



            Console.WriteLine(s1);
        }
    }
}
