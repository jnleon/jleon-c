using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass()]
    public class AnimalGroupNameTests
    {
        [TestMethod]
        public void GetHerd()
        {
            AnimalGroupName lae = new AnimalGroupName();
            Assert.AreEqual("Crash", lae.GetHerd("rhino"));
            Assert.AreEqual("Tower", lae.GetHerd("giRaffe"));
            Assert.AreEqual("Herd", lae.GetHerd("elephant"));
            Assert.AreEqual("Pride", lae.GetHerd("lion"));
            Assert.AreEqual("Murder", lae.GetHerd("CROW"));
            Assert.AreEqual("Kit", lae.GetHerd("pigeon"));
            Assert.AreEqual("Pat", lae.GetHerd("flamingo"));
            Assert.AreEqual("Herd", lae.GetHerd("deer"));
            Assert.AreEqual("Pack", lae.GetHerd("dog"));
            Assert.AreEqual("Float", lae.GetHerd("crocodile"));
            Assert.AreEqual("unknown", lae.GetHerd("FROGGY"));
            Assert.AreEqual("unknown", lae.GetHerd(""));
        }
    }
}
