using System;
using System.IO;

namespace Assessment
{
    public class Program
    {
        
        public static void Main(string[] args)
        {

            Car Mustang = new Car(1965, "Ford Mustang", true);
            Car Subaru = new Car(2019, "Subaru", false);
            Car Baker = new Car(1920, "Baker Electric", true);
            Car Pontiac = new Car(1970, "Pontiac GTO", true);
            Car Toyota = new Car(2018, "Toyota Camry", false);


        }
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return "Person: " + Name + " " + Age;
            }
        }
        public static void ReadFile()
        {
            using (StreamReader CarInput = new StreamReader("CarInput.csv"))
            {

            }

            
        }
    }
  
    }
    

