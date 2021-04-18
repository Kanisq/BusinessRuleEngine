using BusinessRuleEngine.Rules;
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

        public Payment(List<IPayment> _lstPaymentRules)
        {
            lstPaymentRules = _lstPaymentRules;

        }

        public PaymentDetail MakePayment(string paymentType)
        {
            return lstPaymentRules.First(x => x.IsRuleMatch(paymentType)).MakePayment();
        }

    }
}
