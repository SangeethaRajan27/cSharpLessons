using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayTwo
{
    internal class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Phone { get; set; }
        public override string ToString()
        {
            return $"ID:{this.Id},Name:{Title}{FirstName}{LastName},\n" + $"Address:{Address},City:{City},State:{Region},\n" + $"Phone:{Phone},Country:{Country},Zip:{PostalCode}";
        }
    }
    internal class Testperson
    {
        public static void TestOne()
        {
            Person firstPerson = new Person();
            firstPerson.Id = 1;
            firstPerson.FirstName = "THIYANA";
            firstPerson.LastName = "T";
            firstPerson.Address = "chidambaram";
            firstPerson.City = "Chennai";
            firstPerson.Region = "TN";
            firstPerson.PostalCode = "608001";
            firstPerson.Country = "INDIA";
            firstPerson.Phone = "9159262436";
            String value = firstPerson.ToString();
            Console.WriteLine(value);

        }
    }
}
