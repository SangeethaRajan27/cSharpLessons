using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.DayFour
{
    public enum City { Chennai,Bang,Delhi}
    public enum Designation { Manager,Admin,Developer}
    internal class Employee
    {
        public readonly int EId;
        public string EName;
        public City Ecity;
        public Designation Jobtitle;
        public Employee(int v1) { EId = v1; }
        public override string ToString()
        {
            String output = String.Empty;
            output = $"details of employee are:ID {EId},{Ecity},{Jobtitle}";
            return output;
        }
     }
    class TestEmployee
    {
        public static void  TestOne()
        {
            Employee e1 = new Employee(345);
            e1.EName = "PLUM";
            e1.Ecity = City.Bang;
            e1.Jobtitle = Designation.Developer;
            String output = e1.ToString();
            Console.WriteLine( output);
        }
    }
}
