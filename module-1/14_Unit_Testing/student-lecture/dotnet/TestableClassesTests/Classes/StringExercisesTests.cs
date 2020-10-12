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
    public class StringExercisesTests
    {
        //Assert
        //.AreEqual() - compares expected and actual value for equality
        //.AreSame() - verifies two object variables refer to same object
        //.AreNotSame() - verifies two object variables refer to different objects
        //.Fail() - fails without checking conditions
        //.IsFalse()
        //.IsTrue()
        //.IsNotNull()
        //.IsNull()


        [TestMethod]
        public void MakeAbbaTest()
        {
            /// makeAbba("Hi", "Bye") → HiByeByeHi
            ///makeAbba("What", "Up") → "WhatUpUpWhat"

            /// makeAbba("Yo", "Alice") → "YoAliceAliceYo"

            //ARANGEEE

            StringExercises stringExercises = new StringExercises();
            
            //ACTTTTT
            string result = stringExercises.MakeAbba("Hi", "Bye");

            //ASSERTTTT
            Assert.AreEqual("HiByeByeHi", result);


            Assert.AreEqual("YoAliceAliceYo", stringExercises.MakeAbba("Yo", "Alice"));

            Assert.AreEqual("WhatUpUpWhat", stringExercises.MakeAbba("What", "Up"));




        }
        [TestMethod]
        public void FirstTwoTest()
        {
        // firstTwo("Hello") → "He"	
        // firstTwo("abcdefg") → "ab"
        //firstTwo("ab") → "ab"



            StringExercises FirstTwoTest = new StringExercises();
            Assert.AreEqual("He", FirstTwoTest.FirstTwo("Hello"));
            Assert.AreEqual("ab", FirstTwoTest.FirstTwo("abcdefg"));
            Assert.AreEqual("ab", FirstTwoTest.FirstTwo("ab"));
            Assert.AreEqual("", FirstTwoTest.FirstTwo(""));


        }
    }
}