using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableClasses.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestableClasses.Classes.Tests
{
    [TestClass()]
    public class LoopsAndArrayExercisesTests
    {
        //CollectionAssert
        //.AllItemsAreNotNull() - Looks at each item in actual collection for not null
        //.AllItemsAreUnique() - Checks for uniqueness among actual collection
        //.AreEqual() - Checks to see if two collections are equal (same order and quantity)
        //.AreEquilavent() - Checks to see if two collections have same element in same quantity, any order
        //.AreNotEqual() - Opposite of AreEqual
        //.AreNotEquilavent() - Opposite or AreEqualivent
        //.Contains() - Checks to see if collection contains a value/object

        [TestMethod]
        public void MiddleWayTest()
        {
            LoopsAndArrayExercises MiddleWayTest = new LoopsAndArrayExercises();
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            int[] expected = { 2, 5 };

            int[] result = MiddleWayTest.MiddleWay(array1, array2);

            CollectionAssert.AreEqual(expected, result);





        }
        [TestMethod]
        public void MaxEnd3Test()
        {
          // maxEnd3([1, 2, 3]) → [3, 3, 3]
        // maxEnd3([11, 5, 9]) → [11, 11, 11]
       //  maxEnd3([2, 11, 3]) → [3, 3, 3]
            LoopsAndArrayExercises MaxEnd3Test = new LoopsAndArrayExercises();

            int[] array1 = { 1, 2, 3 };
            int[] expected1 = { 3, 3, 3 };

            int[] array2 = { 11, 5, 9 };
            int[] expected2 = { 11, 11, 11 };

            int[] array3 = { 2, 11, 3 };
            int[] expected3 = { 3, 3, 3 };


            int[] result = MaxEnd3Test.MaxEnd3(array1);
            CollectionAssert.AreEqual(array1, expected1);

            int[] result = MaxEnd3Test.MaxEnd3(array2);
            CollectionAssert.AreEqual(array2, expected2);

            int[] result = MaxEnd3Test.MaxEnd3(array1);
            CollectionAssert.AreEqual(array3, expected3);

        }


    }
}