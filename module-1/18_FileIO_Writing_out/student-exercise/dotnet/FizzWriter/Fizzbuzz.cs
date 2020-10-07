using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FizzWriter
{
    class Fizzbuzz
    {
        public static void FizzBuzz()
        {

          //HARD CODEDDD  string directory = @"C:\Users\Student\workspace\jleon-c\module-1\18_FileIO_Writing_out\student-exercise\dotnet";

            // VERSTAILE WAY 
            string path = Environment.CurrentDirectory;
            string fullPath = Path.Combine(path, @"..\..\..\..\", "FizzBuzz.txt");
            
            using (StreamWriter sw = new StreamWriter(fullPath))
            {
                for (int i = 1; i <= 300; i++)
                {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    sw.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0 || i == 3) 
                {
                    sw.WriteLine("Fizz");
                }
                else if (i % 5 == 0 || i == 5) 
                {
                    sw.WriteLine("Buzz");
                }
                else
                    sw.WriteLine(i);
                }
            }
        }
    }
}
