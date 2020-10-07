using System;
using System.IO;
using System.Linq;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
C:\Users\Student\workspace\jleon-c\module-1\18_FileIO_Writing_out\student-exercise\dotnet\bruh.txt

C:\Users\Student\workspace\jleon-c\module-1\18_FileIO_Writing_out\student-exercise\dotnet\FileSplitter\input.txt
            */

            Console.WriteLine("Where is the input file (please include the path to the file?");
            string filePath = Console.ReadLine();

            Console.WriteLine("How many lines of text (max) should there be in the split files?");
            
            int linestext = Convert.ToInt32(Console.ReadLine());
            int lineCount = File.ReadAllLines(filePath).Length;

            double hello = (double)(lineCount) / linestext;
            int howmanyFiles = (int)Math.Ceiling(hello);
            int count = 0;

            Console.WriteLine("\n**GENERATING OUTPUT**\n");

            using (StreamReader sw = new StreamReader(filePath, true))
                {
                    while (!sw.EndOfStream)
                    {
                        for (int i = 1; i <= howmanyFiles; i++)
                        {
                            string FilePath = "input-" + i.ToString() + ".txt";
                            count++;
                           
                            Console.WriteLine("Generating input-" + i.ToString() + ".txt");
                            
                            using (StreamWriter miaw = File.CreateText(FilePath))
                            {
                                for (int ix = 1; ix <= linestext; ix++)
                                {
                                string helli = "";
                                helli = sw.ReadLine();      
                                miaw.WriteLine(helli);
                                }
                            }
                        }
                    }
            }Console.WriteLine("\n{0} total :)", count);
        }
    }
}                       
