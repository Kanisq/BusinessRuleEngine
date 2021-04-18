using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Rules
{
    public class Upgrade : IPayment
    {
        public bool IsRuleMatch(string paymentType)
        {
            return paymentType.StartsWith("Upgrade", StringComparison.InvariantCultureIgnoreCase);
        }

        public PaymentDetail MakePayment()
        {
            PaymentDetail paymentDetail = new PaymentDetail();
            paymentDetail.MembershipStatus = Utility.UpgradeMembership();
            paymentDetail.IsMemberNotified = Utility.NotifyMember(paymentDetail.MembershipStatus);

            return paymentDetail;
        }
    }
}
