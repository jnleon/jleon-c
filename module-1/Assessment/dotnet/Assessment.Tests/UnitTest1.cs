using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assessment.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void shouldreceivecheck()
        {
            Car Mustang = new Car(1965, "Ford Mustang", true);
            Assert.IsFalse(Mustang.shouldreceivecheck(2020));

            Car Mustang2 = new Car(2020, "Ford Mustang", true);
            Assert.IsFalse(Mustang2.shouldreceivecheck(2020));

            Car Mustang3 = new Car(2011, "Ford Mustang", false);
            Assert.IsTrue(Mustang3.shouldreceivecheck(2020));

        }
    }
}
