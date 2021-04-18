using BusinessRuleEngine.Rules;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BusinessRuleEngine.Test
{
    [TestClass]
    public class PaymentTest
    {
        private PaymentDetail paymentDetail;
        private List<IPayment> paymentRules;
        [TestInitialize]
        public void Initialize()
        {
            paymentDetail = new PaymentDetail();
            paymentRules = new List<IPayment>();
            
            paymentRules.Add(new PhysicalProduct());
            paymentRules.Add(new Book());
            paymentRules.Add(new Activate());
            paymentRules.Add(new Upgrade());
            paymentRules.Add(new Video("Learning to Ski,"));

        }

        [TestCleanup]
        public void ClassCleanup()
        {
            this.paymentDetail = null;
        }

        [TestMethod]
        public void WHEN_PAYMENTTYPE_IS_BOOK()
        {
            string paymentType = "Book";
            Payment p = new Payment(this.paymentRules);
            this.paymentDetail= p.MakePayment(paymentType);
            Assert.IsTrue(!string.IsNullOrEmpty(this.paymentDetail.PackingSlip));
            Assert.AreEqual(this.paymentDetail.DuplicatePackingSlip,this.paymentDetail.PackingSlip);
            Assert.AreEqual(100,this.paymentDetail.CommisionToAgent);
        }

        [TestMethod]
        public void WHEN_PAYMENTTYPE_IS_PHYSICAL()
        {
            string paymentType = "Physical Product";
            Payment p = new Payment(this.paymentRules);
            this.paymentDetail = p.MakePayment(paymentType);
            Assert.IsTrue(!string.IsNullOrEmpty(this.paymentDetail.PackingSlip));
            Assert.IsTrue(string.IsNullOrEmpty(this.paymentDetail.DuplicatePackingSlip));
            Assert.AreEqual(100, this.paymentDetail.CommisionToAgent);
        }

        [TestMethod]
        public void WHEN_PAYMENTTYPE_IS_MEMBERSHIP_ACTIVATE()
        {
            string paymentType = "Membership";
            Payment p = new Payment(this.paymentRules);
            this.paymentDetail = p.MakePayment(paymentType);
            Assert.IsTrue(string.IsNullOrEmpty(this.paymentDetail.PackingSlip));
            Assert.IsTrue(string.IsNullOrEmpty(this.paymentDetail.DuplicatePackingSlip));
            
            Assert.AreEqual("Membership Activated", this.paymentDetail.MembershipStatus);
            Assert.AreEqual(true, this.paymentDetail.IsMemberNotified);
        }

        [TestMethod]
        public void WHEN_PAYMENTTYPE_IS_MEMBERSHIP_UPGRADE()
        {
            string paymentType = "Upgrade";
            Payment p = new Payment(this.paymentRules);
            this.paymentDetail = p.MakePayment(paymentType);
            Assert.IsTrue(string.IsNullOrEmpty(this.paymentDetail.PackingSlip));
            Assert.IsTrue(string.IsNullOrEmpty(this.paymentDetail.DuplicatePackingSlip));

            Assert.AreEqual("Membership Upgraded", this.paymentDetail.MembershipStatus);
            Assert.AreEqual(true, this.paymentDetail.IsMemberNotified);
        }

        [TestMethod]
        public void WHEN_PAYMENTTYPE_IS_VIDEO()
        {
            string paymentType = "video";
            Payment p = new Payment(this.paymentRules);
            this.paymentDetail = p.MakePayment(paymentType);
            Assert.IsTrue(!string.IsNullOrEmpty(this.paymentDetail.PackingSlip));
            Assert.IsTrue(string.IsNullOrEmpty(this.paymentDetail.DuplicatePackingSlip));
            Assert.AreEqual(true, this.paymentDetail.IsVideoAdded);
        }

    }
}
