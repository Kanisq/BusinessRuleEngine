using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Rules
{
    public class Activate : IPayment
    {
        public bool IsRuleMatch(string paymentType)
        {
            return paymentType.StartsWith("Member", StringComparison.InvariantCultureIgnoreCase);
        }

        public PaymentDetail MakePayment()
        {
            PaymentDetail paymentDetail = new PaymentDetail();
            paymentDetail.MembershipStatus = Utility.ActivateMembership();
            paymentDetail.IsMemberNotified = Utility.NotifyMember(paymentDetail.MembershipStatus);

            return paymentDetail;
        }
    }
}
