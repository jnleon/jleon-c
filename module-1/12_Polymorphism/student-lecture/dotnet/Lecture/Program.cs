using Lecture.Farming;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // OLD MACDONALD
            //
            Console.WriteLine("Old MacDonald had a farm ee ay ee ay oh");

            // Let's try singing about a Farm Animal

            //  Dictionary<string, string> AnimalNames = new Dictionary<string,string> { 


            List<ISingable> animals = new List<ISingable>();
            animals.Add(new Horse());
            animals.Add(new Snake());
            animals.Add(new Tractor());




            //write a foreach loop to sing verse about every animal in the List
            foreach (ISingable animalName in animals)
            {
                Console.WriteLine("And on his farm there was a " + animalName.Name + " ee ay ee ay oh");
                Console.WriteLine("With a " + animalName.MakeSoundTwice() + " here and a " + animalName.MakeSoundTwice() + " there");
                Console.WriteLine("Here a " + animalName.MakeSoundOnce() + ", there a " + animalName.MakeSoundOnce() + " everywhere a " + animalName.MakeSoundTwice());
                Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
                Console.WriteLine();
            }
            }
            }
}
