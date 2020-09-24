using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Just when you thought it was safe to get back in the water --- Last2Revisited!!!!
         *
         * Given an array of strings, for each string, the count of the number of times that a substring length 2 appears
         * in the string and also as the last 2 chars of the string, so "hixxxhi" yields 1.
         *
         * We don't count the end substring, but the substring may overlap a prior position by one.  For instance, "xxxx"
         * has a count of 2, one pair at position 0, and the second at position 1. The third pair at position 2 is the
         * end substring, which we don't count.
         *
         * Return Dictionary<string, int>, where the key is string from the array, and its last2 count.
         *
         * Last2Revisited(["hixxhi", "xaxxaxaxx", "axxxaaxx"]) → {"hixxhi": 1, "xaxxaxaxx": 1, "axxxaaxx": 2}
         *
         */
        public Dictionary<string, int> Last2Revisited(string[] words)
        {
            Dictionary<string, int> last2Counts = new Dictionary<string, int>();        //new DICTIONARY
                        //loop through words
                        //figure out the last 2 count for the word
                        // last2Counts[word] = whatever we figured out as last 2 count
         foreach(string word in words )
            {
                string last2Chars = word.Substring(word.Length - 2);
                int last2count = 0;

                for (int i = 0; i < word.Length - 1; i++)                                                    
                {
                    if (word[i] == last2Chars[0] && word[i + 1] == last2Chars[1])                                                           // string index + 1 comapred the last 
                        last2count += 1;
                }

                last2Counts[word] = last2count -1;

            }
            return last2Counts;

            //foreach (KeyValuePair<string, int> wordss in last2Counts)
             
    

        }
    }
}
