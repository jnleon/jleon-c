using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass()]
    public class Lucky13Tests
    {
   [TestMethod]
   public void GetLucky()
        {
            int[] miaw = { 0, 2, 4 };
            int[] miaw2 = { 1, 2, 3 };
            int[] miaw3 = { 1, 2, 4 };

            Lucky13 lae = new Lucky13();
            Assert.IsTrue(lae.GetLucky(miaw));
            Assert.IsFalse(lae.GetLucky(miaw2));
            Assert.IsFalse(lae.GetLucky(miaw3));
        }
        [TestMethod]
        public void GetLuckyVariables()
        {
            int[] miaw = { 0, 0, 0 };
            int[] miaw2 = { -4, -2, -3 };
            int[] miaw3 = { -3, -3, 4 };

            Lucky13 lae = new Lucky13();
            Assert.IsTrue(lae.GetLucky(miaw));
            Assert.IsTrue(lae.GetLucky(miaw2));
            Assert.IsTrue(lae.GetLucky(miaw3));
        }
    }
}
