using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LessonA.Day6
{
    internal class BoxList
    {
        class Box
        {
            List<int> noList = new List<int>();
            public void FillList(int from, int to)
            {
                int i = 0;
                for (i = from; i < to; i++)
                {
                    noList.Add(i);
                }
            }
            public List<int> GetList()
            {
                return noList;
            }
        }
        class BoxA<T>
        {
            List<T> myList = new List<T>();
            public void FillList(T data)
            {
                myList.Add(data);
            }
            public List<T> GetList()
            {
                return myList;
            }
        }
        public static void TestA()
        {
            Box b1 = new Box();
            b1.FillList(100, 110);
            List<int> l = b1.GetList();
            foreach (int x in l)
            {
                Console.WriteLine(x);
            }
        }
        public static void TestB()
        {
            BoxA<string> b1 = new BoxA<string>();
            b1.FillList("Hello");
            List<string> l = b1.GetList();
            foreach (string s in l)
                Console.WriteLine(s);





            BoxA<float> b2 = new BoxA<float>();
            b2.FillList(55.24f);
            List<float> flist = b2.GetList();
            foreach (float f in flist)
                Console.WriteLine(f);
        }



    }
}

