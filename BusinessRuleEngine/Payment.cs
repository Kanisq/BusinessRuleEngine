using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public class Payment 
    {
        
        public string GetMessage()
        {
            return "Test Successful";
        }

        public PaymentDetail MakePayment(string paymentType)
        {
            PaymentDetail paymentDetail = new PaymentDetail();    
            
            if (paymentType == "Physical Product")
            {
                paymentDetail.PackingSlip = GenerateSlip();
                paymentDetail.CommisionToAgent=CommisionToAgent();
            }
            if (paymentType=="Book")
            {
                paymentDetail.PackingSlip = GenerateSlip();
                paymentDetail.DuplicatePackingSlip = paymentDetail.PackingSlip;
                paymentDetail.CommisionToAgent = CommisionToAgent();
            }
            if (paymentType == "Membership")
            {
                paymentDetail.MembershipStatus = ActivateMembership();
                paymentDetail.IsNotified = NotifyMember(paymentDetail.MembershipStatus);
            }
            if (paymentType == "Upgrade")
            {
                paymentDetail.MembershipStatus = UpgradeMembership();
                paymentDetail.IsNotified =NotifyMember(paymentDetail.MembershipStatus);
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
            if (message.Equals("Activate", StringComparison.InvariantCultureIgnoreCase) || message.Equals("Upgrade", StringComparison.InvariantCultureIgnoreCase))
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
