using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;



namespace Exercises.Tests
{
    [TestClass()]
    public class FrontTimesTests
    {
        [TestMethod]
        public void GenerateString()
        {
            FrontTimes lae = new FrontTimes();
            Assert.AreEqual("ChoCho", lae.GenerateString("Chocolate", 2));
            Assert.AreEqual("ChoChoCho", lae.GenerateString("Chocolate", 3));
            Assert.AreEqual("AbcAbcAbc", lae.GenerateString("Abc", 3));
        }
        [TestMethod]
        public void GenerateStringVariables()
        {
            FrontTimes lae = new FrontTimes();
            Assert.AreEqual("MIAMIA", lae.GenerateString("MIAWMIAWMIAWMIAW", 2));
            Assert.AreEqual("", lae.GenerateString("", 3));
            Assert.AreEqual("AbAbAb", lae.GenerateString("Ab", 3));
            Assert.AreEqual("rrrrr", lae.GenerateString("r", 5));
            Assert.AreEqual("         ", lae.GenerateString("   ", 3));
            Assert.AreEqual("", lae.GenerateString("MIAWMIAWMIAWMIAW", 0));
        }
    }
}