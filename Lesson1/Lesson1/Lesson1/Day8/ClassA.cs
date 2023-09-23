using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Day8
{
    public  class ClassA
    {
        public static void  TaskMethodA()
        {
            Console.WriteLine( "running taskA");
            Console.WriteLine( $"TaskA id : {Task.CurrentId} Completed");
        }
        public static void TaskMethodB(Task t)
        {
            Console.Write("running TaskB");
            Console.WriteLine($" After task {t.Id} ");
            Thread.Sleep(15000);
            Console.WriteLine($"taskB id {Task.CurrentId} Completed");
        }
        public static void TaskMethodC(Task t)
        {
            Console.Write("running TaskC");
            Console.WriteLine(" After task {0} ", t.Id);
            Thread.Sleep(1000);
            Console.WriteLine("taskC id {0} Completed", Task.CurrentId);
        }
        public static void TaskMethodB1(Task t)
        {
            Console.Write("running TaskB1");
            Console.WriteLine(" After task {0} ", t.Id);
            Console.WriteLine("taskB1 id {0} Completed", Task.CurrentId);
        }
        public static void ParentTask()
        {
            Console.WriteLine("Inside parentTask ");
            Console.WriteLine($"ParentTask id {Task.CurrentId}");
            var child = new Task(ChildTask, TaskCreationOptions.AttachedToParent);
            child.Start();
            Console.WriteLine("parent has started child");
            Thread.Sleep(1000);
        }

        public static void ChildTask()
        {
            Console.WriteLine("child started");
            Console.WriteLine($"childTask id {Task.CurrentId}");
            Thread.Sleep(10000);
            Console.WriteLine("child finished");
        }
        public static void ParentAndChild()
        {
            var parent = new Task(ClassA.ParentTask);
            Console.WriteLine("ParentStatus1: " + parent.Status);
            parent.Start();
            Console.WriteLine("ParentStatus2: " + parent.Status);
            #region A
            Thread.Sleep(1000);
            Console.WriteLine("ParentStatus: " + parent.Status);
            Thread.Sleep(1000);
            Console.WriteLine("ParentStatus: " + parent.Status);
            #endregion
            Console.WriteLine("Test Completed");
        }
       public static int GenerateNumbers(CancellationToken ct)
        {
            int i;
            for (i = 0; i < 1000; i++)
            {
                Console.WriteLine("Method1 - Number: {0}", i);
                Thread.Sleep(1000);
                // poll the IsCancellationRequested property
                // to check if cancellation was requested
                if (ct.IsCancellationRequested)
                {
                    break;
                }
            }
            return i;
        }
        // Notify when task is cancelled
        public static void CancelNotification()
        {
            Console.WriteLine("Cancellation request made!!");
        }
    }
}
