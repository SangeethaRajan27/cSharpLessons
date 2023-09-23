using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.NewFolder
{
    internal class StreamReaderWriteLesson
    {
        static byte[] storage = new byte[255];
        static MemoryStream tempmemorystream = new MemoryStream(storage);
        public static void MemStreamWriter()
        {
            // Wrap tempmemorystream in a reader and a writer.
            StreamWriter streamwriter = null;
            // Write to storage, through streamwriter.
            String? inputString = String.Empty;
            try
            {
                Console.WriteLine("Enter a Sentence:");
                inputString = Console.ReadLine();
                streamwriter = new StreamWriter(tempmemorystream);
                streamwriter.WriteLine(inputString);
                // Put a period at the end.
                streamwriter.WriteLine(".");
                streamwriter.Flush();
                Console.WriteLine("tempmemorystream.Length " + tempmemorystream.Length);
                Console.WriteLine("tempmemorystream.Capacity " + tempmemorystream.Capacity);
                Console.WriteLine("tempmemorystream.Postion " + tempmemorystream.Position);
            }
            catch (Exception err)
            {
                Console.WriteLine("ERROR!!! " + err.Message);
            }
            finally
            {
                //streamwriter.Close();
            }
        }
        public static void MemStreamReader()
        {
            Console.WriteLine("memstrm.Postion " + tempmemorystream.Position);
            StreamReader memrdr = new StreamReader(tempmemorystream);
            try
            {
                Console.WriteLine("\nReading through memrdr: ");
                // Read from tempmemorystream using the stream reader.
                tempmemorystream.Seek(3, SeekOrigin.Begin); // reset file pointer
                Console.WriteLine("tempmemorystream.Postion After seek " + tempmemorystream.Position);
                string str = memrdr.ReadLine();
                while (str != null)
                {
                    Console.WriteLine(str);
                    //if (str.CompareTo(".") == 0) break;
                    str = memrdr.ReadLine();
                }
            }
            finally
            {
                memrdr.Close();
            }
        }
    }
}
