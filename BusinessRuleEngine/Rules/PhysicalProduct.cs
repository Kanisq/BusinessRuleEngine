using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public class PhysicalProduct : IPayment
    {
        public bool IsRuleMatch(string paymentType)
        {
            return paymentType.StartsWith("Physical", StringComparison.InvariantCultureIgnoreCase);
        }

        public PaymentDetail MakePayment()
        {
            PaymentDetail paymentDetail = new PaymentDetail();
            paymentDetail.PackingSlip = Utility.GenerateSlipNumber();
            paymentDetail.CommisionToAgent = Utility.CommisionToAgent();

            return paymentDetail;
        }

        
    }
}
