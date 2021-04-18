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
        private List<IPaymentRule> lstPaymentRules;

        public Payment(List<IPaymentRule> _lstPaymentRules)
        {
            lstPaymentRules = _lstPaymentRules;

        }

        public PaymentDetail MakePayment(string paymentType)
        {
            return this.lstPaymentRules.First(x => x.IsRuleMatch(paymentType)).MakePayment();
        }

    }
}
