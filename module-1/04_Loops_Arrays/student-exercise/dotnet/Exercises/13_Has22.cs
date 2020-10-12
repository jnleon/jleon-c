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
         Given an array of ints, return true if the array contains a 2 next to a 2 somewhere.
         Has22([1, 2, 2]) → true
         Has22([1, 2, 1, 2]) → false
         Has22([2, 1, 2]) → false
         */
        public bool Has22(int[] nums)
        {                                                           //create a boolean if previoys number 2
           
              for (int i = nums.Length -1; i >=1; i --)

                  if (nums[i -1] == 2 )
                          if (nums[i] == 2)

                          return true;

              return false;

            /*  bool previousWasTwo = false;
                                                                         //loop thorught he array
                                                                         //if this elemnt is ==2 and previousWasTwo was 2 return true
                                                                            //otherwise if this element is 2 then set previousWasTwo to true
                                                                            // after the loop if we didnt return true, its not there, return false
            */
        }

    }
}
