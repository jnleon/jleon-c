﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of ints length 3, return a new array with the elements in reverse order, so
         {1, 2, 3} becomes {3, 2, 1}.
         Reverse3([1, 2, 3]) → [3, 2, 1]
         Reverse3([5, 11, 9]) → [9, 11, 5]
         Reverse3([7, 0, 0]) → [0, 0, 7]
         */
        public int[] Reverse3(int[] nums)
        {
            int[] reverse = new int[3];

            reverse[0] = nums[2];
            reverse[1] = nums[1];
            reverse[2] = nums[0];
            return reverse;


        }

    }
}