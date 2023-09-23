using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Day7
{
    internal class ThdemoA
    {
        public static void Demothread()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("ThreadID=" + id);
            Console.WriteLine("isAlive=" + t1.IsAlive);
            Console.WriteLine("Priority=" + t1.Priority);
            Console.WriteLine("ThreadState=" + t1.ThreadState);
            Console.WriteLine("CurrentCulture=" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            t1.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");
            Console.WriteLine("CurrentCulture=" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            t1.CurrentCulture = new System.Globalization.CultureInfo("de-DE");
            Console.WriteLine("CurrentCulture=" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
        }
        public static void Demo()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("MainThreadID=" + id);
            ServiceA a1 = new ServiceA();
            a1.DoTask();
        }
        public static void DemoB()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainThreadID = " + id);
            ServiceA a1 = new ServiceA();
            Thread t1 = new Thread(a1.DoTask);
            t1.Start();
            a1.DoTask();
            Console.WriteLine("------------End of DemoB-----------");
        }
        public static void DemoB2()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainThreadID = " + id);
            ServiceA a1 = new ServiceA();
            Thread t1 = new Thread(a1.DoTask);
            Console.WriteLine(t1.ManagedThreadId + " T1 State " + t1.ThreadState);
            t1.Start();
            Console.WriteLine(t1.ManagedThreadId + " State after Start" + t1.ThreadState);
            Thread.Sleep(3000);
            Console.WriteLine(t1.ManagedThreadId + " T1 State After Sleep " + t1.ThreadState);
            Console.WriteLine("------------End of DemoB-----------");
        }
        public static void DemoC()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainThreadID = " + id);
            ServiceA a1 = new ServiceA();
            ThreadStart ts = a1.DoTask;
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Start();
            t2.Start();
            t1.Join(7000);
            //if(t1.IsAlive)t1.Abort();//Thread.Abort is obsolete -06/01/2022
            t2.Join();
            //if (t2.IsAlive) t2.Abort();
            Console.WriteLine("------------ End of DemoC -----------");
        }
    }
}

