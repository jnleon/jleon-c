using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{   [TestClass()]
    public class Less20Tests
    {
        [TestMethod]
        public void IsLessThanMultipleOf20()
        {
            Less20 lae = new Less20();
            Assert.IsTrue(lae.IsLessThanMultipleOf20(18));
            Assert.IsTrue(lae.IsLessThanMultipleOf20(19));
            Assert.IsFalse(lae.IsLessThanMultipleOf20(20));


        }

        [TestMethod]
        public void IsLessThanMultipleOf20Variables()
        {
            Less20 lae = new Less20();
            Assert.IsFalse(lae.IsLessThanMultipleOf20(0));
            Assert.IsFalse(lae.IsLessThanMultipleOf20(-10));
            Assert.IsTrue(lae.IsLessThanMultipleOf20(98));
            Assert.IsFalse(lae.IsLessThanMultipleOf20(1245));
            Assert.IsFalse(lae.IsLessThanMultipleOf20(-6));
        }
    }
}
