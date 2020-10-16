using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{

    public class Car
    {
        public int Year { get; set; }

        public string Make { get; set; }

        public bool Isclassiccar { get; set; }

        public int Age
        {
            get
            {
               return DateTime.Now.Year - Year;
            }
        }


        public Car(int year, string make, bool isclasssiccar)
        {
            {
                Year = year;
                Make = make;
                Isclassiccar = isclasssiccar;

            }
        }
        public  bool shouldreceivecheck(int yearToCheck)
        {


            if (Age < 4 || Age > 25 || this.Isclassiccar == true)
            {
                return false;
            }
            if (Year % 2 != 0)
            {
                if (yearToCheck % 2 != 0)

                    return true;

            }
            else if (Year % 2 == 0)
            {
               if(yearToCheck % 2 == 0)
                
                return true;

            }
           
            return true;
      
        }
        public override string ToString()
        {
            return string.Format("CAR - {0} - {1}", Year, Make);
        }
    }
}
