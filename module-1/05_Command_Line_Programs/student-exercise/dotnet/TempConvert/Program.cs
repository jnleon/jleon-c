using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
                                       
            Console.WriteLine("Please enter the temperature : ");
            double temperatureGiven = double.Parse(Console.ReadLine());

            Console.WriteLine("Is the temperature in (C)elsius, or (F)ahrenheit? :");
            string orF = Console.ReadLine() ;
            if (orF == "C" || orF =="c" ) 
     
            Console.WriteLine("{0}C is {1}F", temperatureGiven, Math.Round((double)(temperatureGiven * 1.8) + 32),2);  // give calculation variable to make it prettier
                else 
                Console.WriteLine("{0}F is {1}C", temperatureGiven, Math.Round((double)((temperatureGiven -32) / 1.8), 2));
        }
    }
}
