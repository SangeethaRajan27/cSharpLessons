using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;



namespace Lesson1.Day8.ObjectSerialization
{
    public class TestBinaryFormatter
    {
        public static void SerializeCustomer()
        {
            Customer obj = new Customer(1001);
            obj.FirstName = "Venkat";
            obj.LastName = "Krishnan";
            obj.MiddleName = "B";
            obj.CreditLimit = 200000;
            Console.WriteLine("Before serialization");
            obj.ToString();
            Console.WriteLine($"HashCode of the Object: {obj.GetHashCode()}");
            //Opens a file and serializes the object into it in binary format.
            using (Stream stream = File.Open(@"c:\temp\Customer.dat", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
#pragma warning disable SYSLIB0011
                formatter.Serialize(stream, obj);
            }
            Console.WriteLine("Completed.....");
        }
        public static void DeSerializeCustomer()
        {
            using (Stream stream = File.Open(@"c:\temp\Customer.dat", FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
#pragma warning disable SYSLIB0011
                Customer obj = null;
                formatter = new BinaryFormatter();
                obj = (Customer)formatter.Deserialize(stream);
                Console.WriteLine("After deserialization the object contains: ");
                Console.WriteLine(obj.ToString());
                Console.WriteLine($"HashCode of the Object: {obj.GetHashCode()}");





            }
        }
    }
}

