using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a series of integers values (seperated by a space) : ");
            string input = Console.ReadLine();
            string[] strNumbers = input.Split(" ");

            for (int i = 0; i < strNumbers.Length; i++)
            {
                int number = int.Parse(strNumbers[i]);
                Console.WriteLine(number + " in binary is " + hello(number));
            }
        }
        static string hello (int number) { 

              int remainder = 0;
                  string result = "";
                    while (number > 0)
        { 
                    remainder = number % 2;
                    number /= 2;
                    result +=  remainder;
        }return result;
   
        }
}
    }
