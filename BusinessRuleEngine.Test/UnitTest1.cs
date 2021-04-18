using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessRuleEngine.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 c = new Class1();
            string message = c.GetMessage();
            Assert.AreEqual("Test Successful", message);
        }
    }
}
