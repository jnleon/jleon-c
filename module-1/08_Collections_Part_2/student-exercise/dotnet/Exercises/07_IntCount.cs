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
         * Given an array of int values, return a Dictionary<int, int> with a key for each int, with the value the
         * number of times that int appears in the array.
         *
         * ** The lesser known cousin of the the classic WordCount **
         *
         * IntCount([1, 99, 63, 1, 55, 77, 63, 99, 63, 44]) → {1: 2, 44: 1, 55: 1, 63: 3, 77: 1, 99:2}
         * IntCount([107, 33, 107, 33, 33, 33, 106, 107]) → {33: 4, 106: 1, 107: 3}
         * IntCount([]) → {}
         *
         */
        public Dictionary<int, int> IntCount(int[] ints)
        {
            Dictionary<int, int> newDic3 = new Dictionary<int, int>();

            for (int i = 0; i < ints.Length; i++)
            {
                if (!newDic3.ContainsKey(ints[i]))
                {                                        //if its not inside newDic3 add it
                    newDic3.Add(ints[i], i);           //if the word isnt there, add it, 
                    newDic3[ints[i]] = 1;              // give it a value of 1
                }
                else
                    newDic3[ints[i]] += 1;             //Add In one more value                            

            }
            return newDic3;
        }
    }
    }

