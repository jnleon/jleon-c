using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass()]
    public class CigarPartyTest
    {
        [TestMethod]
        public void HaveParty()
        {
           
            CigarParty lae = new CigarParty();
            Assert.IsFalse(lae.HaveParty(30, false));
            Assert.IsTrue(lae.HaveParty(50, false));
            Assert.IsTrue(lae.HaveParty(70, true));
            Assert.IsTrue(lae.HaveParty(70, true));
        }
        [TestMethod]
        public void HavePartyVariables()
        {
            CigarParty lae = new CigarParty();
            Assert.IsTrue(lae.HaveParty(50, false || true));
            Assert.IsFalse(lae.HaveParty(10, false));
            Assert.IsTrue(lae.HaveParty(100, true));
            Assert.IsFalse(lae.HaveParty(10, true || false));
        }
    }
}
