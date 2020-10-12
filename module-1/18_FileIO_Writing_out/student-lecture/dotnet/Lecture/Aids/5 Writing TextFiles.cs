using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Aids
{
    public static class WritingTextFiles
    {
        /*
        * This method below provides sample code for printing out a message to a text file.
        */
        public static void WritingAFile()
        {
            string directory = Environment.CurrentDirectory;
            string filename = "output.txt";
            string fullPath = Path.Combine(directory, filename);

            using (StreamWriter sw = new StreamWriter(fullPath, true))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("Hi bro");
                sw.WriteLine("AAAAAAAAAAAAAA");
                sw.WriteLine("Hello");
                sw.Write("Same line:)))");



            } 




            // After the using statement ends, file has now been written
            // and closed for further writing
        }



    }
}
