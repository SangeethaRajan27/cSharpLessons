using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Day10
{
    internal class Swapping
    {
        public static void QuestionFour()
        {
            Console.WriteLine("Enter a NAME");
            String name = $"{Console.ReadLine()}";
            int len = name.Trim().Length;
            if (len < 8)
            {
                String errorMessage = "Name is Lessthan 8 Char. Try Again...";
                throw new Exception(errorMessage);
            }
            char[] nameCharArray = name.Trim().ToUpper().ToCharArray();
            foreach (var item in nameCharArray)
            {
                int asciiValue = item;
                if (asciiValue < 65 || asciiValue > 90)
                {
                    String errorMessage = "Name Must contain ONLY Alphabets. Try Again...";
                    throw new Exception(errorMessage);
                }
            }
            Console.WriteLine($"Correct Input {name}");
        }
    }
}
