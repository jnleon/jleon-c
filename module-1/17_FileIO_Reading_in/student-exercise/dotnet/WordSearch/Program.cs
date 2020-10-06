using System;
using System.IO;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //C:\Users\Student\workspace\jleon-c\module-1\17_FileIO_Reading_in\student-exercise\dotnet\alices_adventures_in_wonderland.txt

            //1. Ask the user for the search string
            Console.WriteLine("What is fully qualified name of the file that should be searched?");
            string fullPath = Console.ReadLine();
            int lineNumber = 0;

            //2. Ask the user for the file path
            Console.WriteLine("What is the search word you are looking for?");
            string findWord = Console.ReadLine();

            //3. QUESTION
            Console.WriteLine(@"Should the search be case sensitive? (Y\N)");
            string yesorNo = Console.ReadLine();
            
            if (yesorNo == "Y" || yesorNo == "y")
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        lineNumber++;

                        //5. If the line contains the search string, print it out along with its line number
                        if (line.Contains(findWord))
                        {
                            Console.WriteLine(lineNumber + ") " + line);
                        }
                    }
                }
            }
            else
            using (StreamReader sr1 = new StreamReader(fullPath))
            {
                while (!sr1.EndOfStream)
                {
                    string line = sr1.ReadLine ();
                    
                    lineNumber++;

                    //5. If the line contains the search string, print it out along with its line number
                        if (line.ToLower().Contains(findWord.ToLower()))
                    {
                        Console.WriteLine(lineNumber + ") " + line);
                    }
                }
            }
        }
    }
}