using Lecture.Aids;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReadingInFiles.ReadACharacterFile();
            //ReadingCSVFiles.ReadFile();
            //SummingUpNumbers.ReadFile();   
            ReadFileHamletAndOutputWithKatieAsFRANCISCO();
        }
        private static void ReadFileHamletAndOutputWithKatieAsFRANCISCO()
        {

            string directory = Environment.CurrentDirectory;
            string filename = "Hamlet.txt";

            string fullPath = Path.Combine(directory, filename);
            try
            {
                using(StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string newLine = line.Replace("FRANCISCO", "KATIE");
                        Console.WriteLine(newLine);

                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("oh no!" + e.Message);
            }

        }
    }
}
