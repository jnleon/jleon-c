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
         Given a string, return the count of the number of times that a substring length 2 appears in the string and
         also as the last 2 chars of the string, so "hixxxhi" yields 1 (we won't count the end substring).
         Last2("hixxhi") → 1
         Last2("xaxxaxaxx") → 1
         Last2("axxxaaxx") → 2
         */
        public int Last2(string str)
        {

            if (str.Length <= 2)
                return 0;
         
            string last2Chars = str.Substring(str.Length - 2);
            int last2count = 0;                                     //for charac of index of str
                                                                    // at  0 
            for (int i = 0; i < str.Length - 1; i++)                                                          //coompared to last two
            {
                if (str[i] == last2Chars[0] && str[i + 1] == last2Chars[1])                                                           //next string index + 1 comapred the last 
                    last2count++;
            }
            return last2count -1;
        }
    }
}
