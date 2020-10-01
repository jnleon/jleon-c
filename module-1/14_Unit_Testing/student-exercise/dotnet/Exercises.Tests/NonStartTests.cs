using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass()]
    public class NonStartTests
    {
    [TestMethod]
    public void GetPartialString()
        {
            NonStart lae = new NonStart();
            Assert.AreEqual("ellohere", lae.GetPartialString("Hello", "There"));
            Assert.AreEqual("avaode", lae.GetPartialString("java", "code"));
            Assert.AreEqual("hotlava", lae.GetPartialString("shotl", "java"));
        }
        [TestMethod]
        public void GetPartialStringVariables()
        {
            NonStart lae = new NonStart();
            Assert.AreEqual("", lae.GetPartialString("a", "a"));
            Assert.AreEqual("OOFWOOFWOOFWOOFWOOFWOOF", lae.GetPartialString("WOOFWOOFWOOFWOOFWOOFWOOF", ""));
            Assert.AreEqual("Zz", lae.GetPartialString("zZ", "Zz"));

        }
    }
}
