using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass()]
    public class MaxEnd3Tests
    {
        [TestMethod]
        public void MakeArray()
        {
            int[] miaw = { 1, 2, 3 };
            int[] miaw2 = { 11, 5, 9 };
            int[] miaw3 = { 2, 11, 3 };

            int[] answer = { 3, 3, 3 };
            int[] answer2 = { 11, 11, 11 };
            int[] answer3 = { 3, 3, 3 };

            MaxEnd3 lae = new MaxEnd3();
            CollectionAssert.AreEqual(answer, lae.MakeArray(miaw));
            CollectionAssert.AreEqual(answer2, lae.MakeArray(miaw2));
            CollectionAssert.AreEqual(answer3, lae.MakeArray(miaw3));
        }

        [TestMethod]
        public void MakeArrayVariables()
        {
            int[] miaw = { 1, 1000, 0 };
            int[] miaw2 = { 10000, 5, -10001 };
            int[] miaw3 = { 0, 0, 0 };

            int[] answer = { 1, 1, 1 };
            int[] answer2 = { 10000, 10000, 10000 };
            int[] answer3 = { 0, 0, 0 };

            MaxEnd3 lae = new MaxEnd3();
            CollectionAssert.AreEqual(answer, lae.MakeArray(miaw));
            CollectionAssert.AreEqual(answer2, lae.MakeArray(miaw2));
            CollectionAssert.AreEqual(answer3, lae.MakeArray(miaw3));

        }







        /*
           Given an array of ints length 3, figure out which is larger between the first and last elements 
           in the array, and set all the other elements to be that value. Return the changed array.
           MakeArray([1, 2, 3]) → [3, 3, 3]
           MakeArray([11, 5, 9]) → [11, 11, 11]
           MakeArray([2, 11, 3]) → [3, 3, 3]
          
        public int[] MakeArray(int[] nums)
         */






    }



}
