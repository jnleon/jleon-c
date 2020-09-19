using System;
using System.Reflection.Metadata;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
                                            //HOW WOULD THIS WORK?
                                            //static int tempToFah = int.Parse((temperatureGiven * 1.8) + 32));
                                            //static int tempToCel = (int)((temperatureGiven - 32) / 1.8);

            Console.WriteLine("Please enter the temperature : ");
            double temperatureGiven = double.Parse(Console.ReadLine());

            Console.WriteLine("Is the temperature in (C)elsius, or (F)ahrenheit? :");
            string orF = Console.ReadLine() ;
            if (orF == "C") 
            
            
              
            Console.WriteLine("{0}C is {1}F", temperatureGiven, Math.Round((double)(temperatureGiven * 1.8) + 32),2);  // give calculation variable to make it prettier
            
                else 
                Console.WriteLine("{0}F is {1}C", temperatureGiven, Math.Round((double)((temperatureGiven -32) / 1.8), 2));


          
            // tempCelsius = ((tempFahrenheit - 32) / 1.8)
            // tempFahrenheit = ((tempCelsius *1.8) +32);




        }
    }
}
