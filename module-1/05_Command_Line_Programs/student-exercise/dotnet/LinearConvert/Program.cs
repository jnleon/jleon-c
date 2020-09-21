using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please enter the length : ");
            decimal lengthGiven = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Is the measurement in (m)eter, or (f)eet?");
            string morF = Console.ReadLine();
            if (morF == "M" || morF == "m")



                Console.WriteLine("{0}m is {1}f", lengthGiven, Math.Round((decimal)(lengthGiven * (decimal)3.2808399), 2));

            else
                Console.WriteLine("{0}f is {1}m", lengthGiven, Math.Round((decimal)(lengthGiven * (decimal)0.3048), 2)); 






        }
    }
}
