using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRamEqual()
        {
            Laptop testLaptop = new Laptop("testLaptop", 500, 20);
            Assert.AreEqual(500, testLaptop.Ram);
        }

        [TestMethod]
        public void TestIsMobile()
        {
            Laptop testLaptop = new Laptop("testLaptop", 500, 20);
            Assert.IsTrue(testLaptop.Mobile());
        }

        [TestMethod]
        public void TestNameOnlyConstructor()
        {
            Laptop testLaptop = new Laptop("testLaptop");
            Assert.AreEqual("testLaptop has 0 gb of RAM.", testLaptop.ComputerRAM());
        }

        [TestMethod]
        public void TestSmartPhoneName()
        {
            SmartPhone testSmartPhone = new SmartPhone("testSmartPhone", 8, 1.5);
            Assert.AreEqual("testSmartPhone", testSmartPhone.Name);
        }

        [TestMethod]
        public void TestSmartPhoneWeight()
        {
            SmartPhone testSmartPhone = new SmartPhone("testSmartPhone", 8, 1.5);
            Assert.AreEqual(1.5, testSmartPhone.Weight);
        }
    }
}
