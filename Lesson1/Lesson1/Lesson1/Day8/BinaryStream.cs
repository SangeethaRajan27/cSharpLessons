using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Day8
{
    
        public static class DemoB
        {
            static  MemoryStream memoryStream = new MemoryStream();
            //Using BinaryWriter to store random byte value
            public static void WriteBytesToMemoryStream()
            {
                Console.WriteLine("MemoryStream Length " + memoryStream.Length);
                int arrayLength = 10;
                byte[] dataArray = new byte[arrayLength];

                // Create random numbers and fill the dataArray
                Random r1 = new Random();
                r1.NextBytes(dataArray);
                StringBuilder str = new StringBuilder(arrayLength);
                for (int i = 0; i < arrayLength; i++)
                {
                    str.Append(dataArray[i]);
                    str.Append(";");
                }
                Console.WriteLine(str);



                //bool flag = true;
                //byte[] data = BitConverter.GetBytes(flag);
                BinaryWriter binWriter = new BinaryWriter(memoryStream);
                // read data (the random numbers) from dataArray and write to MemoryStream
                binWriter.Write(dataArray);
                Console.WriteLine("Write Completed " + memoryStream.Length);
            }
            //Using BinaryReader
            public static void ReadBytesFromMemoryStream()
            {
                if (memoryStream.Length == 0)
                {
                    Console.WriteLine("Memory Stream is Empty");
                    return;
                }
                // Create the reader using the stream from the writer.
                BinaryReader binReader = new BinaryReader(memoryStream);
                // Set Position to the beginning of the stream.
                binReader.BaseStream.Position = 0;
                // Read and verify the data.
                int arrayLength = (int)memoryStream.Length;
                byte[] verifyArray = binReader.ReadBytes(arrayLength);
                StringBuilder str = new StringBuilder(arrayLength);
                for (int i = 0; i < arrayLength; i++)
                {
                    str.Append(verifyArray[i]);
                    str.Append(";");
                }
                Console.WriteLine(str);
            }
        //Using BinaryWriter to store String 
        public static void WriteStringToMemoryStream()
        {
            Console.WriteLine("MemoryStream Length " + memoryStream.Length);
            Console.WriteLine("Enter a String ");
            String inputData = Console.ReadLine();
            if (inputData == null)
            {
                System.Console.WriteLine("INPUT IS EMPTY");
                return;
            }
            byte[] dataArray = System.Text.Encoding.ASCII.GetBytes(inputData);
            BinaryWriter binWriter = new BinaryWriter(memoryStream);
            // read data(the random numbers) from dataArray and write to MemoryStream
            binWriter.Write(dataArray);
            Console.WriteLine("Write Completed " + memoryStream.Length);
        }
        //Using BinaryReader to read string from MemoryStream
        public static void ReadStringFromMemoryStream()
        {
            if (memoryStream.Length == 0)
            {
                Console.WriteLine("Memory Stream is Empty");
                return;
            }
            // Create the reader using the stream from the writer.
            BinaryReader binReader = new BinaryReader(memoryStream);
            // Set Position to the beginning of the stream.
            binReader.BaseStream.Position = 0;
            // Read and verify the data.
            int arrayLength = (int)memoryStream.Length;
            // memoryStream.Length is Long but binReader.ReadBytes(int)
            byte[] verifyArray = binReader.ReadBytes(arrayLength);
            String stringOutput = Encoding.ASCII.GetString(verifyArray);
            Console.WriteLine(stringOutput);
        }
        public static void PeekAndReadCharacters()
        {
            string readerText = "Tom and Jerry is an American animated media franchise and series of comedy short films created in 1940 by William Hanna and Joseph Barbera.\n" +
                " Best known for its 161 theatrical short films by Metro-Goldwyn-Mayer, the series centers on the rivalry between the titular characters of a cat named Tom and a mouse named Jerry.\n " +
                "Many shorts also feature several recurring characters.";



            Console.WriteLine("Original text:\n\n{0}", readerText);
            Console.WriteLine("*****************************************");
            StringReader strReader = new StringReader(readerText);
            // Peek to see if the next character exists
            try
            {
                while (strReader.Peek() > -1)
                {
                    // Read a line from the Stream and display it on the console
                    Console.WriteLine(strReader.ReadLine() + "--");
                }
                Console.WriteLine("Data Read Complete!");
            }
            finally
            {
                //Close the stringReader
                strReader.Close();
            }
        }
    }
    }
/* static MemoryStream ms = new MemoryStream();
 * public static void WriteBytesToMemoryStream()
 * {
 * cw("Memory length =" + MemoryStream.Length);
 * int x  = 5;
 * byte[] Bytes = new byte [x];
 * Random r = new Random();
 * r.Bytes;
 * StringBuilders s = new StringBuilders(x);
 * for(int i =0; i<x; i++)
 * {
 *   s.Append(Bytes[i]);
 *   s.Append(",");
 *   }
 *   cw (s);
 *   int x =5;
 *   byte[] b = new byte[x];
 *   Random r = new Random();
 *   r.b;
 *   SB s = new SB(x);
 *   for(int i =0;i<x;i++)
 *   {
 *   s.Append(b[i]);
 *   s.Append(",");
 *   }
 *   cw(s); 
 *   BinaryWriter bin = new Binarywriter(ms);
 *   Bin.Write(x);
 *   cw("Completed"+ 5)
 */ 

