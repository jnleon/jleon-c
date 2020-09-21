using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Fibonacci number :");
            int fiboNumber = int.Parse(Console.ReadLine());

            int nexTnumber = 1;
            for (int i = 0; i <= fiboNumber; i += nexTnumber)
            {
                nexTnumber += i;
                if (nexTnumber <= fiboNumber)
                {
                    Console.Write(i + " , " + nexTnumber + " , ");
                }
                else
                    Console.Write(i);

            }

            /*

            int[] fibothing = new int[fiboNumber];

            fibothing[0] = 0;
            fibothing[1] = 1;
            fibothing[2] = 1;
            for (int i = 3; i < fibothing.Length; i++)
            {
                {
                    fibothing[i] = fibothing[i - 1] + fibothing[i - 2];
                }
                if (fibothing[i] >= fiboNumber)
                {
                    break;
                }
            }
            for (int i = 0; i < fibothing.Length - 1; i++)
            {
               
                Console.Write(fibothing[i]);

                if (i < fibothing.Length - 1)
                {
                    if (i > 0 && fibothing[i +1] == 0)
                        break;
                    Console.Write(", ");
                }

               
            }*/


        }
    }
}