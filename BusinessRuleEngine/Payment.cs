using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public class Payment 
    {
        private List<IPayment> lstPaymentRules;

        public Payment()
        {
            lstPaymentRules = new List<IPayment>();
            lstPaymentRules.Add(new PhysicalProduct());
        }
        
        public string GetMessage()
        {
            return "Test Successful";
        }

        public PaymentDetail MakePayment(string paymentType)
        {
           

            return lstPaymentRules.First(x => x.IsRuleMatch(paymentType)).MakePayment();

            PaymentDetail paymentDetail = new PaymentDetail();

            if (paymentType=="Book")
            {
                paymentDetail.PackingSlip = GenerateSlip();
                paymentDetail.DuplicatePackingSlip = paymentDetail.PackingSlip;
                paymentDetail.CommisionToAgent = CommisionToAgent();
            }
            if (paymentType == "Membership")
            {
                paymentDetail.MembershipStatus = ActivateMembership();
                paymentDetail.IsMemberNotified = NotifyMember(paymentDetail.MembershipStatus);
            }
            if (paymentType == "Upgrade")
            {
                paymentDetail.MembershipStatus = UpgradeMembership();
                paymentDetail.IsMemberNotified =NotifyMember(paymentDetail.MembershipStatus);
            }
            if (paymentType == "video")
            {
                paymentDetail.PackingSlip = GenerateSlip();
                paymentDetail.IsVideoAdded=IsVideoAdded(paymentType);                
            }

            return paymentDetail;
        }

        public string GenerateSlip()
        {
            Random r = new Random(10);
            return "SlipNumber_" + r.ToString();
        }

        public string ActivateMembership()
        {
            return "Membership Activated";
        }

        public string UpgradeMembership()
        {
            return "Membership Upgraded";
        }

        public bool NotifyMember(string message)
        {
            if (message.Equals("Membership Activated", StringComparison.InvariantCultureIgnoreCase) || message.Equals("Membership Upgraded", StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
            return false;
        }


        public bool IsVideoAdded(string paymentType)
        {
            if (paymentType.Equals("Video", StringComparison.InvariantCultureIgnoreCase) )
            {
                return true;
            }
            return false;
        }

        public int CommisionToAgent()
        {
            return 100;
        }
        
    }
}
