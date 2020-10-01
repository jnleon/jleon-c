using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass()]
    public class DateFashionTests
    {
    [TestMethod]
        public void GetATable()
        {
            DateFashion lae = new DateFashion();
            Assert.AreEqual(2, lae.GetATable(5, 10));
            Assert.AreEqual(0, lae.GetATable(5, 2));
            Assert.AreEqual(1, lae.GetATable(5, 5));
        }
        [TestMethod]
        public void GetATableVariables()
        {
            DateFashion lae = new DateFashion();
            Assert.AreEqual(2, lae.GetATable(8, 8));
            Assert.AreEqual(0, lae.GetATable(2, 2));
            Assert.AreEqual(1, lae.GetATable(3, 3));
            Assert.AreEqual(0, lae.GetATable(9, 0));
        }
    }
}
