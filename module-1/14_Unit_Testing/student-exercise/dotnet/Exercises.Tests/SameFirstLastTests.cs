using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass()]
    public class SameFirstLastTests
    {
    [TestMethod]
    public void IsItTheSame()
        {
            int[] miaw = { 1, 2, 3 };
            int[] miaw2 = { 1, 2, 3, 1 };
            int[] miaw3 = { 1, 2, 1 };

            SameFirstLast lae = new SameFirstLast();
            Assert.IsFalse(lae.IsItTheSame(miaw));
            Assert.IsTrue(lae.IsItTheSame(miaw2));
            Assert.IsTrue(lae.IsItTheSame(miaw3));
        }
        [TestMethod]
        public void IsItTheSameVariables()
        {
            int[] miaw = { 0, 1, 0 };
            int[] miaw2 = { -5, 0, -89, -5 };
            int[] miaw3 = {1};
            int[] miaw4 = { };

            SameFirstLast lae = new SameFirstLast();
            Assert.IsTrue(lae.IsItTheSame(miaw));
            Assert.IsTrue(lae.IsItTheSame(miaw2));
            Assert.IsTrue(lae.IsItTheSame(miaw3));
            Assert.IsFalse(lae.IsItTheSame(miaw4));
        }

    }
}
