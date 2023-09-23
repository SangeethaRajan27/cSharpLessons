using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Day6
{
    internal class StackDemo
    {
        public static void StackDemoA()
        {
            Stack st = new Stack();
            Random r = new Random();
            int x = 0;
            st.Push(25);
            for (int i = 0; i < 10; i++)
            {
                x = r.Next(100);
                st.Push(x);
            }
            Console.WriteLine("");
            int count = st.Count;
            Console.WriteLine("Count=" + count);
            for (int i = 0; i < count; i++)
            {
                Console.Write(st.Peek() + " ");
                // Peek reads the first object in the queue 
                // without removing the object
            }



            Console.WriteLine("");
            count = st.Count;
            Console.WriteLine("Count After Peek =" + count);
            Console.WriteLine("Contains 25-" + st.Contains(25));
            for (int i = 0; i < 5; i++)
            {
                Console.Write(st.Pop() + " ");
            }
            Console.WriteLine();
            count = st.Count;
            Console.WriteLine("Count After Pop=" + count);
        }
    }
}
