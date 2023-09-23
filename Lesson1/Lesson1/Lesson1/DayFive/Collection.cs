using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Day5
{
    internal class Collection
    {
        public static void TestArrayList()
        {
            ArrayList alist = new ArrayList();
            int count = alist.Count;
            Console.Write("Count " + count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 0
            Random r1 = new Random();
            for (int i = 0; i < 10; i++)
                alist.Add(r1.Next(10));
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 16
            for (int j = 0; j < 10; j++) alist.Add(j);
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 32
            if (alist is IEnumerable)//does alist impliment IEnumerable
            {
                IEnumerator er = alist.GetEnumerator();
                while (er.MoveNext())
                {
                    object obj = er.Current;
                    if (typeof(int) == obj.GetType())
                    {
                        int x = (int)obj;// unboxing
                        Console.WriteLine(x);
                    }
                    else
                        Console.WriteLine(obj.ToString());
                }
            }



            for (int i = 0; i < alist.Count; i++)
            {
                Console.Write(alist[i] + ",");
                if (i > 0 && i % 10 == 0) Console.WriteLine();
            }
            //IEnumerable
            foreach (int x in alist)
            {
                Console.Write(x + " ");
            }
        }
        public static void GenericListInteger()
        {
            List<int> alist = new List<int>();
            int count = alist.Count;
            Console.Write("Count " + count);
            Console.WriteLine(" Capacity " + alist.Capacity);





            for (int i = 0; i < 10; i++)
                alist.Add(i);
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);





            //for (int j = 0; j < 10; j++)
            //    alist.Add("abcd" + j);







            for (int i = 0; i < count; i++)
            {
                Console.Write(alist[i] + ",");
            }
        }
        public static void GenericListString()
        {
            List<string> alist = new List<string>();
            int count = alist.Count;
            Console.Write("Count " + count);
            Console.WriteLine(" Capacity " + alist.Capacity);
            for (int j = 0; j < 10; j++)
                alist.Add("abcd" + j);
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);
            //for (int i = 0; i < 10; i++)
            //    alist.Add(i);
            for (int i = 0; i < count; i++)
            {
                Console.Write(alist[i] + ",");
            }
        }
        public static void GenericListDemoEmp()
        {
            List<Emp> empList = new List<Emp>();





            Console.Write("Length " + empList.Count);
            Console.WriteLine("\tCapacity " + empList.Capacity);
            Emp e1 = new Emp() { ID = 123, Name = "Venkat", Salary = 10000 };
            empList.Add(e1);
            empList.Add(new Emp() { ID = 456, Name = "Krishnan", Salary = 15000 });
            //empList.Add("Hello");
            Console.Write("Length " + empList.Count);
            Console.WriteLine("\tCapacity " + empList.Capacity);
            empList.Add(new Emp() { ID = 1000, Name = "Sam", Salary = 10000 });
            empList.Add(new Emp() { ID = 500, Name = "John", Salary = 10000 });
            empList.Add(new Emp() { ID = 200, Name = "Suresh", Salary = 10000 });
            empList.Add(e1);
            empList.Add(e1);





            Console.Write("Length " + empList.Count);
            Console.WriteLine("\tCapacity " + empList.Capacity);
            //IEnumerator data = empList.GetEnumerator();
            //while (data.MoveNext())
            //{
            //    Object obj = data.Current;
            //    if (obj.GetType() == typeof(Emp))
            //    {
            //        Emp e = (Emp)obj;
            //        Console.WriteLine("Id={0}, Name={1}, Salary={2} ", e.ID, e.Name, e.Salary);
            //    }
            //    else
            //        Console.WriteLine("=======> Object is not an Employee");
            //}
            foreach (Emp e2 in empList)
            {
                Console.WriteLine("Id={0}, Name={1}, Salary={2} ", e2.ID, e2.Name, e2.Salary);
            }
        }
        class Emp
        {
            public int ID;
            public string Name;
            public double Salary;
        }




    }
}
