using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessRuleEngine.Test
{
    [TestClass]
    public class PaymentTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Payment c = new Payment();
            string message = c.GetMessage();
            Assert.AreEqual("Test Successful", message);
        }
    }
}
