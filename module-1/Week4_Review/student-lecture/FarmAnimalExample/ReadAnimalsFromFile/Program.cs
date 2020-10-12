using System;
using System.Collections.Generic;
using System.IO;
using Lecture.Farming;
namespace ReadAnimalsFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //OPEN FILE FOR READING
            string current = Environment.CurrentDirectory;
            string fullName =Path.Combine(current,"FarmAnimalsFood.txt");

            List<FarmAnimal> katiesFarm = ProcessInputFile(fullName);



        }
        static List<FarmAnimal> ProcessInputFile(string inFileName)
        {
            List<FarmAnimal> animals = new List<FarmAnimal>();
            using (StreamReader sr = new StreamReader(inFileName))
            {
                while (!sr.EndOfStream)
                {

                    string line = sr.ReadLine();
                    string[] details = line.Split("|");

                    FarmAnimal newAnimal;
                    switch (details[1])
                    {
                        case "Elephant": newAnimal = new Elephant(); break;
                        case "Goat": newAnimal = new Goat(); break;
                        default: newAnimal = new Goat(); break;
                    }

                    newAnimal.Name = details[0];
                    string[] food = details[2].Split(", ");
                    foreach(string f in food)
                    {
                        newAnimal.Food.Add(f);
                    }
                    animals.Add(newAnimal);

                }
            }
            return animals;
        }
    }
}
