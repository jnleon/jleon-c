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
         * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the
         * number of times that string appears in the array.
         *
         * ** A CLASSIC **
         *
         * WordCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
         * WordCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
         * WordCount([]) → {}
         * WordCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
         *
         */
        public Dictionary<string, int> WordCount(string[] words)
        {
            Dictionary<string, int> newDic2 = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!newDic2.ContainsKey(words[i])) {   //if its not inside newDic2 add it
                    newDic2.Add(words[i], i);           //if the word isnt there, add it, 
                    newDic2[words[i]] = 1;              // give it a value of 1
                }
                else
                    newDic2[words[i]] += 1;             //Add In one more value                            
           
            }return newDic2;               
        }
    }
}       