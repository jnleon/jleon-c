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
         Return the sum of the numbers in the array, returning 0 for an empty array. Except the number
         13 is very unlucky, so it does not count and numbers that come immediately after a 13 also do
         not count.
         Sum13([1, 2, 2, 1]) → 6
         Sum13([1, 1]) → 2
         Sum13([1, 2, 2, 1, 13]) → 6
         */
        public int Sum13(int[] nums)
        {
            int count = 0;                  //set count evens = 0

            for (int i = 0; i < nums.Length; i++)  //check if the element is index 0 is 13, if not , then add it to the sum
             {
                if (nums[i] != 13)                   // if that number is not 13 and the previos element is not 13, add it to the sum
                    count += nums[i];           //loop through the array STARTING INDEX 1
                
                if (i > 0 && nums[i - 1] == 13)        
                    count -= nums[i];
            }
            return count;
}
        }
}
