using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass()]
    
    public class StringBitsTests
    {
        [TestMethod]
         public void GetBits()
        {
            StringBits lae = new StringBits();
            Assert.AreEqual("Hlo", lae.GetBits("Hello"));
            Assert.AreEqual("H", lae.GetBits("Hi"));
            Assert.AreEqual("Hello", lae.GetBits("Heeololeo"));
        }
        [TestMethod]
        public void GetBitsVariables()
        {
            StringBits lae = new StringBits();
            Assert.AreEqual("", lae.GetBits(""));
            Assert.AreEqual("Ho", lae.GetBits("H:o"));
            Assert.AreEqual("RRRRRRRRRR", lae.GetBits("RRRRRRRRRRRRRRRRRRRR"));
            Assert.AreEqual("-78", lae.GetBits("-8798"));
            Assert.AreEqual("A", lae.GetBits("A"));
        }
    }
}
