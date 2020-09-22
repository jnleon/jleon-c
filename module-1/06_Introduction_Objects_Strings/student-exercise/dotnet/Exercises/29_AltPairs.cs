using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien".
         AltPairs("kitten") → "kien"
         AltPairs("Chocolate") → "Chole"
         AltPairs("CodingHorror") → "Congrr"
         */
        public string AltPairs(string str)
        {
            int pairCounter = 0;
            string pairString = "";

            for (int i = 0; i < str.Length; i++) {
                if (pairCounter == 2)
                {
                    i += 1;
                        pairCounter = 0;
                    continue;

                }
                pairString += str[i];
                pairCounter++;
            } 
            return pairString;
        }
    }
}
